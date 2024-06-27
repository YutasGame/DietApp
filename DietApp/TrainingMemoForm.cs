using System;
using System.Windows.Forms;

namespace DietApp
{
    public partial class TrainingMemoForm : Form
    {
        private User loggedInUser;

        public TrainingMemoForm(User user)
        {
            InitializeComponent();
            this.loggedInUser = user;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // データを保存するためのコードをここに追加します。
            // 例えば、データをデータベースに保存するなどの処理を行います。

            MessageBox.Show("データが保存されました。");
        }

        private void btnShowTrainingMemo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void btnShowCardio_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }
    }
}
