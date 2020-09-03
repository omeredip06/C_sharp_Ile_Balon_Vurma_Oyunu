namespace Enes_proje
{
    partial class Form3
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
            this.new_player_save_button = new System.Windows.Forms.Button();
            this.id_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.background_image_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.arrower_image_select_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // new_player_save_button
            // 
            this.new_player_save_button.Location = new System.Drawing.Point(235, 185);
            this.new_player_save_button.Name = "new_player_save_button";
            this.new_player_save_button.Size = new System.Drawing.Size(75, 23);
            this.new_player_save_button.TabIndex = 0;
            this.new_player_save_button.Text = "KAYDET";
            this.new_player_save_button.UseVisualStyleBackColor = true;
            this.new_player_save_button.Click += new System.EventHandler(this.new_player_save_button_Click);
            // 
            // id_textbox
            // 
            this.id_textbox.Location = new System.Drawing.Point(12, 62);
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.Size = new System.Drawing.Size(100, 20);
            this.id_textbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adınızı Giriniz";
            // 
            // background_image_button
            // 
            this.background_image_button.Location = new System.Drawing.Point(12, 112);
            this.background_image_button.Name = "background_image_button";
            this.background_image_button.Size = new System.Drawing.Size(128, 23);
            this.background_image_button.TabIndex = 3;
            this.background_image_button.Text = "Zemin Resmi Ayarla";
            this.background_image_button.UseVisualStyleBackColor = true;
            this.background_image_button.Click += new System.EventHandler(this.background_image_button_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "---";
            // 
            // arrower_image_select_button
            // 
            this.arrower_image_select_button.Location = new System.Drawing.Point(15, 185);
            this.arrower_image_select_button.Name = "arrower_image_select_button";
            this.arrower_image_select_button.Size = new System.Drawing.Size(128, 23);
            this.arrower_image_select_button.TabIndex = 5;
            this.arrower_image_select_button.Text = "Okçu Resmi Ayarla";
            this.arrower_image_select_button.UseVisualStyleBackColor = true;
            this.arrower_image_select_button.Click += new System.EventHandler(this.arrower_image_select_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "---";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.arrower_image_select_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.background_image_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id_textbox);
            this.Controls.Add(this.new_player_save_button);
            this.Name = "Form3";
            this.Text = "Yeni Oyuncu Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button new_player_save_button;
        private System.Windows.Forms.TextBox id_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button background_image_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button arrower_image_select_button;
        private System.Windows.Forms.Label label3;
    }
}