namespace TeraxHook.GUI.Forms
{
    partial class SendPacketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendPacketForm));
            this.pnlBorderLeft = new System.Windows.Forms.Panel();
            this.pnlBorderRight = new System.Windows.Forms.Panel();
            this.pnlBorderBottom = new System.Windows.Forms.Panel();
            this.pnlBorderTop = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblCaption = new System.Windows.Forms.Label();
            this.btnExit = new ShockUI.Controls.ShockButtonImage();
            this.pnlOpList = new System.Windows.Forms.Panel();
            this.cbxOps = new System.Windows.Forms.ComboBox();
            this.pnlFields = new System.Windows.Forms.Panel();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnSend = new ShockUI.Controls.ShockButton();
            this.pnlHeader.SuspendLayout();
            this.pnlOpList.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBorderLeft
            // 
            this.pnlBorderLeft.BackColor = System.Drawing.Color.Black;
            this.pnlBorderLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBorderLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlBorderLeft.Name = "pnlBorderLeft";
            this.pnlBorderLeft.Size = new System.Drawing.Size(1, 418);
            this.pnlBorderLeft.TabIndex = 4;
            // 
            // pnlBorderRight
            // 
            this.pnlBorderRight.BackColor = System.Drawing.Color.Black;
            this.pnlBorderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBorderRight.Location = new System.Drawing.Point(399, 0);
            this.pnlBorderRight.Name = "pnlBorderRight";
            this.pnlBorderRight.Size = new System.Drawing.Size(1, 418);
            this.pnlBorderRight.TabIndex = 5;
            // 
            // pnlBorderBottom
            // 
            this.pnlBorderBottom.BackColor = System.Drawing.Color.Black;
            this.pnlBorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBorderBottom.Location = new System.Drawing.Point(1, 417);
            this.pnlBorderBottom.Name = "pnlBorderBottom";
            this.pnlBorderBottom.Size = new System.Drawing.Size(398, 1);
            this.pnlBorderBottom.TabIndex = 6;
            // 
            // pnlBorderTop
            // 
            this.pnlBorderTop.BackColor = System.Drawing.Color.Black;
            this.pnlBorderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBorderTop.Location = new System.Drawing.Point(1, 0);
            this.pnlBorderTop.Name = "pnlBorderTop";
            this.pnlBorderTop.Size = new System.Drawing.Size(398, 1);
            this.pnlBorderTop.TabIndex = 7;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(10)))), ((int)(((byte)(13)))));
            this.pnlHeader.Controls.Add(this.lblCaption);
            this.pnlHeader.Controls.Add(this.btnExit);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(1, 1);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(398, 24);
            this.pnlHeader.TabIndex = 8;
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Miramonte", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.ForeColor = System.Drawing.Color.Silver;
            this.lblCaption.Location = new System.Drawing.Point(3, 2);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(86, 19);
            this.lblCaption.TabIndex = 9;
            this.lblCaption.Text = "Send Packet";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Animated = true;
            this.btnExit.AnimationInterval = 40;
            this.btnExit.AnimationStep = 1;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(376, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(14, 14);
            this.btnExit.TabIndex = 0;
            this.btnExit.Zoom = 2;
            // 
            // pnlOpList
            // 
            this.pnlOpList.Controls.Add(this.cbxOps);
            this.pnlOpList.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOpList.Location = new System.Drawing.Point(1, 25);
            this.pnlOpList.Name = "pnlOpList";
            this.pnlOpList.Size = new System.Drawing.Size(398, 22);
            this.pnlOpList.TabIndex = 9;
            // 
            // cbxOps
            // 
            this.cbxOps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.cbxOps.DisplayMember = "0";
            this.cbxOps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxOps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxOps.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxOps.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.cbxOps.FormattingEnabled = true;
            this.cbxOps.Location = new System.Drawing.Point(0, 0);
            this.cbxOps.Name = "cbxOps";
            this.cbxOps.Size = new System.Drawing.Size(398, 21);
            this.cbxOps.TabIndex = 10;
            this.cbxOps.ValueMember = "0";
            // 
            // pnlFields
            // 
            this.pnlFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFields.Location = new System.Drawing.Point(1, 47);
            this.pnlFields.Name = "pnlFields";
            this.pnlFields.Size = new System.Drawing.Size(398, 370);
            this.pnlFields.TabIndex = 10;
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(5)))));
            this.pnlButton.Controls.Add(this.btnSend);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButton.Location = new System.Drawing.Point(0, 418);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(400, 32);
            this.pnlButton.TabIndex = 11;
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
            this.btnSend.Location = new System.Drawing.Point(150, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 24);
            this.btnSend.TabIndex = 3;
            this.btnSend.TextColorIdle = System.Drawing.Color.Silver;
            this.btnSend.TextColorOver = System.Drawing.Color.Gainsboro;
            // 
            // SendPacketForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.pnlFields);
            this.Controls.Add(this.pnlOpList);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlBorderTop);
            this.Controls.Add(this.pnlBorderBottom);
            this.Controls.Add(this.pnlBorderRight);
            this.Controls.Add(this.pnlBorderLeft);
            this.Controls.Add(this.pnlButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SendPacketForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlOpList.ResumeLayout(false);
            this.pnlButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBorderLeft;
        private System.Windows.Forms.Panel pnlBorderRight;
        private System.Windows.Forms.Panel pnlBorderBottom;
        private System.Windows.Forms.Panel pnlBorderTop;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblCaption;
        private ShockUI.Controls.ShockButtonImage btnExit;
        private System.Windows.Forms.Panel pnlOpList;
        private System.Windows.Forms.ComboBox cbxOps;
        private System.Windows.Forms.Panel pnlFields;
        private System.Windows.Forms.Panel pnlButton;
        private ShockUI.Controls.ShockButton btnSend;
    }
}