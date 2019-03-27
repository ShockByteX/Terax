namespace TeraxHook.GUI.Forms
{
    partial class PacketInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PacketInfoForm));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblCaption = new System.Windows.Forms.Label();
            this.btnExit = new ShockUI.Controls.ShockButtonImage();
            this.pnlBorderTop = new System.Windows.Forms.Panel();
            this.pnlBorderBottom = new System.Windows.Forms.Panel();
            this.pnlBorderRight = new System.Windows.Forms.Panel();
            this.pnlBorderLeft = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblOpCode = new System.Windows.Forms.Label();
            this.lblOpName = new System.Windows.Forms.Label();
            this.tbData = new System.Windows.Forms.RichTextBox();
            this.lblOpNameCaption = new System.Windows.Forms.Label();
            this.lblOpCodeCaption = new System.Windows.Forms.Label();
            this.pnlFields = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
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
            this.lblCaption.Size = new System.Drawing.Size(79, 19);
            this.lblCaption.TabIndex = 9;
            this.lblCaption.Text = "Packet Info";
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
            this.pnlBorderBottom.Location = new System.Drawing.Point(1, 464);
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
            this.pnlBorderRight.Size = new System.Drawing.Size(1, 465);
            this.pnlBorderRight.TabIndex = 13;
            // 
            // pnlBorderLeft
            // 
            this.pnlBorderLeft.BackColor = System.Drawing.Color.Black;
            this.pnlBorderLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBorderLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlBorderLeft.Name = "pnlBorderLeft";
            this.pnlBorderLeft.Size = new System.Drawing.Size(1, 465);
            this.pnlBorderLeft.TabIndex = 12;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.lblLength);
            this.pnlBody.Controls.Add(this.lblOpCode);
            this.pnlBody.Controls.Add(this.lblOpName);
            this.pnlBody.Controls.Add(this.tbData);
            this.pnlBody.Controls.Add(this.lblOpNameCaption);
            this.pnlBody.Controls.Add(this.lblOpCodeCaption);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBody.Location = new System.Drawing.Point(1, 25);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(369, 178);
            this.pnlBody.TabIndex = 17;
            // 
            // lblLength
            // 
            this.lblLength.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.lblLength.Location = new System.Drawing.Point(325, 32);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(37, 13);
            this.lblLength.TabIndex = 5;
            this.lblLength.Text = "128";
            this.lblLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOpCode
            // 
            this.lblOpCode.AutoSize = true;
            this.lblOpCode.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOpCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.lblOpCode.Location = new System.Drawing.Point(57, 28);
            this.lblOpCode.Name = "lblOpCode";
            this.lblOpCode.Size = new System.Drawing.Size(37, 13);
            this.lblOpCode.TabIndex = 4;
            this.lblOpCode.Text = "16089";
            // 
            // lblOpName
            // 
            this.lblOpName.AutoSize = true;
            this.lblOpName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOpName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.lblOpName.Location = new System.Drawing.Point(57, 7);
            this.lblOpName.Name = "lblOpName";
            this.lblOpName.Size = new System.Drawing.Size(138, 13);
            this.lblOpName.TabIndex = 3;
            this.lblOpName.Text = "SOME_OPERATION_NAME";
            // 
            // tbData
            // 
            this.tbData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.tbData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbData.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbData.ForeColor = System.Drawing.Color.Silver;
            this.tbData.Location = new System.Drawing.Point(7, 48);
            this.tbData.MaxLength = 65535;
            this.tbData.Name = "tbData";
            this.tbData.ReadOnly = true;
            this.tbData.Size = new System.Drawing.Size(355, 126);
            this.tbData.TabIndex = 2;
            this.tbData.Text = resources.GetString("tbData.Text");
            // 
            // lblOpNameCaption
            // 
            this.lblOpNameCaption.AutoSize = true;
            this.lblOpNameCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOpNameCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(160)))));
            this.lblOpNameCaption.Location = new System.Drawing.Point(4, 6);
            this.lblOpNameCaption.Name = "lblOpNameCaption";
            this.lblOpNameCaption.Size = new System.Drawing.Size(58, 15);
            this.lblOpNameCaption.TabIndex = 1;
            this.lblOpNameCaption.Text = "OpName:";
            // 
            // lblOpCodeCaption
            // 
            this.lblOpCodeCaption.AutoSize = true;
            this.lblOpCodeCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOpCodeCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(160)))));
            this.lblOpCodeCaption.Location = new System.Drawing.Point(8, 27);
            this.lblOpCodeCaption.Name = "lblOpCodeCaption";
            this.lblOpCodeCaption.Size = new System.Drawing.Size(54, 15);
            this.lblOpCodeCaption.TabIndex = 0;
            this.lblOpCodeCaption.Text = "OpCode:";
            // 
            // pnlFields
            // 
            this.pnlFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFields.Location = new System.Drawing.Point(1, 203);
            this.pnlFields.Name = "pnlFields";
            this.pnlFields.Size = new System.Drawing.Size(369, 261);
            this.pnlFields.TabIndex = 18;
            // 
            // PacketInfoForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(371, 465);
            this.ControlBox = false;
            this.Controls.Add(this.pnlFields);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlBorderTop);
            this.Controls.Add(this.pnlBorderBottom);
            this.Controls.Add(this.pnlBorderRight);
            this.Controls.Add(this.pnlBorderLeft);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PacketInfoForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblCaption;
        private ShockUI.Controls.ShockButtonImage btnExit;
        private System.Windows.Forms.Panel pnlBorderTop;
        private System.Windows.Forms.Panel pnlBorderBottom;
        private System.Windows.Forms.Panel pnlBorderRight;
        private System.Windows.Forms.Panel pnlBorderLeft;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.RichTextBox tbData;
        private System.Windows.Forms.Label lblOpNameCaption;
        private System.Windows.Forms.Label lblOpCodeCaption;
        private System.Windows.Forms.Label lblOpName;
        private System.Windows.Forms.Label lblOpCode;
        private System.Windows.Forms.Panel pnlFields;
        private System.Windows.Forms.Label lblLength;
    }
}