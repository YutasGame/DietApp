using System;
using System.Configuration;
using System.Windows.Forms;

namespace DietApp
{
    public partial class LoginForm : Form
    {
        private UserManager userManager;
        private bool isPasswordShown = false;

        public LoginForm(UserManager userManager)
        {
            InitializeComponent();
            this.userManager = userManager;

            // 自動ログイン設定を読み込む
            string savedEmail = ConfigurationManager.AppSettings["AutoLoginEmail"];
            if (!string.IsNullOrEmpty(savedEmail))
            {
                txtEmail.Text = savedEmail;
                chkAutoLogin.Checked = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text;
                string password = txtPassword.Text;

                // 自動ログイン設定を保存する
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                if (chkAutoLogin.Checked)
                {
                    if (config.AppSettings.Settings["AutoLoginEmail"] == null)
                    {
                        config.AppSettings.Settings.Add("AutoLoginEmail", email);
                    }
                    else
                    {
                        config.AppSettings.Settings["AutoLoginEmail"].Value = email;
                    }
                }
                else
                {
                    if (config.AppSettings.Settings["AutoLoginEmail"] == null)
                    {
                        config.AppSettings.Settings.Add("AutoLoginEmail", "");
                    }
                    else
                    {
                        config.AppSettings.Settings["AutoLoginEmail"].Value = "";
                    }
                }
                config.Save(ConfigurationSaveMode.Modified);

                User user = userManager.Login(email, password);
                MessageBox.Show("ログイン成功しました。", "ログイン成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // トレーニングメモフォームを表示し、ユーザー情報を渡す
                TrainingMemoForm trainingMemoForm = new TrainingMemoForm(user);
                trainingMemoForm.Show();

                // 現在のログインフォームを閉じる
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ログインエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm(userManager);
            registrationForm.ShowDialog();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }
    }
}
