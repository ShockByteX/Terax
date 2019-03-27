using ShockUI;
using System;
using System.Linq;
using System.Windows.Forms;
using Tera.Core.Network;
using Tera.Core.Network.OpCodes;
using Tera.Core.Network.Protocol;
using TeraxHook.Helpers;
using TeraxHook.Internals;

namespace TeraxHook.GUI.Forms
{
    public partial class SendDataForm : Form
    {
        #region Constants
        private static readonly char SPLITTER = ' ';
        private static readonly string NONE = "NONE";
        #endregion
        #region Constructors
        public SendDataForm()
        {
            InitializeComponent();
            GUIHelpers.DragControl dc = new GUIHelpers.DragControl(this);
            dc.Add(pnlHeader, lblCaption);
            btnExit.Click += (s, e) => Close();
            tbData.TextChanged += tbData_TextChanged;
            btnSend.Click += btnSend_Click;
            cbxDirection.SelectedIndex = 0;
        }
        #endregion
        #region [PRIVATE]Handlers
        private void btnSend_Click(object sender, EventArgs e)
        {
            string[] splitted = tbData.Text.Split(SPLITTER);
            if (splitted == null || splitted.Length < 4) { MessageBox.Show("HEX-code contains to little data.", "Terax", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
            byte[] data = new byte[splitted.Length];
            int length = data.Length;
            for (int i = 0; i < length; i++)
            {
                if (!splitted[i].IsHex()) { MessageBox.Show("HEX-code contains wrong data.", "Terax", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                data[i] = splitted[i].ToByte();
            }
            PacketDirection direction = (PacketDirection)cbxDirection.SelectedIndex;
            if (cbEncrypt.Selected)
            {
                if (lblOpName.Text.Equals(NONE)) { MessageBox.Show("Byte-code is wrong. Check your OpCode.", "Terax", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                if (data.Length != (data[0] | data[1] << 8)) { MessageBox.Show($"Wrong length of hex-code. Should be: {(data[0] | data[1] << 8)}", "Terax", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                switch (direction)
                {
                    case PacketDirection.ClientToServer: PacketController.Send(new RawPacket(data, direction)); break;
                    case PacketDirection.ServerToClient:
                        PacketController.Client.CPacket = new RawPacket(data, direction);
                        PacketController.Send(new RawPacket(new byte[] { 0x04, 0x00, 0xFE, 0xFF }, PacketDirection.ClientToServer));
                        break;
                }
            }
            else PacketController.Send(data, direction);
        }
        private void tbData_TextChanged(object sender, EventArgs e)
        {
            string text = tbData.Text;
            if (string.IsNullOrEmpty(text)) { lblOpCode.Text = NONE; lblOpName.Text = NONE; lblLength.Text = "0"; return; }
            void RemoveLast() { tbData.Text = text.Substring(0, text.Length - 1); tbData.SelectionStart = text.Length; }
            char cLast = text[text.Length - 1];
            if ((text.Length % 3 == 0 && cLast != SPLITTER) || (text.Length % 3 != 0 && !cLast.IsHex())) { RemoveLast(); return; }
            if (text.Length % 3 == 2)
            {
                string[] splitted = text.Split(SPLITTER);
                lblLength.Text = splitted.Length.ToString();
                if (splitted.Length >= 4 && cbEncrypt.Selected)
                {
                    ushort opCode = (ushort)(splitted[2].ToByte() | splitted[3].ToByte() << 8);
                    PacketController.Client.Processor.Serializer.Tables.Game.OpCodeToName.TryGetValue(opCode, out string opName);
                    if (!string.IsNullOrEmpty(opName)) { lblOpCode.Text = opCode.ToString(); lblOpName.Text = opName; } else { lblOpCode.Text = NONE; lblOpName.Text = NONE; }
                }
                else { lblOpCode.Text = NONE; lblOpName.Text = NONE; }
            }
        }
        #endregion
    }
}