namespace MyHardestGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startTimer = new System.Windows.Forms.Timer(this.components);
            this.welcomeTo = new System.Windows.Forms.Label();
            this.gameName = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // startTimer
            // 
            this.startTimer.Enabled = true;
            this.startTimer.Interval = 1000;
            this.startTimer.Tick += new System.EventHandler(this.startTimer_Tick);
            // 
            // welcomeTo
            // 
            this.welcomeTo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomeTo.AutoSize = true;
            this.welcomeTo.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcomeTo.Location = new System.Drawing.Point(300, 132);
            this.welcomeTo.Name = "welcomeTo";
            this.welcomeTo.Size = new System.Drawing.Size(230, 47);
            this.welcomeTo.TabIndex = 0;
            this.welcomeTo.Text = "Welcome to...";
            // 
            // gameName
            // 
            this.gameName.AutoSize = true;
            this.gameName.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gameName.Location = new System.Drawing.Point(110, 179);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(599, 86);
            this.gameName.TabIndex = 1;
            this.gameName.Text = "My Hardest Game!";
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startBtn.Location = new System.Drawing.Point(341, 288);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(123, 47);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // mainTimer
            // 
            this.mainTimer.Enabled = true;
            this.mainTimer.Interval = 20;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.gameName);
            this.Controls.Add(this.welcomeTo);
            this.Name = "Form1";
            this.Text = "My Hardest Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer startTimer;
        private Label welcomeTo;
        private Label gameName;
        private Button startBtn;
        private System.Windows.Forms.Timer mainTimer;
    }
}