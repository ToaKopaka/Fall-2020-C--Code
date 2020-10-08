namespace ReturnOfMasters
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
            this.nametxtbox = new System.Windows.Forms.TextBox();
            this.articleCounter = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HatMasterBtn = new System.Windows.Forms.Button();
            this.RollCallBtn = new System.Windows.Forms.Button();
            this.PantsMasterBtn = new System.Windows.Forms.Button();
            this.RingMasterBtn = new System.Windows.Forms.Button();
            this.PersonBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.articleCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // nametxtbox
            // 
            this.nametxtbox.Location = new System.Drawing.Point(307, 85);
            this.nametxtbox.Name = "nametxtbox";
            this.nametxtbox.Size = new System.Drawing.Size(169, 22);
            this.nametxtbox.TabIndex = 0;
            // 
            // articleCounter
            // 
            this.articleCounter.Location = new System.Drawing.Point(307, 139);
            this.articleCounter.Name = "articleCounter";
            this.articleCounter.Size = new System.Drawing.Size(169, 22);
            this.articleCounter.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Articles:";
            // 
            // HatMasterBtn
            // 
            this.HatMasterBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HatMasterBtn.Location = new System.Drawing.Point(246, 199);
            this.HatMasterBtn.Name = "HatMasterBtn";
            this.HatMasterBtn.Size = new System.Drawing.Size(230, 43);
            this.HatMasterBtn.TabIndex = 4;
            this.HatMasterBtn.Text = "Create HatMaster";
            this.HatMasterBtn.UseVisualStyleBackColor = false;
            this.HatMasterBtn.Click += new System.EventHandler(this.HatMasterBtn_Click);
            // 
            // RollCallBtn
            // 
            this.RollCallBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.RollCallBtn.Location = new System.Drawing.Point(246, 404);
            this.RollCallBtn.Name = "RollCallBtn";
            this.RollCallBtn.Size = new System.Drawing.Size(230, 34);
            this.RollCallBtn.TabIndex = 5;
            this.RollCallBtn.Text = "Roll Call";
            this.RollCallBtn.UseVisualStyleBackColor = false;
            this.RollCallBtn.Click += new System.EventHandler(this.RollCallBtn_Click);
            // 
            // PantsMasterBtn
            // 
            this.PantsMasterBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PantsMasterBtn.Location = new System.Drawing.Point(246, 249);
            this.PantsMasterBtn.Name = "PantsMasterBtn";
            this.PantsMasterBtn.Size = new System.Drawing.Size(230, 42);
            this.PantsMasterBtn.TabIndex = 6;
            this.PantsMasterBtn.Text = "Create PantsMaster";
            this.PantsMasterBtn.UseVisualStyleBackColor = false;
            this.PantsMasterBtn.Click += new System.EventHandler(this.PantsMasterBtn_Click);
            // 
            // RingMasterBtn
            // 
            this.RingMasterBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RingMasterBtn.Location = new System.Drawing.Point(246, 298);
            this.RingMasterBtn.Name = "RingMasterBtn";
            this.RingMasterBtn.Size = new System.Drawing.Size(230, 44);
            this.RingMasterBtn.TabIndex = 7;
            this.RingMasterBtn.Text = "Create RingMaster";
            this.RingMasterBtn.UseVisualStyleBackColor = false;
            this.RingMasterBtn.Click += new System.EventHandler(this.RingMasterBtn_Click);
            // 
            // PersonBtn
            // 
            this.PersonBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PersonBtn.Location = new System.Drawing.Point(246, 349);
            this.PersonBtn.Name = "PersonBtn";
            this.PersonBtn.Size = new System.Drawing.Size(230, 38);
            this.PersonBtn.TabIndex = 8;
            this.PersonBtn.Text = "Create a normal person";
            this.PersonBtn.UseVisualStyleBackColor = false;
            this.PersonBtn.Click += new System.EventHandler(this.PersonBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PersonBtn);
            this.Controls.Add(this.RingMasterBtn);
            this.Controls.Add(this.PantsMasterBtn);
            this.Controls.Add(this.RollCallBtn);
            this.Controls.Add(this.HatMasterBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.articleCounter);
            this.Controls.Add(this.nametxtbox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.articleCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nametxtbox;
        private System.Windows.Forms.NumericUpDown articleCounter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button HatMasterBtn;
        private System.Windows.Forms.Button RollCallBtn;
        private System.Windows.Forms.Button PantsMasterBtn;
        private System.Windows.Forms.Button RingMasterBtn;
        private System.Windows.Forms.Button PersonBtn;
    }
}

