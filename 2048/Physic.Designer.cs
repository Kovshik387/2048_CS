namespace _2048
{
    partial class Game4
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        //
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game4));
            this.Score_Name = new System.Windows.Forms.Label();
            this.Score_ = new System.Windows.Forms.Label();
            this.Rating = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.Profile = new System.Windows.Forms.Button();
            this.Start_Game = new System.Windows.Forms.Button();
            this.Stopp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Score_Name
            // 
            this.Score_Name.AutoSize = true;
            this.Score_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Score_Name.Location = new System.Drawing.Point(12, 9);
            this.Score_Name.MinimumSize = new System.Drawing.Size(50, 20);
            this.Score_Name.Name = "Score_Name";
            this.Score_Name.Size = new System.Drawing.Size(64, 24);
            this.Score_Name.TabIndex = 0;
            this.Score_Name.Text = "Счёт:";
            // 
            // Score_
            // 
            this.Score_.AutoSize = true;
            this.Score_.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Score_.Location = new System.Drawing.Point(82, 5);
            this.Score_.Name = "Score_";
            this.Score_.Size = new System.Drawing.Size(24, 28);
            this.Score_.TabIndex = 1;
            this.Score_.Text = "0";
            // 
            // Rating
            // 
            this.Rating.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Rating.BackgroundImage")));
            this.Rating.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Rating.CausesValidation = false;
            this.Rating.Location = new System.Drawing.Point(244, 128);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(44, 30);
            this.Rating.TabIndex = 2;
            this.Rating.TabStop = false;
            this.Rating.UseVisualStyleBackColor = true;
            this.Rating.Click += new System.EventHandler(this.Rating_Click);
            // 
            // Refresh
            // 
            this.Refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Refresh.BackgroundImage")));
            this.Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Refresh.CausesValidation = false;
            this.Refresh.Location = new System.Drawing.Point(244, 46);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(45, 30);
            this.Refresh.TabIndex = 3;
            this.Refresh.TabStop = false;
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Visible = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Profile
            // 
            this.Profile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Profile.BackgroundImage")));
            this.Profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Profile.Location = new System.Drawing.Point(243, 92);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(45, 30);
            this.Profile.TabIndex = 4;
            this.Profile.UseVisualStyleBackColor = true;
            this.Profile.Click += new System.EventHandler(this.Profile_Click);
            // 
            // Start_Game
            // 
            this.Start_Game.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Start_Game.BackgroundImage")));
            this.Start_Game.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Start_Game.Location = new System.Drawing.Point(244, 46);
            this.Start_Game.Name = "Start_Game";
            this.Start_Game.Size = new System.Drawing.Size(45, 40);
            this.Start_Game.TabIndex = 5;
            this.Start_Game.UseVisualStyleBackColor = true;
            this.Start_Game.Click += new System.EventHandler(this.Start_Game_Click);
            // 
            // Stopp
            // 
            this.Stopp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stopp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(174)))), ((int)(((byte)(163)))));
            this.Stopp.Location = new System.Drawing.Point(263, 243);
            this.Stopp.Name = "Stopp";
            this.Stopp.Size = new System.Drawing.Size(26, 23);
            this.Stopp.TabIndex = 6;
            this.Stopp.UseVisualStyleBackColor = true;
            // 
            // Game4
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(174)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(301, 278);
            this.Controls.Add(this.Stopp);
            this.Controls.Add(this.Profile);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Rating);
            this.Controls.Add(this.Score_);
            this.Controls.Add(this.Score_Name);
            this.Controls.Add(this.Start_Game);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(317, 317);
            this.MinimumSize = new System.Drawing.Size(317, 317);
            this.Name = "Game4";
            this.Text = "2048";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Score_Name;
        private System.Windows.Forms.Label Score_;
        private System.Windows.Forms.Button Rating;
        private new System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button Profile;
        private System.Windows.Forms.Button Start_Game;
        private System.Windows.Forms.Button Stopp;
    }
}

