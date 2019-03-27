using ShockUI;
using Tera.Core.Game;
using Tera.Core.Network.Protocol;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection;
using System.Windows.Forms;
using TeraxHook.GUI.Controls;
using TeraxHook.Internals;
using Tera.Core.Network.Protocol.Packets;

namespace TeraxHook.GUI.Forms
{
    public partial class SendPacketForm : Form
    {
        #region [STATIC]Fields
        public static SendPacketForm Instance = new SendPacketForm();
        #endregion
        #region [PRIVATE]Fields
        private List<ExControl> _controls = new List<ExControl>();
        #endregion
        #region Constructors
        public SendPacketForm()
        {
            InitializeComponent();
            GUIHelpers.DragControl dc = new GUIHelpers.DragControl(this);
            dc.Add(pnlHeader, lblCaption);
            btnExit.Click += (s, e) => Close();
            foreach (KeyValuePair<string, PacketReflectionInfo> kvp in PacketController.Client.Processor.Serializer.Info) cbxOps.Items.Add(kvp.Value);
            cbxOps.SelectedValueChanged += cbxOps_SelectedValueChanged;
            btnSend.Click += btnSend_Click;
        }
        #endregion
        #region [PRIVATE]Methods
        private void AddControl(Control ctrl)
        {
            ctrl.Dock = DockStyle.Top;
            pnlFields.Controls.Add(ctrl);
            ctrl.BringToFront();
        }
        private Panel GetPanel() => new Panel() { Height = 4 };
        #endregion
        #region [PRIVATE]Handlers
        private void cbxOps_SelectedValueChanged(object sender, EventArgs e)
        {
            pnlFields.Visible = false;
            _controls.Clear();
            pnlFields.Controls.Clear();
            PacketReflectionInfo info = PacketController.Client.Processor.Serializer.Info[cbxOps.Text];
            foreach (FieldInfo field in info.Fields)
            {
                Type type = field.FieldType;
                TypeCode fTypeCode = Type.GetTypeCode(type);
                UserControl ctrl = null;
                if (type.IsEnum) ctrl = new ExEnum(field);
                else
                {
                    switch (fTypeCode)
                    {
                        case TypeCode.Object:
                            if (type == typeof(Vector3)) ctrl = new ExVector3(field);
                            if (type == typeof(Angle)) ctrl = new ExAngle(field);
                            break;
                        case TypeCode.Boolean: break;
                        case TypeCode.SByte:
                        case TypeCode.Byte:
                        case TypeCode.Int16:
                        case TypeCode.UInt16:
                        case TypeCode.Int32:
                        case TypeCode.UInt32:
                        case TypeCode.Int64:
                        case TypeCode.UInt64:
                        case TypeCode.Single:
                        case TypeCode.Double: ctrl = new ExUpDown(field); break;
                        case TypeCode.String: ctrl = new ExTextBox(field); break;
                    }
                }
                if (ctrl != null) { AddControl(GetPanel()); AddControl(ctrl); _controls.Add((ExControl)ctrl); }
            }
            if (_controls.Count != info.Fields.Length) throw new Exception("Not enough controls.");
            pnlFields.Visible = true;
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            PacketReflectionInfo info = PacketController.Client.Processor.Serializer.Info[cbxOps.Text];
            Object pObject = Activator.CreateInstance(info.Type);
            int length = info.Fields.Length;
            for (int i = 0; i < length; i++)
            {
                FieldInfo field = info.Fields[i];
                field.SetValue(pObject, _controls[i].FieldValue);
            }
            PacketController.Send((Packet)pObject);
        }
        #endregion
    }
}