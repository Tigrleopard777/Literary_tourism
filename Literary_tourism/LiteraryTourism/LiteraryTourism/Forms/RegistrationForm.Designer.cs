namespace LiteraryTourism
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.login_lbl = new System.Windows.Forms.Label();
            this.login_txt = new System.Windows.Forms.TextBox();
            this.pass_lbl = new System.Windows.Forms.Label();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.nick_lbl = new System.Windows.Forms.Label();
            this.nick_txt = new System.Windows.Forms.TextBox();
            this.reg_btn = new System.Windows.Forms.Button();
            this.confirm_pass_lbl = new System.Windows.Forms.Label();
            this.confirm_pass_txt = new System.Windows.Forms.TextBox();
            this.icon_picture = new System.Windows.Forms.PictureBox();
            this.auth_lbl = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.icon_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // login_lbl
            // 
            this.login_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.login_lbl.AutoSize = true;
            this.login_lbl.Location = new System.Drawing.Point(372, 46);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(38, 13);
            this.login_lbl.TabIndex = 0;
            this.login_lbl.Text = "Логин";
            // 
            // login_txt
            // 
            this.login_txt.Location = new System.Drawing.Point(342, 79);
            this.login_txt.Name = "login_txt";
            this.login_txt.Size = new System.Drawing.Size(100, 20);
            this.login_txt.TabIndex = 1;
            // 
            // pass_lbl
            // 
            this.pass_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pass_lbl.AutoSize = true;
            this.pass_lbl.Location = new System.Drawing.Point(369, 122);
            this.pass_lbl.Name = "pass_lbl";
            this.pass_lbl.Size = new System.Drawing.Size(45, 13);
            this.pass_lbl.TabIndex = 2;
            this.pass_lbl.Text = "Пароль";
            // 
            // pass_txt
            // 
            this.pass_txt.Location = new System.Drawing.Point(342, 151);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.Size = new System.Drawing.Size(100, 20);
            this.pass_txt.TabIndex = 3;
            this.pass_txt.UseSystemPasswordChar = true;
            // 
            // nick_lbl
            // 
            this.nick_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nick_lbl.AutoSize = true;
            this.nick_lbl.Location = new System.Drawing.Point(376, 264);
            this.nick_lbl.Name = "nick_lbl";
            this.nick_lbl.Size = new System.Drawing.Size(27, 13);
            this.nick_lbl.TabIndex = 4;
            this.nick_lbl.Text = "Ник";
            // 
            // nick_txt
            // 
            this.nick_txt.Location = new System.Drawing.Point(341, 289);
            this.nick_txt.Name = "nick_txt";
            this.nick_txt.Size = new System.Drawing.Size(100, 20);
            this.nick_txt.TabIndex = 5;
            // 
            // reg_btn
            // 
            this.reg_btn.Location = new System.Drawing.Point(329, 338);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(127, 23);
            this.reg_btn.TabIndex = 6;
            this.reg_btn.Text = "Зарегистрироваться";
            this.reg_btn.UseVisualStyleBackColor = true;
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            // 
            // confirm_pass_lbl
            // 
            this.confirm_pass_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirm_pass_lbl.AutoSize = true;
            this.confirm_pass_lbl.Location = new System.Drawing.Point(337, 194);
            this.confirm_pass_lbl.Name = "confirm_pass_lbl";
            this.confirm_pass_lbl.Size = new System.Drawing.Size(112, 13);
            this.confirm_pass_lbl.TabIndex = 2;
            this.confirm_pass_lbl.Text = "Подтвердите пароль";
            // 
            // confirm_pass_txt
            // 
            this.confirm_pass_txt.Location = new System.Drawing.Point(341, 222);
            this.confirm_pass_txt.Name = "confirm_pass_txt";
            this.confirm_pass_txt.Size = new System.Drawing.Size(100, 20);
            this.confirm_pass_txt.TabIndex = 3;
            this.confirm_pass_txt.UseSystemPasswordChar = true;
            // 
            // icon_picture
            // 
            this.icon_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.icon_picture.Enabled = false;
            this.icon_picture.Image = global::LiteraryTourism.Properties.Resources.icon;
            this.icon_picture.Location = new System.Drawing.Point(660, 12);
            this.icon_picture.Name = "icon_picture";
            this.icon_picture.Size = new System.Drawing.Size(112, 57);
            this.icon_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_picture.TabIndex = 15;
            this.icon_picture.TabStop = false;
            // 
            // auth_lbl
            // 
            this.auth_lbl.AutoSize = true;
            this.auth_lbl.Location = new System.Drawing.Point(291, 379);
            this.auth_lbl.Name = "auth_lbl";
            this.auth_lbl.Size = new System.Drawing.Size(210, 13);
            this.auth_lbl.TabIndex = 16;
            this.auth_lbl.TabStop = true;
            this.auth_lbl.Text = "Уже есть аккаунта? Авторизируйстесь!";
            this.auth_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.auth_lbl_LinkClicked);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.auth_lbl);
            this.Controls.Add(this.icon_picture);
            this.Controls.Add(this.reg_btn);
            this.Controls.Add(this.nick_txt);
            this.Controls.Add(this.nick_lbl);
            this.Controls.Add(this.confirm_pass_txt);
            this.Controls.Add(this.confirm_pass_lbl);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.pass_lbl);
            this.Controls.Add(this.login_txt);
            this.Controls.Add(this.login_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЛитераТУРа";
            ((System.ComponentModel.ISupportInitialize)(this.icon_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login_lbl;
        private System.Windows.Forms.TextBox login_txt;
        private System.Windows.Forms.Label pass_lbl;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.Label nick_lbl;
        private System.Windows.Forms.TextBox nick_txt;
        private System.Windows.Forms.Button reg_btn;
        private System.Windows.Forms.Label confirm_pass_lbl;
        private System.Windows.Forms.TextBox confirm_pass_txt;
        private System.Windows.Forms.PictureBox icon_picture;
        private System.Windows.Forms.LinkLabel auth_lbl;
    }
}