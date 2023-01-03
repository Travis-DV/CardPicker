namespace CardPicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CardLB = new System.Windows.Forms.Label();
            this.Card5PIC = new System.Windows.Forms.PictureBox();
            this.Card4PIC = new System.Windows.Forms.PictureBox();
            this.Card3PIC = new System.Windows.Forms.PictureBox();
            this.Card2PIC = new System.Windows.Forms.PictureBox();
            this.Card1PIC = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Card5PIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card4PIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card3PIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card2PIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card1PIC)).BeginInit();
            this.SuspendLayout();
            // 
            // CardLB
            // 
            this.CardLB.AutoSize = true;
            this.CardLB.Location = new System.Drawing.Point(265, 183);
            this.CardLB.Name = "CardLB";
            this.CardLB.Size = new System.Drawing.Size(152, 13);
            this.CardLB.TabIndex = 12;
            this.CardLB.Text = "You haven\'t picked a card yet!";
            this.CardLB.Click += new System.EventHandler(this.CardLB_Click);
            // 
            // Card5PIC
            // 
            this.Card5PIC.Image = ((System.Drawing.Image)(resources.GetObject("Card5PIC.Image")));
            this.Card5PIC.Location = new System.Drawing.Point(462, 12);
            this.Card5PIC.Name = "Card5PIC";
            this.Card5PIC.Size = new System.Drawing.Size(100, 144);
            this.Card5PIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card5PIC.TabIndex = 11;
            this.Card5PIC.TabStop = false;
            this.Card5PIC.Click += new System.EventHandler(this.Card5PIC_Click);
            // 
            // Card4PIC
            // 
            this.Card4PIC.Image = ((System.Drawing.Image)(resources.GetObject("Card4PIC.Image")));
            this.Card4PIC.Location = new System.Drawing.Point(356, 12);
            this.Card4PIC.Name = "Card4PIC";
            this.Card4PIC.Size = new System.Drawing.Size(100, 144);
            this.Card4PIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card4PIC.TabIndex = 10;
            this.Card4PIC.TabStop = false;
            this.Card4PIC.Click += new System.EventHandler(this.Card4PIC_Click);
            // 
            // Card3PIC
            // 
            this.Card3PIC.Image = ((System.Drawing.Image)(resources.GetObject("Card3PIC.Image")));
            this.Card3PIC.Location = new System.Drawing.Point(250, 12);
            this.Card3PIC.Name = "Card3PIC";
            this.Card3PIC.Size = new System.Drawing.Size(100, 144);
            this.Card3PIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card3PIC.TabIndex = 9;
            this.Card3PIC.TabStop = false;
            this.Card3PIC.Click += new System.EventHandler(this.Card3PIC_Click);
            // 
            // Card2PIC
            // 
            this.Card2PIC.Image = ((System.Drawing.Image)(resources.GetObject("Card2PIC.Image")));
            this.Card2PIC.Location = new System.Drawing.Point(144, 12);
            this.Card2PIC.Name = "Card2PIC";
            this.Card2PIC.Size = new System.Drawing.Size(100, 144);
            this.Card2PIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card2PIC.TabIndex = 8;
            this.Card2PIC.TabStop = false;
            this.Card2PIC.Click += new System.EventHandler(this.Card2PIC_Click);
            // 
            // Card1PIC
            // 
            this.Card1PIC.Image = ((System.Drawing.Image)(resources.GetObject("Card1PIC.Image")));
            this.Card1PIC.Location = new System.Drawing.Point(38, 12);
            this.Card1PIC.Name = "Card1PIC";
            this.Card1PIC.Size = new System.Drawing.Size(100, 144);
            this.Card1PIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card1PIC.TabIndex = 7;
            this.Card1PIC.TabStop = false;
            this.Card1PIC.Click += new System.EventHandler(this.Card1PIC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.CardLB);
            this.Controls.Add(this.Card5PIC);
            this.Controls.Add(this.Card4PIC);
            this.Controls.Add(this.Card3PIC);
            this.Controls.Add(this.Card2PIC);
            this.Controls.Add(this.Card1PIC);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Card5PIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card4PIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card3PIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card2PIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card1PIC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CardLB;
        private System.Windows.Forms.PictureBox Card5PIC;
        private System.Windows.Forms.PictureBox Card4PIC;
        private System.Windows.Forms.PictureBox Card3PIC;
        private System.Windows.Forms.PictureBox Card2PIC;
        private System.Windows.Forms.PictureBox Card1PIC;
    }
}

