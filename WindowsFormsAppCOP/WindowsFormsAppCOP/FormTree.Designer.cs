namespace WindowsFormsAppCOP
{
    partial class FormTree
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
            this.controlTreeView1 = new ControlLibrary.ControlTreeView();
            this.SuspendLayout();
            // 
            // controlTreeView1
            // 
            this.controlTreeView1.Location = new System.Drawing.Point(140, 14);
            this.controlTreeView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.controlTreeView1.Name = "controlTreeView1";
            this.controlTreeView1.Size = new System.Drawing.Size(378, 319);
            this.controlTreeView1.TabIndex = 0;
            // 
            // FormTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 377);
            this.Controls.Add(this.controlTreeView1);
            this.Name = "FormTree";
            this.Text = "FormTree";
            this.ResumeLayout(false);

        }

        #endregion

        private ControlLibrary.ControlTreeView controlTreeView1;
    }
}