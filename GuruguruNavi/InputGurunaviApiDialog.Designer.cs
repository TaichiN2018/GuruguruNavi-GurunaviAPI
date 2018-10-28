namespace GNaviMain
{
    partial class InputGurunaviApiDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartBtn = new System.Windows.Forms.Button();
            this.InputGurunaviAPIKeyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.getLeatestDataRadioButton = new System.Windows.Forms.RadioButton();
            this.startByLocalDataRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.StartBtn.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StartBtn.Location = new System.Drawing.Point(209, 155);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(206, 57);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "起動";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // InputGurunaviAPIKeyTextBox
            // 
            this.InputGurunaviAPIKeyTextBox.Enabled = false;
            this.InputGurunaviAPIKeyTextBox.Location = new System.Drawing.Point(199, 64);
            this.InputGurunaviAPIKeyTextBox.Name = "InputGurunaviAPIKeyTextBox";
            this.InputGurunaviAPIKeyTextBox.Size = new System.Drawing.Size(389, 19);
            this.InputGurunaviAPIKeyTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "ぐるなびAPI用KEY :";
            // 
            // getLeatestDataRadioButton
            // 
            this.getLeatestDataRadioButton.AutoSize = true;
            this.getLeatestDataRadioButton.Location = new System.Drawing.Point(60, 42);
            this.getLeatestDataRadioButton.Name = "getLeatestDataRadioButton";
            this.getLeatestDataRadioButton.Size = new System.Drawing.Size(187, 16);
            this.getLeatestDataRadioButton.TabIndex = 6;
            this.getLeatestDataRadioButton.Text = "最新のデータを取得して起動する。";
            this.getLeatestDataRadioButton.UseVisualStyleBackColor = true;
            this.getLeatestDataRadioButton.CheckedChanged += new System.EventHandler(this.getLeatestDataRadioButton_CheckedChanged);
            // 
            // startByLocalDataRadioButton
            // 
            this.startByLocalDataRadioButton.AutoSize = true;
            this.startByLocalDataRadioButton.Checked = true;
            this.startByLocalDataRadioButton.Location = new System.Drawing.Point(60, 112);
            this.startByLocalDataRadioButton.Name = "startByLocalDataRadioButton";
            this.startByLocalDataRadioButton.Size = new System.Drawing.Size(210, 16);
            this.startByLocalDataRadioButton.TabIndex = 7;
            this.startByLocalDataRadioButton.TabStop = true;
            this.startByLocalDataRadioButton.Text = "取得済みのデータを使用して起動する。";
            this.startByLocalDataRadioButton.UseVisualStyleBackColor = true;
            this.startByLocalDataRadioButton.CheckedChanged += new System.EventHandler(this.startByLocalDataRadioButton_CheckedChanged);
            // 
            // InputGurunaviApiDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 247);
            this.Controls.Add(this.startByLocalDataRadioButton);
            this.Controls.Add(this.getLeatestDataRadioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputGurunaviAPIKeyTextBox);
            this.Controls.Add(this.StartBtn);
            this.Name = "InputGurunaviApiDialog";
            this.Text = "事前入力";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.TextBox InputGurunaviAPIKeyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton getLeatestDataRadioButton;
        private System.Windows.Forms.RadioButton startByLocalDataRadioButton;
    }
}