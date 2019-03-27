namespace TeraxHook.GUI.Controls
{
    partial class ExEnum
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
            this.cbxValue = new System.Windows.Forms.ComboBox();
            this.pnlCaption.SuspendLayout();
            this.pnlControl.SuspendLayout();
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
            this.pnlControl.Controls.Add(this.cbxValue);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControl.Location = new System.Drawing.Point(67, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(331, 22);
            this.pnlControl.TabIndex = 2;
            // 
            // cbxValue
            // 
            this.cbxValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.cbxValue.DisplayMember = "0";
            this.cbxValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxValue.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxValue.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbxValue.FormattingEnabled = true;
            this.cbxValue.Location = new System.Drawing.Point(0, 0);
            this.cbxValue.Name = "cbxValue";
            this.cbxValue.Size = new System.Drawing.Size(331, 21);
            this.cbxValue.TabIndex = 11;
            this.cbxValue.ValueMember = "0";
            // 
            // ExEnum
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.pnlCaption);
            this.DoubleBuffered = true;
            this.Name = "ExEnum";
            this.Size = new System.Drawing.Size(398, 22);
            this.pnlCaption.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCaption;
        private System.Windows.Forms.Label lblFieldName;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.ComboBox cbxValue;
    }
}
