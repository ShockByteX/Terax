using EasyHook;
using ShockUI;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels.Ipc;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeraxHook;

namespace Terax.GUI.Forms
{
    public partial class MainForm : Form
    {
        #region Enums
        private enum StatusType : byte { Fail, Default, Success, Information }
        #endregion
        #region Fields
        private readonly string processName = "Tera";
        private readonly string dllName = "TeraxHook.dll";
        private readonly string currentFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private readonly string dllPath;
        private Process process;
        #endregion
        #region Constructors
        public MainForm()
        {
            dllPath = $"{currentFolder}\\{dllName}";
            InitializeComponent();
            Shown += (s, e) =>
            {
                GUIHelpers.Transitions.ShowForm(this, 0.96, 0.12, 10);
                tmrApplication.Start();
            };
            GUIHelpers.DragControl dc = new GUIHelpers.DragControl(this);
            dc.Add(this, lblCaption, lblHint);
            btnExit.Click += (s, e) => GUIHelpers.Transitions.HideForm(this, 0.12, 10, true);
            if (!File.Exists(dllPath)) { SetStatus($"The file \"{dllName}\" is missing!", StatusType.Fail); return; }
            SetStatus($"Waiting for {processName}..", StatusType.Default);
        }
        #endregion
        #region [PRIVATE]Methods
        private void SetStatus(string text, StatusType type)
        {
            if (InvokeRequired)
            {
                Action action = () =>
                {
                    switch (type)
                    {
                        case StatusType.Fail: lblStatus.ForeColor = Color.FromArgb(220, 50, 40); break;
                        case StatusType.Default: lblStatus.ForeColor = Color.Silver; break;
                        case StatusType.Success: lblStatus.ForeColor = Color.FromArgb(50, 200, 80); break;
                        case StatusType.Information: lblStatus.ForeColor = Color.FromArgb(220, 160, 50); break;
                    }
                    lblStatus.Text = text;
                };
                Invoke(action);
            }
            else
            {
                switch (type)
                {
                    case StatusType.Fail: lblStatus.ForeColor = Color.FromArgb(220, 50, 40); break;
                    case StatusType.Default: lblStatus.ForeColor = Color.Silver; break;
                    case StatusType.Success: lblStatus.ForeColor = Color.FromArgb(50, 200, 80); break;
                    case StatusType.Information: lblStatus.ForeColor = Color.FromArgb(220, 160, 50); break;
                }
                lblStatus.Text = text;
            }
        }
        private async void Inject()
        {
            SetStatus("Casting a spell on the game...", StatusType.Default);
            if (await IsEnchanted()) { SetStatus("The game is already enchanted.", StatusType.Information); return; }
            if (!await TryInject()) { SetStatus("Unhandled error.", StatusType.Fail); return; }
            SetStatus("Succesful enchantment!", StatusType.Success);
            Thread.Sleep(500);
            GUIHelpers.Transitions.HideForm(this, 0.12, 10, true);
        }
        private async Task<bool> IsEnchanted()
        {
            return await Task.Run(() =>
            {
                ProcessModuleCollection modules = process.Modules;
                int modulesCount = modules.Count;
                for (int i = 0; i < modulesCount; i++)
                {
                    ProcessModule module = modules[i];
                    if (module.ModuleName == "EasyLoad32.dll" || module.ModuleName == "EasyLoad64.dll") { SetStatus("The game is already enchanted.", StatusType.Information); return true; }
                }
                return false;
            });
        }
        private async Task<bool> TryInject()
        {
            return await Task.Run(() =>
            {
                try
                {
                    string channelName = null;
                    IpcServerChannel server = RemoteHooking.IpcCreateServer<ServerInterface>(ref channelName, WellKnownObjectMode.Singleton);
                    RemoteHooking.Inject(process.Id, dllPath, dllPath, channelName);
                    return true;
                }
                catch { return false; }
            });
        }
        #endregion
        #region [PRIVATE]Timers
        private void tmrApplication_Tick(object sender, EventArgs e)
        {
            try { process = Process.GetProcessesByName(processName)[0]; tmrApplication.Stop(); Inject(); } catch { }
        }
        #endregion
    }
}