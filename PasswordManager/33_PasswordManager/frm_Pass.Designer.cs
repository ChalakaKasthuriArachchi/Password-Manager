namespace _33_PasswordManager
{
    partial class frm_pass
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
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Password
            // 
            this.txt_Password.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip;
            this.txt_Password.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Password.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_Password.Location = new System.Drawing.Point(24, 64);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(511, 38);
            this.txt_Password.TabIndex = 0;
            this.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Password_KeyDown);
            // 
            // frm_pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 115);
            this.Controls.Add(this.txt_Password);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_pass";
            this.Resizable = false;
            this.Text = "Enter the Password to Unlock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Password;
    }
}

