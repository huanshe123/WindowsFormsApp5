namespace WindowsFormsApp5
{
    partial class Form2
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
            this.Test2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Test2
            // 
            this.Test2.Location = new System.Drawing.Point(114, 91);
            this.Test2.Name = "Test2";
            this.Test2.Size = new System.Drawing.Size(75, 23);
            this.Test2.TabIndex = 0;
            this.Test2.Text = "测试";
            this.Test2.UseVisualStyleBackColor = true;
            this.Test2.Click += new System.EventHandler(this.Test2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Test2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Test2;
    }
}