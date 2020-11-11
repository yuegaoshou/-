namespace VALIDATION
{
    partial class LANDING
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.TxbPassword = new System.Windows.Forms.TextBox();
            this.TxbPaccount = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnSignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(44, 172);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(29, 12);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "密码";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(44, 83);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(29, 12);
            this.lblAccount.TabIndex = 2;
            this.lblAccount.Text = "账号";
            // 
            // TxbPassword
            // 
            this.TxbPassword.Location = new System.Drawing.Point(154, 163);
            this.TxbPassword.Name = "TxbPassword";
            this.TxbPassword.PasswordChar = '*';
            this.TxbPassword.Size = new System.Drawing.Size(100, 21);
            this.TxbPassword.TabIndex = 3;
            this.TxbPassword.TextChanged += new System.EventHandler(this.TxbPassword_TextChanged);
            // 
            // TxbPaccount
            // 
            this.TxbPaccount.Location = new System.Drawing.Point(154, 83);
            this.TxbPaccount.Name = "TxbPaccount";
            this.TxbPaccount.Size = new System.Drawing.Size(100, 21);
            this.TxbPaccount.TabIndex = 4;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(61, 268);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnLogin.TabIndex = 5;
            this.BtnLogin.Text = "注册";
            this.BtnLogin.UseVisualStyleBackColor = true;
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.Location = new System.Drawing.Point(179, 268);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(75, 23);
            this.BtnSignUp.TabIndex = 6;
            this.BtnSignUp.Text = "登录";
            this.BtnSignUp.UseVisualStyleBackColor = true;
            // 
            // LANDING
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 352);
            this.Controls.Add(this.BtnSignUp);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxbPaccount);
            this.Controls.Add(this.TxbPassword);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.lblPassword);
            this.Name = "LANDING";
            this.Text = "账号登录";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.TextBox TxbPassword;
        private System.Windows.Forms.TextBox TxbPaccount;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnSignUp;
    }
}

