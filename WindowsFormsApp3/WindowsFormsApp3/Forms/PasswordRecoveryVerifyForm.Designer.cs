namespace WindowsFormsApp3.Forms
{
    partial class PasswordRecoveryVerifyForm
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
            this.textBoxOldLogin = new System.Windows.Forms.TextBox();
            this.labelInfoForRecovery = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.labelOldLogin = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxOldLogin
            // 
            this.textBoxOldLogin.Location = new System.Drawing.Point(66, 18);
            this.textBoxOldLogin.Multiline = true;
            this.textBoxOldLogin.Name = "textBoxOldLogin";
            this.textBoxOldLogin.Size = new System.Drawing.Size(188, 30);
            this.textBoxOldLogin.TabIndex = 0;
            // 
            // labelInfoForRecovery
            // 
            this.labelInfoForRecovery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelInfoForRecovery.Location = new System.Drawing.Point(9, 126);
            this.labelInfoForRecovery.Name = "labelInfoForRecovery";
            this.labelInfoForRecovery.Size = new System.Drawing.Size(245, 80);
            this.labelInfoForRecovery.TabIndex = 1;
            this.labelInfoForRecovery.Text = "Для восстановления пароля необходимо ввести логин, почту, которые были использова" +
    "ны при регистрации";
            this.labelInfoForRecovery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelInfoForRecovery.Click += new System.EventHandler(this.labelInfoForRecovery_Click);
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(66, 54);
            this.textBoxMail.Multiline = true;
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(188, 30);
            this.textBoxMail.TabIndex = 2;
            // 
            // labelOldLogin
            // 
            this.labelOldLogin.AutoSize = true;
            this.labelOldLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelOldLogin.Location = new System.Drawing.Point(5, 21);
            this.labelOldLogin.Name = "labelOldLogin";
            this.labelOldLogin.Size = new System.Drawing.Size(55, 20);
            this.labelOldLogin.TabIndex = 3;
            this.labelOldLogin.Text = "Логин";
            this.labelOldLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelOldLogin.Click += new System.EventHandler(this.labelOldLogin_Click);
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelMail.Location = new System.Drawing.Point(3, 54);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(57, 20);
            this.labelMail.TabIndex = 4;
            this.labelMail.Text = "Почта";
            this.labelMail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(9, 90);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(245, 33);
            this.buttonEnter.TabIndex = 5;
            this.buttonEnter.Text = "Далее";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // PasswordRecoveryVerifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 219);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.labelOldLogin);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.labelInfoForRecovery);
            this.Controls.Add(this.textBoxOldLogin);
            this.Name = "PasswordRecoveryVerifyForm";
            this.Text = "PasswordRecoveryVerifyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOldLogin;
        private System.Windows.Forms.Label labelInfoForRecovery;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label labelOldLogin;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Button buttonEnter;
    }
}