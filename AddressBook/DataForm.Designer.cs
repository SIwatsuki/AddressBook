namespace AddressBook
{
    partial class DataForm
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelFName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.Button = new System.Windows.Forms.Button();
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.prefComboBox = new System.Windows.Forms.ComboBox();
            this.telNoTextBox = new System.Windows.Forms.TextBox();
            this.eMailTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.buildingTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.pNameTextBox = new System.Windows.Forms.TextBox();
            this.fNameKanaTextBox = new System.Windows.Forms.TextBox();
            this.pNameKanaTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Location = new System.Drawing.Point(31, 34);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(17, 12);
            this.labelFName.TabIndex = 0;
            this.labelFName.Text = "姓";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "ふりがな（姓）";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "ふりがな（名）";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "℡";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "メール";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "〒";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "都道府県";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "番地";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(264, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 15;
            this.label10.Text = "市区町村";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(264, 322);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 19;
            this.label11.Text = "建物";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(384, 396);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 23;
            this.closeButton.Text = "閉じる";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(303, 396);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(75, 23);
            this.Button.TabIndex = 22;
            this.Button.Text = "更新";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.Location = new System.Drawing.Point(33, 49);
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(191, 19);
            this.fNameTextBox.TabIndex = 2;
            // 
            // prefComboBox
            // 
            this.prefComboBox.FormattingEnabled = true;
            this.prefComboBox.Location = new System.Drawing.Point(35, 295);
            this.prefComboBox.Name = "prefComboBox";
            this.prefComboBox.Size = new System.Drawing.Size(191, 20);
            this.prefComboBox.TabIndex = 16;
            // 
            // telNoTextBox
            // 
            this.telNoTextBox.Location = new System.Drawing.Point(35, 171);
            this.telNoTextBox.Name = "telNoTextBox";
            this.telNoTextBox.Size = new System.Drawing.Size(191, 19);
            this.telNoTextBox.TabIndex = 10;
            // 
            // eMailTextBox
            // 
            this.eMailTextBox.Location = new System.Drawing.Point(268, 171);
            this.eMailTextBox.Name = "eMailTextBox";
            this.eMailTextBox.Size = new System.Drawing.Size(191, 19);
            this.eMailTextBox.TabIndex = 11;
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.Location = new System.Drawing.Point(35, 212);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(191, 19);
            this.zipCodeTextBox.TabIndex = 13;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(35, 337);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(191, 19);
            this.addressTextBox.TabIndex = 20;
            // 
            // buildingTextBox
            // 
            this.buildingTextBox.Location = new System.Drawing.Point(268, 337);
            this.buildingTextBox.Name = "buildingTextBox";
            this.buildingTextBox.Size = new System.Drawing.Size(191, 19);
            this.buildingTextBox.TabIndex = 21;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(266, 295);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(193, 19);
            this.cityTextBox.TabIndex = 17;
            // 
            // pNameTextBox
            // 
            this.pNameTextBox.Location = new System.Drawing.Point(264, 49);
            this.pNameTextBox.Name = "pNameTextBox";
            this.pNameTextBox.Size = new System.Drawing.Size(193, 19);
            this.pNameTextBox.TabIndex = 3;
            // 
            // fNameKanaTextBox
            // 
            this.fNameKanaTextBox.Location = new System.Drawing.Point(33, 95);
            this.fNameKanaTextBox.Name = "fNameKanaTextBox";
            this.fNameKanaTextBox.Size = new System.Drawing.Size(191, 19);
            this.fNameKanaTextBox.TabIndex = 6;
            // 
            // pNameKanaTextBox
            // 
            this.pNameKanaTextBox.Location = new System.Drawing.Point(266, 95);
            this.pNameKanaTextBox.Name = "pNameKanaTextBox";
            this.pNameKanaTextBox.Size = new System.Drawing.Size(191, 19);
            this.pNameKanaTextBox.TabIndex = 7;
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(494, 448);
            this.Controls.Add(this.pNameKanaTextBox);
            this.Controls.Add(this.fNameKanaTextBox);
            this.Controls.Add(this.pNameTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.buildingTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.zipCodeTextBox);
            this.Controls.Add(this.eMailTextBox);
            this.Controls.Add(this.telNoTextBox);
            this.Controls.Add(this.prefComboBox);
            this.Controls.Add(this.fNameTextBox);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelFName);
            this.Name = "DataForm";
            this.Text = "DataForm";
            this.Load += new System.EventHandler(this.DataForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.TextBox fNameTextBox;
        private System.Windows.Forms.ComboBox prefComboBox;
        private System.Windows.Forms.TextBox telNoTextBox;
        private System.Windows.Forms.TextBox eMailTextBox;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox buildingTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox pNameTextBox;
        private System.Windows.Forms.TextBox fNameKanaTextBox;
        private System.Windows.Forms.TextBox pNameKanaTextBox;
    }
}