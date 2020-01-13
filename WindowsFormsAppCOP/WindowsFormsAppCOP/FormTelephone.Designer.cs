namespace WindowsFormsAppCOP
{
    partial class FormTelephone
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
            this.controlTelNum1 = new ControlLibrary.ControlTelNum();
            this.SuspendLayout();
            // 
            // controlTelNum1
            // 
            this.controlTelNum1.Location = new System.Drawing.Point(132, 51);
            this.controlTelNum1.Name = "controlTelNum1";
            this.controlTelNum1.Size = new System.Drawing.Size(346, 247);
            this.controlTelNum1.TabIndex = 0;
            // 
            // FormTelephone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 413);
            this.Controls.Add(this.controlTelNum1);
            this.Name = "FormTelephone";
            this.Text = "FormTelephone";
            this.ResumeLayout(false);

        }

        #endregion

        private ControlLibrary.ControlTelNum controlTelNum1;
    }
}