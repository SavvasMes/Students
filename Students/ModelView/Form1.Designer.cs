namespace Students.ModelView
{
    partial class Form1
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
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.txtSurname2 = new System.Windows.Forms.TextBox();
            this.txtId2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtName2
            // 
            this.txtName2.Location = new System.Drawing.Point(152, 53);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(100, 20);
            this.txtName2.TabIndex = 0;
            // 
            // txtSurname2
            // 
            this.txtSurname2.Location = new System.Drawing.Point(302, 53);
            this.txtSurname2.Name = "txtSurname2";
            this.txtSurname2.Size = new System.Drawing.Size(100, 20);
            this.txtSurname2.TabIndex = 1;
            // 
            // txtId2
            // 
            this.txtId2.Location = new System.Drawing.Point(547, 53);
            this.txtId2.Name = "txtId2";
            this.txtId2.Size = new System.Drawing.Size(100, 20);
            this.txtId2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 577);
            this.Controls.Add(this.txtId2);
            this.Controls.Add(this.txtSurname2);
            this.Controls.Add(this.txtName2);
            this.Name = "Form1";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.TextBox txtSurname2;
        private System.Windows.Forms.TextBox txtId2;
    }
}