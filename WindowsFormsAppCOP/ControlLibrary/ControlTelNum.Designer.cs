namespace ControlLibrary
{
    partial class ControlTelNum
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
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(77, 88);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(201, 26);
            this.textBoxNum.TabIndex = 0;
            this.textBoxNum.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // ControlTelNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxNum);
            this.Name = "ControlTelNum";
            this.Size = new System.Drawing.Size(346, 247);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNum;
    }
}
