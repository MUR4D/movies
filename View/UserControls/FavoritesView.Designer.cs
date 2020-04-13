namespace WindowsFormsApp3.View.UserControls
{
    partial class FavoritesView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.favoritesList = new System.Windows.Forms.ListBox();
            this.favoritesPoster = new System.Windows.Forms.PictureBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.favoritesPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Favorites";
            // 
            // favoritesList
            // 
            this.favoritesList.FormattingEnabled = true;
            this.favoritesList.Location = new System.Drawing.Point(8, 74);
            this.favoritesList.Name = "favoritesList";
            this.favoritesList.Size = new System.Drawing.Size(282, 277);
            this.favoritesList.TabIndex = 1;
            this.favoritesList.SelectedIndexChanged += new System.EventHandler(this.favoritesList_SelectedIndexChanged);
            // 
            // favoritesPoster
            // 
            this.favoritesPoster.Location = new System.Drawing.Point(314, 74);
            this.favoritesPoster.Name = "favoritesPoster";
            this.favoritesPoster.Size = new System.Drawing.Size(133, 277);
            this.favoritesPoster.TabIndex = 2;
            this.favoritesPoster.TabStop = false;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(315, 399);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(132, 23);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(19, 399);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(132, 23);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "<<Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // FavoritesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.favoritesPoster);
            this.Controls.Add(this.favoritesList);
            this.Controls.Add(this.label1);
            this.Name = "FavoritesView";
            this.Size = new System.Drawing.Size(460, 440);
            ((System.ComponentModel.ISupportInitialize)(this.favoritesPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox favoritesList;
        private System.Windows.Forms.PictureBox favoritesPoster;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button backButton;
    }
}
