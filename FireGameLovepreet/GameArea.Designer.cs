namespace FireGameLovepreet
{
    partial class GameArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameArea));
            this.pistol = new System.Windows.Forms.PictureBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.ShootButton = new System.Windows.Forms.Button();
            this.ShootAwayButton = new System.Windows.Forms.Button();
            this.PlayAgainButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pistol)).BeginInit();
            this.SuspendLayout();
            // 
            // pistol
            // 
            this.pistol.BackColor = System.Drawing.Color.Transparent;
            this.pistol.Location = new System.Drawing.Point(331, 60);
            this.pistol.Name = "pistol";
            this.pistol.Size = new System.Drawing.Size(321, 302);
            this.pistol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pistol.TabIndex = 0;
            this.pistol.TabStop = false;
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.Color.Red;
            this.StartButton.Location = new System.Drawing.Point(9, 73);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(89, 28);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadButton.ForeColor = System.Drawing.Color.Red;
            this.LoadButton.Location = new System.Drawing.Point(9, 119);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(89, 28);
            this.LoadButton.TabIndex = 2;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // ShootButton
            // 
            this.ShootButton.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShootButton.ForeColor = System.Drawing.Color.Red;
            this.ShootButton.Location = new System.Drawing.Point(9, 168);
            this.ShootButton.Name = "ShootButton";
            this.ShootButton.Size = new System.Drawing.Size(89, 28);
            this.ShootButton.TabIndex = 3;
            this.ShootButton.Text = "Shoot";
            this.ShootButton.UseVisualStyleBackColor = true;
            this.ShootButton.Click += new System.EventHandler(this.ShootButton_Click);
            // 
            // ShootAwayButton
            // 
            this.ShootAwayButton.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShootAwayButton.ForeColor = System.Drawing.Color.Red;
            this.ShootAwayButton.Location = new System.Drawing.Point(12, 216);
            this.ShootAwayButton.Name = "ShootAwayButton";
            this.ShootAwayButton.Size = new System.Drawing.Size(152, 28);
            this.ShootAwayButton.TabIndex = 4;
            this.ShootAwayButton.Text = "Shoot Away";
            this.ShootAwayButton.UseVisualStyleBackColor = true;
            this.ShootAwayButton.Click += new System.EventHandler(this.ShootAwayButton_Click);
            // 
            // PlayAgainButton
            // 
            this.PlayAgainButton.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayAgainButton.ForeColor = System.Drawing.Color.Red;
            this.PlayAgainButton.Location = new System.Drawing.Point(12, 262);
            this.PlayAgainButton.Name = "PlayAgainButton";
            this.PlayAgainButton.Size = new System.Drawing.Size(152, 28);
            this.PlayAgainButton.TabIndex = 5;
            this.PlayAgainButton.Text = "Play Again";
            this.PlayAgainButton.UseVisualStyleBackColor = true;
            this.PlayAgainButton.Click += new System.EventHandler(this.PlayAgainButton_Click);
            // 
            // GameArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PlayAgainButton);
            this.Controls.Add(this.ShootAwayButton);
            this.Controls.Add(this.ShootButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.pistol);
            this.Name = "GameArea";
            this.Text = "GameArea";
            ((System.ComponentModel.ISupportInitialize)(this.pistol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pistol;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button ShootButton;
        private System.Windows.Forms.Button ShootAwayButton;
        private System.Windows.Forms.Button PlayAgainButton;
    }
}