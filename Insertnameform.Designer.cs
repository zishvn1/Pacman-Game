namespace PacMan_Game
{
    partial class Insertnameform
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
            this.nameBox1 = new System.Windows.Forms.TextBox();
            this.insertnamehere = new System.Windows.Forms.Label();
            this.BtnStore = new System.Windows.Forms.Button();
            this.closeFrm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameBox1
            // 
            this.nameBox1.Location = new System.Drawing.Point(53, 107);
            this.nameBox1.Name = "nameBox1";
            this.nameBox1.Size = new System.Drawing.Size(202, 20);
            this.nameBox1.TabIndex = 0;
            this.nameBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // insertnamehere
            // 
            this.insertnamehere.AutoSize = true;
            this.insertnamehere.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertnamehere.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.insertnamehere.Location = new System.Drawing.Point(12, 46);
            this.insertnamehere.Name = "insertnamehere";
            this.insertnamehere.Size = new System.Drawing.Size(290, 24);
            this.insertnamehere.TabIndex = 1;
            this.insertnamehere.Text = "Enter Username to view score";
            // 
            // BtnStore
            // 
            this.BtnStore.Location = new System.Drawing.Point(53, 157);
            this.BtnStore.Name = "BtnStore";
            this.BtnStore.Size = new System.Drawing.Size(92, 46);
            this.BtnStore.TabIndex = 2;
            this.BtnStore.Text = "Continue ";
            this.BtnStore.UseVisualStyleBackColor = true;
            this.BtnStore.Click += new System.EventHandler(this.button1_Click);
            // 
            // closeFrm
            // 
            this.closeFrm.Location = new System.Drawing.Point(163, 157);
            this.closeFrm.Name = "closeFrm";
            this.closeFrm.Size = new System.Drawing.Size(92, 46);
            this.closeFrm.TabIndex = 3;
            this.closeFrm.Text = "Close";
            this.closeFrm.UseVisualStyleBackColor = true;
            this.closeFrm.Click += new System.EventHandler(this.closeFrm_Click);
            // 
            // Insertnameform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(317, 261);
            this.Controls.Add(this.closeFrm);
            this.Controls.Add(this.BtnStore);
            this.Controls.Add(this.insertnamehere);
            this.Controls.Add(this.nameBox1);
            this.Name = "Insertnameform";
            this.Text = "Insertnameform";
            this.Load += new System.EventHandler(this.Insertnameform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox1;
        private System.Windows.Forms.Label insertnamehere;
        private System.Windows.Forms.Button BtnStore;
        private System.Windows.Forms.Button closeFrm;
    }
}