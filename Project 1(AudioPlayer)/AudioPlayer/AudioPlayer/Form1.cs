using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AudioPlayer
{
    public partial class Form1 : Form
    {
        //
        public Form1()
        {
            InitializeComponent();
            track_volume.Value = 50;
            ibl_volume.Text = "50%";
            Coad();
        }

        //Загрузка песен
        private void Coad()
        {
            list_favorite.Items.Clear();
            String home = ".\\Songs\\";
            points = Directory.GetFiles(home, "*", SearchOption.AllDirectories);
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = System.IO.Path.GetFullPath(points[i]);
            }
            Directory
                .GetFiles(home, "*", SearchOption.AllDirectories)
                .ToList()
                .ForEach(f => list_favorite.Items.Add(Path.GetFileName(f)));
        }

        //Переменные
        String[] paths, files, points;
        Color b_color;
        Color h_color = Color.Crimson;

        //Открытие файлов
        private void btn_open_Click(object sender, EventArgs e)
        {
            if (files == null)
            {
                OpenFileDialog oFD = new OpenFileDialog();
                oFD.Multiselect = true;
                if (oFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    files = oFD.SafeFileNames;
                    paths = oFD.FileNames;
                    for (int x = 0; x < files.Length; x++)
                    {
                        track_list.Items.Add(files[x]);
                    }
                }
            }
            else
            {
                OpenFileDialog oFD = new OpenFileDialog();
                oFD.Multiselect = true;
                if (oFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    track_list.Items.Clear();
                    Array.Resize(ref files, files.Length + oFD.SafeFileNames.Length);
                    Array.Resize(ref paths, paths.Length + oFD.SafeFileNames.Length);
                    int i = 0;
                    for (int x = 0; x < files.Length; x++)
                    {
                        if (files[x] == null)
                        {
                            files[x] = oFD.SafeFileNames[i];
                            paths[x] = oFD.FileNames[i];
                            i++;
                        }
                        track_list.Items.Add(files[x]);
                    }
                }
            }
        }

        //Играть
        private void btn_play_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
        }

        //Пауза
        private void btn_pause_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }

        //Следующая
        private void btn_next_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex < track_list.Items.Count - 1)
            {
                track_list.SelectedIndex = track_list.SelectedIndex + 1;
            }
        }

        //Предыдущая
        private void btn_previous_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex > 0)
            {
                track_list.SelectedIndex = track_list.SelectedIndex - 1;
            }
        }

        //Временная шкала
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                pb_bar.Max = (int)player.Ctlcontrols.currentItem.duration;
                pb_bar.Value = (int)player.Ctlcontrols.currentPosition;
                if (player.Ctlcontrols.currentItem.duration == player.Ctlcontrols.currentPosition)
                {
                    player.Ctlcontrols.currentPosition = 0;
                }
            }
            try
            {
                ibl_track_start.Text = player.Ctlcontrols.currentPositionString;
                if (player.Ctlcontrols.currentItem != null)
                {
                    ibl_track_end.Text = player.Ctlcontrols.currentItem.durationString.ToString();
                }
            }
            catch
            { }
        }

        //Перемотка
        private void pb_bar_MouseDown(object sender, MouseEventArgs e)
        {
            player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / pb_bar.Width;
        }

        //Скорость вопроизведения
        private void customComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.settings.rate = Convert.ToDouble(customComboBox1.SelectedItem);
        }

        //Звук
        private void track_volume_MouseMove(object sender, MouseEventArgs e)
        {
            player.settings.volume = track_volume.Value;
            ibl_volume.Text = track_volume.Value.ToString() + "%";
        }

        //Дизайн списков
        private void track_list_DrawItem(object sender, DrawItemEventArgs e)
        {
            b_color = e.BackColor;
            Color clr = Color.FromArgb(0, b_color);

            if (e.Index >= 0)
            {
                SolidBrush sb = new SolidBrush(((e.State & DrawItemState.Selected) == DrawItemState.Selected) ? h_color : b_color);
                e.Graphics.FillRectangle(sb, e.Bounds);

                string txt = track_list.Items[e.Index].ToString();
                SolidBrush tb = new SolidBrush(e.ForeColor);
                e.Graphics.DrawString(txt, e.Font, tb, track_list.GetItemRectangle(e.Index).Location);
            }
        }
        private void list_favorite_DrawItem(object sender, DrawItemEventArgs e)
        {
            b_color = e.BackColor;
            Color clr = Color.FromArgb(0, b_color);

            if (e.Index >= 0)
            {
                SolidBrush sb = new SolidBrush(((e.State & DrawItemState.Selected) == DrawItemState.Selected) ? h_color : b_color);
                e.Graphics.FillRectangle(sb, e.Bounds);

                string txt = list_favorite.Items[e.Index].ToString();
                SolidBrush tb = new SolidBrush(e.ForeColor);
                e.Graphics.DrawString(txt, e.Font, tb, list_favorite.GetItemRectangle(e.Index).Location);
            }
        }


        //Очищение
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            txt_search.Text = "";
        }
        private void txt_search_MouseLeave(object sender, EventArgs e)
        {
            txt_search.Text = "Поиск";
        }
        private void txt_searches_MouseClick(object sender, MouseEventArgs e)
        {
            txt_searches.Text = "";
        }
        private void txt_searches_MouseLeave(object sender, EventArgs e)
        {
            txt_searches.Text = "Поиск";
        }

        //Поиск
        private void txt_search_KeyUp(object sender, KeyEventArgs e)
        {
            int index = track_list.FindString(txt_search.Text);
            if (0 <= index)
            {
                track_list.SelectedIndex = index;
            }
        }
        private void txt_searches_KeyUp(object sender, KeyEventArgs e)
        {
            int index = list_favorite.FindString(txt_searches.Text);
            if (0 <= index)
            {
                list_favorite.SelectedIndex = index;
            }
        }

        //Сохранить
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (track_list.SelectedItem != null)
                {
                    string path = Path.GetFullPath("./Songs/" + files[track_list.SelectedIndex]);
                    File.Copy(paths[track_list.SelectedIndex], path);
                    Coad();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Песня уже сохранена!",
                    "Ошибка",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error,
                     MessageBoxDefaultButton.Button1);
            }
        }

        //Удаление
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (list_favorite.SelectedItem != null)
            {
                File.Delete(points[list_favorite.SelectedIndex]);
                Coad();
            }
        }


        //Список
        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (track_list.SelectedItem != null)
                {
                    player.URL = paths[track_list.SelectedIndex];
                }
                var file = TagLib.File.Create(paths[track_list.SelectedIndex]);
                byte[] bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                pic_art.Image = Image.FromStream(new MemoryStream(bin));
                txt_title.Text = "Название: " + file.Tag.Title;
            }
            catch { }
        }
        private void list_favorite_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (list_favorite.SelectedItem != null)
                {
                    player.URL = points[list_favorite.SelectedIndex];
                }
                var file = TagLib.File.Create(points[list_favorite.SelectedIndex]);
                byte[] bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                pic_art.Image = Image.FromStream(new MemoryStream(bin));
                txt_title.Text = "Название: " + file.Tag.Title;
            }
            catch { }
        }

        //Зацикливание
        private void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 1)
            {
               player.Ctlcontrols.play();
            }
        }
    }
}
