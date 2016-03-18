namespace Combat
{
    partial class RPG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPG));
            this.UserLabelName = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AttributeLabel = new System.Windows.Forms.Label();
            this.StrengthValue = new System.Windows.Forms.Label();
            this.AttributePlus = new System.Windows.Forms.Button();
            this.AttributeMinus = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Strength = new System.Windows.Forms.Panel();
            this.Speed = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SpeedValue = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Defense = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.DefenseValue = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Strength.SuspendLayout();
            this.Speed.SuspendLayout();
            this.Defense.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserLabelName
            // 
            this.UserLabelName.AutoSize = true;
            this.UserLabelName.Location = new System.Drawing.Point(6, 19);
            this.UserLabelName.Name = "UserLabelName";
            this.UserLabelName.Size = new System.Drawing.Size(35, 13);
            this.UserLabelName.TabIndex = 1;
            this.UserLabelName.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(46, 19);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(163, 20);
            this.NameTextBox.TabIndex = 2;
            // 
            // AttributeLabel
            // 
            this.AttributeLabel.AutoSize = true;
            this.AttributeLabel.Location = new System.Drawing.Point(38, 57);
            this.AttributeLabel.Name = "AttributeLabel";
            this.AttributeLabel.Size = new System.Drawing.Size(47, 13);
            this.AttributeLabel.TabIndex = 4;
            this.AttributeLabel.Text = "Strength";
            // 
            // StrengthValue
            // 
            this.StrengthValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StrengthValue.AutoSize = true;
            this.StrengthValue.Location = new System.Drawing.Point(50, 10);
            this.StrengthValue.Name = "StrengthValue";
            this.StrengthValue.Size = new System.Drawing.Size(13, 13);
            this.StrengthValue.TabIndex = 12;
            this.StrengthValue.Text = "0";
            // 
            // AttributePlus
            // 
            this.AttributePlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AttributePlus.Location = new System.Drawing.Point(85, 4);
            this.AttributePlus.Name = "AttributePlus";
            this.AttributePlus.Size = new System.Drawing.Size(20, 25);
            this.AttributePlus.TabIndex = 11;
            this.AttributePlus.Text = ">";
            this.AttributePlus.UseVisualStyleBackColor = true;
            this.AttributePlus.Click += new System.EventHandler(this.ChangeAttribute);
            // 
            // AttributeMinus
            // 
            this.AttributeMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AttributeMinus.Location = new System.Drawing.Point(10, 4);
            this.AttributeMinus.Name = "AttributeMinus";
            this.AttributeMinus.Size = new System.Drawing.Size(20, 25);
            this.AttributeMinus.TabIndex = 10;
            this.AttributeMinus.Text = "<";
            this.AttributeMinus.UseVisualStyleBackColor = true;
            this.AttributeMinus.Click += new System.EventHandler(this.ChangeAttribute);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(236, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 189);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Strength
            // 
            this.Strength.Controls.Add(this.AttributeMinus);
            this.Strength.Controls.Add(this.StrengthValue);
            this.Strength.Controls.Add(this.AttributePlus);
            this.Strength.Location = new System.Drawing.Point(90, 57);
            this.Strength.Name = "Strength";
            this.Strength.Size = new System.Drawing.Size(119, 33);
            this.Strength.TabIndex = 20;
            // 
            // Speed
            // 
            this.Speed.Controls.Add(this.button1);
            this.Speed.Controls.Add(this.SpeedValue);
            this.Speed.Controls.Add(this.button2);
            this.Speed.Location = new System.Drawing.Point(90, 135);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(119, 33);
            this.Speed.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(10, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 25);
            this.button1.TabIndex = 10;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ChangeAttribute);
            // 
            // SpeedValue
            // 
            this.SpeedValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SpeedValue.AutoSize = true;
            this.SpeedValue.Location = new System.Drawing.Point(50, 10);
            this.SpeedValue.Name = "SpeedValue";
            this.SpeedValue.Size = new System.Drawing.Size(13, 13);
            this.SpeedValue.TabIndex = 12;
            this.SpeedValue.Text = "0";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(85, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 25);
            this.button2.TabIndex = 11;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ChangeAttribute);
            // 
            // Defense
            // 
            this.Defense.Controls.Add(this.button3);
            this.Defense.Controls.Add(this.DefenseValue);
            this.Defense.Controls.Add(this.button4);
            this.Defense.Location = new System.Drawing.Point(90, 96);
            this.Defense.Name = "Defense";
            this.Defense.Size = new System.Drawing.Size(119, 33);
            this.Defense.TabIndex = 22;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(10, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(20, 25);
            this.button3.TabIndex = 10;
            this.button3.Text = "<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ChangeAttribute);
            // 
            // DefenseValue
            // 
            this.DefenseValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DefenseValue.AutoSize = true;
            this.DefenseValue.Location = new System.Drawing.Point(50, 10);
            this.DefenseValue.Name = "DefenseValue";
            this.DefenseValue.Size = new System.Drawing.Size(13, 13);
            this.DefenseValue.TabIndex = 12;
            this.DefenseValue.Text = "0";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(85, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(20, 25);
            this.button4.TabIndex = 11;
            this.button4.Text = ">";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ChangeAttribute);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Defense";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Speed";
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveButton.Location = new System.Drawing.Point(58, 201);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 25;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveAttributes);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Defense);
            this.panel1.Controls.Add(this.Speed);
            this.panel1.Controls.Add(this.AttributeLabel);
            this.panel1.Controls.Add(this.Strength);
            this.panel1.Controls.Add(this.NameTextBox);
            this.panel1.Controls.Add(this.UserLabelName);
            this.panel1.Location = new System.Drawing.Point(7, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 248);
            this.panel1.TabIndex = 26;
            // 
            // RPG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 293);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "RPG";
            this.Text = "RPG";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Strength.ResumeLayout(false);
            this.Strength.PerformLayout();
            this.Speed.ResumeLayout(false);
            this.Speed.PerformLayout();
            this.Defense.ResumeLayout(false);
            this.Defense.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label UserLabelName;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label AttributeLabel;
        private System.Windows.Forms.Label StrengthValue;
        private System.Windows.Forms.Button AttributePlus;
        private System.Windows.Forms.Button AttributeMinus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Strength;
        private System.Windows.Forms.Panel Speed;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label SpeedValue;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel Defense;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label DefenseValue;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Panel panel1;
    }
}

