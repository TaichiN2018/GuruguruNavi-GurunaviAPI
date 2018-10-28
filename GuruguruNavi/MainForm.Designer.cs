namespace GNaviMain
{
    partial class MainForm
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.reloadButton = new System.Windows.Forms.Button();
            this.RegionListBox = new System.Windows.Forms.ListBox();
            this.PrefectureListBox = new System.Windows.Forms.ListBox();
            this.SmallAreaListBox = new System.Windows.Forms.ListBox();
            this.NextPageButton = new System.Windows.Forms.Button();
            this.PrevPageButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.onlyUpdateRadioButton = new System.Windows.Forms.RadioButton();
            this.onlyNewRadioButton = new System.Windows.Forms.RadioButton();
            this.allRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pageCountLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dispRestaurantDataPanel3 = new CommonControlLibrary.DispRestaurantDataPanel();
            this.dispRestaurantDataPanel2 = new CommonControlLibrary.DispRestaurantDataPanel();
            this.dispRestaurantDataPanel1 = new CommonControlLibrary.DispRestaurantDataPanel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // reloadButton
            // 
            this.reloadButton.Location = new System.Drawing.Point(61, 626);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(244, 50);
            this.reloadButton.TabIndex = 2;
            this.reloadButton.Text = "更新";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // RegionListBox
            // 
            this.RegionListBox.FormattingEnabled = true;
            this.RegionListBox.ItemHeight = 12;
            this.RegionListBox.Location = new System.Drawing.Point(61, 130);
            this.RegionListBox.Name = "RegionListBox";
            this.RegionListBox.Size = new System.Drawing.Size(244, 124);
            this.RegionListBox.TabIndex = 3;
            this.RegionListBox.SelectedIndexChanged += new System.EventHandler(this.RegionListBox_SelectedIndexChanged);
            // 
            // PrefectureListBox
            // 
            this.PrefectureListBox.FormattingEnabled = true;
            this.PrefectureListBox.ItemHeight = 12;
            this.PrefectureListBox.Location = new System.Drawing.Point(61, 277);
            this.PrefectureListBox.Name = "PrefectureListBox";
            this.PrefectureListBox.Size = new System.Drawing.Size(244, 124);
            this.PrefectureListBox.TabIndex = 4;
            this.PrefectureListBox.SelectedIndexChanged += new System.EventHandler(this.PrefectureListBox_SelectedIndexChanged);
            // 
            // SmallAreaListBox
            // 
            this.SmallAreaListBox.FormattingEnabled = true;
            this.SmallAreaListBox.ItemHeight = 12;
            this.SmallAreaListBox.Location = new System.Drawing.Point(61, 424);
            this.SmallAreaListBox.Name = "SmallAreaListBox";
            this.SmallAreaListBox.Size = new System.Drawing.Size(244, 160);
            this.SmallAreaListBox.TabIndex = 5;
            this.SmallAreaListBox.SelectedIndexChanged += new System.EventHandler(this.SmallAreaListBox_SelectedIndexChanged);
            // 
            // NextPageButton
            // 
            this.NextPageButton.Location = new System.Drawing.Point(979, 22);
            this.NextPageButton.Name = "NextPageButton";
            this.NextPageButton.Size = new System.Drawing.Size(75, 23);
            this.NextPageButton.TabIndex = 9;
            this.NextPageButton.Text = "次へ";
            this.NextPageButton.UseVisualStyleBackColor = true;
            this.NextPageButton.Click += new System.EventHandler(this.NextPageButton_Click);
            // 
            // PrevPageButton
            // 
            this.PrevPageButton.Location = new System.Drawing.Point(736, 22);
            this.PrevPageButton.Name = "PrevPageButton";
            this.PrevPageButton.Size = new System.Drawing.Size(75, 23);
            this.PrevPageButton.TabIndex = 10;
            this.PrevPageButton.Text = "前へ";
            this.PrevPageButton.UseVisualStyleBackColor = true;
            this.PrevPageButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.onlyUpdateRadioButton);
            this.groupBox1.Controls.Add(this.onlyNewRadioButton);
            this.groupBox1.Controls.Add(this.allRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(412, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 41);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "表示区分：";
            // 
            // onlyUpdateRadioButton
            // 
            this.onlyUpdateRadioButton.AutoSize = true;
            this.onlyUpdateRadioButton.Location = new System.Drawing.Point(137, 15);
            this.onlyUpdateRadioButton.Name = "onlyUpdateRadioButton";
            this.onlyUpdateRadioButton.Size = new System.Drawing.Size(83, 16);
            this.onlyUpdateRadioButton.TabIndex = 2;
            this.onlyUpdateRadioButton.Text = "新規店以外";
            this.onlyUpdateRadioButton.UseVisualStyleBackColor = true;
            this.onlyUpdateRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_EnabledChanged);
            // 
            // onlyNewRadioButton
            // 
            this.onlyNewRadioButton.AutoSize = true;
            this.onlyNewRadioButton.Location = new System.Drawing.Point(72, 15);
            this.onlyNewRadioButton.Name = "onlyNewRadioButton";
            this.onlyNewRadioButton.Size = new System.Drawing.Size(59, 16);
            this.onlyNewRadioButton.TabIndex = 1;
            this.onlyNewRadioButton.Text = "新規店";
            this.onlyNewRadioButton.UseVisualStyleBackColor = true;
            this.onlyNewRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_EnabledChanged);
            // 
            // allRadioButton
            // 
            this.allRadioButton.AutoSize = true;
            this.allRadioButton.Checked = true;
            this.allRadioButton.Location = new System.Drawing.Point(11, 15);
            this.allRadioButton.Name = "allRadioButton";
            this.allRadioButton.Size = new System.Drawing.Size(44, 16);
            this.allRadioButton.TabIndex = 0;
            this.allRadioButton.TabStop = true;
            this.allRadioButton.Text = "全て";
            this.allRadioButton.UseVisualStyleBackColor = true;
            this.allRadioButton.EnabledChanged += new System.EventHandler(this.RadioButton_EnabledChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "１．地方を選択してください";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "２．都道府県を選択してください";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "３．地域を選択してください";
            // 
            // pageCountLabel
            // 
            this.pageCountLabel.Location = new System.Drawing.Point(817, 27);
            this.pageCountLabel.Name = "pageCountLabel";
            this.pageCountLabel.Size = new System.Drawing.Size(156, 12);
            this.pageCountLabel.TabIndex = 15;
            this.pageCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(63, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 92);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "※１４日以内に更新のあったお店を表示します。";
            // 
            // dispRestaurantDataPanel3
            // 
            this.dispRestaurantDataPanel3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.dispRestaurantDataPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dispRestaurantDataPanel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dispRestaurantDataPanel3.Location = new System.Drawing.Point(372, 459);
            this.dispRestaurantDataPanel3.Name = "dispRestaurantDataPanel3";
            this.dispRestaurantDataPanel3.Size = new System.Drawing.Size(744, 190);
            this.dispRestaurantDataPanel3.TabIndex = 8;
            // 
            // dispRestaurantDataPanel2
            // 
            this.dispRestaurantDataPanel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.dispRestaurantDataPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dispRestaurantDataPanel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dispRestaurantDataPanel2.Location = new System.Drawing.Point(372, 267);
            this.dispRestaurantDataPanel2.Name = "dispRestaurantDataPanel2";
            this.dispRestaurantDataPanel2.Size = new System.Drawing.Size(744, 190);
            this.dispRestaurantDataPanel2.TabIndex = 7;
            // 
            // dispRestaurantDataPanel1
            // 
            this.dispRestaurantDataPanel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.dispRestaurantDataPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dispRestaurantDataPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dispRestaurantDataPanel1.Location = new System.Drawing.Point(372, 71);
            this.dispRestaurantDataPanel1.Name = "dispRestaurantDataPanel1";
            this.dispRestaurantDataPanel1.Size = new System.Drawing.Size(744, 190);
            this.dispRestaurantDataPanel1.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1149, 711);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pageCountLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PrevPageButton);
            this.Controls.Add(this.NextPageButton);
            this.Controls.Add(this.dispRestaurantDataPanel3);
            this.Controls.Add(this.dispRestaurantDataPanel2);
            this.Controls.Add(this.dispRestaurantDataPanel1);
            this.Controls.Add(this.SmallAreaListBox);
            this.Controls.Add(this.PrefectureListBox);
            this.Controls.Add(this.RegionListBox);
            this.Controls.Add(this.reloadButton);
            this.Name = "MainForm";
            this.Text = "ぐるぐるナビ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.ListBox RegionListBox;
        private System.Windows.Forms.ListBox PrefectureListBox;
        private System.Windows.Forms.ListBox SmallAreaListBox;
        private CommonControlLibrary.DispRestaurantDataPanel dispRestaurantDataPanel1;
        private CommonControlLibrary.DispRestaurantDataPanel dispRestaurantDataPanel2;
        private CommonControlLibrary.DispRestaurantDataPanel dispRestaurantDataPanel3;
        private System.Windows.Forms.Button NextPageButton;
        private System.Windows.Forms.Button PrevPageButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton onlyUpdateRadioButton;
        private System.Windows.Forms.RadioButton onlyNewRadioButton;
        private System.Windows.Forms.RadioButton allRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label pageCountLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

