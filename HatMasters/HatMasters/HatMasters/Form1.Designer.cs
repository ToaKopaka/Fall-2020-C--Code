namespace HatMasters
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
            this.rollCallBtn = new System.Windows.Forms.Button();
            this.nametxt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.testLabel = new System.Windows.Forms.Label();
            this.Hatnumlabel = new System.Windows.Forms.Label();
            this.nameboxlabel = new System.Windows.Forms.Label();
            this.nametxtbox = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.MakeHatMasterBtn = new System.Windows.Forms.Button();
            this.nameoutlabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // rollCallBtn
            // 
            this.rollCallBtn.Location = new System.Drawing.Point(289, 388);
            this.rollCallBtn.Name = "rollCallBtn";
            this.rollCallBtn.Size = new System.Drawing.Size(173, 35);
            this.rollCallBtn.TabIndex = 0;
            this.rollCallBtn.Text = "Roll Call";
            this.rollCallBtn.UseVisualStyleBackColor = true;
            this.rollCallBtn.Click += new System.EventHandler(this.rollCallBtn_Click);
            // 
            // nametxt
            // 
            this.nametxt.AutoSize = true;
            this.nametxt.Location = new System.Drawing.Point(304, 200);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(0, 17);
            this.nametxt.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.nameoutlabel);
            this.panel1.Controls.Add(this.testLabel);
            this.panel1.Controls.Add(this.Hatnumlabel);
            this.panel1.Controls.Add(this.nameboxlabel);
            this.panel1.Controls.Add(this.nametxtbox);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.MakeHatMasterBtn);
            this.panel1.Location = new System.Drawing.Point(27, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 338);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(3, 172);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(0, 17);
            this.testLabel.TabIndex = 5;
            // 
            // Hatnumlabel
            // 
            this.Hatnumlabel.AutoSize = true;
            this.Hatnumlabel.Location = new System.Drawing.Point(215, 129);
            this.Hatnumlabel.Name = "Hatnumlabel";
            this.Hatnumlabel.Size = new System.Drawing.Size(41, 17);
            this.Hatnumlabel.TabIndex = 4;
            this.Hatnumlabel.Text = "Hats:";
            // 
            // nameboxlabel
            // 
            this.nameboxlabel.AutoSize = true;
            this.nameboxlabel.Location = new System.Drawing.Point(207, 86);
            this.nameboxlabel.Name = "nameboxlabel";
            this.nameboxlabel.Size = new System.Drawing.Size(49, 17);
            this.nameboxlabel.TabIndex = 3;
            this.nameboxlabel.Text = "Name:";
            // 
            // nametxtbox
            // 
            this.nametxtbox.Location = new System.Drawing.Point(262, 86);
            this.nametxtbox.Name = "nametxtbox";
            this.nametxtbox.Size = new System.Drawing.Size(173, 22);
            this.nametxtbox.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(262, 129);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(173, 22);
            this.numericUpDown1.TabIndex = 1;
            // 
            // MakeHatMasterBtn
            // 
            this.MakeHatMasterBtn.Location = new System.Drawing.Point(262, 245);
            this.MakeHatMasterBtn.Name = "MakeHatMasterBtn";
            this.MakeHatMasterBtn.Size = new System.Drawing.Size(173, 55);
            this.MakeHatMasterBtn.TabIndex = 0;
            this.MakeHatMasterBtn.Text = "Create Hat Master";
            this.MakeHatMasterBtn.UseVisualStyleBackColor = true;
            this.MakeHatMasterBtn.Click += new System.EventHandler(this.MakeHatMasterBtn_Click);
            // 
            // nameoutlabel
            // 
            this.nameoutlabel.AutoSize = true;
            this.nameoutlabel.Location = new System.Drawing.Point(19, 173);
            this.nameoutlabel.Name = "nameoutlabel";
            this.nameoutlabel.Size = new System.Drawing.Size(0, 17);
            this.nameoutlabel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.rollCallBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rollCallBtn;
        private System.Windows.Forms.Label nametxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MakeHatMasterBtn;
        private System.Windows.Forms.Label Hatnumlabel;
        private System.Windows.Forms.Label nameboxlabel;
        private System.Windows.Forms.TextBox nametxtbox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.Label nameoutlabel;
    }
}

