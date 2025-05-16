namespace hash_algorithms_rsa_and_sha256
{
    partial class Sha256Form
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
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelInputPrompt = new System.Windows.Forms.Label();
            this.radioTextInput = new System.Windows.Forms.RadioButton();
            this.radioFileInput = new System.Windows.Forms.RadioButton();
            this.labelSelectedFilePrompt = new System.Windows.Forms.Label();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.labelActualSelectedFilePath = new System.Windows.Forms.Label();
            this.buttonCalculateHash = new System.Windows.Forms.Button();
            this.labelResultPrompt = new System.Windows.Forms.Label();
            this.textBoxResultHash = new System.Windows.Forms.TextBox();
            this.openFileDialogForSha = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(15, 68);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput.Size = new System.Drawing.Size(759, 117);
            this.textBoxInput.TabIndex = 0;
            // 
            // labelInputPrompt
            // 
            this.labelInputPrompt.AutoSize = true;
            this.labelInputPrompt.Location = new System.Drawing.Point(12, 52);
            this.labelInputPrompt.Name = "labelInputPrompt";
            this.labelInputPrompt.Size = new System.Drawing.Size(59, 13);
            this.labelInputPrompt.TabIndex = 1;
            this.labelInputPrompt.Text = "Metin Giriş:";
            // 
            // radioTextInput
            // 
            this.radioTextInput.AutoSize = true;
            this.radioTextInput.Checked = true;
            this.radioTextInput.Location = new System.Drawing.Point(15, 13);
            this.radioTextInput.Name = "radioTextInput";
            this.radioTextInput.Size = new System.Drawing.Size(46, 17);
            this.radioTextInput.TabIndex = 2;
            this.radioTextInput.TabStop = true;
            this.radioTextInput.Text = "Text";
            this.radioTextInput.UseVisualStyleBackColor = true;
            this.radioTextInput.CheckedChanged += new System.EventHandler(this.radioTextInput_CheckedChanged);
            // 
            // radioFileInput
            // 
            this.radioFileInput.AutoSize = true;
            this.radioFileInput.Location = new System.Drawing.Point(68, 13);
            this.radioFileInput.Name = "radioFileInput";
            this.radioFileInput.Size = new System.Drawing.Size(41, 17);
            this.radioFileInput.TabIndex = 3;
            this.radioFileInput.Text = "File";
            this.radioFileInput.UseVisualStyleBackColor = true;
            this.radioFileInput.CheckedChanged += new System.EventHandler(this.radioFileInput_CheckedChanged);
            // 
            // labelSelectedFilePrompt
            // 
            this.labelSelectedFilePrompt.AutoSize = true;
            this.labelSelectedFilePrompt.Location = new System.Drawing.Point(12, 217);
            this.labelSelectedFilePrompt.Name = "labelSelectedFilePrompt";
            this.labelSelectedFilePrompt.Size = new System.Drawing.Size(78, 13);
            this.labelSelectedFilePrompt.TabIndex = 4;
            this.labelSelectedFilePrompt.Text = "Secilen Dosya:";
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Enabled = false;
            this.buttonSelectFile.Location = new System.Drawing.Point(12, 191);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectFile.TabIndex = 5;
            this.buttonSelectFile.Text = "Select File";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            // 
            // labelActualSelectedFilePath
            // 
            this.labelActualSelectedFilePath.AutoSize = true;
            this.labelActualSelectedFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelActualSelectedFilePath.Location = new System.Drawing.Point(96, 217);
            this.labelActualSelectedFilePath.Name = "labelActualSelectedFilePath";
            this.labelActualSelectedFilePath.Size = new System.Drawing.Size(25, 15);
            this.labelActualSelectedFilePath.TabIndex = 6;
            this.labelActualSelectedFilePath.Text = "null";
            // 
            // buttonCalculateHash
            // 
            this.buttonCalculateHash.Location = new System.Drawing.Point(12, 233);
            this.buttonCalculateHash.Name = "buttonCalculateHash";
            this.buttonCalculateHash.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculateHash.TabIndex = 7;
            this.buttonCalculateHash.Text = "SHA256 Calculate";
            this.buttonCalculateHash.UseVisualStyleBackColor = true;
            this.buttonCalculateHash.Click += new System.EventHandler(this.buttonCalculateHash_Click);
            // 
            // labelResultPrompt
            // 
            this.labelResultPrompt.AutoSize = true;
            this.labelResultPrompt.Location = new System.Drawing.Point(12, 259);
            this.labelResultPrompt.Name = "labelResultPrompt";
            this.labelResultPrompt.Size = new System.Drawing.Size(108, 13);
            this.labelResultPrompt.TabIndex = 8;
            this.labelResultPrompt.Text = "SHA256 Hash Value:";
            this.labelResultPrompt.Click += new System.EventHandler(this.labelResultPrompt_Click);
            // 
            // textBoxResultHash
            // 
            this.textBoxResultHash.Location = new System.Drawing.Point(12, 275);
            this.textBoxResultHash.Multiline = true;
            this.textBoxResultHash.Name = "textBoxResultHash";
            this.textBoxResultHash.ReadOnly = true;
            this.textBoxResultHash.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResultHash.Size = new System.Drawing.Size(762, 145);
            this.textBoxResultHash.TabIndex = 9;
            // 
            // openFileDialogForSha
            // 
            this.openFileDialogForSha.FileName = "openFileDialog1";
            // 
            // Sha256Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxResultHash);
            this.Controls.Add(this.labelResultPrompt);
            this.Controls.Add(this.buttonCalculateHash);
            this.Controls.Add(this.labelActualSelectedFilePath);
            this.Controls.Add(this.buttonSelectFile);
            this.Controls.Add(this.labelSelectedFilePrompt);
            this.Controls.Add(this.radioFileInput);
            this.Controls.Add(this.radioTextInput);
            this.Controls.Add(this.labelInputPrompt);
            this.Controls.Add(this.textBoxInput);
            this.Name = "Sha256Form";
            this.Text = "FormSHA256";
            this.Load += new System.EventHandler(this.Sha256Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelInputPrompt;
        private System.Windows.Forms.RadioButton radioTextInput;
        private System.Windows.Forms.RadioButton radioFileInput;
        private System.Windows.Forms.Label labelSelectedFilePrompt;
        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.Label labelActualSelectedFilePath;
        private System.Windows.Forms.Button buttonCalculateHash;
        private System.Windows.Forms.Label labelResultPrompt;
        private System.Windows.Forms.TextBox textBoxResultHash;
        private System.Windows.Forms.OpenFileDialog openFileDialogForSha;
    }
}