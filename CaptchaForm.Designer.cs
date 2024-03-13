namespace StroyModern
{
    partial class CaptchaForm
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
            this.captchaText = new System.Windows.Forms.TextBox();
            this.captchaBtn = new System.Windows.Forms.Button();
            this.captchaBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.captchaBox)).BeginInit();
            this.SuspendLayout();
            // 
            // captchaText
            // 
            this.captchaText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.captchaText.Location = new System.Drawing.Point(86, 102);
            this.captchaText.Margin = new System.Windows.Forms.Padding(2);
            this.captchaText.MaxLength = 10;
            this.captchaText.Multiline = true;
            this.captchaText.Name = "captchaText";
            this.captchaText.Size = new System.Drawing.Size(156, 32);
            this.captchaText.TabIndex = 16;
            // 
            // captchaBtn
            // 
            this.captchaBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.captchaBtn.Location = new System.Drawing.Point(116, 159);
            this.captchaBtn.Margin = new System.Windows.Forms.Padding(2);
            this.captchaBtn.Name = "captchaBtn";
            this.captchaBtn.Size = new System.Drawing.Size(98, 37);
            this.captchaBtn.TabIndex = 18;
            this.captchaBtn.Text = "Проверить";
            this.captchaBtn.UseVisualStyleBackColor = true;
            this.captchaBtn.Click += new System.EventHandler(this.captchaBtn_Click);
            // 
            // captchaBox
            // 
            this.captchaBox.Location = new System.Drawing.Point(86, 37);
            this.captchaBox.Margin = new System.Windows.Forms.Padding(2);
            this.captchaBox.Name = "captchaBox";
            this.captchaBox.Size = new System.Drawing.Size(156, 41);
            this.captchaBox.TabIndex = 19;
            this.captchaBox.TabStop = false;
            // 
            // CaptchaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.captchaBox);
            this.Controls.Add(this.captchaBtn);
            this.Controls.Add(this.captchaText);
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "CaptchaForm";
            this.Text = "CaptchaForm";
            this.Load += new System.EventHandler(this.CaptchaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.captchaBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox captchaText;
        private System.Windows.Forms.Button captchaBtn;
        private System.Windows.Forms.PictureBox captchaBox;
    }
}