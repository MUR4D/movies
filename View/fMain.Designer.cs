namespace WindowsFormsApp3.View
{
    partial class fMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.favoritesView1 = new WindowsFormsApp3.View.UserControls.FavoritesView();
            this.Laters = new System.Windows.Forms.Button();
            this.Favorites = new System.Windows.Forms.Button();
            this.moviePoster = new System.Windows.Forms.PictureBox();
            this.tofavoritesButton = new System.Windows.Forms.Button();
            this.tolaterButton = new System.Windows.Forms.Button();
            this.moviesList = new System.Windows.Forms.ListBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviePoster)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.favoritesView1);
            this.panel1.Controls.Add(this.Laters);
            this.panel1.Controls.Add(this.Favorites);
            this.panel1.Controls.Add(this.moviePoster);
            this.panel1.Controls.Add(this.tofavoritesButton);
            this.panel1.Controls.Add(this.tolaterButton);
            this.panel1.Controls.Add(this.moviesList);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 440);
            this.panel1.TabIndex = 18;
            // 
            // favoritesView1
            // 
            this.favoritesView1.Location = new System.Drawing.Point(0, 0);
            this.favoritesView1.Name = "favoritesView1";
            this.favoritesView1.Presenter = null;
            this.favoritesView1.Size = new System.Drawing.Size(454, 426);
            this.favoritesView1.TabIndex = 26;
            this.favoritesView1.Load += new System.EventHandler(this.favoritesView1_Load);
            // 
            // Laters
            // 
            this.Laters.Location = new System.Drawing.Point(175, 406);
            this.Laters.Name = "Laters";
            this.Laters.Size = new System.Drawing.Size(124, 23);
            this.Laters.TabIndex = 24;
            this.Laters.Text = "to Watch later";
            this.Laters.UseVisualStyleBackColor = true;
            this.Laters.Click += new System.EventHandler(this.Laters_Click);
            // 
            // Favorites
            // 
            this.Favorites.Location = new System.Drawing.Point(21, 406);
            this.Favorites.Name = "Favorites";
            this.Favorites.Size = new System.Drawing.Size(124, 23);
            this.Favorites.TabIndex = 25;
            this.Favorites.Text = "Favorites";
            this.Favorites.UseVisualStyleBackColor = true;
            this.Favorites.Click += new System.EventHandler(this.Favorites_Click);
            // 
            // moviePoster
            // 
            this.moviePoster.Location = new System.Drawing.Point(318, 102);
            this.moviePoster.Name = "moviePoster";
            this.moviePoster.Size = new System.Drawing.Size(136, 193);
            this.moviePoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.moviePoster.TabIndex = 23;
            this.moviePoster.TabStop = false;
            // 
            // tofavoritesButton
            // 
            this.tofavoritesButton.Location = new System.Drawing.Point(318, 301);
            this.tofavoritesButton.Name = "tofavoritesButton";
            this.tofavoritesButton.Size = new System.Drawing.Size(136, 23);
            this.tofavoritesButton.TabIndex = 21;
            this.tofavoritesButton.Text = "Add to Favorites";
            this.tofavoritesButton.UseVisualStyleBackColor = true;
            this.tofavoritesButton.Click += new System.EventHandler(this.tofavoritesButton_Click);
            // 
            // tolaterButton
            // 
            this.tolaterButton.Location = new System.Drawing.Point(318, 343);
            this.tolaterButton.Name = "tolaterButton";
            this.tolaterButton.Size = new System.Drawing.Size(136, 23);
            this.tolaterButton.TabIndex = 22;
            this.tolaterButton.Text = "Watch later";
            this.tolaterButton.UseVisualStyleBackColor = true;
            // 
            // moviesList
            // 
            this.moviesList.FormattingEnabled = true;
            this.moviesList.Location = new System.Drawing.Point(21, 102);
            this.moviesList.Name = "moviesList";
            this.moviesList.Size = new System.Drawing.Size(278, 264);
            this.moviesList.TabIndex = 20;
            this.moviesList.SelectedIndexChanged += new System.EventHandler(this.moviesList_SelectedIndexChanged_1);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(376, 49);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 20);
            this.searchButton.TabIndex = 19;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click_1);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(21, 50);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(339, 20);
            this.searchBox.TabIndex = 18;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 439);
            this.Controls.Add(this.panel1);
            this.Name = "fMain";
            this.Text = "fMain";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviePoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Laters;
        private System.Windows.Forms.Button Favorites;
        private System.Windows.Forms.PictureBox moviePoster;
        private System.Windows.Forms.Button tofavoritesButton;
        private System.Windows.Forms.Button tolaterButton;
        private System.Windows.Forms.ListBox moviesList;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBox;
        private UserControls.FavoritesView favoritesView1;
    }
}