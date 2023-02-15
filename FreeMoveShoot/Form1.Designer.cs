namespace FreeMoveShoot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblMoving = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.PlayerPiece = new System.Windows.Forms.PictureBox();
            this.BulletRange = new System.Windows.Forms.PictureBox();
            this.Movingzone = new System.Windows.Forms.PictureBox();
            this.picBackGround = new System.Windows.Forms.PictureBox();
            this.SpaceTimer = new System.Windows.Forms.Timer(this.components);
            this.EnemyTimer = new System.Windows.Forms.Timer(this.components);
            this.lblASDWLayout = new System.Windows.Forms.Label();
            this.lblArrowLayout = new System.Windows.Forms.Label();
            this.lblControls = new System.Windows.Forms.Label();
            this.lblOptionsBack = new System.Windows.Forms.Label();
            this.btnMON = new System.Windows.Forms.Label();
            this.btnMOFF = new System.Windows.Forms.Label();
            this.lblMusic = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.PictureBox();
            this.pickillspic = new System.Windows.Forms.PictureBox();
            this.picmadepast = new System.Windows.Forms.PictureBox();
            this.lblMissed = new System.Windows.Forms.Label();
            this.lblMessages = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lstScoreBoard = new System.Windows.Forms.ListView();
            this.colName = new System.Windows.Forms.ColumnHeader();
            this.colScore = new System.Windows.Forms.ColumnHeader();
            this.lblBack = new System.Windows.Forms.Label();
            this.lblReset = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.lblFinalScore = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPiece)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BulletRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Movingzone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickillspic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmadepast)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMoving
            // 
            this.lblMoving.BackColor = System.Drawing.Color.Black;
            this.lblMoving.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMoving.ForeColor = System.Drawing.Color.Red;
            this.lblMoving.Location = new System.Drawing.Point(95, 9);
            this.lblMoving.Name = "lblMoving";
            this.lblMoving.Size = new System.Drawing.Size(142, 72);
            this.lblMoving.TabIndex = 0;
            this.lblMoving.Text = "0";
            this.lblMoving.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimeEvent);
            // 
            // PlayerPiece
            // 
            this.PlayerPiece.Image = ((System.Drawing.Image)(resources.GetObject("PlayerPiece.Image")));
            this.PlayerPiece.Location = new System.Drawing.Point(61, 416);
            this.PlayerPiece.Name = "PlayerPiece";
            this.PlayerPiece.Size = new System.Drawing.Size(164, 90);
            this.PlayerPiece.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerPiece.TabIndex = 1;
            this.PlayerPiece.TabStop = false;
            // 
            // BulletRange
            // 
            this.BulletRange.Location = new System.Drawing.Point(61, 57);
            this.BulletRange.Name = "BulletRange";
            this.BulletRange.Size = new System.Drawing.Size(675, 816);
            this.BulletRange.TabIndex = 3;
            this.BulletRange.TabStop = false;
            this.BulletRange.Visible = false;
            // 
            // Movingzone
            // 
            this.Movingzone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Movingzone.Location = new System.Drawing.Point(351, 368);
            this.Movingzone.Name = "Movingzone";
            this.Movingzone.Size = new System.Drawing.Size(1046, 200);
            this.Movingzone.TabIndex = 6;
            this.Movingzone.TabStop = false;
            this.Movingzone.Visible = false;
            // 
            // picBackGround
            // 
            this.picBackGround.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBackGround.Image = global::FreeMoveShoot.Properties.Resources.Scorespic;
            this.picBackGround.Location = new System.Drawing.Point(909, 57);
            this.picBackGround.Name = "picBackGround";
            this.picBackGround.Size = new System.Drawing.Size(250, 125);
            this.picBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackGround.TabIndex = 7;
            this.picBackGround.TabStop = false;
            this.picBackGround.Visible = false;
            // 
            // SpaceTimer
            // 
            this.SpaceTimer.Enabled = true;
            this.SpaceTimer.Tick += new System.EventHandler(this.SpaceTimer_Tick);
            // 
            // EnemyTimer
            // 
            this.EnemyTimer.Enabled = true;
            this.EnemyTimer.Interval = 20;
            this.EnemyTimer.Tick += new System.EventHandler(this.EnemyTimer_Tick);
            // 
            // lblASDWLayout
            // 
            this.lblASDWLayout.Font = new System.Drawing.Font("Showcard Gothic", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblASDWLayout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblASDWLayout.Location = new System.Drawing.Point(473, 492);
            this.lblASDWLayout.Name = "lblASDWLayout";
            this.lblASDWLayout.Size = new System.Drawing.Size(641, 102);
            this.lblASDWLayout.TabIndex = 8;
            this.lblASDWLayout.Text = "ASDW layout";
            this.lblASDWLayout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblASDWLayout.Visible = false;
            this.lblASDWLayout.Click += new System.EventHandler(this.lblASDWLayout_Click);
            // 
            // lblArrowLayout
            // 
            this.lblArrowLayout.Font = new System.Drawing.Font("Showcard Gothic", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArrowLayout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblArrowLayout.Location = new System.Drawing.Point(473, 368);
            this.lblArrowLayout.Name = "lblArrowLayout";
            this.lblArrowLayout.Size = new System.Drawing.Size(641, 102);
            this.lblArrowLayout.TabIndex = 9;
            this.lblArrowLayout.Text = "Arrow layout";
            this.lblArrowLayout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblArrowLayout.Visible = false;
            this.lblArrowLayout.Click += new System.EventHandler(this.lblArrowLayout_Click);
            // 
            // lblControls
            // 
            this.lblControls.Font = new System.Drawing.Font("Showcard Gothic", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblControls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblControls.Location = new System.Drawing.Point(604, 266);
            this.lblControls.Name = "lblControls";
            this.lblControls.Size = new System.Drawing.Size(388, 102);
            this.lblControls.TabIndex = 10;
            this.lblControls.Text = "Controls";
            this.lblControls.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblControls.Visible = false;
            // 
            // lblOptionsBack
            // 
            this.lblOptionsBack.Font = new System.Drawing.Font("Showcard Gothic", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOptionsBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblOptionsBack.Location = new System.Drawing.Point(659, 666);
            this.lblOptionsBack.Name = "lblOptionsBack";
            this.lblOptionsBack.Size = new System.Drawing.Size(279, 102);
            this.lblOptionsBack.TabIndex = 11;
            this.lblOptionsBack.Text = "Back";
            this.lblOptionsBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOptionsBack.Visible = false;
            this.lblOptionsBack.Click += new System.EventHandler(this.lblOptionsBack_Click);
            // 
            // btnMON
            // 
            this.btnMON.BackColor = System.Drawing.Color.Green;
            this.btnMON.Font = new System.Drawing.Font("Segoe Print", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMON.ForeColor = System.Drawing.Color.Black;
            this.btnMON.Location = new System.Drawing.Point(1262, 324);
            this.btnMON.Name = "btnMON";
            this.btnMON.Size = new System.Drawing.Size(177, 146);
            this.btnMON.TabIndex = 12;
            this.btnMON.Text = "ON";
            this.btnMON.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMON.Visible = false;
            this.btnMON.Click += new System.EventHandler(this.btnMON_Click);
            // 
            // btnMOFF
            // 
            this.btnMOFF.BackColor = System.Drawing.Color.Red;
            this.btnMOFF.Font = new System.Drawing.Font("Segoe Print", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMOFF.ForeColor = System.Drawing.Color.Black;
            this.btnMOFF.Location = new System.Drawing.Point(1262, 492);
            this.btnMOFF.Name = "btnMOFF";
            this.btnMOFF.Size = new System.Drawing.Size(177, 146);
            this.btnMOFF.TabIndex = 13;
            this.btnMOFF.Text = "OFF";
            this.btnMOFF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMOFF.Visible = false;
            this.btnMOFF.Click += new System.EventHandler(this.btnMOFF_Click);
            // 
            // lblMusic
            // 
            this.lblMusic.Font = new System.Drawing.Font("Showcard Gothic", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMusic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblMusic.Location = new System.Drawing.Point(876, 185);
            this.lblMusic.Name = "lblMusic";
            this.lblMusic.Size = new System.Drawing.Size(619, 102);
            this.lblMusic.TabIndex = 14;
            this.lblMusic.Text = "MUSIC";
            this.lblMusic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMusic.Visible = false;
            // 
            // lblHP
            // 
            this.lblHP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lblHP.Image = global::FreeMoveShoot.Properties.Resources.Health3;
            this.lblHP.Location = new System.Drawing.Point(243, -5);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(341, 86);
            this.lblHP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lblHP.TabIndex = 15;
            this.lblHP.TabStop = false;
            this.lblHP.Visible = false;
            // 
            // pickillspic
            // 
            this.pickillspic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pickillspic.Image = global::FreeMoveShoot.Properties.Resources.killspic;
            this.pickillspic.Location = new System.Drawing.Point(2, 5);
            this.pickillspic.Name = "pickillspic";
            this.pickillspic.Size = new System.Drawing.Size(87, 76);
            this.pickillspic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pickillspic.TabIndex = 16;
            this.pickillspic.TabStop = false;
            this.pickillspic.Visible = false;
            // 
            // picmadepast
            // 
            this.picmadepast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picmadepast.Image = global::FreeMoveShoot.Properties.Resources.alien;
            this.picmadepast.Location = new System.Drawing.Point(590, 2);
            this.picmadepast.Name = "picmadepast";
            this.picmadepast.Size = new System.Drawing.Size(87, 76);
            this.picmadepast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picmadepast.TabIndex = 17;
            this.picmadepast.TabStop = false;
            this.picmadepast.Visible = false;
            // 
            // lblMissed
            // 
            this.lblMissed.BackColor = System.Drawing.Color.Black;
            this.lblMissed.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMissed.ForeColor = System.Drawing.Color.Red;
            this.lblMissed.Location = new System.Drawing.Point(683, 2);
            this.lblMissed.Name = "lblMissed";
            this.lblMissed.Size = new System.Drawing.Size(92, 72);
            this.lblMissed.TabIndex = 18;
            this.lblMissed.Text = "0";
            this.lblMissed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMessages
            // 
            this.lblMessages.BackColor = System.Drawing.Color.Black;
            this.lblMessages.Font = new System.Drawing.Font("Algerian", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMessages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblMessages.Location = new System.Drawing.Point(31, 345);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(1544, 277);
            this.lblMessages.TabIndex = 20;
            this.lblMessages.Text = "Level 1\r\nDestroy all incomming enemies";
            this.lblMessages.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMessages.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1310, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 41);
            this.label1.TabIndex = 21;
            this.label1.Text = "label1";
            // 
            // lblStart
            // 
            this.lblStart.Font = new System.Drawing.Font("Showcard Gothic", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblStart.Location = new System.Drawing.Point(659, 666);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(287, 102);
            this.lblStart.TabIndex = 22;
            this.lblStart.Text = "Start";
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStart.Visible = false;
            this.lblStart.Click += new System.EventHandler(this.lblStart_Click);
            // 
            // lstScoreBoard
            // 
            this.lstScoreBoard.BackColor = System.Drawing.Color.Black;
            this.lstScoreBoard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colScore});
            this.lstScoreBoard.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstScoreBoard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lstScoreBoard.FullRowSelect = true;
            this.lstScoreBoard.GridLines = true;
            this.lstScoreBoard.Location = new System.Drawing.Point(557, 292);
            this.lstScoreBoard.MultiSelect = false;
            this.lstScoreBoard.Name = "lstScoreBoard";
            this.lstScoreBoard.Size = new System.Drawing.Size(505, 258);
            this.lstScoreBoard.TabIndex = 23;
            this.lstScoreBoard.UseCompatibleStateImageBehavior = false;
            this.lstScoreBoard.View = System.Windows.Forms.View.Details;
            this.lstScoreBoard.Visible = false;
            // 
            // colName
            // 
            this.colName.Text = "Score Holder";
            this.colName.Width = 250;
            // 
            // colScore
            // 
            this.colScore.Text = "Score";
            this.colScore.Width = 250;
            // 
            // lblBack
            // 
            this.lblBack.Font = new System.Drawing.Font("Showcard Gothic", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblBack.Location = new System.Drawing.Point(505, 666);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(287, 102);
            this.lblBack.TabIndex = 24;
            this.lblBack.Text = "Back";
            this.lblBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBack.Visible = false;
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // lblReset
            // 
            this.lblReset.Font = new System.Drawing.Font("Showcard Gothic", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblReset.Location = new System.Drawing.Point(827, 666);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(287, 102);
            this.lblReset.TabIndex = 25;
            this.lblReset.Text = "Reset";
            this.lblReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblReset.Visible = false;
            this.lblReset.Click += new System.EventHandler(this.lblReset_Click);
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtPlayerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlayerName.Enabled = false;
            this.txtPlayerName.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPlayerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtPlayerName.Location = new System.Drawing.Point(561, 666);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(450, 45);
            this.txtPlayerName.TabIndex = 26;
            this.txtPlayerName.Visible = false;
            // 
            // lblFinalScore
            // 
            this.lblFinalScore.BackColor = System.Drawing.Color.Black;
            this.lblFinalScore.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFinalScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblFinalScore.Location = new System.Drawing.Point(206, 666);
            this.lblFinalScore.Name = "lblFinalScore";
            this.lblFinalScore.Size = new System.Drawing.Size(349, 46);
            this.lblFinalScore.TabIndex = 27;
            this.lblFinalScore.Text = "Final score ";
            this.lblFinalScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFinalScore.Visible = false;
            // 
            // lblHighScore
            // 
            this.lblHighScore.BackColor = System.Drawing.Color.Black;
            this.lblHighScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHighScore.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHighScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblHighScore.Location = new System.Drawing.Point(495, 357);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(619, 149);
            this.lblHighScore.TabIndex = 28;
            this.lblHighScore.Text = "HighScore\r\nScoreHolder:\r\n";
            this.lblHighScore.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1587, 903);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.lblFinalScore);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.lblReset);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.lstScoreBoard);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMessages);
            this.Controls.Add(this.lblMissed);
            this.Controls.Add(this.picmadepast);
            this.Controls.Add(this.pickillspic);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.lblMusic);
            this.Controls.Add(this.btnMOFF);
            this.Controls.Add(this.btnMON);
            this.Controls.Add(this.lblOptionsBack);
            this.Controls.Add(this.lblControls);
            this.Controls.Add(this.lblArrowLayout);
            this.Controls.Add(this.lblASDWLayout);
            this.Controls.Add(this.picBackGround);
            this.Controls.Add(this.Movingzone);
            this.Controls.Add(this.BulletRange);
            this.Controls.Add(this.PlayerPiece);
            this.Controls.Add(this.lblMoving);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ClientSizeChanged += new System.EventHandler(this.Form1_ClientSizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnUp);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPiece)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BulletRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Movingzone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickillspic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmadepast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMoving;
        private System.Windows.Forms.Timer GameTimer;
        private PictureBox PlayerPiece;
        private PictureBox BulletRange;
        private PictureBox Movingzone;
        private PictureBox picBackGround;
        private System.Windows.Forms.Timer SpaceTimer;
        private System.Windows.Forms.Timer EnemyTimer;
        private Label lblASDWLayout;
        private Label lblArrowLayout;
        private Label lblControls;
        private Label lblOptionsBack;
        private Label btnMON;
        private Label btnMOFF;
        private Label lblMusic;
        private PictureBox lblHP;
        private PictureBox pickillspic;
        private PictureBox picmadepast;
        private Label lblMissed;
        private Label lblMessages;
        private Label label1;
        private Label lblStart;
        private ListView lstScoreBoard;
        private ColumnHeader colName;
        private ColumnHeader colScore;
        private Label lblBack;
        private Label lblReset;
        private TextBox txtPlayerName;
        private Label lblFinalScore;
        private Label lblHighScore;
    }
}