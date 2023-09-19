
namespace AudioPlayer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.track_list = new System.Windows.Forms.ListBox();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.ibl_volume = new System.Windows.Forms.Label();
            this.ibl_track_start = new System.Windows.Forms.Label();
            this.ibl_track_end = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_search = new System.Windows.Forms.TextBox();
            this.txt_title = new System.Windows.Forms.Label();
            this.txt_searches = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.pic_art = new System.Windows.Forms.PictureBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.list_favorite = new System.Windows.Forms.ListBox();
            this.track_volume = new AudioPlayer.Volume();
            this.pb_bar = new AudioPlayer.My_ProgressBar();
            this.customComboBox1 = new AudioPlayer.CustomComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).BeginInit();
            this.SuspendLayout();
            // 
            // track_list
            // 
            this.track_list.BackColor = System.Drawing.Color.Black;
            this.track_list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.track_list.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.track_list.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.track_list.ForeColor = System.Drawing.Color.LawnGreen;
            this.track_list.FormattingEnabled = true;
            this.track_list.ItemHeight = 30;
            this.track_list.Location = new System.Drawing.Point(0, 96);
            this.track_list.Name = "track_list";
            this.track_list.Size = new System.Drawing.Size(479, 152);
            this.track_list.TabIndex = 11;
            this.track_list.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.track_list_DrawItem);
            this.track_list.SelectedIndexChanged += new System.EventHandler(this.track_list_SelectedIndexChanged);
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Top;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 0);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(1212, 70);
            this.player.TabIndex = 13;
            this.player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.player_PlayStateChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(516, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Громкость";
            // 
            // ibl_volume
            // 
            this.ibl_volume.AutoSize = true;
            this.ibl_volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ibl_volume.ForeColor = System.Drawing.SystemColors.Window;
            this.ibl_volume.Location = new System.Drawing.Point(538, 321);
            this.ibl_volume.Name = "ibl_volume";
            this.ibl_volume.Size = new System.Drawing.Size(39, 17);
            this.ibl_volume.TabIndex = 16;
            this.ibl_volume.Text = "50%";
            // 
            // ibl_track_start
            // 
            this.ibl_track_start.AutoSize = true;
            this.ibl_track_start.Font = new System.Drawing.Font("Agency FB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibl_track_start.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ibl_track_start.Location = new System.Drawing.Point(3, 272);
            this.ibl_track_start.Name = "ibl_track_start";
            this.ibl_track_start.Size = new System.Drawing.Size(42, 21);
            this.ibl_track_start.TabIndex = 17;
            this.ibl_track_start.Text = "00:00";
            // 
            // ibl_track_end
            // 
            this.ibl_track_end.AutoSize = true;
            this.ibl_track_end.Font = new System.Drawing.Font("Agency FB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibl_track_end.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ibl_track_end.Location = new System.Drawing.Point(1140, 272);
            this.ibl_track_end.Name = "ibl_track_end";
            this.ibl_track_end.Size = new System.Drawing.Size(42, 21);
            this.ibl_track_end.TabIndex = 18;
            this.ibl_track_end.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.Black;
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_search.ForeColor = System.Drawing.Color.LawnGreen;
            this.txt_search.Location = new System.Drawing.Point(0, 73);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(310, 22);
            this.txt_search.TabIndex = 25;
            this.txt_search.Text = "Поиск";
            this.txt_search.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.txt_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyUp);
            this.txt_search.MouseLeave += new System.EventHandler(this.txt_search_MouseLeave);
            // 
            // txt_title
            // 
            this.txt_title.AutoSize = true;
            this.txt_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_title.ForeColor = System.Drawing.Color.White;
            this.txt_title.Location = new System.Drawing.Point(481, 70);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(110, 25);
            this.txt_title.TabIndex = 27;
            this.txt_title.Text = "Название: ";
            // 
            // txt_searches
            // 
            this.txt_searches.BackColor = System.Drawing.Color.Black;
            this.txt_searches.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_searches.ForeColor = System.Drawing.Color.LawnGreen;
            this.txt_searches.Location = new System.Drawing.Point(902, 72);
            this.txt_searches.Name = "txt_searches";
            this.txt_searches.Size = new System.Drawing.Size(310, 22);
            this.txt_searches.TabIndex = 29;
            this.txt_searches.Text = "Поиск";
            this.txt_searches.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_searches_MouseClick);
            this.txt_searches.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_searches_KeyUp);
            this.txt_searches.MouseLeave += new System.EventHandler(this.txt_searches_MouseLeave);
            // 
            // btn_delete
            // 
            this.btn_delete.BackgroundImage = global::AudioPlayer.Properties.Resources.waste_garbage_trash_bin_icon_219173;
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_delete.Location = new System.Drawing.Point(1132, 297);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(50, 50);
            this.btn_delete.TabIndex = 32;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackgroundImage = global::AudioPlayer.Properties.Resources.upload_storage_cloud_icon_219241;
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_save.Location = new System.Drawing.Point(1048, 297);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(50, 50);
            this.btn_save.TabIndex = 31;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pic_art
            // 
            this.pic_art.Image = global::AudioPlayer.Properties.Resources._283__2048x1280;
            this.pic_art.Location = new System.Drawing.Point(516, 105);
            this.pic_art.Name = "pic_art";
            this.pic_art.Size = new System.Drawing.Size(184, 155);
            this.pic_art.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_art.TabIndex = 12;
            this.pic_art.TabStop = false;
            // 
            // btn_open
            // 
            this.btn_open.BackgroundImage = global::AudioPlayer.Properties.Resources.folder_explorer_file_icon_219192;
            this.btn_open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_open.Location = new System.Drawing.Point(715, 295);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(50, 50);
            this.btn_open.TabIndex = 9;
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.SystemColors.MenuText;
            this.btn_play.BackgroundImage = global::AudioPlayer.Properties.Resources.multimedia_media_video_play_icon_219208;
            this.btn_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_play.Location = new System.Drawing.Point(125, 294);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(50, 50);
            this.btn_play.TabIndex = 8;
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.BackgroundImage = global::AudioPlayer.Properties.Resources.play_media_pause_stop_icon_219229;
            this.btn_pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pause.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_pause.Location = new System.Drawing.Point(69, 294);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(50, 50);
            this.btn_pause.TabIndex = 7;
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.BackgroundImage = global::AudioPlayer.Properties.Resources.before_play_back_previous_icon_219238;
            this.btn_previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_previous.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_previous.Location = new System.Drawing.Point(13, 294);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(50, 50);
            this.btn_previous.TabIndex = 5;
            this.btn_previous.UseVisualStyleBackColor = true;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackgroundImage = global::AudioPlayer.Properties.Resources.after_play_forward_next_icon_219226;
            this.btn_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_next.Location = new System.Drawing.Point(181, 294);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(50, 50);
            this.btn_next.TabIndex = 4;
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // list_favorite
            // 
            this.list_favorite.BackColor = System.Drawing.Color.Black;
            this.list_favorite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_favorite.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.list_favorite.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_favorite.ForeColor = System.Drawing.Color.LawnGreen;
            this.list_favorite.FormattingEnabled = true;
            this.list_favorite.ItemHeight = 30;
            this.list_favorite.Location = new System.Drawing.Point(744, 94);
            this.list_favorite.Name = "list_favorite";
            this.list_favorite.Size = new System.Drawing.Size(467, 152);
            this.list_favorite.TabIndex = 34;
            this.list_favorite.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.list_favorite_DrawItem);
            this.list_favorite.SelectedIndexChanged += new System.EventHandler(this.list_favorite_SelectedIndexChanged);
            // 
            // track_volume
            // 
            this.track_volume.BackColor = System.Drawing.Color.Black;
            this.track_volume.Bar_color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.track_volume.Location = new System.Drawing.Point(237, 305);
            this.track_volume.Max = 100;
            this.track_volume.Min = 0;
            this.track_volume.Name = "track_volume";
            this.track_volume.Size = new System.Drawing.Size(273, 29);
            this.track_volume.TabIndex = 24;
            this.track_volume.Value = 50;
            this.track_volume.MouseMove += new System.Windows.Forms.MouseEventHandler(this.track_volume_MouseMove);
            // 
            // pb_bar
            // 
            this.pb_bar.BackColor = System.Drawing.Color.White;
            this.pb_bar.Bar_color = System.Drawing.Color.Crimson;
            this.pb_bar.Location = new System.Drawing.Point(53, 279);
            this.pb_bar.Max = 100;
            this.pb_bar.Min = 0;
            this.pb_bar.Name = "pb_bar";
            this.pb_bar.Size = new System.Drawing.Size(1079, 10);
            this.pb_bar.TabIndex = 23;
            this.pb_bar.Value = 0;
            this.pb_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_bar_MouseDown);
            // 
            // customComboBox1
            // 
            this.customComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.customComboBox1.BorderColor = System.Drawing.Color.Black;
            this.customComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customComboBox1.ForeColor = System.Drawing.Color.White;
            this.customComboBox1.IconColor = System.Drawing.Color.White;
            this.customComboBox1.Items.AddRange(new object[] {
            "0,25",
            "0,5",
            "0,75",
            "1",
            "1,25",
            "1,5",
            "1,75",
            "2"});
            this.customComboBox1.ListBackColor = System.Drawing.Color.Black;
            this.customComboBox1.ListTextColor = System.Drawing.Color.White;
            this.customComboBox1.Location = new System.Drawing.Point(608, 310);
            this.customComboBox1.MinimumSize = new System.Drawing.Size(20, 20);
            this.customComboBox1.Name = "customComboBox1";
            this.customComboBox1.Size = new System.Drawing.Size(87, 24);
            this.customComboBox1.TabIndex = 22;
            this.customComboBox1.Texts = "1";
            this.customComboBox1.SelectedIndexChanged += new System.EventHandler(this.customComboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(1212, 355);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.list_favorite);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_searches);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.track_volume);
            this.Controls.Add(this.pb_bar);
            this.Controls.Add(this.customComboBox1);
            this.Controls.Add(this.ibl_track_end);
            this.Controls.Add(this.ibl_track_start);
            this.Controls.Add(this.ibl_volume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pic_art);
            this.Controls.Add(this.track_list);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.btn_next);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zain";
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.ListBox track_list;
        private System.Windows.Forms.PictureBox pic_art;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ibl_volume;
        private System.Windows.Forms.Label ibl_track_start;
        private System.Windows.Forms.Label ibl_track_end;
        private System.Windows.Forms.Timer timer1;
        private CustomComboBox customComboBox1;
        private My_ProgressBar pb_bar;
        private Volume track_volume;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label txt_title;
        private System.Windows.Forms.TextBox txt_searches;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ListBox list_favorite;
    }
}

