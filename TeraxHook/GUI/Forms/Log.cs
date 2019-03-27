using System;
using System.Windows.Forms;
using ShockUI;

namespace TeraxHook.GUI.Forms
{
    public partial class Log : Form
    {
        #region [PUBLIC]Fields
        public static readonly Log Instance = new Log();
        #endregion
        #region [PRIVATE]Fields
        private static object sync = new object();
        #endregion
        #region Constructors
        public Log()
        {
            InitializeComponent();
            GUIHelpers.DragControl dc = new GUIHelpers.DragControl(this);
            dc.Add(pnlHeader, lblCaption);
            btnClear.Click += (s, e) => rtbLog.Text = null;
        }
        #endregion
        #region [PUBLIC\STATIC]Methods
        public static void ShowForm() { if (!Instance.Visible) GUIHelpers.Transitions.ShowForm(Instance, 0.96, 0.12, 10); }
        public static void HideForm() { if (Instance.Visible) GUIHelpers.Transitions.HideForm(Instance, 0.12, 10); }
        public static void WriteLine(string text)
        {
            lock (sync)
            {
                Action action = () =>
                {
                    Instance.rtbLog.Text += $"{text}\n";
                    Instance.rtbLog.SelectionStart = Instance.rtbLog.Text.Length;
                    Instance.rtbLog.ScrollToCaret();
                };
                Instance.Invoke(action);
            }
        }
        public static void Write(string text) { lock (sync) { Action action = () => Instance.rtbLog.Text += text; Instance.Invoke(action); } }
        public static void Clear() { lock (sync) { Action action = () => Instance.rtbLog.Text = null; Instance.Invoke(action); } }
        #endregion
    }
}