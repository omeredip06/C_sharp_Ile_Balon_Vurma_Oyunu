
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enes_proje
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string kullanici_adi;
        int asama=0, skor=0, ok_adedi = 50, yesil_sayac = 20,sari_sayac=6,kirmizi_sayac=6;
        Random rnd = new Random();
        int x;

        void kaydet()
        {
            string JsonOkunanData = File.ReadAllText(@"players_information\All_Information.json");
            List<Kullanici> okunanJson = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Kullanici>>(JsonOkunanData);
            foreach (var item in okunanJson)
            {
                if (item.ID.Equals(kullanici_adi))
                {
                    item.asama = Convert.ToInt32(label5.Text);
                    item.score = Convert.ToInt32(score_label.Text);
                }
                else
                {
                    continue;
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            yesil_balon.ImageLocation = @"standarts\yesilBalon.png";
            sari_balon.ImageLocation = @" standarts\sariBalon.png";
            kirmizi_balon.ImageLocation = @"standarts\kirmiziBalon.png";
            label1.Visible = false;
            kullanici_adi = label1.Text;
            string JsonOkunanData = File.ReadAllText(@"players_information\All_Information.json");
            List<Kullanici> okunanJson = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Kullanici>>(JsonOkunanData);
            foreach (var item in okunanJson)
            {
                if (item.ID.Equals(kullanici_adi))
                {
                    label1.Text = item.arrower_image;
                    this.BackgroundImage = Image.FromFile(item.background_image);
                    arrower_picturebox.ImageLocation = item.arrower_image;
                    arrower_picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
                    asama = item.asama;
                    skor = item.score;
                }
                else
                {
                    continue;
                }
                label3.Text = ok_adedi.ToString();
            }
        }

        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                if (ok_adedi > 0)
                {
                    arrow_picturebox.Left = arrower_picturebox.Left;
                    ok_adedi -= 1;
                    label3.Text = ok_adedi.ToString();
                }
                else
                {
                    MessageBox.Show("Oklarınız Bitti. Oyun Bitti.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Form2 form2 = new Form2();
                    form2.score.Text = score_label.Text;
                    form2.asama_lbl.Text = label5.Text;
                    kaydet();
                }
            }
            if(e.KeyCode==Keys.Up)
            {
                if(arrower_picturebox.Top > 50)
                {
                    arrower_picturebox.Top -= 5;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (arrower_picturebox.Top < 200)
                {
                    arrower_picturebox.Top += 5;
                }
            }
        }

        

        void yesil_Balloon()
        {
            
            if (yesil_balon.Top > 500)
            {
                yesil_balon.Top = 30;
                x = rnd.Next(200, 600);
                yesil_balon.Location = new Point(x, 30);
                yesil_sayac--;
                if (yesil_balon.Location.Y==30)
                {
                    timer1.Stop();
                    MessageBox.Show("Balon Yere Ulaştı. Oyun Bitti!", "Başarısız!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    kaydet();
                    this.Close();
                }
                
            }
            else
            {
                yesil_balon.Top += 8;
            }
        }

        void sari_Balloon()
        {
            sari_balon.Visible = true;
            if (sari_balon.Top > 500)
            {
                sari_balon.Top = 30;
                x = rnd.Next(200, 600);
                sari_balon.Location = new Point(x, 30);
                if (sari_balon.Location.Y == 30)
                {
                    timer1.Stop();
                    MessageBox.Show("Balon Yere Ulaştı.", "Başarısız!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    kaydet();
                    this.Close();
                }
            }
            else
            {
                sari_balon.Top += 6;
            }
        }

        void kirmizi_Balloon()
        {
            kirmizi_balon.Visible = true;
            if (kirmizi_balon.Top > 500)
            {
                kirmizi_balon.Top = 30;
                x = rnd.Next(200, 600);
                kirmizi_balon.Location = new Point(x, 30);
            }
            else
            {
                kirmizi_balon.Top += 4;
            }
        }

        void score_kontrol()
        {
            if (arrow_picturebox.Bounds.IntersectsWith(yesil_balon.Bounds))
            {
                yesil_balon.Top = 30;
                skor += 5;
                score_label.Text = skor.ToString();
                arrow_picturebox.ImageLocation = @"standarts\patlamaEfekti.png";
                x = rnd.Next(200, 600);
                yesil_balon.Location = new Point(x, 50);
                yesil_sayac--;
                if (yesil_sayac == 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Balonlar Bitti. Aşama 2'ye Geçildi!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    asama = 2;
                    kaydet();
                }
            }
            if (arrow_picturebox.Bounds.IntersectsWith(sari_balon.Bounds))
            {
                sari_balon.Top = 30;
                skor += 15;
                score_label.Text = skor.ToString();
                arrow_picturebox.ImageLocation = @"standarts\patlamaEfekti.png";
                x = rnd.Next(200, 600);
                sari_balon.Location = new Point(x, 50);
                sari_sayac--;
                if (sari_sayac == 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Balonlar Bitti. Aşama 3'e Geçildi!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    asama = 3;
                    kaydet();
                }
            }
            if (arrow_picturebox.Bounds.IntersectsWith(kirmizi_balon.Bounds))
            {
                kirmizi_balon.Top = 30;
                skor = 0;
                score_label.Text = skor.ToString();
                arrow_picturebox.ImageLocation = @"standarts\patlamaEfekti.png";
                x = rnd.Next(200, 600);
                kirmizi_balon.Location = new Point(x, 50);
                kirmizi_sayac--;
                if (kirmizi_sayac == 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Balonlar Bitti. Oyunu Kazandınız!!", "Tebrikler!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    kaydet();
                    this.Close();
                }
            }
            timer1.Start();
        }
        void Shoot()
        {
            arrow_picturebox.Left += 100;
            if (arrow_picturebox.Left > 600)
            {
                arrow_picturebox.Top = arrower_picturebox.Top + 20;
            }
            arrow_picturebox.ImageLocation = @"standarts\ok.png";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Shoot();
            if (asama == 0)
            {

            }
            else if (asama == 1)
            {
                label5.Text = asama.ToString();
                yesil_Balloon();
            }
            else if (asama==2)
            {
                label5.Text = asama.ToString();
                yesil_Balloon();
                sari_Balloon();
            }
            else
            {
                label5.Text = asama.ToString();
                yesil_Balloon();
                sari_Balloon();
                kirmizi_Balloon();
            }
            
            score_kontrol();
        }
    }
}
