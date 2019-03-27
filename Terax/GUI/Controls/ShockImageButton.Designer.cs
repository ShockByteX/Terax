namespace Terax.GUI.Controls
{
    partial class ShockImageButton
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
            this.tmrAnimation = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tmrAnimation
            // 
            this.tmrAnimation.Interval = 40;
            this.tmrAnimation.Tick += new System.EventHandler(this.tmrAnimation_Tick);
            // 
            // ShockImageButton
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.DoubleBuffered = true;
            this.Name = "ShockImageButton";
            this.Size = new System.Drawing.Size(32, 32);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrAnimation;
    }
}
