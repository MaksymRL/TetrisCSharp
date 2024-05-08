namespace ProgettoFineAnno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nickname = new System.Windows.Forms.TextBox();
            this.b_gioca = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.b_esci = new System.Windows.Forms.Button();
            this.leaderboard = new System.Windows.Forms.ListView();
            this.Posizione = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Punteggio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Statistiche = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TXT_Top3 = new System.Windows.Forms.TextBox();
            this.TXT_Top1 = new System.Windows.Forms.TextBox();
            this.TXT_Top2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(975, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "INSERISCI NICKNAME";
            // 
            // txt_nickname
            // 
            this.txt_nickname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nickname.Location = new System.Drawing.Point(689, 453);
            this.txt_nickname.MaxLength = 16;
            this.txt_nickname.Name = "txt_nickname";
            this.txt_nickname.Size = new System.Drawing.Size(739, 29);
            this.txt_nickname.TabIndex = 5;
            this.txt_nickname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // b_gioca
            // 
            this.b_gioca.BackColor = System.Drawing.Color.Navy;
            this.b_gioca.FlatAppearance.BorderSize = 0;
            this.b_gioca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_gioca.Font = new System.Drawing.Font("Yu Gothic UI", 40F, System.Drawing.FontStyle.Bold);
            this.b_gioca.ForeColor = System.Drawing.Color.Yellow;
            this.b_gioca.Location = new System.Drawing.Point(689, 530);
            this.b_gioca.Name = "b_gioca";
            this.b_gioca.Size = new System.Drawing.Size(739, 181);
            this.b_gioca.TabIndex = 4;
            this.b_gioca.Text = "GIOCA";
            this.b_gioca.UseVisualStyleBackColor = false;
            this.b_gioca.Click += new System.EventHandler(this.b_gioca_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProgettoFineAnno.Properties.Resources.titolo_tetris;
            this.pictureBox1.Location = new System.Drawing.Point(689, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(739, 260);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // b_esci
            // 
            this.b_esci.BackColor = System.Drawing.Color.Navy;
            this.b_esci.FlatAppearance.BorderSize = 0;
            this.b_esci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_esci.Font = new System.Drawing.Font("Yu Gothic UI", 40F, System.Drawing.FontStyle.Bold);
            this.b_esci.ForeColor = System.Drawing.Color.Yellow;
            this.b_esci.Location = new System.Drawing.Point(689, 736);
            this.b_esci.Name = "b_esci";
            this.b_esci.Size = new System.Drawing.Size(739, 181);
            this.b_esci.TabIndex = 11;
            this.b_esci.Text = "ESCI";
            this.b_esci.UseVisualStyleBackColor = false;
            this.b_esci.Click += new System.EventHandler(this.b_esci_Click);
            // 
            // leaderboard
            // 
            this.leaderboard.BackColor = System.Drawing.Color.Navy;
            this.leaderboard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Posizione,
            this.Nome,
            this.Punteggio,
            this.Statistiche});
            this.leaderboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaderboard.ForeColor = System.Drawing.Color.Yellow;
            this.leaderboard.FullRowSelect = true;
            this.leaderboard.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.leaderboard.HideSelection = false;
            this.leaderboard.Location = new System.Drawing.Point(90, 185);
            this.leaderboard.Name = "leaderboard";
            this.leaderboard.Size = new System.Drawing.Size(584, 732);
            this.leaderboard.TabIndex = 12;
            this.leaderboard.UseCompatibleStateImageBehavior = false;
            this.leaderboard.View = System.Windows.Forms.View.Details;
            this.leaderboard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.leaderboard_MouseClick);
            // 
            // Posizione
            // 
            this.Posizione.Text = "Posizione";
            this.Posizione.Width = 100;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 160;
            // 
            // Punteggio
            // 
            this.Punteggio.Text = "Punteggio";
            this.Punteggio.Width = 160;
            // 
            // Statistiche
            // 
            this.Statistiche.Text = "Statistiche";
            this.Statistiche.Width = 160;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Navy;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Yellow;
            this.textBox1.Location = new System.Drawing.Point(90, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(584, 43);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Leaderboard";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Navy;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Yellow;
            this.textBox2.Location = new System.Drawing.Point(1437, 359);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(475, 43);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "Podio";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ProgettoFineAnno.Properties.Resources.podiotetris_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(125, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(251, 264);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.TXT_Top2);
            this.panel1.Controls.Add(this.TXT_Top1);
            this.panel1.Controls.Add(this.TXT_Top3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1437, 408);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 326);
            this.panel1.TabIndex = 16;
            // 
            // TXT_Top3
            // 
            this.TXT_Top3.BackColor = System.Drawing.Color.Navy;
            this.TXT_Top3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Top3.ForeColor = System.Drawing.Color.Yellow;
            this.TXT_Top3.Location = new System.Drawing.Point(105, 158);
            this.TXT_Top3.Multiline = true;
            this.TXT_Top3.Name = "TXT_Top3";
            this.TXT_Top3.Size = new System.Drawing.Size(128, 20);
            this.TXT_Top3.TabIndex = 17;
            this.TXT_Top3.Text = "Manca";
            this.TXT_Top3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_Top1
            // 
            this.TXT_Top1.BackColor = System.Drawing.Color.Navy;
            this.TXT_Top1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Top1.ForeColor = System.Drawing.Color.Yellow;
            this.TXT_Top1.Location = new System.Drawing.Point(191, 132);
            this.TXT_Top1.Multiline = true;
            this.TXT_Top1.Name = "TXT_Top1";
            this.TXT_Top1.Size = new System.Drawing.Size(129, 20);
            this.TXT_Top1.TabIndex = 19;
            this.TXT_Top1.Text = "Manca";
            this.TXT_Top1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_Top2
            // 
            this.TXT_Top2.BackColor = System.Drawing.Color.Navy;
            this.TXT_Top2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Top2.ForeColor = System.Drawing.Color.Yellow;
            this.TXT_Top2.Location = new System.Drawing.Point(276, 158);
            this.TXT_Top2.Multiline = true;
            this.TXT_Top2.Name = "TXT_Top2";
            this.TXT_Top2.Size = new System.Drawing.Size(131, 20);
            this.TXT_Top2.TabIndex = 20;
            this.TXT_Top2.Text = "Manca";
            this.TXT_Top2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ProgettoFineAnno.Properties.Resources.sfondo;
            this.ClientSize = new System.Drawing.Size(1924, 972);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.leaderboard);
            this.Controls.Add(this.b_esci);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nickname);
            this.Controls.Add(this.b_gioca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nickname;
        private System.Windows.Forms.Button b_gioca;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button b_esci;
        private System.Windows.Forms.ListView leaderboard;
        private System.Windows.Forms.ColumnHeader Posizione;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Punteggio;
        private System.Windows.Forms.ColumnHeader Statistiche;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TXT_Top2;
        private System.Windows.Forms.TextBox TXT_Top1;
        private System.Windows.Forms.TextBox TXT_Top3;
    }
}