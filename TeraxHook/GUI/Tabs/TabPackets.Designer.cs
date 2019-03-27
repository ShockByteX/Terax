namespace TeraxHook.GUI.Tabs
{
    partial class TabPackets
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lvPackets = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSendPacket = new ShockUI.Controls.ShockButton();
            this.lvOps = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClear = new ShockUI.Controls.ShockButton();
            this.tbOpFilter = new System.Windows.Forms.TextBox();
            this.cmsPacket = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsiInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSendData = new ShockUI.Controls.ShockButton();
            this.cmsPacket.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvPackets
            // 
            this.lvPackets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.lvPackets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lvPackets.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvPackets.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvPackets.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lvPackets.FullRowSelect = true;
            this.lvPackets.Location = new System.Drawing.Point(0, 145);
            this.lvPackets.MultiSelect = false;
            this.lvPackets.Name = "lvPackets";
            this.lvPackets.Size = new System.Drawing.Size(750, 355);
            this.lvPackets.TabIndex = 1;
            this.lvPackets.UseCompatibleStateImageBehavior = false;
            this.lvPackets.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Id";
            this.columnHeader6.Width = 44;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Direction";
            this.columnHeader7.Width = 87;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "OpCode";
            this.columnHeader8.Width = 55;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "OpName";
            this.columnHeader9.Width = 512;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Length";
            this.columnHeader10.Width = 48;
            // 
            // btnSendPacket
            // 
            this.btnSendPacket.BackColorIdle = System.Drawing.Color.Transparent;
            this.btnSendPacket.BackColorOver = System.Drawing.Color.Transparent;
            this.btnSendPacket.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnSendPacket.BorderColorOver = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(240)))));
            this.btnSendPacket.BorderThickness = 1;
            this.btnSendPacket.ButtonFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSendPacket.ButtonText = "Send Packet";
            this.btnSendPacket.CornerRadius = 0;
            this.btnSendPacket.Location = new System.Drawing.Point(598, 56);
            this.btnSendPacket.Name = "btnSendPacket";
            this.btnSendPacket.Size = new System.Drawing.Size(150, 24);
            this.btnSendPacket.TabIndex = 2;
            this.btnSendPacket.TextColorIdle = System.Drawing.Color.Silver;
            this.btnSendPacket.TextColorOver = System.Drawing.Color.Gainsboro;
            // 
            // lvOps
            // 
            this.lvOps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.lvOps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvOps.CheckBoxes = true;
            this.lvOps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvOps.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvOps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lvOps.FullRowSelect = true;
            this.lvOps.Location = new System.Drawing.Point(3, 0);
            this.lvOps.MultiSelect = false;
            this.lvOps.Name = "lvOps";
            this.lvOps.Size = new System.Drawing.Size(591, 140);
            this.lvOps.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvOps.TabIndex = 3;
            this.lvOps.UseCompatibleStateImageBehavior = false;
            this.lvOps.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Operation";
            this.columnHeader1.Width = 389;
            // 
            // btnClear
            // 
            this.btnClear.BackColorIdle = System.Drawing.Color.Transparent;
            this.btnClear.BackColorOver = System.Drawing.Color.Transparent;
            this.btnClear.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(200)))));
            this.btnClear.BorderColorOver = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(60)))), ((int)(((byte)(240)))));
            this.btnClear.BorderThickness = 1;
            this.btnClear.ButtonFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.ButtonText = "Clear";
            this.btnClear.CornerRadius = 0;
            this.btnClear.Location = new System.Drawing.Point(598, 116);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 24);
            this.btnClear.TabIndex = 4;
            this.btnClear.TextColorIdle = System.Drawing.Color.Silver;
            this.btnClear.TextColorOver = System.Drawing.Color.Gainsboro;
            // 
            // tbOpFilter
            // 
            this.tbOpFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.tbOpFilter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOpFilter.ForeColor = System.Drawing.Color.Silver;
            this.tbOpFilter.Location = new System.Drawing.Point(598, 0);
            this.tbOpFilter.Name = "tbOpFilter";
            this.tbOpFilter.Size = new System.Drawing.Size(149, 22);
            this.tbOpFilter.TabIndex = 5;
            this.tbOpFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmsPacket
            // 
            this.cmsPacket.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsiInfo});
            this.cmsPacket.Name = "cmsPacket";
            this.cmsPacket.Size = new System.Drawing.Size(96, 26);
            // 
            // cmsiInfo
            // 
            this.cmsiInfo.Name = "cmsiInfo";
            this.cmsiInfo.Size = new System.Drawing.Size(95, 22);
            this.cmsiInfo.Text = "Info";
            this.cmsiInfo.Click += new System.EventHandler(this.cmsiInfo_Click);
            // 
            // btnSendData
            // 
            this.btnSendData.BackColorIdle = System.Drawing.Color.Transparent;
            this.btnSendData.BackColorOver = System.Drawing.Color.Transparent;
            this.btnSendData.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnSendData.BorderColorOver = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(240)))));
            this.btnSendData.BorderThickness = 1;
            this.btnSendData.ButtonFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSendData.ButtonText = "Send Data";
            this.btnSendData.CornerRadius = 0;
            this.btnSendData.Location = new System.Drawing.Point(598, 86);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(150, 24);
            this.btnSendData.TabIndex = 6;
            this.btnSendData.TextColorIdle = System.Drawing.Color.Silver;
            this.btnSendData.TextColorOver = System.Drawing.Color.Gainsboro;
            // 
            // TabPackets
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.btnSendData);
            this.Controls.Add(this.tbOpFilter);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lvOps);
            this.Controls.Add(this.btnSendPacket);
            this.Controls.Add(this.lvPackets);
            this.Name = "TabPackets";
            this.Size = new System.Drawing.Size(750, 500);
            this.cmsPacket.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvPackets;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private ShockUI.Controls.ShockButton btnSendPacket;
        private System.Windows.Forms.ListView lvOps;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private ShockUI.Controls.ShockButton btnClear;
        private System.Windows.Forms.TextBox tbOpFilter;
        private System.Windows.Forms.ContextMenuStrip cmsPacket;
        private System.Windows.Forms.ToolStripMenuItem cmsiInfo;
        private ShockUI.Controls.ShockButton btnSendData;
    }
}
