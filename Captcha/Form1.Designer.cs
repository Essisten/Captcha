
namespace Captcha
{
    partial class CaptchaWindow
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.RefreshButton = new System.Windows.Forms.Button();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.CaptchaBackground = new System.Windows.Forms.PictureBox();
            this.CaptchaChecker = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CaptchaBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // RefreshButton
            // 
            this.RefreshButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshButton.Location = new System.Drawing.Point(12, 148);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(78, 27);
            this.RefreshButton.TabIndex = 0;
            this.RefreshButton.Text = "Обновить";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // ContinueButton
            // 
            this.ContinueButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContinueButton.Location = new System.Drawing.Point(144, 148);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(78, 27);
            this.ContinueButton.TabIndex = 1;
            this.ContinueButton.Text = "Далее";
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // CaptchaBackground
            // 
            this.CaptchaBackground.Location = new System.Drawing.Point(12, 12);
            this.CaptchaBackground.Name = "CaptchaBackground";
            this.CaptchaBackground.Size = new System.Drawing.Size(210, 104);
            this.CaptchaBackground.TabIndex = 2;
            this.CaptchaBackground.TabStop = false;
            // 
            // CaptchaChecker
            // 
            this.CaptchaChecker.Location = new System.Drawing.Point(12, 122);
            this.CaptchaChecker.Name = "CaptchaChecker";
            this.CaptchaChecker.Size = new System.Drawing.Size(210, 20);
            this.CaptchaChecker.TabIndex = 4;
            // 
            // CaptchaWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(234, 180);
            this.Controls.Add(this.CaptchaChecker);
            this.Controls.Add(this.ContinueButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.CaptchaBackground);
            this.Name = "CaptchaWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Captcha";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.CaptchaBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button ContinueButton;
        private System.Windows.Forms.PictureBox CaptchaBackground;
        private System.Windows.Forms.TextBox CaptchaChecker;
    }
}

