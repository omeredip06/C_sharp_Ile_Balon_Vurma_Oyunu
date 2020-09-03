namespace Enes_proje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.enter_game_button = new System.Windows.Forms.Button();
            this.id_textbox = new System.Windows.Forms.TextBox();
            this.new_player_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adını Giriniz";
            // 
            // enter_game_button
            // 
            this.enter_game_button.Location = new System.Drawing.Point(21, 113);
            this.enter_game_button.Name = "enter_game_button";
            this.enter_game_button.Size = new System.Drawing.Size(75, 23);
            this.enter_game_button.TabIndex = 1;
            this.enter_game_button.Text = "Giriş";
            this.enter_game_button.UseVisualStyleBackColor = true;
            this.enter_game_button.Click += new System.EventHandler(this.enter_game_button_Click);
            // 
            // id_textbox
            // 
            this.id_textbox.Location = new System.Drawing.Point(21, 74);
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.Size = new System.Drawing.Size(100, 20);
            this.id_textbox.TabIndex = 2;
            // 
            // new_player_button
            // 
            this.new_player_button.Location = new System.Drawing.Point(111, 113);
            this.new_player_button.Name = "new_player_button";
            this.new_player_button.Size = new System.Drawing.Size(96, 37);
            this.new_player_button.TabIndex = 3;
            this.new_player_button.Text = "Yeni Oyuncu Girişi";
            this.new_player_button.UseVisualStyleBackColor = true;
            this.new_player_button.Click += new System.EventHandler(this.new_player_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 199);
            this.Controls.Add(this.new_player_button);
            this.Controls.Add(this.id_textbox);
            this.Controls.Add(this.enter_game_button);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ok oyunu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button enter_game_button;
        private System.Windows.Forms.Button new_player_button;
        public System.Windows.Forms.TextBox id_textbox;
    }
}

