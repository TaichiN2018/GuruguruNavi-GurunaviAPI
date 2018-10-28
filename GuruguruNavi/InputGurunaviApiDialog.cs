using System;
using System.Windows.Forms;
using GNaviManager;

namespace GNaviMain
{
    public partial class InputGurunaviApiDialog : Form
    {
        public bool StartByOnlyLocalData { get; set; }
        public bool GetAllPrefSearchRestaurantData { get; set; }
        public string gNAPIKey { get; set; }
        public InputGurunaviApiDialog()
        {
            InitializeComponent();
        }

        public DialogResult ExecuteModal()
        {
            return this.ShowDialog();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (this.startByLocalDataRadioButton.Checked)
            {
                this.StartByOnlyLocalData = true;
                this.gNAPIKey = this.InputGurunaviAPIKeyTextBox.Text;
            }
            else
            {
                if (string.IsNullOrEmpty(InputGurunaviAPIKeyTextBox.Text))
                {
                    MessageBox.Show("ぐるなびAPIのKeyを入力してください。code:01");
                    this.DialogResult = DialogResult.None;
                    return;
                }
                if (GuruguruNaviManager.IsAPIKeyValid(InputGurunaviAPIKeyTextBox.Text)){
                    MessageBox.Show("ぐるなびAPIのKeyを入力してください。code:02");
                    this.DialogResult = DialogResult.None;
                    return;
                }

                //ぐるなびAPIのKeyかどうかのチェック
                //masterをgetして、不正値エラーが発生するかどうかをチェック？

                this.StartByOnlyLocalData = false;
                this.gNAPIKey = this.InputGurunaviAPIKeyTextBox.Text;
            }
        }

        private void startByLocalDataRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            InputGurunaviAPIKeyTextBox.Enabled = false;
        }

        private void getLeatestDataRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            InputGurunaviAPIKeyTextBox.Enabled = true;
        }
    }
}
