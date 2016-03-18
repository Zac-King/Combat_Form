namespace Combat
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
            this.Player1Image = new System.Windows.Forms.PictureBox();
            this.Player2Image = new System.Windows.Forms.PictureBox();
            this.Player2Health = new System.Windows.Forms.ProgressBar();
            this.Player1Health = new System.Windows.Forms.ProgressBar();
            this.Player1Stats = new System.Windows.Forms.TextBox();
            this.Player2Stats = new System.Windows.Forms.TextBox();
            this.Player1Attack = new System.Windows.Forms.Button();
            this.Player1Pass = new System.Windows.Forms.Button();
            this.Player2Attack = new System.Windows.Forms.Button();
            this.Player2Pass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Player1Image
            // 
            this.Player1Image.Image = ((System.Drawing.Image)(resources.GetObject("Player1Image.Image")));
            this.Player1Image.Location = new System.Drawing.Point(12, 12);
            this.Player1Image.Name = "Player1Image";
            this.Player1Image.Size = new System.Drawing.Size(375, 295);
            this.Player1Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player1Image.TabIndex = 0;
            this.Player1Image.TabStop = false;
            // 
            // Player2Image
            // 
            this.Player2Image.Image = ((System.Drawing.Image)(resources.GetObject("Player2Image.Image")));
            this.Player2Image.Location = new System.Drawing.Point(462, 12);
            this.Player2Image.Name = "Player2Image";
            this.Player2Image.Size = new System.Drawing.Size(375, 295);
            this.Player2Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player2Image.TabIndex = 1;
            this.Player2Image.TabStop = false;
            // 
            // Player2Health
            // 
            this.Player2Health.Location = new System.Drawing.Point(462, 314);
            this.Player2Health.Name = "Player2Health";
            this.Player2Health.Size = new System.Drawing.Size(375, 23);
            this.Player2Health.TabIndex = 2;
            // 
            // Player1Health
            // 
            this.Player1Health.Location = new System.Drawing.Point(13, 314);
            this.Player1Health.Name = "Player1Health";
            this.Player1Health.Size = new System.Drawing.Size(374, 23);
            this.Player1Health.TabIndex = 3;
            // 
            // Player1Stats
            // 
            this.Player1Stats.Location = new System.Drawing.Point(12, 386);
            this.Player1Stats.Multiline = true;
            this.Player1Stats.Name = "Player1Stats";
            this.Player1Stats.Size = new System.Drawing.Size(375, 173);
            this.Player1Stats.TabIndex = 4;
            // 
            // Player2Stats
            // 
            this.Player2Stats.Location = new System.Drawing.Point(462, 386);
            this.Player2Stats.Multiline = true;
            this.Player2Stats.Name = "Player2Stats";
            this.Player2Stats.Size = new System.Drawing.Size(375, 173);
            this.Player2Stats.TabIndex = 5;
            // 
            // Player1Attack
            // 
            this.Player1Attack.Location = new System.Drawing.Point(116, 357);
            this.Player1Attack.Name = "Player1Attack";
            this.Player1Attack.Size = new System.Drawing.Size(75, 23);
            this.Player1Attack.TabIndex = 6;
            this.Player1Attack.Text = "Attack";
            this.Player1Attack.UseVisualStyleBackColor = true;
            this.Player1Attack.Click += new System.EventHandler(this.Player1Attack_Click);
            // 
            // Player1Pass
            // 
            this.Player1Pass.Location = new System.Drawing.Point(197, 357);
            this.Player1Pass.Name = "Player1Pass";
            this.Player1Pass.Size = new System.Drawing.Size(75, 23);
            this.Player1Pass.TabIndex = 7;
            this.Player1Pass.Text = "Pass";
            this.Player1Pass.UseVisualStyleBackColor = true;
            // 
            // Player2Attack
            // 
            this.Player2Attack.Location = new System.Drawing.Point(580, 357);
            this.Player2Attack.Name = "Player2Attack";
            this.Player2Attack.Size = new System.Drawing.Size(75, 23);
            this.Player2Attack.TabIndex = 8;
            this.Player2Attack.Text = "Attack";
            this.Player2Attack.UseVisualStyleBackColor = true;
            // 
            // Player2Pass
            // 
            this.Player2Pass.Location = new System.Drawing.Point(662, 357);
            this.Player2Pass.Name = "Player2Pass";
            this.Player2Pass.Size = new System.Drawing.Size(75, 23);
            this.Player2Pass.TabIndex = 9;
            this.Player2Pass.Text = "Pass";
            this.Player2Pass.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 585);
            this.Controls.Add(this.Player2Pass);
            this.Controls.Add(this.Player2Attack);
            this.Controls.Add(this.Player1Pass);
            this.Controls.Add(this.Player1Attack);
            this.Controls.Add(this.Player2Stats);
            this.Controls.Add(this.Player1Stats);
            this.Controls.Add(this.Player1Health);
            this.Controls.Add(this.Player2Health);
            this.Controls.Add(this.Player2Image);
            this.Controls.Add(this.Player1Image);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Player1Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player1Image;
        private System.Windows.Forms.PictureBox Player2Image;
        private System.Windows.Forms.ProgressBar Player2Health;
        private System.Windows.Forms.ProgressBar Player1Health;
        private System.Windows.Forms.TextBox Player1Stats;
        private System.Windows.Forms.TextBox Player2Stats;
        private System.Windows.Forms.Button Player1Attack;
        private System.Windows.Forms.Button Player1Pass;
        private System.Windows.Forms.Button Player2Attack;
        private System.Windows.Forms.Button Player2Pass;
    }
}

