namespace LiteraryTourism
{
    partial class AuthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this.login_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pass_lbl = new System.Windows.Forms.Label();
            this.login_lbl = new System.Windows.Forms.Label();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.log_in_btn = new System.Windows.Forms.Button();
            this.reg_lbl = new System.Windows.Forms.LinkLabel();
            this.go_main_lbl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // login_txt
            // 
            this.login_txt.Location = new System.Drawing.Point(353, 219);
            this.login_txt.Name = "login_txt";
            this.login_txt.Size = new System.Drawing.Size(100, 20);
            this.login_txt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 6;
            // 
            // pass_lbl
            // 
            this.pass_lbl.AutoSize = true;
            this.pass_lbl.Location = new System.Drawing.Point(356, 259);
            this.pass_lbl.Name = "pass_lbl";
            this.pass_lbl.Size = new System.Drawing.Size(45, 13);
            this.pass_lbl.TabIndex = 2;
            this.pass_lbl.Text = "Пароль";
            // 
            // login_lbl
            // 
            this.login_lbl.AutoSize = true;
            this.login_lbl.Location = new System.Drawing.Point(359, 184);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(38, 13);
            this.login_lbl.TabIndex = 3;
            this.login_lbl.Text = "Логин";
            // 
            // pass_txt
            // 
            this.pass_txt.Location = new System.Drawing.Point(353, 289);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.Size = new System.Drawing.Size(100, 20);
            this.pass_txt.TabIndex = 4;
            this.pass_txt.UseSystemPasswordChar = true;
            // 
            // log_in_btn
            // 
            this.log_in_btn.Location = new System.Drawing.Point(362, 328);
            this.log_in_btn.Name = "log_in_btn";
            this.log_in_btn.Size = new System.Drawing.Size(75, 23);
            this.log_in_btn.TabIndex = 5;
            this.log_in_btn.Text = "Войти";
            this.log_in_btn.UseVisualStyleBackColor = false;
            this.log_in_btn.Click += new System.EventHandler(this.LogIn_btn_Click);
            // 
            // reg_lbl
            // 
            this.reg_lbl.AutoSize = true;
            this.reg_lbl.Location = new System.Drawing.Point(438, 388);
            this.reg_lbl.Name = "reg_lbl";
            this.reg_lbl.Size = new System.Drawing.Size(193, 13);
            this.reg_lbl.TabIndex = 9;
            this.reg_lbl.TabStop = true;
            this.reg_lbl.Text = "Еще нет аккаунта? Создайте новый!";
            this.reg_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Reg_lbl_LinkClicked);
            // 
            // go_main_lbl
            // 
            this.go_main_lbl.AutoSize = true;
            this.go_main_lbl.Location = new System.Drawing.Point(209, 388);
            this.go_main_lbl.Name = "go_main_lbl";
            this.go_main_lbl.Size = new System.Drawing.Size(162, 13);
            this.go_main_lbl.TabIndex = 10;
            this.go_main_lbl.TabStop = true;
            this.go_main_lbl.Text = "Продолжить без авторизации!";
            this.go_main_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GoMain_lbl_LinkClicked);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LiteraryTourism.Properties.Resources.icon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.go_main_lbl);
            this.Controls.Add(this.reg_lbl);
            this.Controls.Add(this.log_in_btn);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.login_lbl);
            this.Controls.Add(this.pass_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_txt);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЛитераТУРа";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AuthForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pass_lbl;
        private System.Windows.Forms.Label login_lbl;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.Button log_in_btn;
        private System.Windows.Forms.LinkLabel reg_lbl;
        private System.Windows.Forms.LinkLabel go_main_lbl;
    }
}