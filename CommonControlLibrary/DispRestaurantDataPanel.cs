using System;
using System.Windows.Forms;
using GNaviDataClass;

namespace CommonControlLibrary
{
    public partial class DispRestaurantDataPanel : UserControl
    {
        private ShowRestaurantItem _di;

        public DispRestaurantDataPanel()
        {
            InitializeComponent();
        }
        public DispRestaurantDataPanel(ShowRestaurantItem di)
        {
            this._di = di;
            InitializeComponent();
            SetStates();
        }

        private void SetStates()
        {
            if (_di == null)
            {
                Enabled = false;
                Visible = false;
            }
            else
            {
                Enabled = true;
                Visible = true;
                this.DispRestaurantDataPanel_Load(this, new EventArgs());
            }
        }

        public void Reload(ShowRestaurantItem di)
        {
            this._di = di;
            SetStates();
        }

        private void DispRestaurantDataPanel_Load(object sender, EventArgs e)
        {
            if (this._di == null)
            {
                return;
            }

            NameLabel.Text = _di.restInfo.name;
            PRLabel.Text = "ＰＲメッセージ：" + _di.restInfo.pr.pr_short;
            AddressLabel.Text = "住所：" + _di.restInfo.address;
            TELLabel.Text = "TEL ：" + _di.restInfo.tel;
            URLLinkLabel.Text = _di.restInfo.url;
            ImagePictureBox.ImageLocation = _di.restInfo.image_url.shop_image1;
            QRCodePictureBox.ImageLocation = _di.restInfo.image_url.qrcode;
            updateLabel.Text = "更新日時：" + _di.restInfo.update_date;
        }

        private void URLLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.URLLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start(_di.restInfo.url);
        }
    }
}
