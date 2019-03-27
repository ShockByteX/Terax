namespace TeraxHook.GUI.Controls
{
    partial class ExVector3
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlCaption = new System.Windows.Forms.Panel();
            this.lblFieldName = new System.Windows.Forms.Label();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.udZ = new System.Windows.Forms.NumericUpDown();
            this.lblZ = new System.Windows.Forms.Label();
            this.udY = new System.Windows.Forms.NumericUpDown();
            this.lblY = new System.Windows.Forms.Label();
            this.udX = new System.Windows.Forms.NumericUpDown();
            this.lblX = new System.Windows.Forms.Label();
            this.pnlCaption.SuspendLayout();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udX)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCaption
            // 
            this.pnlCaption.Controls.Add(this.lblFieldName);
            this.pnlCaption.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCaption.Location = new System.Drawing.Point(0, 0);
            this.pnlCaption.Name = "pnlCaption";
            this.pnlCaption.Size = new System.Drawing.Size(67, 22);
            this.pnlCaption.TabIndex = 1;
            // 
            // lblFieldName
            // 
            this.lblFieldName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFieldName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFieldName.ForeColor = System.Drawing.Color.Silver;
            this.lblFieldName.Location = new System.Drawing.Point(0, 0);
            this.lblFieldName.Name = "lblFieldName";
            this.lblFieldName.Size = new System.Drawing.Size(67, 22);
            this.lblFieldName.TabIndex = 1;
            this.lblFieldName.Text = "Field name:";
            this.lblFieldName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.udZ);
            this.pnlControl.Controls.Add(this.lblZ);
            this.pnlControl.Controls.Add(this.udY);
            this.pnlControl.Controls.Add(this.lblY);
            this.pnlControl.Controls.Add(this.udX);
            this.pnlControl.Controls.Add(this.lblX);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControl.Location = new System.Drawing.Point(67, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(331, 22);
            this.pnlControl.TabIndex = 2;
            // 
            // udZ
            // 
            this.udZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.udZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.udZ.DecimalPlaces = 4;
            this.udZ.Dock = System.Windows.Forms.DockStyle.Left;
            this.udZ.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.udZ.ForeColor = System.Drawing.Color.Gainsboro;
            this.udZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.udZ.Location = new System.Drawing.Point(236, 0);
            this.udZ.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.udZ.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.udZ.Name = "udZ";
            this.udZ.Size = new System.Drawing.Size(94, 22);
            this.udZ.TabIndex = 7;
            // 
            // lblZ
            // 
            this.lblZ.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblZ.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblZ.ForeColor = System.Drawing.Color.Silver;
            this.lblZ.Location = new System.Drawing.Point(220, 0);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(16, 22);
            this.lblZ.TabIndex = 6;
            this.lblZ.Text = "Z:";
            this.lblZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // udY
            // 
            this.udY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.udY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.udY.DecimalPlaces = 4;
            this.udY.Dock = System.Windows.Forms.DockStyle.Left;
            this.udY.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.udY.ForeColor = System.Drawing.Color.Gainsboro;
            this.udY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.udY.Location = new System.Drawing.Point(126, 0);
            this.udY.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.udY.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.udY.Name = "udY";
            this.udY.Size = new System.Drawing.Size(94, 22);
            this.udY.TabIndex = 5;
            // 
            // lblY
            // 
            this.lblY.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblY.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblY.ForeColor = System.Drawing.Color.Silver;
            this.lblY.Location = new System.Drawing.Point(110, 0);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(16, 22);
            this.lblY.TabIndex = 4;
            this.lblY.Text = "Y:";
            this.lblY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // udX
            // 
            this.udX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.udX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.udX.DecimalPlaces = 4;
            this.udX.Dock = System.Windows.Forms.DockStyle.Left;
            this.udX.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.udX.ForeColor = System.Drawing.Color.Gainsboro;
            this.udX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.udX.Location = new System.Drawing.Point(16, 0);
            this.udX.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.udX.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.udX.Name = "udX";
            this.udX.Size = new System.Drawing.Size(94, 22);
            this.udX.TabIndex = 3;
            // 
            // lblX
            // 
            this.lblX.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblX.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblX.ForeColor = System.Drawing.Color.Silver;
            this.lblX.Location = new System.Drawing.Point(0, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(16, 22);
            this.lblX.TabIndex = 2;
            this.lblX.Text = "X:";
            this.lblX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExVector3
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.pnlCaption);
            this.DoubleBuffered = true;
            this.Name = "ExVector3";
            this.Size = new System.Drawing.Size(398, 22);
            this.pnlCaption.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.udZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCaption;
        private System.Windows.Forms.Label lblFieldName;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.NumericUpDown udZ;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.NumericUpDown udY;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.NumericUpDown udX;
    }
}
