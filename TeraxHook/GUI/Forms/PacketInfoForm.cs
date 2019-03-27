using ShockUI;
using Tera.Core.IO;
using Tera.Core.Network.Protocol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;
using TeraxHook.GUI.Controls;
using TeraxHook.Helpers;
using TeraxHook.Internals;

namespace TeraxHook.GUI.Forms
{
    public partial class PacketInfoForm : Form
    {
        #region Constructors
        public PacketInfoForm(RawPacket packet)
        {
            InitializeComponent();
            GUIHelpers.DragControl dc = new GUIHelpers.DragControl(this);
            dc.Add(pnlHeader, lblCaption);
            btnExit.Click += (s, e) => Close();
            string opName = PacketController.Client.Processor.Serializer.Tables.Game.OpCodeToName[packet.OpCode];
            lblOpCode.Text = packet.OpCode.ToString();
            lblOpName.Text = opName;
            lblLength.Text = packet.Length.ToString();
            tbData.Text = packet.Data.AsString(10000);
            PacketController.Client.Processor.Serializer.Info.TryGetValue(opName, out PacketReflectionInfo info);
            if (info != null)
            {
                pnlFields.Controls.Clear();
                using (TeraBinaryReader reader = new TeraBinaryReader(packet.GetPayloadData()))
                {
                    foreach (FieldInfo field in info.Fields)
                    {
                        FieldInfoControl ctrl = new FieldInfoControl(field.Name, reader.ReadString(field.FieldType)) { Dock = DockStyle.Top };
                        pnlFields.Controls.Add(ctrl);
                        ctrl.BringToFront();
                    }
                }
            }
        }
        #endregion
    }
}