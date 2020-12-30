namespace ExcitingVirtualPet
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.petPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.catWaterButton = new System.Windows.Forms.Button();
            this.petCatButton = new System.Windows.Forms.Button();
            this.catPlayButton = new System.Windows.Forms.Button();
            this.feedCatButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.affectionMeter = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.boredomMeter = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.thirstMeter = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.hungerMeter = new System.Windows.Forms.ProgressBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.foodAmountBar = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.waterAmountBar = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.CatButton = new System.Windows.Forms.Button();
            this.DogButton = new System.Windows.Forms.Button();
            this.BirdButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.MailAttkLabel = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.TrickLabel = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petPictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.petPictureBox);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(437, 370);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pet Display";
            // 
            // petPictureBox
            // 
            this.petPictureBox.Location = new System.Drawing.Point(8, 23);
            this.petPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.petPictureBox.Name = "petPictureBox";
            this.petPictureBox.Size = new System.Drawing.Size(421, 331);
            this.petPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.petPictureBox.TabIndex = 0;
            this.petPictureBox.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.catWaterButton);
            this.groupBox2.Controls.Add(this.petCatButton);
            this.groupBox2.Controls.Add(this.catPlayButton);
            this.groupBox2.Controls.Add(this.feedCatButton);
            this.groupBox2.Location = new System.Drawing.Point(461, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(297, 169);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pet Controls";
            // 
            // catWaterButton
            // 
            this.catWaterButton.Location = new System.Drawing.Point(8, 59);
            this.catWaterButton.Margin = new System.Windows.Forms.Padding(4);
            this.catWaterButton.Name = "catWaterButton";
            this.catWaterButton.Size = new System.Drawing.Size(281, 28);
            this.catWaterButton.TabIndex = 0;
            this.catWaterButton.Text = "Give Pet Water";
            this.catWaterButton.UseVisualStyleBackColor = true;
            this.catWaterButton.Click += new System.EventHandler(this.catWaterButton_Click);
            // 
            // petCatButton
            // 
            this.petCatButton.Location = new System.Drawing.Point(8, 130);
            this.petCatButton.Margin = new System.Windows.Forms.Padding(4);
            this.petCatButton.Name = "petCatButton";
            this.petCatButton.Size = new System.Drawing.Size(281, 28);
            this.petCatButton.TabIndex = 0;
            this.petCatButton.Text = "Pet the Pet";
            this.petCatButton.UseVisualStyleBackColor = true;
            this.petCatButton.Click += new System.EventHandler(this.petCatButton_Click);
            // 
            // catPlayButton
            // 
            this.catPlayButton.Location = new System.Drawing.Point(8, 95);
            this.catPlayButton.Margin = new System.Windows.Forms.Padding(4);
            this.catPlayButton.Name = "catPlayButton";
            this.catPlayButton.Size = new System.Drawing.Size(281, 28);
            this.catPlayButton.TabIndex = 0;
            this.catPlayButton.Text = "Play With Pet";
            this.catPlayButton.UseVisualStyleBackColor = true;
            this.catPlayButton.Click += new System.EventHandler(this.catPlayButton_Click);
            // 
            // feedCatButton
            // 
            this.feedCatButton.Location = new System.Drawing.Point(8, 23);
            this.feedCatButton.Margin = new System.Windows.Forms.Padding(4);
            this.feedCatButton.Name = "feedCatButton";
            this.feedCatButton.Size = new System.Drawing.Size(281, 28);
            this.feedCatButton.TabIndex = 0;
            this.feedCatButton.Text = "Feed Pet";
            this.feedCatButton.UseVisualStyleBackColor = true;
            this.feedCatButton.Click += new System.EventHandler(this.feedCatButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.affectionMeter);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.boredomMeter);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.thirstMeter);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.hungerMeter);
            this.groupBox3.Location = new System.Drawing.Point(461, 191);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(297, 194);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pet Facts";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Affection";
            // 
            // affectionMeter
            // 
            this.affectionMeter.Location = new System.Drawing.Point(81, 153);
            this.affectionMeter.Margin = new System.Windows.Forms.Padding(4);
            this.affectionMeter.Maximum = 10;
            this.affectionMeter.Name = "affectionMeter";
            this.affectionMeter.Size = new System.Drawing.Size(208, 28);
            this.affectionMeter.Step = 1;
            this.affectionMeter.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Boredom";
            // 
            // boredomMeter
            // 
            this.boredomMeter.Location = new System.Drawing.Point(81, 107);
            this.boredomMeter.Margin = new System.Windows.Forms.Padding(4);
            this.boredomMeter.Maximum = 10;
            this.boredomMeter.Name = "boredomMeter";
            this.boredomMeter.Size = new System.Drawing.Size(208, 28);
            this.boredomMeter.Step = 1;
            this.boredomMeter.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thirst";
            // 
            // thirstMeter
            // 
            this.thirstMeter.Location = new System.Drawing.Point(81, 64);
            this.thirstMeter.Margin = new System.Windows.Forms.Padding(4);
            this.thirstMeter.Maximum = 10;
            this.thirstMeter.Name = "thirstMeter";
            this.thirstMeter.Size = new System.Drawing.Size(208, 28);
            this.thirstMeter.Step = 1;
            this.thirstMeter.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hunger";
            // 
            // hungerMeter
            // 
            this.hungerMeter.Location = new System.Drawing.Point(81, 23);
            this.hungerMeter.Margin = new System.Windows.Forms.Padding(4);
            this.hungerMeter.Maximum = 10;
            this.hungerMeter.Name = "hungerMeter";
            this.hungerMeter.Size = new System.Drawing.Size(208, 28);
            this.hungerMeter.Step = 1;
            this.hungerMeter.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.foodAmountBar);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.waterAmountBar);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(16, 393);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(497, 94);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resources";
            // 
            // foodAmountBar
            // 
            this.foodAmountBar.Location = new System.Drawing.Point(265, 30);
            this.foodAmountBar.Margin = new System.Windows.Forms.Padding(4);
            this.foodAmountBar.Maximum = 10;
            this.foodAmountBar.Name = "foodAmountBar";
            this.foodAmountBar.Size = new System.Drawing.Size(216, 28);
            this.foodAmountBar.Step = 1;
            this.foodAmountBar.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Food Dish:";
            // 
            // waterAmountBar
            // 
            this.waterAmountBar.Location = new System.Drawing.Point(19, 30);
            this.waterAmountBar.Margin = new System.Windows.Forms.Padding(4);
            this.waterAmountBar.Maximum = 10;
            this.waterAmountBar.Name = "waterAmountBar";
            this.waterAmountBar.Size = new System.Drawing.Size(216, 28);
            this.waterAmountBar.Step = 1;
            this.waterAmountBar.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Water Dish:";
            // 
            // CatButton
            // 
            this.CatButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CatButton.Location = new System.Drawing.Point(16, 544);
            this.CatButton.Name = "CatButton";
            this.CatButton.Size = new System.Drawing.Size(154, 49);
            this.CatButton.TabIndex = 4;
            this.CatButton.Text = "Cat";
            this.CatButton.UseVisualStyleBackColor = false;
            this.CatButton.Click += new System.EventHandler(this.CatButton_Click);
            // 
            // DogButton
            // 
            this.DogButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DogButton.Location = new System.Drawing.Point(209, 544);
            this.DogButton.Name = "DogButton";
            this.DogButton.Size = new System.Drawing.Size(148, 48);
            this.DogButton.TabIndex = 5;
            this.DogButton.Text = "Dog";
            this.DogButton.UseVisualStyleBackColor = false;
            this.DogButton.Click += new System.EventHandler(this.DogButton_Click);
            // 
            // BirdButton
            // 
            this.BirdButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BirdButton.Location = new System.Drawing.Point(399, 544);
            this.BirdButton.Name = "BirdButton";
            this.BirdButton.Size = new System.Drawing.Size(133, 47);
            this.BirdButton.TabIndex = 6;
            this.BirdButton.Text = "Bird";
            this.BirdButton.UseVisualStyleBackColor = false;
            this.BirdButton.Click += new System.EventHandler(this.BirdButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 495);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(274, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Pick  which animal you want to be your pet";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.MailAttkLabel);
            this.groupBox5.Location = new System.Drawing.Point(542, 447);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 100);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Mailmen Attacked";
            // 
            // MailAttkLabel
            // 
            this.MailAttkLabel.AutoSize = true;
            this.MailAttkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MailAttkLabel.Location = new System.Drawing.Point(90, 41);
            this.MailAttkLabel.Name = "MailAttkLabel";
            this.MailAttkLabel.Size = new System.Drawing.Size(26, 29);
            this.MailAttkLabel.TabIndex = 0;
            this.MailAttkLabel.Text = "0";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.TrickLabel);
            this.groupBox6.Location = new System.Drawing.Point(542, 636);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 100);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tricks Learned";
            // 
            // TrickLabel
            // 
            this.TrickLabel.AutoSize = true;
            this.TrickLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrickLabel.Location = new System.Drawing.Point(90, 44);
            this.TrickLabel.Name = "TrickLabel";
            this.TrickLabel.Size = new System.Drawing.Size(26, 29);
            this.TrickLabel.TabIndex = 0;
            this.TrickLabel.Text = "0";
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SaveBtn.Location = new System.Drawing.Point(99, 647);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(157, 46);
            this.SaveBtn.TabIndex = 10;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // LoadBtn
            // 
            this.LoadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LoadBtn.Location = new System.Drawing.Point(377, 647);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(136, 46);
            this.LoadBtn.TabIndex = 11;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = false;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(176, 627);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(277, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Save and Load are not working at this time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(539, 571);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 51);
            this.label9.TabIndex = 13;
            this.label9.Text = "Every time you play with your\r\n pet they learn a new trick, that is\r\n tracked by " +
    "a decorator";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(530, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(239, 51);
            this.label10.TabIndex = 14;
            this.label10.Text = "Every 5 actions an event is triggered\r\n where a mailman comes and your\r\n pet scar" +
    "es them away";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 748);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BirdButton);
            this.Controls.Add(this.DogButton);
            this.Controls.Add(this.CatButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Virtual Pet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.petPictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox petPictureBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button catWaterButton;
        private System.Windows.Forms.Button petCatButton;
        private System.Windows.Forms.Button catPlayButton;
        private System.Windows.Forms.Button feedCatButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar affectionMeter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar boredomMeter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar thirstMeter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar hungerMeter;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ProgressBar foodAmountBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar waterAmountBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CatButton;
        private System.Windows.Forms.Button DogButton;
        private System.Windows.Forms.Button BirdButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label MailAttkLabel;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label TrickLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

