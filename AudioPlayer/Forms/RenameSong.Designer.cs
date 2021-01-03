﻿namespace AudioPlayer
{
    partial class RenameSongLabel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenameSongLabel));
            this.top_right_panel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.newSongNameLabel = new System.Windows.Forms.Label();
            this.newSongNameBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.top_right_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // top_right_panel
            // 
            this.top_right_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.top_right_panel.Controls.Add(this.pictureBox2);
            this.top_right_panel.Controls.Add(this.exitButton);
            this.top_right_panel.Location = new System.Drawing.Point(0, 0);
            this.top_right_panel.Name = "top_right_panel";
            this.top_right_panel.Size = new System.Drawing.Size(266, 30);
            this.top_right_panel.TabIndex = 1;
            this.top_right_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TabMoveCapture);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(157, 30);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TabMoveCapture);
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = global::AudioPlayer.Properties.Resources.exit;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Location = new System.Drawing.Point(190, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(20, 20);
            this.exitButton.TabIndex = 0;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // newSongNameLabel
            // 
            this.newSongNameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newSongNameLabel.Location = new System.Drawing.Point(24, 49);
            this.newSongNameLabel.Name = "newSongNameLabel";
            this.newSongNameLabel.Size = new System.Drawing.Size(173, 19);
            this.newSongNameLabel.TabIndex = 16;
            this.newSongNameLabel.Text = "Enter new song name";
            // 
            // newSongNameBox
            // 
            this.newSongNameBox.Location = new System.Drawing.Point(28, 80);
            this.newSongNameBox.Name = "newSongNameBox";
            this.newSongNameBox.Size = new System.Drawing.Size(169, 20);
            this.newSongNameBox.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AudioPlayer.Properties.Resources.apply;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(69, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 37);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // RenameSongLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(220, 170);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.newSongNameLabel);
            this.Controls.Add(this.newSongNameBox);
            this.Controls.Add(this.top_right_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RenameSongLabel";
            this.Text = "AddSong";
            this.top_right_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.Panel top_right_panel;
        private System.Windows.Forms.Label newSongNameLabel;
        private System.Windows.Forms.TextBox newSongNameBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}