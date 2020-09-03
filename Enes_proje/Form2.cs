

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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Form4 form4 = new Form4();


        public void new_game_button_Click(object sender, EventArgs e)
        {
            
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Eski skorunuz sıfırlanacaktır! Devam etmek istiyor musunuz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                string JsonOkunanData = File.ReadAllText(@"players_information\All_Information.json");
                List<Kullanici> okunanJson = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Kullanici>>(JsonOkunanData);
                foreach (var item in okunanJson)
                {
                    if (item.ID.Equals(player_name_label.Text))
                    {
                        item.score = 0;
                        item.asama = 1;
                    }
                    else
                    {
                        continue;
                    }
                }
                form4.label1.Text = player_name_label.Text;
                form4.ShowDialog();
                form4.timer1.Stop();
                
            }
            else
            {
                MessageBox.Show("Oyun Başlatılmadı.");
            }
        }

        private void selected_game_start_button_Click(object sender, EventArgs e)
        {
            string JsonOkunanData = File.ReadAllText(@"players_information\All_Information.json");
            List<Kullanici> okunanJson = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Kullanici>>(JsonOkunanData);
            foreach (var item in okunanJson)
            {
                if (item.ID.Equals(player_name_label.Text))
                {
                    score.Text=item.score.ToString();
                    asama_lbl.Text= item.asama.ToString();
                }
                else
                {
                    continue;
                }
            }
            form4.label1.Text = player_name_label.Text;
            form4.timer1.Start();
            form4.ShowDialog();
        }

        private void cikis_button_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
            
        }
    }
}
