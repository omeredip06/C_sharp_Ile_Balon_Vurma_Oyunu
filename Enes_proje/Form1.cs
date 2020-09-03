
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void new_player_button_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void enter_game_button_Click(object sender, EventArgs e)
        {
            if (id_textbox.Text.ToString() == "")
            {
                MessageBox.Show("Lütfen bir kullanıcı adı giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TextBoxKontrol(id_textbox.Text) == 1)
            {
                MessageBox.Show("Kullanıcı Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Giriş Başarılı!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 form2 = new Form2();
                string JsonOkunanData = File.ReadAllText(@"players_information\All_Information.json");
                List<Kullanici> okunanJson = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Kullanici>>(JsonOkunanData);
                foreach (var item in okunanJson)
                {
                    if (item.ID.Equals(id_textbox.Text))
                    {
                        form2.player_name_label.Text = item.ID;
                        form2.score.Text = item.score.ToString();
                        form2.asama_lbl.Text = item.asama.ToString();
                        form2.BackgroundImage = Image.FromFile(item.background_image);
                    }
                    else
                    {
                        continue;
                    }
                }
                form2.Show();
                this.Hide();
            }
        }
        public int TextBoxKontrol(string textboxGelen)
        {
            string JsonOkunanData = File.ReadAllText(@"players_information\All_Information.json");

            List<Kullanici> okunanJson = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Kullanici>>(JsonOkunanData);
            if (okunanJson == null)
            {
                return 1;
            }
            foreach (var item in okunanJson)
            {
                if (item.ID.Equals(textboxGelen))
                {
                    return 0;
                    break;
                }
                else
                {
                    continue;
                }
            }
            return 1;
        }
    }
    
}
