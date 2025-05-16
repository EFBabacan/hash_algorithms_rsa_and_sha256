namespace hash_algorithms_rsa_and_sha256
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonShowSha256Form = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lütfen yapmak istediğiniz işlemi seçin:";
            // 
            // buttonShowSha256Form
            // 
            this.buttonShowSha256Form.Location = new System.Drawing.Point(204, 12);
            this.buttonShowSha256Form.Name = "buttonShowSha256Form";
            this.buttonShowSha256Form.Size = new System.Drawing.Size(75, 23);
            this.buttonShowSha256Form.TabIndex = 1;
            this.buttonShowSha256Form.Text = "SHA256 Hash Hesaplama";
            this.buttonShowSha256Form.UseVisualStyleBackColor = true;
            this.buttonShowSha256Form.Click += new System.EventHandler(this.buttonShowSha256Form_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(286, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "RSA Şifreleme/Şifre Çözme";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonShowSha256Form);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonShowSha256Form;
        private System.Windows.Forms.Button button2;
    }
}

