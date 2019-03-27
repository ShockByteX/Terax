namespace TeraxHook.GUI.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlBorderLeft = new System.Windows.Forms.Panel();
            this.pnlBorderRight = new System.Windows.Forms.Panel();
            this.pnlBorderBottom = new System.Windows.Forms.Panel();
            this.pnlBorderTop = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnExit = new ShockUI.Controls.ShockButtonImage();
            this.btnSettings = new ShockUI.Controls.ShockButtonSelector();
            this.btnTables = new ShockUI.Controls.ShockButtonSelector();
            this.btnPackets = new ShockUI.Controls.ShockButtonSelector();
            this.btnFeatures = new ShockUI.Controls.ShockButtonSelector();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.btnImage = new ShockUI.Controls.ShockButtonImage();
            this.btnLog = new ShockUI.Controls.ShockButtonImage();
            this.lblPCStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTabs = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBorderLeft
            // 
            this.pnlBorderLeft.BackColor = System.Drawing.Color.Black;
            this.pnlBorderLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBorderLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlBorderLeft.Name = "pnlBorderLeft";
            this.pnlBorderLeft.Size = new System.Drawing.Size(1, 577);
            this.pnlBorderLeft.TabIndex = 3;
            // 
            // pnlBorderRight
            // 
            this.pnlBorderRight.BackColor = System.Drawing.Color.Black;
            this.pnlBorderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBorderRight.Location = new System.Drawing.Point(751, 0);
            this.pnlBorderRight.Name = "pnlBorderRight";
            this.pnlBorderRight.Size = new System.Drawing.Size(1, 577);
            this.pnlBorderRight.TabIndex = 4;
            // 
            // pnlBorderBottom
            // 
            this.pnlBorderBottom.BackColor = System.Drawing.Color.Black;
            this.pnlBorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBorderBottom.Location = new System.Drawing.Point(1, 576);
            this.pnlBorderBottom.Name = "pnlBorderBottom";
            this.pnlBorderBottom.Size = new System.Drawing.Size(750, 1);
            this.pnlBorderBottom.TabIndex = 5;
            // 
            // pnlBorderTop
            // 
            this.pnlBorderTop.BackColor = System.Drawing.Color.Black;
            this.pnlBorderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBorderTop.Location = new System.Drawing.Point(1, 0);
            this.pnlBorderTop.Name = "pnlBorderTop";
            this.pnlBorderTop.Size = new System.Drawing.Size(750, 1);
            this.pnlBorderTop.TabIndex = 6;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(10)))), ((int)(((byte)(13)))));
            this.pnlHeader.Controls.Add(this.btnExit);
            this.pnlHeader.Controls.Add(this.btnSettings);
            this.pnlHeader.Controls.Add(this.btnTables);
            this.pnlHeader.Controls.Add(this.btnPackets);
            this.pnlHeader.Controls.Add(this.btnFeatures);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(1, 1);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(750, 50);
            this.pnlHeader.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Animated = true;
            this.btnExit.AnimationInterval = 40;
            this.btnExit.AnimationStep = 1;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(726, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(16, 16);
            this.btnExit.TabIndex = 0;
            this.btnExit.Zoom = 2;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSettings.AnimationInterval = 10;
            this.btnSettings.AnimationStep = 8;
            this.btnSettings.ButtonIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(10)))), ((int)(((byte)(13)))));
            this.btnSettings.ButtonSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(10)))), ((int)(((byte)(13)))));
            this.btnSettings.ButtonText = "Settings";
            this.btnSettings.CurrentFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSettings.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnSettings.LineHeight = 3;
            this.btnSettings.Location = new System.Drawing.Point(625, 20);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Selected = false;
            this.btnSettings.Size = new System.Drawing.Size(120, 30);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.TextEnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSettings.TextIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSettings.TextSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSettings.TextYPositionOffset = 1;
            // 
            // btnTables
            // 
            this.btnTables.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTables.AnimationInterval = 10;
            this.btnTables.AnimationStep = 8;
            this.btnTables.ButtonIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(10)))), ((int)(((byte)(13)))));
            this.btnTables.ButtonSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(10)))), ((int)(((byte)(13)))));
            this.btnTables.ButtonText = "Tables";
            this.btnTables.CurrentFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTables.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnTables.LineHeight = 3;
            this.btnTables.Location = new System.Drawing.Point(438, 20);
            this.btnTables.Name = "btnTables";
            this.btnTables.Selected = false;
            this.btnTables.Size = new System.Drawing.Size(120, 30);
            this.btnTables.TabIndex = 2;
            this.btnTables.TextEnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTables.TextIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTables.TextSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTables.TextYPositionOffset = 1;
            // 
            // btnPackets
            // 
            this.btnPackets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPackets.AnimationInterval = 10;
            this.btnPackets.AnimationStep = 8;
            this.btnPackets.ButtonIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(10)))), ((int)(((byte)(13)))));
            this.btnPackets.ButtonSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(10)))), ((int)(((byte)(13)))));
            this.btnPackets.ButtonText = "Packets";
            this.btnPackets.CurrentFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPackets.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnPackets.LineHeight = 3;
            this.btnPackets.Location = new System.Drawing.Point(237, 20);
            this.btnPackets.Name = "btnPackets";
            this.btnPackets.Selected = false;
            this.btnPackets.Size = new System.Drawing.Size(120, 30);
            this.btnPackets.TabIndex = 1;
            this.btnPackets.TextEnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPackets.TextIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPackets.TextSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPackets.TextYPositionOffset = 1;
            // 
            // btnFeatures
            // 
            this.btnFeatures.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFeatures.AnimationInterval = 10;
            this.btnFeatures.AnimationStep = 8;
            this.btnFeatures.ButtonIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(10)))), ((int)(((byte)(13)))));
            this.btnFeatures.ButtonSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(10)))), ((int)(((byte)(13)))));
            this.btnFeatures.ButtonText = "Features";
            this.btnFeatures.CurrentFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFeatures.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnFeatures.LineHeight = 3;
            this.btnFeatures.Location = new System.Drawing.Point(24, 21);
            this.btnFeatures.Name = "btnFeatures";
            this.btnFeatures.Selected = true;
            this.btnFeatures.Size = new System.Drawing.Size(120, 30);
            this.btnFeatures.TabIndex = 0;
            this.btnFeatures.TextEnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFeatures.TextIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFeatures.TextSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFeatures.TextYPositionOffset = 1;
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(4)))));
            this.pnlStatus.Controls.Add(this.btnImage);
            this.pnlStatus.Controls.Add(this.btnLog);
            this.pnlStatus.Controls.Add(this.lblPCStatus);
            this.pnlStatus.Controls.Add(this.label1);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatus.Location = new System.Drawing.Point(1, 551);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(750, 25);
            this.pnlStatus.TabIndex = 9;
            // 
            // btnImage
            // 
            this.btnImage.Animated = true;
            this.btnImage.AnimationInterval = 40;
            this.btnImage.AnimationStep = 1;
            this.btnImage.Image = ((System.Drawing.Image)(resources.GetObject("btnImage.Image")));
            this.btnImage.Location = new System.Drawing.Point(697, 2);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(21, 21);
            this.btnImage.TabIndex = 2;
            this.btnImage.Zoom = 2;
            // 
            // btnLog
            // 
            this.btnLog.Animated = true;
            this.btnLog.AnimationInterval = 40;
            this.btnLog.AnimationStep = 1;
            this.btnLog.Image = ((System.Drawing.Image)(resources.GetObject("btnLog.Image")));
            this.btnLog.Location = new System.Drawing.Point(724, 2);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(21, 21);
            this.btnLog.TabIndex = 0;
            this.btnLog.Zoom = 2;
            // 
            // lblPCStatus
            // 
            this.lblPCStatus.AutoSize = true;
            this.lblPCStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPCStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPCStatus.Location = new System.Drawing.Point(46, 3);
            this.lblPCStatus.Name = "lblPCStatus";
            this.lblPCStatus.Size = new System.Drawing.Size(61, 17);
            this.lblPCStatus.TabIndex = 1;
            this.lblPCStatus.Text = "Unknown";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server:";
            // 
            // pnlTabs
            // 
            this.pnlTabs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.pnlTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTabs.Location = new System.Drawing.Point(1, 51);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Size = new System.Drawing.Size(750, 500);
            this.pnlTabs.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(752, 577);
            this.ControlBox = false;
            this.Controls.Add(this.pnlTabs);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlBorderTop);
            this.Controls.Add(this.pnlBorderBottom);
            this.Controls.Add(this.pnlBorderRight);
            this.Controls.Add(this.pnlBorderLeft);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.pnlHeader.ResumeLayout(false);
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBorderLeft;
        private System.Windows.Forms.Panel pnlBorderRight;
        private System.Windows.Forms.Panel pnlBorderBottom;
        private System.Windows.Forms.Panel pnlBorderTop;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Panel pnlTabs;
        private ShockUI.Controls.ShockButtonSelector btnFeatures;
        private ShockUI.Controls.ShockButtonSelector btnTables;
        private ShockUI.Controls.ShockButtonSelector btnPackets;
        private ShockUI.Controls.ShockButtonSelector btnSettings;
        private System.Windows.Forms.Label lblPCStatus;
        private System.Windows.Forms.Label label1;
        private ShockUI.Controls.ShockButtonImage btnLog;
        private ShockUI.Controls.ShockButtonImage btnExit;
        private ShockUI.Controls.ShockButtonImage btnImage;
    }
}