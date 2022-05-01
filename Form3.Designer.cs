namespace MyHardestGame
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
            this.components = new System.ComponentModel.Container();
            this.delima = new System.Windows.Forms.PictureBox();
            this.delimaTimer = new System.Windows.Forms.Timer(this.components);
            this.limaSpawnTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.duterte = new System.Windows.Forms.PictureBox();
            this.duterteTimer = new System.Windows.Forms.Timer(this.components);
            this.duterteLifeLabel = new System.Windows.Forms.Label();
            this.duterteFlipTimer = new System.Windows.Forms.Timer(this.components);
            this.levelTimer = new System.Windows.Forms.Timer(this.components);
            this.levelTimeLabel = new System.Windows.Forms.Label();
            this.finalTimer = new System.Windows.Forms.Timer(this.components);
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.youWonLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.delima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duterte)).BeginInit();
            this.SuspendLayout();
            // 
            // delima
            // 
            this.delima.Image = global::MyHardestGame.Properties.Resources.delima;
            this.delima.Location = new System.Drawing.Point(688, 12);
            this.delima.Name = "delima";
            this.delima.Size = new System.Drawing.Size(100, 100);
            this.delima.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.delima.TabIndex = 0;
            this.delima.TabStop = false;
            // 
            // delimaTimer
            // 
            this.delimaTimer.Enabled = true;
            this.delimaTimer.Interval = 20;
            this.delimaTimer.Tick += new System.EventHandler(this.delimaTimer_Tick);
            // 
            // limaSpawnTimer
            // 
            this.limaSpawnTimer.Enabled = true;
            this.limaSpawnTimer.Interval = 250;
            this.limaSpawnTimer.Tick += new System.EventHandler(this.limaSpawnTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(475, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 71);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // duterte
            // 
            this.duterte.Image = global::MyHardestGame.Properties.Resources.duterte;
            this.duterte.Location = new System.Drawing.Point(12, 12);
            this.duterte.Name = "duterte";
            this.duterte.Size = new System.Drawing.Size(54, 76);
            this.duterte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.duterte.TabIndex = 2;
            this.duterte.TabStop = false;
            // 
            // duterteTimer
            // 
            this.duterteTimer.Enabled = true;
            this.duterteTimer.Interval = 20;
            this.duterteTimer.Tick += new System.EventHandler(this.duterteTimer_Tick);
            // 
            // duterteLifeLabel
            // 
            this.duterteLifeLabel.AutoSize = true;
            this.duterteLifeLabel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.duterteLifeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.duterteLifeLabel.Location = new System.Drawing.Point(322, 9);
            this.duterteLifeLabel.Name = "duterteLifeLabel";
            this.duterteLifeLabel.Size = new System.Drawing.Size(137, 54);
            this.duterteLifeLabel.TabIndex = 3;
            this.duterteLifeLabel.Text = "label2";
            // 
            // duterteFlipTimer
            // 
            this.duterteFlipTimer.Interval = 20;
            this.duterteFlipTimer.Tick += new System.EventHandler(this.duterteFlipTimer_Tick);
            // 
            // levelTimer
            // 
            this.levelTimer.Enabled = true;
            this.levelTimer.Interval = 1000;
            this.levelTimer.Tick += new System.EventHandler(this.levelTimer_Tick);
            // 
            // levelTimeLabel
            // 
            this.levelTimeLabel.AutoSize = true;
            this.levelTimeLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.levelTimeLabel.ForeColor = System.Drawing.Color.Green;
            this.levelTimeLabel.Location = new System.Drawing.Point(328, 55);
            this.levelTimeLabel.Name = "levelTimeLabel";
            this.levelTimeLabel.Size = new System.Drawing.Size(124, 28);
            this.levelTimeLabel.TabIndex = 4;
            this.levelTimeLabel.Text = "Seconds: 60";
            // 
            // finalTimer
            // 
            this.finalTimer.Interval = 1000;
            this.finalTimer.Tick += new System.EventHandler(this.finalTimer_Tick);
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.Font = new System.Drawing.Font("Segoe UI", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gameOverLabel.ForeColor = System.Drawing.Color.Red;
            this.gameOverLabel.Location = new System.Drawing.Point(173, 180);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(449, 89);
            this.gameOverLabel.TabIndex = 5;
            this.gameOverLabel.Text = "GAME OVER!";
            this.gameOverLabel.Visible = false;
            // 
            // youWonLabel
            // 
            this.youWonLabel.AutoSize = true;
            this.youWonLabel.Font = new System.Drawing.Font("Segoe UI", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.youWonLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.youWonLabel.Location = new System.Drawing.Point(212, 180);
            this.youWonLabel.Name = "youWonLabel";
            this.youWonLabel.Size = new System.Drawing.Size(387, 89);
            this.youWonLabel.TabIndex = 6;
            this.youWonLabel.Text = "YOU WON!";
            this.youWonLabel.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.youWonLabel);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.levelTimeLabel);
            this.Controls.Add(this.duterteLifeLabel);
            this.Controls.Add(this.duterte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delima);
            this.Name = "Form3";
            this.Text = "Level 2: Avoid De Lima";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.delima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duterte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox delima;
        private System.Windows.Forms.Timer delimaTimer;
        private System.Windows.Forms.Timer limaSpawnTimer;
        private Label label1;
        private PictureBox duterte;
        private System.Windows.Forms.Timer duterteTimer;
        private Label duterteLifeLabel;
        private System.Windows.Forms.Timer duterteFlipTimer;
        private System.Windows.Forms.Timer levelTimer;
        private Label levelTimeLabel;
        private System.Windows.Forms.Timer finalTimer;
        private Label gameOverLabel;
        private Label youWonLabel;
    }
}