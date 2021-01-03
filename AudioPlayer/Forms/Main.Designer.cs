namespace AudioPlayer
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.infoLabel = new System.Windows.Forms.Label();
            this.top_right_panel = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.top_left_panel = new System.Windows.Forms.Panel();
            this.tabLogoPicture = new System.Windows.Forms.PictureBox();
            this.trackNameLabel = new System.Windows.Forms.Label();
            this.volumeBar = new System.Windows.Forms.TrackBar();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.volumeIcon = new System.Windows.Forms.PictureBox();
            this.nextButton = new System.Windows.Forms.PictureBox();
            this.previosButton = new System.Windows.Forms.PictureBox();
            this.playButton = new System.Windows.Forms.PictureBox();
            this.left_image = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.createdBy = new System.Windows.Forms.Label();
            this.authorLabel_1 = new System.Windows.Forms.Label();
            this.authorsPanel = new System.Windows.Forms.Panel();
            this.authorLabel_2 = new System.Windows.Forms.Label();
            this.addRadioButton = new System.Windows.Forms.PictureBox();
            this.addMusicButton = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.top_right_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.top_left_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabLogoPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previosButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).BeginInit();
            this.authorsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addMusicButton)).BeginInit();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(28, 27);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(252, 36);
            this.infoLabel.TabIndex = 15;
            this.infoLabel.Text = "My Audio Library";
            // 
            // top_right_panel
            // 
            this.top_right_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(213)))), ((int)(((byte)(216)))));
            this.top_right_panel.Controls.Add(this.minimizeButton);
            this.top_right_panel.Controls.Add(this.exitButton);
            this.top_right_panel.Location = new System.Drawing.Point(474, 0);
            this.top_right_panel.Name = "top_right_panel";
            this.top_right_panel.Size = new System.Drawing.Size(223, 30);
            this.top_right_panel.TabIndex = 0;
            this.top_right_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TabMoveCapture);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackgroundImage = global::AudioPlayer.Properties.Resources.minimize;
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.Location = new System.Drawing.Point(167, 5);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(16, 16);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = global::AudioPlayer.Properties.Resources.exit;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Location = new System.Drawing.Point(197, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(16, 16);
            this.exitButton.TabIndex = 0;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // top_left_panel
            // 
            this.top_left_panel.BackColor = System.Drawing.SystemColors.Control;
            this.top_left_panel.Controls.Add(this.tabLogoPicture);
            this.top_left_panel.Location = new System.Drawing.Point(0, 0);
            this.top_left_panel.Name = "top_left_panel";
            this.top_left_panel.Size = new System.Drawing.Size(474, 30);
            this.top_left_panel.TabIndex = 1;
            this.top_left_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TabMoveCapture);
            // 
            // tabLogoPicture
            // 
            this.tabLogoPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabLogoPicture.BackgroundImage")));
            this.tabLogoPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabLogoPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabLogoPicture.Location = new System.Drawing.Point(0, 0);
            this.tabLogoPicture.Name = "tabLogoPicture";
            this.tabLogoPicture.Size = new System.Drawing.Size(157, 30);
            this.tabLogoPicture.TabIndex = 19;
            this.tabLogoPicture.TabStop = false;
            this.tabLogoPicture.Click += new System.EventHandler(this.tabLogoPicture_Click);
            // 
            // trackNameLabel
            // 
            this.trackNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackNameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trackNameLabel.Location = new System.Drawing.Point(27, 221);
            this.trackNameLabel.Name = "trackNameLabel";
            this.trackNameLabel.Size = new System.Drawing.Size(188, 58);
            this.trackNameLabel.TabIndex = 1;
            this.trackNameLabel.Text = "Music not selected";
            this.trackNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.trackNameLabel.Click += new System.EventHandler(this.trackNameLabel_Click);
            // 
            // volumeBar
            // 
            this.volumeBar.Location = new System.Drawing.Point(53, 395);
            this.volumeBar.Maximum = 100;
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(130, 45);
            this.volumeBar.TabIndex = 3;
            this.volumeBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volumeBar.Value = 100;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(213)))), ((int)(((byte)(216)))));
            this.rightPanel.Controls.Add(this.volumeIcon);
            this.rightPanel.Controls.Add(this.nextButton);
            this.rightPanel.Controls.Add(this.previosButton);
            this.rightPanel.Controls.Add(this.playButton);
            this.rightPanel.Controls.Add(this.volumeBar);
            this.rightPanel.Controls.Add(this.left_image);
            this.rightPanel.Controls.Add(this.trackNameLabel);
            this.rightPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.rightPanel.Location = new System.Drawing.Point(474, 30);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(223, 432);
            this.rightPanel.TabIndex = 14;
            // 
            // volumeIcon
            // 
            this.volumeIcon.BackgroundImage = global::AudioPlayer.Properties.Resources.Volume;
            this.volumeIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.volumeIcon.Location = new System.Drawing.Point(16, 393);
            this.volumeIcon.Name = "volumeIcon";
            this.volumeIcon.Size = new System.Drawing.Size(31, 25);
            this.volumeIcon.TabIndex = 16;
            this.volumeIcon.TabStop = false;
            // 
            // nextButton
            // 
            this.nextButton.BackgroundImage = global::AudioPlayer.Properties.Resources.Right;
            this.nextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nextButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.nextButton.Location = new System.Drawing.Point(155, 335);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(28, 28);
            this.nextButton.TabIndex = 15;
            this.nextButton.TabStop = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            this.nextButton.MouseEnter += new System.EventHandler(this.switchCursor_Enter);
            this.nextButton.MouseLeave += new System.EventHandler(this.switchCursor_Leave);
            // 
            // previosButton
            // 
            this.previosButton.BackgroundImage = global::AudioPlayer.Properties.Resources.Left;
            this.previosButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.previosButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.previosButton.Location = new System.Drawing.Point(53, 335);
            this.previosButton.Name = "previosButton";
            this.previosButton.Size = new System.Drawing.Size(28, 28);
            this.previosButton.TabIndex = 14;
            this.previosButton.TabStop = false;
            this.previosButton.Click += new System.EventHandler(this.previosButton_Click);
            this.previosButton.MouseEnter += new System.EventHandler(this.switchCursor_Enter);
            this.previosButton.MouseLeave += new System.EventHandler(this.switchCursor_Leave);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.BackgroundImage = global::AudioPlayer.Properties.Resources.Play;
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playButton.Location = new System.Drawing.Point(93, 326);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(50, 46);
            this.playButton.TabIndex = 13;
            this.playButton.TabStop = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // left_image
            // 
            this.left_image.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("left_image.BackgroundImage")));
            this.left_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.left_image.Location = new System.Drawing.Point(23, 8);
            this.left_image.Name = "left_image";
            this.left_image.Size = new System.Drawing.Size(188, 200);
            this.left_image.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // createdBy
            // 
            this.createdBy.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdBy.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.createdBy.Location = new System.Drawing.Point(4, 1);
            this.createdBy.Name = "createdBy";
            this.createdBy.Size = new System.Drawing.Size(124, 19);
            this.createdBy.TabIndex = 0;
            this.createdBy.Text = "Created for you by";
            // 
            // authorLabel_1
            // 
            this.authorLabel_1.BackColor = System.Drawing.Color.Transparent;
            this.authorLabel_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.authorLabel_1.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel_1.ForeColor = System.Drawing.Color.Fuchsia;
            this.authorLabel_1.Location = new System.Drawing.Point(134, 0);
            this.authorLabel_1.Name = "authorLabel_1";
            this.authorLabel_1.Size = new System.Drawing.Size(69, 23);
            this.authorLabel_1.TabIndex = 18;
            this.authorLabel_1.Text = "_Demirug_";
            this.authorLabel_1.Click += new System.EventHandler(this.authorLabel_1_Click);
            // 
            // authorsPanel
            // 
            this.authorsPanel.Controls.Add(this.authorLabel_2);
            this.authorsPanel.Controls.Add(this.createdBy);
            this.authorsPanel.Controls.Add(this.authorLabel_1);
            this.authorsPanel.Location = new System.Drawing.Point(92, 429);
            this.authorsPanel.Name = "authorsPanel";
            this.authorsPanel.Size = new System.Drawing.Size(269, 20);
            this.authorsPanel.TabIndex = 20;
            // 
            // authorLabel_2
            // 
            this.authorLabel_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.authorLabel_2.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel_2.ForeColor = System.Drawing.Color.Fuchsia;
            this.authorLabel_2.Location = new System.Drawing.Point(209, 1);
            this.authorLabel_2.Name = "authorLabel_2";
            this.authorLabel_2.Size = new System.Drawing.Size(62, 18);
            this.authorLabel_2.TabIndex = 19;
            this.authorLabel_2.Text = "AnixMoon";
            this.authorLabel_2.Click += new System.EventHandler(this.authorLabel_2_Click);
            // 
            // addRadioButton
            // 
            this.addRadioButton.BackgroundImage = global::AudioPlayer.Properties.Resources.add_radio;
            this.addRadioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addRadioButton.Location = new System.Drawing.Point(384, 33);
            this.addRadioButton.Name = "addRadioButton";
            this.addRadioButton.Size = new System.Drawing.Size(75, 30);
            this.addRadioButton.TabIndex = 21;
            this.addRadioButton.TabStop = false;
            this.addRadioButton.Click += new System.EventHandler(this.addRadioButton_Click);
            // 
            // addMusicButton
            // 
            this.addMusicButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addMusicButton.BackgroundImage = global::AudioPlayer.Properties.Resources.add_music;
            this.addMusicButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addMusicButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addMusicButton.Location = new System.Drawing.Point(286, 33);
            this.addMusicButton.Name = "addMusicButton";
            this.addMusicButton.Size = new System.Drawing.Size(75, 30);
            this.addMusicButton.TabIndex = 19;
            this.addMusicButton.TabStop = false;
            this.addMusicButton.Click += new System.EventHandler(this.addMusicButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.BackgroundImage = global::AudioPlayer.Properties.Resources.Back;
            this.mainPanel.Location = new System.Drawing.Point(18, 83);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(456, 340);
            this.mainPanel.TabIndex = 17;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 461);
            this.Controls.Add(this.addRadioButton);
            this.Controls.Add(this.authorsPanel);
            this.Controls.Add(this.addMusicButton);
            this.Controls.Add(this.top_left_panel);
            this.Controls.Add(this.top_right_panel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.infoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Audio Player";
            this.top_right_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.top_left_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabLogoPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).EndInit();
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previosButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).EndInit();
            this.authorsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addMusicButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel top_right_panel;
        private System.Windows.Forms.Panel top_left_panel;
        private System.Windows.Forms.Label trackNameLabel;
        private System.Windows.Forms.Panel left_image;
        private System.Windows.Forms.TrackBar volumeBar;
        private System.Windows.Forms.PictureBox playButton;
        private System.Windows.Forms.PictureBox previosButton;
        private System.Windows.Forms.PictureBox nextButton;
        private System.Windows.Forms.PictureBox volumeIcon;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.PictureBox minimizeButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label createdBy;
        private System.Windows.Forms.Label authorLabel_1;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.PictureBox addMusicButton;
        private System.Windows.Forms.Panel authorsPanel;
        private System.Windows.Forms.PictureBox addRadioButton;
        private System.Windows.Forms.Label authorLabel_2;
        private System.Windows.Forms.PictureBox tabLogoPicture;
    }
}

