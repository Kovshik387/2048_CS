namespace _2048
{
    partial class Game4
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            // Game4
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(174)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(260, 278);
            this.Controls.Add(this.Score_);
            this.Controls.Add(this.Score_Name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Game4";
            this.Text = "2048";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Score_Name;
        private System.Windows.Forms.Label Score_;
    }
}

