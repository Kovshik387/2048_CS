namespace _2048
{
    partial class LeadersScores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeadersScores));
            this.View_R = new System.Windows.Forms.ListView();
            this.Lead_score = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name__ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Scores_ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // View_R
            // 
            this.View_R.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(227)))), ((int)(((byte)(215)))));
            this.View_R.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.View_R.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Lead_score,
            this.Name__,
            this.Scores_});
            this.View_R.GridLines = true;
            this.View_R.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.View_R.HideSelection = false;
            this.View_R.Location = new System.Drawing.Point(12, 12);
            this.View_R.MultiSelect = false;
            this.View_R.Name = "View_R";
            this.View_R.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.View_R.Size = new System.Drawing.Size(272, 292);
            this.View_R.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.View_R.TabIndex = 0;
            this.View_R.TabStop = false;
            this.View_R.UseCompatibleStateImageBehavior = false;
            this.View_R.View = System.Windows.Forms.View.Details;
            // 
            // Lead_score
            // 
            this.Lead_score.Text = "Место";
            this.Lead_score.Width = 66;
            // 
            // Name__
            // 
            this.Name__.Text = "Имя";
            this.Name__.Width = 103;
            // 
            // Scores_
            // 
            this.Scores_.Text = "Счёт";
            this.Scores_.Width = 103;
            // 
            // LeadersScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(174)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(296, 316);
            this.Controls.Add(this.View_R);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(312, 355);
            this.MinimumSize = new System.Drawing.Size(312, 355);
            this.Name = "LeadersScores";
            this.Text = "Рейтинг";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView View_R;
        private System.Windows.Forms.ColumnHeader Lead_score;
        private System.Windows.Forms.ColumnHeader Name__;
        private System.Windows.Forms.ColumnHeader Scores_;
    }
}