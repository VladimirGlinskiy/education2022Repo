namespace VGlinskii.WinForms.Exam
{
    partial class KartinkerForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.PathLabel = new System.Windows.Forms.Label();
            this.chooseRatingBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.goBackButton = new System.Windows.Forms.Button();
            this.goRightButton = new System.Windows.Forms.Button();
            this.getRandomPictureButton = new System.Windows.Forms.Button();
            this.averageRate = new System.Windows.Forms.Label();
            this.pictureIndex = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PictureBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PictureBox.ImageLocation = "";
            this.PictureBox.Location = new System.Drawing.Point(12, 12);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Padding = new System.Windows.Forms.Padding(10);
            this.PictureBox.Size = new System.Drawing.Size(505, 537);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(423, 73);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(0, 13);
            this.PathLabel.TabIndex = 1;
            this.PathLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // chooseRatingBox
            // 
            this.chooseRatingBox.FormattingEnabled = true;
            this.chooseRatingBox.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1",
            "0"});
            this.chooseRatingBox.Location = new System.Drawing.Point(529, 268);
            this.chooseRatingBox.Name = "chooseRatingBox";
            this.chooseRatingBox.Size = new System.Drawing.Size(99, 21);
            this.chooseRatingBox.TabIndex = 2;
            this.chooseRatingBox.Text = "Rate the picture";
            this.chooseRatingBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Your rating";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Average rating of all users";
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(537, 458);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(75, 48);
            this.goBackButton.TabIndex = 6;
            this.goBackButton.Text = "<";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // goRightButton
            // 
            this.goRightButton.Location = new System.Drawing.Point(615, 458);
            this.goRightButton.Name = "goRightButton";
            this.goRightButton.Size = new System.Drawing.Size(75, 48);
            this.goRightButton.TabIndex = 7;
            this.goRightButton.Text = ">";
            this.goRightButton.UseVisualStyleBackColor = true;
            this.goRightButton.Click += new System.EventHandler(this.goRightButton_Click);
            // 
            // getRandomPictureButton
            // 
            this.getRandomPictureButton.Location = new System.Drawing.Point(537, 399);
            this.getRandomPictureButton.Name = "getRandomPictureButton";
            this.getRandomPictureButton.Size = new System.Drawing.Size(118, 40);
            this.getRandomPictureButton.TabIndex = 8;
            this.getRandomPictureButton.Text = "Get random picture";
            this.getRandomPictureButton.UseVisualStyleBackColor = true;
            this.getRandomPictureButton.Click += new System.EventHandler(this.getRandomPictureButton_Click);
            // 
            // averageRate
            // 
            this.averageRate.AutoSize = true;
            this.averageRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.averageRate.Location = new System.Drawing.Point(529, 321);
            this.averageRate.Name = "averageRate";
            this.averageRate.Size = new System.Drawing.Size(2, 15);
            this.averageRate.TabIndex = 9;
            // 
            // pictureIndex
            // 
            this.pictureIndex.AutoSize = true;
            this.pictureIndex.Location = new System.Drawing.Point(612, 522);
            this.pictureIndex.Name = "pictureIndex";
            this.pictureIndex.Size = new System.Drawing.Size(0, 13);
            this.pictureIndex.TabIndex = 10;
            // 
            // KartinkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureIndex);
            this.Controls.Add(this.averageRate);
            this.Controls.Add(this.getRandomPictureButton);
            this.Controls.Add(this.goRightButton);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chooseRatingBox);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.PictureBox);
            this.Name = "KartinkerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KartinkerForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.ComboBox chooseRatingBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Button goRightButton;
        private System.Windows.Forms.Button getRandomPictureButton;
        private System.Windows.Forms.Label averageRate;
        private System.Windows.Forms.Label pictureIndex;
    }
}

