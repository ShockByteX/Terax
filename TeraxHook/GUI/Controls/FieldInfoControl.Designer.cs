namespace TeraxHook.GUI.Controls
{
    partial class FieldInfoControl
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
            this.lblFieldName = new System.Windows.Forms.Label();
            this.lblFieldValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFieldName
            // 
            this.lblFieldName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFieldName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFieldName.ForeColor = System.Drawing.Color.Silver;
            this.lblFieldName.Location = new System.Drawing.Point(0, 0);
            this.lblFieldName.Name = "lblFieldName";
            this.lblFieldName.Size = new System.Drawing.Size(123, 22);
            this.lblFieldName.TabIndex = 0;
            this.lblFieldName.Text = "Field name";
            this.lblFieldName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFieldValue
            // 
            this.lblFieldValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFieldValue.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFieldValue.ForeColor = System.Drawing.Color.Silver;
            this.lblFieldValue.Location = new System.Drawing.Point(123, 0);
            this.lblFieldValue.Name = "lblFieldValue";
            this.lblFieldValue.Size = new System.Drawing.Size(246, 22);
            this.lblFieldValue.TabIndex = 1;
            this.lblFieldValue.Text = "Field value";
            this.lblFieldValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FieldInfoControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.lblFieldValue);
            this.Controls.Add(this.lblFieldName);
            this.DoubleBuffered = true;
            this.Name = "FieldInfoControl";
            this.Size = new System.Drawing.Size(369, 22);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFieldName;
        private System.Windows.Forms.Label lblFieldValue;
    }
}
