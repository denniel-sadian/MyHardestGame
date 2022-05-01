namespace MyHardestGame
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
            this.components = new System.ComponentModel.Container();
            this.duterte = new System.Windows.Forms.PictureBox();
            this.duterteTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bulletTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.respawnTimer = new System.Windows.Forms.Timer(this.components);
            this.livesLabel = new System.Windows.Forms.Label();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.finalTimer = new System.Windows.Forms.Timer(this.components);
            this.leni = new System.Windows.Forms.PictureBox();
            this.wonLabel = new System.Windows.Forms.Label();
            this.saveMeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.duterte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leni)).BeginInit();
            this.SuspendLayout();
            // 
            // duterte
            // 
            this.duterte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.duterte.Image = global::MyHardestGame.Properties.Resources.duterte_hearts;
            this.duterte.Location = new System.Drawing.Point(12, 342);
            this.duterte.Name = "duterte";
            this.duterte.Size = new System.Drawing.Size(62, 96);
            this.duterte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.duterte.TabIndex = 0;
            this.duterte.TabStop = false;
            // 
            // duterteTimer
            // 
            this.duterteTimer.Enabled = true;
            this.duterteTimer.Interval = 20;
            this.duterteTimer.Tick += new System.EventHandler(this.duterteTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyHardestGame.Properties.Resources.bullet;
            this.pictureBox1.Location = new System.Drawing.Point(269, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "bullet";
            // 
            // bulletTimer
            // 
            this.bulletTimer.Enabled = true;
            this.bulletTimer.Interval = 20;
            this.bulletTimer.Tick += new System.EventHandler(this.bulletTimer_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MyHardestGame.Properties.Resources.bullet;
            this.pictureBox2.Location = new System.Drawing.Point(337, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "bullet";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MyHardestGame.Properties.Resources.bullet;
            this.pictureBox3.Location = new System.Drawing.Point(485, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(15, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "bullet";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::MyHardestGame.Properties.Resources.bullet;
            this.pictureBox4.Location = new System.Drawing.Point(417, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(15, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "bullet";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::MyHardestGame.Properties.Resources.bullet;
            this.pictureBox5.Location = new System.Drawing.Point(551, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(15, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "bullet";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::MyHardestGame.Properties.Resources.bullet;
            this.pictureBox6.Location = new System.Drawing.Point(202, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(15, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "bullet";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::MyHardestGame.Properties.Resources.bullet;
            this.pictureBox7.Location = new System.Drawing.Point(134, 12);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(15, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 9;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "bullet";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::MyHardestGame.Properties.Resources.bullet;
            this.pictureBox8.Location = new System.Drawing.Point(677, 12);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(15, 50);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "bullet";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::MyHardestGame.Properties.Resources.bullet;
            this.pictureBox9.Location = new System.Drawing.Point(609, 12);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(15, 50);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 7;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "bullet";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::MyHardestGame.Properties.Resources.bullet;
            this.pictureBox10.Location = new System.Drawing.Point(512, 168);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(15, 50);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 18;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "bullet";
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::MyHardestGame.Properties.Resources.bullet;
            this.pictureBox13.Location = new System.Drawing.Point(580, 168);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(15, 50);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 15;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Tag = "bullet";
            // 
            // pictureBox17
            // 
            this.pictureBox17.Image = global::MyHardestGame.Properties.Resources.bullet;
            this.pictureBox17.Location = new System.Drawing.Point(366, 64);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(15, 50);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox17.TabIndex = 11;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Tag = "bullet";
            // 
            // pictureBox18
            // 
            this.pictureBox18.Image = global::MyHardestGame.Properties.Resources.bullet;
            this.pictureBox18.Location = new System.Drawing.Point(647, 168);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(15, 50);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox18.TabIndex = 10;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.Tag = "bullet";
            // 
            // respawnTimer
            // 
            this.respawnTimer.Interval = 1000;
            this.respawnTimer.Tick += new System.EventHandler(this.respawnTimer_Tick);
            // 
            // livesLabel
            // 
            this.livesLabel.AutoSize = true;
            this.livesLabel.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.livesLabel.ForeColor = System.Drawing.Color.Red;
            this.livesLabel.Location = new System.Drawing.Point(12, 12);
            this.livesLabel.Name = "livesLabel";
            this.livesLabel.Size = new System.Drawing.Size(113, 45);
            this.livesLabel.TabIndex = 19;
            this.livesLabel.Text = "label1";
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.Font = new System.Drawing.Font("Segoe UI", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gameOverLabel.ForeColor = System.Drawing.Color.Red;
            this.gameOverLabel.Location = new System.Drawing.Point(197, 168);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(427, 89);
            this.gameOverLabel.TabIndex = 20;
            this.gameOverLabel.Text = "GAME OVER";
            this.gameOverLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // finalTimer
            // 
            this.finalTimer.Interval = 1000;
            this.finalTimer.Tick += new System.EventHandler(this.finalTimer_Tick);
            // 
            // leni
            // 
            this.leni.Image = global::MyHardestGame.Properties.Resources.leni_hearts;
            this.leni.Location = new System.Drawing.Point(719, 326);
            this.leni.Name = "leni";
            this.leni.Size = new System.Drawing.Size(79, 112);
            this.leni.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leni.TabIndex = 21;
            this.leni.TabStop = false;
            // 
            // wonLabel
            // 
            this.wonLabel.AutoSize = true;
            this.wonLabel.Font = new System.Drawing.Font("Segoe UI", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wonLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.wonLabel.Location = new System.Drawing.Point(212, 178);
            this.wonLabel.Name = "wonLabel";
            this.wonLabel.Size = new System.Drawing.Size(387, 89);
            this.wonLabel.TabIndex = 23;
            this.wonLabel.Text = "YOU WON!";
            this.wonLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // saveMeLabel
            // 
            this.saveMeLabel.AutoSize = true;
            this.saveMeLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveMeLabel.ForeColor = System.Drawing.Color.Red;
            this.saveMeLabel.Location = new System.Drawing.Point(683, 293);
            this.saveMeLabel.Name = "saveMeLabel";
            this.saveMeLabel.Size = new System.Drawing.Size(115, 30);
            this.saveMeLabel.TabIndex = 24;
            this.saveMeLabel.Text = "Save me!!!";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveMeLabel);
            this.Controls.Add(this.wonLabel);
            this.Controls.Add(this.leni);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.livesLabel);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.duterte);
            this.Name = "Form2";
            this.Text = "Level 1: Save VP Leni";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.duterte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox duterte;
        private System.Windows.Forms.Timer duterteTimer;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer bulletTimer;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox13;
        private PictureBox pictureBox17;
        private PictureBox pictureBox18;
        private System.Windows.Forms.Timer respawnTimer;
        private Label livesLabel;
        private Label gameOverLabel;
        private System.Windows.Forms.Timer finalTimer;
        private PictureBox leni;
        private Label wonLabel;
        private Label saveMeLabel;
    }
}