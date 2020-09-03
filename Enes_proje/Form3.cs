

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

    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void background_image_button_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog background_image = new OpenFileDialog();
            background_image.Filter = "Bitmaps|*.bmp|PNG files|*.png|JPEG files|*.jpg|GIF files|*.gif|TIFF files|*.tif|Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*";
            background_image.ShowDialog();
            label2.Text = background_image.FileName;
        }

        private void arrower_image_select_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog arrower_image = new OpenFileDialog();
            arrower_image.Filter = "Bitmaps|*.bmp|PNG files|*.png|JPEG files|*.jpg|GIF files|*.gif|TIFF files|*.tif|Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*";
            arrower_image.ShowDialog();
            label3.Text = arrower_image.FileName;
        }

        public void new_player_save_button_Click(object sender, EventArgs e)
        {
            
            if (Directory.Exists(@"players_information\"))
            {
                // ilgili klasor var ise herhangi bir işlem yapmıyoruz. 
            }
            else
            {
                Directory.CreateDirectory(@"players_information\");
            }
            if (id_textbox.Text.ToString()=="")
            {
                MessageBox.Show("Lütfen bir kullanıcı adı giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TextBoxKontrol(id_textbox.Text.ToString()) == 0)
            {
                MessageBox.Show("Aynı ID'ye sahip başka bir oyuncu var. Lütfen başka bir ad giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 
                List<Kullanici> Kullaniciler = new List<Kullanici>();

                Kullanici k1 = new Kullanici();
                k1.ID = id_textbox.Text.ToString();
                if(label2.Text.ToString().Equals("---") || label2.Text.ToString().Equals(""))
                {
                    k1.background_image = @"standarts\standart_renk.png";
                }
                else
                {
                    k1.background_image = @label2.Text.ToString();
                }
                if (label3.Text.ToString().Equals("---") || label3.Text.Equals(""))
                {
                    k1.arrower_image = @"standarts\okcu.png";
                }
                else
                {
                    k1.arrower_image = @label3.Text.ToString();
                }
                k1.asama = 1;
                k1.score = 0;

                Kullaniciler.Add(k1);
                if (Directory.Exists(@"players_information\"))
                {
                    // ilgili klasor var ise herhangi bir işlem yapmıyoruz. 
                }
                else
                {
                    Directory.CreateDirectory(@"players_information\");
                }

                string JsonKullaniciler = Newtonsoft.Json.JsonConvert.SerializeObject(Kullaniciler);
                File.WriteAllText(@"players_information\All_Information.json", JsonKullaniciler);
                
                if(MessageBox.Show("Kullanıcı Başarı İle Kaydedildi!", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)==DialogResult.OK)
                {
                    this.Hide();
                }
            }
        }

        public int TextBoxKontrol(string textboxGelen)
        {
            string JsonOkunanData = File.ReadAllText(@"players_information\All_Information.json");

            List<Kullanici> okunanJson = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Kullanici>>(JsonOkunanData);
            if(okunanJson==null)
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
    class Kullanici
    {
        public string ID { get; set; }
        public string background_image{ get; set; }
        public string arrower_image { get; set; }
        public int asama { get; set; }
        public int score { get; set; }
    }
}
