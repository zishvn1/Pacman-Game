namespace PacMan_Game
{
    partial class MenuForm
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
            this.easyFormBtn = new System.Windows.Forms.Button();
            this.hardFormBtn = new System.Windows.Forms.Button();
            this.leaderboardBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // easyFormBtn
            // 
            this.easyFormBtn.Location = new System.Drawing.Point(12, 99);
            this.easyFormBtn.Margin = new System.Windows.Forms.Padding(2);
            this.easyFormBtn.Name = "easyFormBtn";
            this.easyFormBtn.Size = new System.Drawing.Size(237, 63);
            this.easyFormBtn.TabIndex = 0;
            this.easyFormBtn.Text = "Easy";
            this.easyFormBtn.UseVisualStyleBackColor = true;
            this.easyFormBtn.Click += new System.EventHandler(this.easyFormBtn_Click);
            // 
            // hardFormBtn
            // 
            this.hardFormBtn.Location = new System.Drawing.Point(12, 175);
            this.hardFormBtn.Margin = new System.Windows.Forms.Padding(2);
            this.hardFormBtn.Name = "hardFormBtn";
            this.hardFormBtn.Size = new System.Drawing.Size(237, 63);
            this.hardFormBtn.TabIndex = 1;
            this.hardFormBtn.Text = "Hard";
            this.hardFormBtn.UseVisualStyleBackColor = true;
            this.hardFormBtn.Click += new System.EventHandler(this.hardFormBtn_Click);
            // 
            // leaderboardBtn
            // 
            this.leaderboardBtn.Location = new System.Drawing.Point(12, 253);
            this.leaderboardBtn.Name = "leaderboardBtn";
            this.leaderboardBtn.Size = new System.Drawing.Size(237, 63);
            this.leaderboardBtn.TabIndex = 2;
            this.leaderboardBtn.Text = "Leaderboard";
            this.leaderboardBtn.UseVisualStyleBackColor = true;
            this.leaderboardBtn.Click += new System.EventHandler(this.leaderboardBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(122, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pac Man";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PacMan_Game.Properties.Resources.bmet_logo;
            this.pictureBox2.Location = new System.Drawing.Point(9, 334);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(240, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PacMan_Game.Properties.Resources.right;
            this.pictureBox1.Location = new System.Drawing.Point(22, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(276, 334);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(161, 79);
            this.closeBtn.TabIndex = 6;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(449, 425);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leaderboardBtn);
            this.Controls.Add(this.hardFormBtn);
            this.Controls.Add(this.easyFormBtn);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button easyFormBtn;
        private System.Windows.Forms.Button hardFormBtn;
        private System.Windows.Forms.Button leaderboardBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button closeBtn;
    }
}