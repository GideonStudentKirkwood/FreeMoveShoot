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
            this.lblMessages = new System.Windows.Forms.Label();
            this.BulletRange = new System.Windows.Forms.PictureBox();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblMissed = new System.Windows.Forms.Label();
            this.Movingzone = new System.Windows.Forms.PictureBox();
            this.picBackGround = new System.Windows.Forms.PictureBox();
            this.SpaceTimer = new System.Windows.Forms.Timer(this.components);
            this.EnemyTimer = new System.Windows.Forms.Timer(this.components);
            this.lblASDWLayout = new System.Windows.Forms.Label();
            this.lblArrowLayout = new System.Windows.Forms.Label();
            this.lblControls = new System.Windows.Forms.Label();
            this.lblOptionsBack = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPiece)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BulletRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Movingzone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackGround)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMoving
            // 
            this.lblMoving.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMoving.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMoving.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMoving.Location = new System.Drawing.Point(31, 22);
            this.lblMoving.Name = "lblMoving";
            this.lblMoving.Size = new System.Drawing.Size(341, 56);
            this.lblMoving.TabIndex = 0;
            this.lblMoving.Text = "label1";
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
            // lblMessages
            // 
            this.lblMessages.AutoSize = true;
            this.lblMessages.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessages.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMessages.Location = new System.Drawing.Point(31, 81);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(106, 43);
            this.lblMessages.TabIndex = 2;
            this.lblMessages.Text = "label1";
            this.lblMessages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lblHP
            // 
            this.lblHP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHP.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHP.Location = new System.Drawing.Point(379, 22);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(341, 56);
            this.lblHP.TabIndex = 4;
            this.lblHP.Text = "label1";
            this.lblHP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMissed
            // 
            this.lblMissed.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMissed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMissed.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMissed.Location = new System.Drawing.Point(726, 22);
            this.lblMissed.Name = "lblMissed";
            this.lblMissed.Size = new System.Drawing.Size(435, 56);
            this.lblMissed.TabIndex = 5;
            this.lblMissed.Text = "label1";
            this.lblMissed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.picBackGround.Image = global::FreeMoveShoot.Properties.Resources.space;
            this.picBackGround.Location = new System.Drawing.Point(712, 81);
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
            this.lblControls.Location = new System.Drawing.Point(589, 169);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1587, 903);
            this.Controls.Add(this.lblOptionsBack);
            this.Controls.Add(this.lblControls);
            this.Controls.Add(this.lblArrowLayout);
            this.Controls.Add(this.lblASDWLayout);
            this.Controls.Add(this.picBackGround);
            this.Controls.Add(this.Movingzone);
            this.Controls.Add(this.lblMissed);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.BulletRange);
            this.Controls.Add(this.lblMessages);
            this.Controls.Add(this.PlayerPiece);
            this.Controls.Add(this.lblMoving);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ClientSizeChanged += new System.EventHandler(this.Form1_ClientSizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnUp);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPiece)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BulletRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Movingzone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMoving;
        private System.Windows.Forms.Timer GameTimer;
        private PictureBox PlayerPiece;
        private Label lblMessages;
        private PictureBox BulletRange;
        private Label lblHP;
        private Label lblMissed;
        private PictureBox Movingzone;
        private PictureBox picBackGround;
        private System.Windows.Forms.Timer SpaceTimer;
        private System.Windows.Forms.Timer EnemyTimer;
        private Label lblASDWLayout;
        private Label lblArrowLayout;
        private Label lblControls;
        private Label lblOptionsBack;
    }
}