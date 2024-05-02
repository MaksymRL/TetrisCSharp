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
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Punteggio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Statistiche = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(925, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "INSERISCI NICKNAME";
            // 
            // txt_nickname
            // 
            this.txt_nickname.Location = new System.Drawing.Point(605, 309);
            this.txt_nickname.Name = "txt_nickname";
            this.txt_nickname.Size = new System.Drawing.Size(739, 20);
            this.txt_nickname.TabIndex = 5;
            // 
            // b_gioca
            // 
            this.b_gioca.BackColor = System.Drawing.Color.Navy;
            this.b_gioca.FlatAppearance.BorderSize = 0;
            this.b_gioca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_gioca.Font = new System.Drawing.Font("Yu Gothic UI", 40F, System.Drawing.FontStyle.Bold);
            this.b_gioca.ForeColor = System.Drawing.Color.Yellow;
            this.b_gioca.Location = new System.Drawing.Point(605, 386);
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
            this.pictureBox1.Location = new System.Drawing.Point(605, 0);
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
            this.b_esci.Location = new System.Drawing.Point(605, 592);
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
            this.Nome,
            this.Punteggio,
            this.Statistiche});
            this.leaderboard.ForeColor = System.Drawing.Color.Yellow;
            this.leaderboard.HideSelection = false;
            this.leaderboard.Location = new System.Drawing.Point(1, -5);
            this.leaderboard.Name = "leaderboard";
            this.leaderboard.Size = new System.Drawing.Size(598, 334);
            this.leaderboard.TabIndex = 12;
            this.leaderboard.UseCompatibleStateImageBehavior = false;
            this.leaderboard.View = System.Windows.Forms.View.Details;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 200;
            // 
            // Punteggio
            // 
            this.Punteggio.Text = "Punteggio";
            this.Punteggio.Width = 200;
            // 
            // Statistiche
            // 
            this.Statistiche.Text = "Statistiche";
            this.Statistiche.Width = 200;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ProgettoFineAnno.Properties.Resources.sfondo;
            this.ClientSize = new System.Drawing.Size(1428, 837);
            this.Controls.Add(this.leaderboard);
            this.Controls.Add(this.b_esci);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nickname);
            this.Controls.Add(this.b_gioca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Punteggio;
        private System.Windows.Forms.ColumnHeader Statistiche;
    }
}