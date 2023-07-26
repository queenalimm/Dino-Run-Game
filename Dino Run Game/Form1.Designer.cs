namespace Dino_Run_Game
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            dino = new PictureBox();
            txtScore = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            txtRestart = new Label();
            txtHighScore = new Label();
            txtHighScoreValue = new Label();
            pictureBox5 = new PictureBox();
            pictureBox2 = new PictureBox();
            bird = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dino).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bird).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Location = new Point(-10, 363);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(819, 95);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dino
            // 
            dino.BackColor = Color.Transparent;
            dino.Image = Properties.Resources.running;
            dino.Location = new Point(107, 320);
            dino.Name = "dino";
            dino.Size = new Size(40, 43);
            dino.SizeMode = PictureBoxSizeMode.AutoSize;
            dino.TabIndex = 1;
            dino.TabStop = false;
            // 
            // txtScore
            // 
            txtScore.AutoSize = true;
            txtScore.BackColor = Color.Transparent;
            txtScore.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtScore.Location = new Point(661, 27);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(90, 33);
            txtScore.TabIndex = 2;
            txtScore.Text = "00000";
            // 
            // gameTimer
            // 
            gameTimer.Interval = 20;
            gameTimer.Tick += MainGameTimerEvent;
            // 
            // txtRestart
            // 
            txtRestart.AutoSize = true;
            txtRestart.BackColor = Color.Transparent;
            txtRestart.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtRestart.ForeColor = Color.Black;
            txtRestart.Location = new Point(183, 186);
            txtRestart.Name = "txtRestart";
            txtRestart.Size = new Size(0, 33);
            txtRestart.TabIndex = 3;
            // 
            // txtHighScore
            // 
            txtHighScore.AutoSize = true;
            txtHighScore.BackColor = Color.Transparent;
            txtHighScore.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtHighScore.Location = new Point(514, 27);
            txtHighScore.Name = "txtHighScore";
            txtHighScore.Size = new Size(45, 33);
            txtHighScore.TabIndex = 4;
            txtHighScore.Text = "HI";
            // 
            // txtHighScoreValue
            // 
            txtHighScoreValue.AutoSize = true;
            txtHighScoreValue.BackColor = Color.Transparent;
            txtHighScoreValue.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtHighScoreValue.Location = new Point(565, 27);
            txtHighScoreValue.Name = "txtHighScoreValue";
            txtHighScoreValue.Size = new Size(90, 33);
            txtHighScoreValue.TabIndex = 5;
            txtHighScoreValue.Text = "00000";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = Properties.Resources.Cactus_Large_Single;
            pictureBox5.Location = new Point(523, 317);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(61, 46);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            pictureBox5.Tag = "obstacle";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.Cactus_Small_Doube1;
            pictureBox2.Location = new Point(246, 319);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "obstacle";
            // 
            // bird
            // 
            bird.BackColor = Color.Transparent;
            bird.Image = Properties.Resources.Bird_02;
            bird.Location = new Point(762, 168);
            bird.Name = "bird";
            bird.Size = new Size(57, 58);
            bird.SizeMode = PictureBoxSizeMode.Zoom;
            bird.TabIndex = 11;
            bird.TabStop = false;
            bird.Tag = "obstacle";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(txtRestart);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox5);
            Controls.Add(txtHighScoreValue);
            Controls.Add(txtHighScore);
            Controls.Add(txtScore);
            Controls.Add(dino);
            Controls.Add(bird);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = " Dinosaur Runner Game";
            KeyDown += keyisdown;
            KeyUp += keyisup;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dino).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bird).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox dino;
        private Label txtScore;
        private System.Windows.Forms.Timer gameTimer;
        private Label txtRestart;
        private Label txtHighScore;
        private Label txtHighScoreValue;
        private PictureBox pictureBox5;
        private PictureBox pictureBox2;
        private PictureBox bird;
    }
}