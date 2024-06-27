using System;
using System.Windows.Forms;

namespace DietApp
{
    public partial class RegistrationForm : Form
    {
        private UserManager userManager;

        public RegistrationForm(UserManager userManager)
        {
            InitializeComponent();
            this.userManager = userManager;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }

        private void chkShowPasswordConfirm_CheckedChanged(object sender, EventArgs e)
        {
            txtPasswordConfirm.PasswordChar = chkShowPasswordConfirm.Checked ? '\0' : '*';
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string passwordConfirm = txtPasswordConfirm.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            int age = int.Parse(txtAge.Text);
            string gender = cmbGender.SelectedItem.ToString();
            float height = float.Parse(txtHeight.Text);

            if (password != passwordConfirm)
            {
                MessageBox.Show("パスワードが一致しません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                userManager.Register(email, password, firstName, lastName, age, gender, height);
                MessageBox.Show("登録が完了しました。", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
