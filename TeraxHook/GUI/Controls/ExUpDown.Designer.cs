namespace TeraxHook.GUI.Controls
{
    partial class ExUpDown
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
            this.udValue = new System.Windows.Forms.NumericUpDown();
            this.pnlCaption.SuspendLayout();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udValue)).BeginInit();
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
            this.pnlControl.Controls.Add(this.udValue);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControl.Location = new System.Drawing.Point(67, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(331, 22);
            this.pnlControl.TabIndex = 2;
            // 
            // udValue
            // 
            this.udValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.udValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.udValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.udValue.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.udValue.ForeColor = System.Drawing.Color.Gainsboro;
            this.udValue.Location = new System.Drawing.Point(0, 0);
            this.udValue.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.udValue.Name = "udValue";
            this.udValue.Size = new System.Drawing.Size(331, 22);
            this.udValue.TabIndex = 0;
            // 
            // ExUpDown
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.pnlCaption);
            this.DoubleBuffered = true;
            this.Name = "ExUpDown";
            this.Size = new System.Drawing.Size(398, 22);
            this.pnlCaption.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.udValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCaption;
        private System.Windows.Forms.Label lblFieldName;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.NumericUpDown udValue;
    }
}
