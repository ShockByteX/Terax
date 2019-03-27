using Newtonsoft.Json;
using ShockUI;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Tera.Core.Network.Protocol;
using Tera.Core.Network.Protocol.Packets;
using TeraxHook.GUI.Tabs;
using TeraxHook.Internals;

namespace TeraxHook.GUI.Forms
{
    public partial class MainForm : Form
    {
        #region [STATIC]Fields
        public static readonly MainForm Instance = new MainForm();
        #endregion
        #region Constructors
        public MainForm()
        {
            InitializeComponent();
            Shown += (s, e) => GUIHelpers.Transitions.ShowForm(this, 1, 0.1, 10);
            GUIHelpers.DragControl dc = new GUIHelpers.DragControl(this);
            dc.Add(pnlHeader);
            btnExit.Click += (s, e) => Process.GetCurrentProcess().Kill();
            SetHandlers();
            SetDefaults();
            btnImage.Click += (s, e) =>
            {
                
                for (int i = 0; i < 6; i++)
                {
                    char[] arr = new char[6] { '#', '#', '#', '#', '#', '#' };
                    arr[i] = '@';
                    C_CHAT packet = new C_CHAT();
                    packet.Message = $"<FONT>{new string(arr)}</FONT>";
                    packet.TextOffset = 10;
                    packet.Channel = Tera.Core.Game.ChatChannel.Global;
                    PacketController.Send(packet);
                }            
            };
        }
        private void SetHandlers()
        {
            PacketController.StatusChanged += PacketContoroller_StatusChanged;
            btnPackets.SelectedChanged += (s, value) => { if (value) ShowTab(TabPackets.Instance); };
        }
        private void SetDefaults()
        {
            PacketContoroller_StatusChanged(PacketControllerStatus.Offline);
            btnLog.Click += (s, e) => { Log form = Log.Instance; if (!form.Visible) GUIHelpers.Transitions.ShowForm(form); else GUIHelpers.Transitions.HideForm(form, 0.08); };
        }
        #endregion
        #region [PRIVATE]Methods
        private void ShowTab(UserControl ctrl)
        {
            pnlTabs.Visible = false;
            pnlTabs.Controls.Clear();
            pnlTabs.Controls.Add(ctrl);
            pnlTabs.Visible = true;
        }
        #endregion
        #region [PRIVATE]Handlers PacketController
        private void PacketContoroller_StatusChanged(PacketControllerStatus status)
        {
            switch (status)
            {
                case PacketControllerStatus.Online: lblPCStatus.ForeColor = Color.FromArgb(50, 200, 100); break;
                case PacketControllerStatus.Offline: lblPCStatus.ForeColor = Color.FromArgb(200, 50, 100); break;
                case PacketControllerStatus.Waiting: lblPCStatus.ForeColor = Color.FromArgb(100, 50, 200); break;
            }
            lblPCStatus.Text = status.ToString();
        }
        #endregion
    }
}