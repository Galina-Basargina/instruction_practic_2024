namespace практика_2._1.Forms
{
    partial class EditPassword
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
            this.btSave = new System.Windows.Forms.Button();
            this.tb_new_password = new System.Windows.Forms.TextBox();
            this.tb_old_password = new System.Windows.Forms.TextBox();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_repeat_password = new System.Windows.Forms.TextBox();
            this.labelAdress = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPatronym = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.Navy;
            this.btSave.Font = new System.Drawing.Font("Miriam Libre", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ForeColor = System.Drawing.Color.White;
            this.btSave.Location = new System.Drawing.Point(344, 350);
            this.btSave.Margin = new System.Windows.Forms.Padding(4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(119, 28);
            this.btSave.TabIndex = 44;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // tb_new_password
            // 
            this.tb_new_password.Font = new System.Drawing.Font("Miriam Libre", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_new_password.ForeColor = System.Drawing.Color.Navy;
            this.tb_new_password.Location = new System.Drawing.Point(368, 180);
            this.tb_new_password.Margin = new System.Windows.Forms.Padding(4);
            this.tb_new_password.Name = "tb_new_password";
            this.tb_new_password.Size = new System.Drawing.Size(187, 27);
            this.tb_new_password.TabIndex = 43;
            // 
            // tb_old_password
            // 
            this.tb_old_password.Font = new System.Drawing.Font("Miriam Libre", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_old_password.ForeColor = System.Drawing.Color.Navy;
            this.tb_old_password.Location = new System.Drawing.Point(368, 146);
            this.tb_old_password.Margin = new System.Windows.Forms.Padding(4);
            this.tb_old_password.Name = "tb_old_password";
            this.tb_old_password.Size = new System.Drawing.Size(187, 27);
            this.tb_old_password.TabIndex = 42;
            // 
            // tb_login
            // 
            this.tb_login.Font = new System.Drawing.Font("Miriam Libre", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_login.ForeColor = System.Drawing.Color.Navy;
            this.tb_login.Location = new System.Drawing.Point(368, 114);
            this.tb_login.Margin = new System.Windows.Forms.Padding(4);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(187, 27);
            this.tb_login.TabIndex = 41;
            // 
            // tb_repeat_password
            // 
            this.tb_repeat_password.Font = new System.Drawing.Font("Miriam Libre", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_repeat_password.ForeColor = System.Drawing.Color.Navy;
            this.tb_repeat_password.Location = new System.Drawing.Point(368, 215);
            this.tb_repeat_password.Margin = new System.Windows.Forms.Padding(4);
            this.tb_repeat_password.Name = "tb_repeat_password";
            this.tb_repeat_password.Size = new System.Drawing.Size(187, 27);
            this.tb_repeat_password.TabIndex = 40;
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Font = new System.Drawing.Font("Miriam Libre", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdress.Location = new System.Drawing.Point(245, 184);
            this.labelAdress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(110, 20);
            this.labelAdress.TabIndex = 37;
            this.labelAdress.Text = "Новый пароль";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Miriam Libre", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(245, 149);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(116, 20);
            this.labelPhone.TabIndex = 36;
            this.labelPhone.Text = "Старый пароль";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Miriam Libre", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(245, 117);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(51, 20);
            this.labelLogin.TabIndex = 35;
            this.labelLogin.Text = "Логин";
            // 
            // labelPatronym
            // 
            this.labelPatronym.Font = new System.Drawing.Font("Miriam Libre", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatronym.Location = new System.Drawing.Point(126, 215);
            this.labelPatronym.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPatronym.Name = "labelPatronym";
            this.labelPatronym.Size = new System.Drawing.Size(229, 71);
            this.labelPatronym.TabIndex = 33;
            this.labelPatronym.Text = "Подтверждение нового пароля";
            // 
            // EditPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tb_new_password);
            this.Controls.Add(this.tb_old_password);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.tb_repeat_password);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelPatronym);
            this.Name = "EditPassword";
            this.Text = "EditPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox tb_new_password;
        private System.Windows.Forms.TextBox tb_old_password;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_repeat_password;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPatronym;
    }
}