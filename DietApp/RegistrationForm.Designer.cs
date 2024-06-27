namespace DietApp
{
    partial class RegistrationForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.txtPasswordConfirm = new System.Windows.Forms.TextBox();
            this.chkShowPasswordConfirm = new System.Windows.Forms.CheckBox();
            this.lblPasswordConfirm = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtGoalWeight = new System.Windows.Forms.TextBox();
            this.lblGoalWeight = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 15);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "メールアドレス:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(15, 31);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 60);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(52, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "パスワード:";
            // 
            // txtPassword
            // 
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(15, 76);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(250, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "英大文字、英小文字、数字を含んだ8文字";
            this.txtPassword.Font = new System.Drawing.Font(this.txtPassword.Font.FontFamily, 10);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Location = new System.Drawing.Point(15, 102);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(120, 17);
            this.chkShowPassword.TabIndex = 4;
            this.chkShowPassword.Text = "パスワードを表示する";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.ForeColor = System.Drawing.Color.Gray;
            this.txtPasswordConfirm.Location = new System.Drawing.Point(15, 145);
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.Size = new System.Drawing.Size(250, 20);
            this.txtPasswordConfirm.TabIndex = 5;
            this.txtPasswordConfirm.Text = "パスワードを再入力";
            this.txtPasswordConfirm.Enter += new System.EventHandler(this.txtPasswordConfirm_Enter);
            this.txtPasswordConfirm.Leave += new System.EventHandler(this.txtPasswordConfirm_Leave);
            // 
            // chkShowPasswordConfirm
            // 
            this.chkShowPasswordConfirm.AutoSize = true;
            this.chkShowPasswordConfirm.Location = new System.Drawing.Point(15, 171);
            this.chkShowPasswordConfirm.Name = "chkShowPasswordConfirm";
            this.chkShowPasswordConfirm.Size = new System.Drawing.Size(120, 17);
            this.chkShowPasswordConfirm.TabIndex = 6;
            this.chkShowPasswordConfirm.Text = "パスワードを表示する";
            this.chkShowPasswordConfirm.UseVisualStyleBackColor = true;
            this.chkShowPasswordConfirm.CheckedChanged += new System.EventHandler(this.chkShowPasswordConfirm_CheckedChanged);
            // 
            // lblPasswordConfirm
            // 
            this.lblPasswordConfirm.AutoSize = true;
            this.lblPasswordConfirm.Location = new System.Drawing.Point(12, 129);
            this.lblPasswordConfirm.Name = "lblPasswordConfirm";
            this.lblPasswordConfirm.Size = new System.Drawing.Size(80, 13);
            this.lblPasswordConfirm.TabIndex = 7;
            this.lblPasswordConfirm.Text = "パスワード再入力:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(121, 216);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(144, 20);
            this.txtLastName.TabIndex = 8;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(15, 216);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 9;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(118, 200);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(25, 13);
            this.lblLastName.TabIndex = 10;
            this.lblLastName.Text = "名:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 200);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(25, 13);
            this.lblFirstName.TabIndex = 11;
            this.lblFirstName.Text = "姓:";
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(15, 262);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(60, 21);
            this.cmbYear.TabIndex = 12;
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(81, 262);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(50, 21);
            this.cmbMonth.TabIndex = 13;
            // 
            // cmbDay
            // 
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Location = new System.Drawing.Point(137, 262);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(50, 21);
            this.cmbDay.TabIndex = 14;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(12, 246);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(55, 13);
            this.lblBirthDate.TabIndex = 15;
            this.lblBirthDate.Text = "生年月日:";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "男性",
            "女性"});
            this.cmbGender.Location = new System.Drawing.Point(15, 308);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(100, 21);
            this.cmbGender.TabIndex = 16;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(12, 292);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(31, 13);
            this.lblGender.TabIndex = 17;
            this.lblGender.Text = "性別:";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(15, 354);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(250, 20);
            this.txtHeight.TabIndex = 18;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(12, 338);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(31, 13);
            this.lblHeight.TabIndex = 19;
            this.lblHeight.Text = "身長:";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(15, 400);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(250, 20);
            this.txtWeight.TabIndex = 20;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(12, 384);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(31, 13);
            this.lblWeight.TabIndex = 21;
            this.lblWeight.Text = "体重:";
            // 
            // txtGoalWeight
            // 
            this.txtGoalWeight.Location = new System.Drawing.Point(15, 446);
            this.txtGoalWeight.Name = "txtGoalWeight";
            this.txtGoalWeight.Size = new System.Drawing.Size(250, 20);
            this.txtGoalWeight.TabIndex = 22;
            // 
            // lblGoalWeight
            // 
            this.lblGoalWeight.AutoSize = true;
            this.lblGoalWeight.Location = new System.Drawing.Point(12, 430);
            this.lblGoalWeight.Name = "lblGoalWeight";
            this.lblGoalWeight.Size = new System.Drawing.Size(55, 13);
            this.lblGoalWeight.TabIndex = 23;
            this.lblGoalWeight.Text = "目標体重:";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(15, 480);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(250, 23);
            this.btnRegister.TabIndex = 24;
            this.btnRegister.Text = "登録";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // RegistrationForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 520);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblGoalWeight);
            this.Controls.Add(this.txtGoalWeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.cmbDay);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblPasswordConfirm);
            this.Controls.Add(this.chkShowPasswordConfirm);
            this.Controls.Add(this.txtPasswordConfirm);
            this.Controls.Add(this.chkShowPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Name = "RegistrationForm";
            this.Text = "新規登録";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.TextBox txtPasswordConfirm;
        private System.Windows.Forms.CheckBox chkShowPasswordConfirm;
        private System.Windows.Forms.Label lblPasswordConfirm;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtGoalWeight;
        private System.Windows.Forms.Label lblGoalWeight;
        private System.Windows.Forms.Button btnRegister;
    }
}
