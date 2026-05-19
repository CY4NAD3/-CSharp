namespace HospitalManagementSystem
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtUsername = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            btnLogin = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            btnEyeOpen = new System.Windows.Forms.Button();
            btnEyeClosed = new System.Windows.Forms.Button();
            lblTitle = new System.Windows.Forms.Label();
            lblUser = new System.Windows.Forms.Label();
            lblPass = new System.Windows.Forms.Label();
            panelTop = new System.Windows.Forms.Panel();
            panelTop.SuspendLayout();
            SuspendLayout();

            // panelTop
            panelTop.BackColor = System.Drawing.Color.FromArgb(0, 102, 204);
            panelTop.Controls.Add(lblTitle);
            panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            panelTop.Location = new System.Drawing.Point(0, 0);
            panelTop.Size = new System.Drawing.Size(420, 60);

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(100, 12);
            lblTitle.Text = "Hospital Management System";

            // lblUser
            lblUser.AutoSize = true;
            lblUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblUser.Location = new System.Drawing.Point(30, 90);
            lblUser.Text = "Username:";

            // txtUsername
            txtUsername.Location = new System.Drawing.Point(140, 87);
            txtUsername.Size = new System.Drawing.Size(220, 27);
            txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);

            // lblPass
            lblPass.AutoSize = true;
            lblPass.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblPass.Location = new System.Drawing.Point(30, 135);
            lblPass.Text = "Password:";

            // txtPassword
            txtPassword.Location = new System.Drawing.Point(140, 132);
            txtPassword.Size = new System.Drawing.Size(190, 27);
            txtPassword.PasswordChar = '*';
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);

            // btnEyeOpen
            btnEyeOpen.Location = new System.Drawing.Point(333, 132);
            btnEyeOpen.Size = new System.Drawing.Size(27, 27);
            btnEyeOpen.Text = "👁";
            btnEyeOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEyeOpen.Click += new System.EventHandler(this.btnEyeOpen_Click);

            // btnEyeClosed
            btnEyeClosed.Location = new System.Drawing.Point(333, 132);
            btnEyeClosed.Size = new System.Drawing.Size(27, 27);
            btnEyeClosed.Text = "🙈";
            btnEyeClosed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEyeClosed.Visible = false;
            btnEyeClosed.Click += new System.EventHandler(this.btnEyeClosed_Click);

            // btnLogin
            btnLogin.Location = new System.Drawing.Point(140, 185);
            btnLogin.Size = new System.Drawing.Size(100, 35);
            btnLogin.Text = "Login";
            btnLogin.BackColor = System.Drawing.Color.FromArgb(0, 102, 204);
            btnLogin.ForeColor = System.Drawing.Color.White;
            btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // btnClear
            btnClear.Location = new System.Drawing.Point(255, 185);
            btnClear.Size = new System.Drawing.Size(100, 35);
            btnClear.Text = "Clear";
            btnClear.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // LoginForm
            ClientSize = new System.Drawing.Size(420, 260);
            Controls.Add(panelTop);
            Controls.Add(lblUser);
            Controls.Add(txtUsername);
            Controls.Add(lblPass);
            Controls.Add(txtPassword);
            Controls.Add(btnEyeOpen);
            Controls.Add(btnEyeClosed);
            Controls.Add(btnLogin);
            Controls.Add(btnClear);
            Text = "Login - Hospital Management";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEyeOpen;
        private System.Windows.Forms.Button btnEyeClosed;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Panel panelTop;
    }
}
