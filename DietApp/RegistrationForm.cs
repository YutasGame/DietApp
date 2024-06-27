using System;
using System.Drawing;
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
            InitializeBirthDateComboBoxes();
        }

        private void InitializeBirthDateComboBoxes()
        {
            for (int year = 1900; year <= DateTime.Now.Year; year++)
            {
                cmbYear.Items.Add(year);
            }

            for (int month = 1; month <= 12; month++)
            {
                cmbMonth.Items.Add(month);
            }

            for (int day = 1; day <= 31; day++)
            {
                cmbDay.Items.Add(day);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text;
                string password = txtPassword.Text;
                string passwordConfirm = txtPasswordConfirm.Text;
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                int year = int.Parse(cmbYear.SelectedItem.ToString());
                int month = int.Parse(cmbMonth.SelectedItem.ToString());
                int day = int.Parse(cmbDay.SelectedItem.ToString());
                DateTime birthDate = new DateTime(year, month, day);
                string gender = cmbGender.SelectedItem.ToString();
                int height = int.Parse(txtHeight.Text);
                int weight = int.Parse(txtWeight.Text);
                int goalWeight = int.Parse(txtGoalWeight.Text);

                if (password != passwordConfirm)
                {
                    MessageBox.Show("パスワードが一致しません。");
                    return;
                }

                userManager.Register(email, password, firstName, lastName, birthDate, gender, height, weight, goalWeight);
                MessageBox.Show("登録が完了しました。");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("エラーが発生しました: " + ex.Message);
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }

        private void chkShowPasswordConfirm_CheckedChanged(object sender, EventArgs e)
        {
            txtPasswordConfirm.PasswordChar = chkShowPasswordConfirm.Checked ? '\0' : '*';
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.ForeColor == Color.Gray)
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.Text = "パスワードは英大文字、英小文字、数字を含んだ8文字です。";
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void txtPasswordConfirm_Enter(object sender, EventArgs e)
        {
            if (txtPasswordConfirm.ForeColor == Color.Gray)
            {
                txtPasswordConfirm.Text = "";
                txtPasswordConfirm.ForeColor = Color.Black;
                txtPasswordConfirm.PasswordChar = '*';
            }
        }

        private void txtPasswordConfirm_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPasswordConfirm.Text))
            {
                txtPasswordConfirm.PasswordChar = '\0';
                txtPasswordConfirm.Text = "パスワードを再入力";
                txtPasswordConfirm.ForeColor = Color.Gray;
            }
        }
    }
}
