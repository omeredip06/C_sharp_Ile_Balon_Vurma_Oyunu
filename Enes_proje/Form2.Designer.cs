namespace Enes_proje
{
    partial class Form2
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
            this.selected_game_start_button = new System.Windows.Forms.Button();
            this.score = new System.Windows.Forms.Label();
            this.score_label = new System.Windows.Forms.Label();
            this.player_name_label = new System.Windows.Forms.Label();
            this.new_game_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.asama_lbl = new System.Windows.Forms.Label();
            this.cikis_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selected_game_start_button
            // 
            this.selected_game_start_button.Location = new System.Drawing.Point(261, 116);
            this.selected_game_start_button.Name = "selected_game_start_button";
            this.selected_game_start_button.Size = new System.Drawing.Size(137, 45);
            this.selected_game_start_button.TabIndex = 15;
            this.selected_game_start_button.Text = "Önceki Oyuna Devam Et";
            this.selected_game_start_button.UseVisualStyleBackColor = true;
            this.selected_game_start_button.Click += new System.EventHandler(this.selected_game_start_button_Click);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.score.Location = new System.Drawing.Point(316, 30);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(26, 29);
            this.score.TabIndex = 12;
            this.score.Text = "0";
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.score_label.Location = new System.Drawing.Point(241, 30);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(69, 29);
            this.score_label.TabIndex = 11;
            this.score_label.Text = "Skor:";
            // 
            // player_name_label
            // 
            this.player_name_label.AutoSize = true;
            this.player_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.player_name_label.Location = new System.Drawing.Point(65, 30);
            this.player_name_label.Name = "player_name_label";
            this.player_name_label.Size = new System.Drawing.Size(149, 29);
            this.player_name_label.TabIndex = 10;
            this.player_name_label.Text = "Yeni Oyuncu";
            // 
            // new_game_button
            // 
            this.new_game_button.Location = new System.Drawing.Point(70, 110);
            this.new_game_button.Name = "new_game_button";
            this.new_game_button.Size = new System.Drawing.Size(107, 56);
            this.new_game_button.TabIndex = 9;
            this.new_game_button.Text = "Yeni Oyun";
            this.new_game_button.UseVisualStyleBackColor = true;
            this.new_game_button.Click += new System.EventHandler(this.new_game_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(384, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Aşama:";
            // 
            // asama_lbl
            // 
            this.asama_lbl.AutoSize = true;
            this.asama_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.asama_lbl.Location = new System.Drawing.Point(482, 30);
            this.asama_lbl.Name = "asama_lbl";
            this.asama_lbl.Size = new System.Drawing.Size(26, 29);
            this.asama_lbl.TabIndex = 17;
            this.asama_lbl.Text = "0";
            // 
            // cikis_button
            // 
            this.cikis_button.Location = new System.Drawing.Point(508, 230);
            this.cikis_button.Name = "cikis_button";
            this.cikis_button.Size = new System.Drawing.Size(75, 23);
            this.cikis_button.TabIndex = 18;
            this.cikis_button.Text = "ÇIKIŞ";
            this.cikis_button.UseVisualStyleBackColor = true;
            this.cikis_button.Click += new System.EventHandler(this.cikis_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 277);
            this.Controls.Add(this.cikis_button);
            this.Controls.Add(this.asama_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selected_game_start_button);
            this.Controls.Add(this.score);
            this.Controls.Add(this.score_label);
            this.Controls.Add(this.player_name_label);
            this.Controls.Add(this.new_game_button);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selected_game_start_button;
        private System.Windows.Forms.Button new_game_button;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label asama_lbl;
        public System.Windows.Forms.Label score;
        public System.Windows.Forms.Label score_label;
        public System.Windows.Forms.Label player_name_label;
        private System.Windows.Forms.Button cikis_button;
    }
}