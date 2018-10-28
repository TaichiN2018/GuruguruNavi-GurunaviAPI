namespace CommonControlLibrary
{
    partial class DispRestaurantDataPanel
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.NameLabel = new System.Windows.Forms.Label();
            this.PRLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.ImagePictureBox = new System.Windows.Forms.PictureBox();
            this.TELLabel = new System.Windows.Forms.Label();
            this.QRCodePictureBox = new System.Windows.Forms.PictureBox();
            this.URLLinkLabel = new System.Windows.Forms.LinkLabel();
            this.updateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QRCodePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(217, 12);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(348, 17);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "店名：";
            // 
            // PRLabel
            // 
            this.PRLabel.Location = new System.Drawing.Point(217, 108);
            this.PRLabel.Name = "PRLabel";
            this.PRLabel.Size = new System.Drawing.Size(348, 42);
            this.PRLabel.TabIndex = 1;
            this.PRLabel.Text = "PRコメント";
            // 
            // AddressLabel
            // 
            this.AddressLabel.Location = new System.Drawing.Point(217, 29);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(348, 41);
            this.AddressLabel.TabIndex = 2;
            this.AddressLabel.Text = "住所：";
            // 
            // ImagePictureBox
            // 
            this.ImagePictureBox.Location = new System.Drawing.Point(13, 12);
            this.ImagePictureBox.Name = "ImagePictureBox";
            this.ImagePictureBox.Size = new System.Drawing.Size(185, 163);
            this.ImagePictureBox.TabIndex = 4;
            this.ImagePictureBox.TabStop = false;
            // 
            // TELLabel
            // 
            this.TELLabel.Location = new System.Drawing.Point(217, 70);
            this.TELLabel.Name = "TELLabel";
            this.TELLabel.Size = new System.Drawing.Size(348, 17);
            this.TELLabel.TabIndex = 5;
            this.TELLabel.Text = "TEL ：";
            // 
            // QRCodePictureBox
            // 
            this.QRCodePictureBox.Location = new System.Drawing.Point(576, 12);
            this.QRCodePictureBox.Name = "QRCodePictureBox";
            this.QRCodePictureBox.Size = new System.Drawing.Size(185, 163);
            this.QRCodePictureBox.TabIndex = 7;
            this.QRCodePictureBox.TabStop = false;
            // 
            // URLLinkLabel
            // 
            this.URLLinkLabel.Location = new System.Drawing.Point(217, 87);
            this.URLLinkLabel.Name = "URLLinkLabel";
            this.URLLinkLabel.Size = new System.Drawing.Size(348, 21);
            this.URLLinkLabel.TabIndex = 8;
            this.URLLinkLabel.TabStop = true;
            this.URLLinkLabel.Text = "URL:";
            this.URLLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.URLLinkLabel_LinkClicked);
            // 
            // updateLabel
            // 
            this.updateLabel.Location = new System.Drawing.Point(217, 155);
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(348, 17);
            this.updateLabel.TabIndex = 9;
            this.updateLabel.Text = "更新日時：";
            // 
            // DispRestaurantDataPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.updateLabel);
            this.Controls.Add(this.URLLinkLabel);
            this.Controls.Add(this.QRCodePictureBox);
            this.Controls.Add(this.TELLabel);
            this.Controls.Add(this.ImagePictureBox);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.PRLabel);
            this.Controls.Add(this.NameLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "DispRestaurantDataPanel";
            this.Size = new System.Drawing.Size(772, 188);
            this.Load += new System.EventHandler(this.DispRestaurantDataPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QRCodePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PRLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.PictureBox ImagePictureBox;
        private System.Windows.Forms.Label TELLabel;
        private System.Windows.Forms.PictureBox QRCodePictureBox;
        private System.Windows.Forms.LinkLabel URLLinkLabel;
        private System.Windows.Forms.Label updateLabel;
    }
}
