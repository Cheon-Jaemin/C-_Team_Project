namespace C_TeamProject
{
    partial class loginForm
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
            label1 = new Label();
            lblLoing = new Label();
            lblPassword = new Label();
            btnLoing = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "로그인 화면";
            
            // 
            // lblLoing
            // 
            lblLoing.AutoSize = true;
            lblLoing.Location = new Point(33, 44);
            lblLoing.Name = "lblLoing";
            lblLoing.Size = new Size(50, 15);
            lblLoing.TabIndex = 1;
            lblLoing.Text = "로그인 :";
            
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(21, 68);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(62, 15);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "비밀번호 :";
            
            // 
            // btnLoing
            // 
            btnLoing.Location = new Point(12, 108);
            btnLoing.Name = "btnLoing";
            btnLoing.Size = new Size(75, 23);
            btnLoing.TabIndex = 4;
            btnLoing.Text = "로그인";
            btnLoing.UseVisualStyleBackColor = true;
            btnLoing.Click += btnLoing_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(89, 60);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 5;
            
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(89, 36);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(100, 23);
            txtUsername.TabIndex = 5;
            
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(215, 164);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(btnLoing);
            Controls.Add(lblPassword);
            Controls.Add(lblLoing);
            Controls.Add(label1);
            Name = "loginForm";
            Text = "loginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label lblLoing;
        private Label lblPassword;
        private Button btnLoing;
        private TextBox txtPassword;
        private TextBox txtUsername;
    }
}