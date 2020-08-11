namespace telCom_2._1
{
    partial class LoginForm
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
            this.buttonWorkerEntrance = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonUserEntrance = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonWorkerEntrance
            // 
            this.buttonWorkerEntrance.Location = new System.Drawing.Point(6, 127);
            this.buttonWorkerEntrance.Name = "buttonWorkerEntrance";
            this.buttonWorkerEntrance.Size = new System.Drawing.Size(126, 25);
            this.buttonWorkerEntrance.TabIndex = 13;
            this.buttonWorkerEntrance.Text = "Войти как сотрудник";
            this.buttonWorkerEntrance.UseVisualStyleBackColor = true;
            this.buttonWorkerEntrance.Click += new System.EventHandler(this.buttonWorkerEntrance_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Пароль";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(15, 81);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(108, 20);
            this.password.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Логин";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(292, 127);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 25);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonUserEntrance
            // 
            this.buttonUserEntrance.Location = new System.Drawing.Point(138, 127);
            this.buttonUserEntrance.Name = "buttonUserEntrance";
            this.buttonUserEntrance.Size = new System.Drawing.Size(148, 25);
            this.buttonUserEntrance.TabIndex = 8;
            this.buttonUserEntrance.Text = "Войти как пользователь";
            this.buttonUserEntrance.UseVisualStyleBackColor = true;
            this.buttonUserEntrance.Click += new System.EventHandler(this.buttonWorkerEntrance_Click_1);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(15, 32);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(108, 20);
            this.login.TabIndex = 7;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 163);
            this.Controls.Add(this.buttonWorkerEntrance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonUserEntrance);
            this.Controls.Add(this.login);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonWorkerEntrance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonUserEntrance;
        private System.Windows.Forms.TextBox login;
    }
}