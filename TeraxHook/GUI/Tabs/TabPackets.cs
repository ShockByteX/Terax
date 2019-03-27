using Tera.Core.Network.Protocol;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using TeraxHook.GUI.Forms;
using TeraxHook.Internals;
using Tera.Core.Network.OpCodes;

using System.Linq;

namespace TeraxHook.GUI.Tabs
{
    public partial class TabPackets : UserControl
    {
        #region [PUBLIC\STATIC]Fields
        public static readonly TabPackets Instance = new TabPackets();
        #endregion
        #region [PRIVATE]Fields
        private OpArray _ops;
        private int _totalPackets = 0;
        #endregion
        #region Constructors
        public TabPackets()
        {
            InitializeComponent();
            btnSendPacket.Click += (s, e) => SendPacketForm.Instance.Show();
            btnSendData.Click += (s, e) => new SendDataForm().Show();
            btnClear.Click += btnClear_Click;
            tbOpFilter.TextChanged += tbOpFilter_TextChanged;
            lvOps.ItemChecked += lvOps_ItemChecked;
            lvPackets.MouseClick += lvPackets_MouseClick;
        }
        #endregion
        #region [PRIVATE]Handlers
        private void btnClear_Click(object sender, EventArgs e) { lvPackets.Items.Clear(); _totalPackets = 0; }
        private void lvOps_ItemChecked(object sender, ItemCheckedEventArgs e) => _ops[e.Item.Name].Checked = e.Item.Checked;
        private void tbOpFilter_TextChanged(object sender, EventArgs e)
        {
            lvOps.Items.Clear();
            List<Op> ops = _ops.GetByFilter(tbOpFilter.Text);
            foreach (Op op in ops) lvOps.Items.Add(new ListViewItem(op.Name) { Name = op.Name, Checked = op.Checked });
        }
        private void lvPackets_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lvPackets.FocusedItem.Bounds.Contains(e.Location)) cmsPacket.Show(Cursor.Position);
            }
        }
        private void cmsiInfo_Click(object sender, EventArgs e) => new PacketInfoForm((RawPacket)lvPackets.SelectedItems[0].Tag).Show();
        #endregion
        #region [PRIVATE]Methods
        public void AddOpTable(OpCodeTable table)
        {
            
            Action action = () =>
            {
                _ops = new OpArray(table);
                //string[] uck = new string[] { "BALLOON", "LOCATION", "DOOR", "SHUTTLE", "SPAWN", "S_SOCIAL" };
                //foreach (string filter in uck)
                //{
                //    foreach (Op op in _ops.GetByFilter(filter)) _ops[op.Name].Checked = false;
                //}
            };
            Invoke(action);
        }
        public void AddItem(RawPacket packet)
        {
            Action action = () =>
            {
                string opName = PacketController.Client.Processor.Serializer.Tables.Game.OpCodeToName[packet.OpCode];
                if (!_ops[opName].Checked) return;
                _totalPackets++;
                if (_totalPackets > 100) { lvPackets.Items.RemoveAt(0); }
                ListViewItem lvi = new ListViewItem(_totalPackets.ToString()) { Tag = packet };
                lvi.SubItems.Add(packet.Direction.ToString());
                lvi.SubItems.Add(packet.OpCode.ToString());
                lvi.SubItems.Add(opName);
                lvi.SubItems.Add(packet.Length.ToString());
                lvPackets.Items.Add(lvi);
                lvPackets.Items[lvPackets.Items.Count - 1].EnsureVisible();
            };
            Invoke(action);
        }
        #endregion
        #region [PUBLIC\STATIC]Methods
        public static void AddPacket(RawPacket packet) => Instance.AddItem(packet);
        public static void AddTable(OpCodeTable table) => Instance.AddOpTable(table);
        #endregion
        #region [NESTED]Classes
        private class OpArray
        {
            #region Fields
            private Op[] _ops;
            private int _length;
            #endregion
            #region Properties
            public int Length => _length;
            public Op this[string name] => _ops[IndexOf(name)];
            #endregion
            #region Constructors
            public OpArray(OpCodeTable table)
            {
                List<Op> ops = new List<Op>();
                foreach (string opName in table.NameToOpCode.Keys) ops.Add(new Op(opName, true));
                _ops = ops.ToArray();
                _length = _ops.Length;
            }
            #endregion
            #region [PUBLIC]
            public int IndexOf(string name) { for (int i = 0; i < _length; i++) { if (_ops[i].Name == name) return i; } return -1; }
            public List<Op> GetByFilter(string filter)
            {
                List<Op> result = new List<Op>();
                for (int i = 0; i < _length; i++)
                {
                    Op op = _ops[i];
                    if (op.Name.Contains(filter)) result.Add(op);
                    if (result.Count == 300) return result;
                }
                return result;
            }
            #endregion
        }
        private class Op
        {
            #region Fields
            public readonly string Name;
            public bool Checked;
            #endregion
            #region Constructors
            public Op(string name, bool isChecked) { Name = name; Checked = isChecked; }
            #endregion
        }
        #endregion
    }
}