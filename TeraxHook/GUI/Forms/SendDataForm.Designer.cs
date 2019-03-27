namespace TeraxHook.GUI.Forms
{
    partial class SendDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendDataForm));
            this.pnlControls = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblCaption = new System.Windows.Forms.Label();
            this.btnExit = new ShockUI.Controls.ShockButtonImage();
            this.pnlBorderTop = new System.Windows.Forms.Panel();
            this.pnlBorderBottom = new System.Windows.Forms.Panel();
            this.pnlBorderRight = new System.Windows.Forms.Panel();
            this.pnlBorderLeft = new System.Windows.Forms.Panel();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnSend = new ShockUI.Controls.ShockButton();
            this.pnlData = new System.Windows.Forms.Panel();
            this.lblOpNameCaption = new System.Windows.Forms.Label();
            this.tbData = new System.Windows.Forms.RichTextBox();
            this.lblOpCode = new System.Windows.Forms.Label();
            this.lblOpName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOpCodeCaption = new System.Windows.Forms.Label();
            this.pnlSplitter = new System.Windows.Forms.Panel();
            this.lblLength = new System.Windows.Forms.Label();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.lblDirectionCaption = new System.Windows.Forms.Label();
            this.cbxDirection = new System.Windows.Forms.ComboBox();
            this.lblEncryptCaption = new System.Windows.Forms.Label();
            this.cbEncrypt = new ShockUI.Controls.ShockCheckbox();
            this.pnlControls.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.pnlData.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.pnlControls.Controls.Add(this.pnlSettings);
            this.pnlControls.Controls.Add(this.pnlSplitter);
            this.pnlControls.Controls.Add(this.pnlData);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControls.Location = new System.Drawing.Point(1, 25);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(369, 244);
            this.pnlControls.TabIndex = 18;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(10)))), ((int)(((byte)(13)))));
            this.pnlHeader.Controls.Add(this.lblCaption);
            this.pnlHeader.Controls.Add(this.btnExit);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(1, 1);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(369, 24);
            this.pnlHeader.TabIndex = 16;
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Miramonte", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.ForeColor = System.Drawing.Color.Silver;
            this.lblCaption.Location = new System.Drawing.Point(3, 2);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(76, 19);
            this.lblCaption.TabIndex = 9;
            this.lblCaption.Text = "Send Data";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Animated = true;
            this.btnExit.AnimationInterval = 40;
            this.btnExit.AnimationStep = 1;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(347, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(14, 14);
            this.btnExit.TabIndex = 0;
            this.btnExit.Zoom = 2;
            // 
            // pnlBorderTop
            // 
            this.pnlBorderTop.BackColor = System.Drawing.Color.Black;
            this.pnlBorderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBorderTop.Location = new System.Drawing.Point(1, 0);
            this.pnlBorderTop.Name = "pnlBorderTop";
            this.pnlBorderTop.Size = new System.Drawing.Size(369, 1);
            this.pnlBorderTop.TabIndex = 15;
            // 
            // pnlBorderBottom
            // 
            this.pnlBorderBottom.BackColor = System.Drawing.Color.Black;
            this.pnlBorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBorderBottom.Location = new System.Drawing.Point(1, 269);
            this.pnlBorderBottom.Name = "pnlBorderBottom";
            this.pnlBorderBottom.Size = new System.Drawing.Size(369, 1);
            this.pnlBorderBottom.TabIndex = 14;
            // 
            // pnlBorderRight
            // 
            this.pnlBorderRight.BackColor = System.Drawing.Color.Black;
            this.pnlBorderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBorderRight.Location = new System.Drawing.Point(370, 0);
            this.pnlBorderRight.Name = "pnlBorderRight";
            this.pnlBorderRight.Size = new System.Drawing.Size(1, 270);
            this.pnlBorderRight.TabIndex = 13;
            // 
            // pnlBorderLeft
            // 
            this.pnlBorderLeft.BackColor = System.Drawing.Color.Black;
            this.pnlBorderLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBorderLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlBorderLeft.Name = "pnlBorderLeft";
            this.pnlBorderLeft.Size = new System.Drawing.Size(1, 270);
            this.pnlBorderLeft.TabIndex = 12;
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(5)))));
            this.pnlButton.Controls.Add(this.btnSend);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButton.Location = new System.Drawing.Point(0, 270);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(371, 32);
            this.pnlButton.TabIndex = 19;
            // 
            // btnSend
            // 
            this.btnSend.BackColorIdle = System.Drawing.Color.Transparent;
            this.btnSend.BackColorOver = System.Drawing.Color.Transparent;
            this.btnSend.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnSend.BorderColorOver = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(240)))));
            this.btnSend.BorderThickness = 1;
            this.btnSend.ButtonFont = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSend.ButtonText = "Send";
            this.btnSend.CornerRadius = 0;
            this.btnSend.Location = new System.Drawing.Point(135, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 24);
            this.btnSend.TabIndex = 3;
            this.btnSend.TextColorIdle = System.Drawing.Color.Silver;
            this.btnSend.TextColorOver = System.Drawing.Color.Gainsboro;
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.lblLength);
            this.pnlData.Controls.Add(this.lblOpCode);
            this.pnlData.Controls.Add(this.lblOpName);
            this.pnlData.Controls.Add(this.label1);
            this.pnlData.Controls.Add(this.lblOpCodeCaption);
            this.pnlData.Controls.Add(this.lblOpNameCaption);
            this.pnlData.Controls.Add(this.tbData);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlData.Location = new System.Drawing.Point(0, 0);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(369, 189);
            this.pnlData.TabIndex = 5;
            // 
            // lblOpNameCaption
            // 
            this.lblOpNameCaption.AutoSize = true;
            this.lblOpNameCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOpNameCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(160)))));
            this.lblOpNameCaption.Location = new System.Drawing.Point(4, 4);
            this.lblOpNameCaption.Name = "lblOpNameCaption";
            this.lblOpNameCaption.Size = new System.Drawing.Size(31, 15);
            this.lblOpNameCaption.TabIndex = 6;
            this.lblOpNameCaption.Text = "Data";
            // 
            // tbData
            // 
            this.tbData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.tbData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbData.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbData.ForeColor = System.Drawing.Color.Silver;
            this.tbData.Location = new System.Drawing.Point(7, 22);
            this.tbData.MaxLength = 65535;
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(355, 126);
            this.tbData.TabIndex = 5;
            this.tbData.Text = "";
            // 
            // lblOpCode
            // 
            this.lblOpCode.AutoSize = true;
            this.lblOpCode.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOpCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.lblOpCode.Location = new System.Drawing.Point(57, 171);
            this.lblOpCode.Name = "lblOpCode";
            this.lblOpCode.Size = new System.Drawing.Size(38, 13);
            this.lblOpCode.TabIndex = 10;
            this.lblOpCode.Text = "NONE";
            // 
            // lblOpName
            // 
            this.lblOpName.AutoSize = true;
            this.lblOpName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOpName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.lblOpName.Location = new System.Drawing.Point(57, 153);
            this.lblOpName.Name = "lblOpName";
            this.lblOpName.Size = new System.Drawing.Size(38, 13);
            this.lblOpName.TabIndex = 9;
            this.lblOpName.Text = "NONE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(4, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "OpName:";
            // 
            // lblOpCodeCaption
            // 
            this.lblOpCodeCaption.AutoSize = true;
            this.lblOpCodeCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOpCodeCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(160)))));
            this.lblOpCodeCaption.Location = new System.Drawing.Point(8, 170);
            this.lblOpCodeCaption.Name = "lblOpCodeCaption";
            this.lblOpCodeCaption.Size = new System.Drawing.Size(54, 15);
            this.lblOpCodeCaption.TabIndex = 7;
            this.lblOpCodeCaption.Text = "OpCode:";
            // 
            // pnlSplitter
            // 
            this.pnlSplitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.pnlSplitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSplitter.Location = new System.Drawing.Point(0, 189);
            this.pnlSplitter.Name = "pnlSplitter";
            this.pnlSplitter.Size = new System.Drawing.Size(369, 1);
            this.pnlSplitter.TabIndex = 6;
            // 
            // lblLength
            // 
            this.lblLength.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.lblLength.Location = new System.Drawing.Point(325, 6);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(37, 13);
            this.lblLength.TabIndex = 11;
            this.lblLength.Text = "0";
            this.lblLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlSettings
            // 
            this.pnlSettings.Controls.Add(this.cbEncrypt);
            this.pnlSettings.Controls.Add(this.lblEncryptCaption);
            this.pnlSettings.Controls.Add(this.cbxDirection);
            this.pnlSettings.Controls.Add(this.lblDirectionCaption);
            this.pnlSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSettings.Location = new System.Drawing.Point(0, 190);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(369, 54);
            this.pnlSettings.TabIndex = 7;
            // 
            // lblDirectionCaption
            // 
            this.lblDirectionCaption.AutoSize = true;
            this.lblDirectionCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDirectionCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(160)))));
            this.lblDirectionCaption.Location = new System.Drawing.Point(4, 6);
            this.lblDirectionCaption.Name = "lblDirectionCaption";
            this.lblDirectionCaption.Size = new System.Drawing.Size(58, 15);
            this.lblDirectionCaption.TabIndex = 9;
            this.lblDirectionCaption.Text = "Direction:";
            // 
            // cbxDirection
            // 
            this.cbxDirection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.cbxDirection.DisplayMember = "0";
            this.cbxDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDirection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxDirection.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxDirection.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.cbxDirection.FormattingEnabled = true;
            this.cbxDirection.Items.AddRange(new object[] {
            "Server",
            "Client"});
            this.cbxDirection.Location = new System.Drawing.Point(61, 4);
            this.cbxDirection.Name = "cbxDirection";
            this.cbxDirection.Size = new System.Drawing.Size(300, 21);
            this.cbxDirection.TabIndex = 11;
            this.cbxDirection.ValueMember = "0";
            // 
            // lblEncryptCaption
            // 
            this.lblEncryptCaption.AutoSize = true;
            this.lblEncryptCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEncryptCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(160)))));
            this.lblEncryptCaption.Location = new System.Drawing.Point(12, 31);
            this.lblEncryptCaption.Name = "lblEncryptCaption";
            this.lblEncryptCaption.Size = new System.Drawing.Size(50, 15);
            this.lblEncryptCaption.TabIndex = 12;
            this.lblEncryptCaption.Text = "Encrypt:";
            // 
            // cbEncrypt
            // 
            this.cbEncrypt.AnimationInterval = 10;
            this.cbEncrypt.AnimationSteps = 10;
            this.cbEncrypt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.cbEncrypt.BorderThickness = 1;
            this.cbEncrypt.ColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.cbEncrypt.ColorInactive = System.Drawing.Color.WhiteSmoke;
            this.cbEncrypt.CornerRadius = 0;
            this.cbEncrypt.Location = new System.Drawing.Point(60, 31);
            this.cbEncrypt.MarkColor = System.Drawing.Color.WhiteSmoke;
            this.cbEncrypt.MarkThickness = 2;
            this.cbEncrypt.Name = "cbEncrypt";
            this.cbEncrypt.Selected = true;
            this.cbEncrypt.Size = new System.Drawing.Size(16, 16);
            this.cbEncrypt.TabIndex = 13;
            // 
            // SendDataForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(371, 302);
            this.ControlBox = false;
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlBorderTop);
            this.Controls.Add(this.pnlBorderBottom);
            this.Controls.Add(this.pnlBorderRight);
            this.Controls.Add(this.pnlBorderLeft);
            this.Controls.Add(this.pnlButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SendDataForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.pnlControls.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblCaption;
        private ShockUI.Controls.ShockButtonImage btnExit;
        private System.Windows.Forms.Panel pnlBorderTop;
        private System.Windows.Forms.Panel pnlBorderBottom;
        private System.Windows.Forms.Panel pnlBorderRight;
        private System.Windows.Forms.Panel pnlBorderLeft;
        private System.Windows.Forms.Panel pnlButton;
        private ShockUI.Controls.ShockButton btnSend;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Label lblOpNameCaption;
        private System.Windows.Forms.RichTextBox tbData;
        private System.Windows.Forms.Panel pnlSplitter;
        private System.Windows.Forms.Label lblOpCode;
        private System.Windows.Forms.Label lblOpName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOpCodeCaption;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Label lblDirectionCaption;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.ComboBox cbxDirection;
        private ShockUI.Controls.ShockCheckbox cbEncrypt;
        private System.Windows.Forms.Label lblEncryptCaption;
    }
}