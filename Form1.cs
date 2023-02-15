using System.Media;
namespace FreeMoveShoot
{
    public partial class Form1 : Form
    {
        //@"C:\Users\grimj\OneDrive\Desktop\FreeMoveShoot\FreeMoveShoot\Resources\GameMusic2.wav"
        bool goLeft;
        bool goRight;
        bool goUp; 
        bool goDown;
        readonly int speed = 15;
        int kills = 0;
        int PlayerHP = 3;
        int MadePast = 0;
        readonly int zombieSpeed = 5;
        readonly int parralelspeed = 8;
        string parraleldirection = "up";
        readonly int zombieTopSpeed = 10;
        List<PictureBox> zombiesList = new List<PictureBox>();
        Random randNum = new Random();
        string controlscheme = "asdw";

        List<PictureBox> GUIList = new List<PictureBox>();
        SoundPlayer BattleMusic = new SoundPlayer(@"C:\Users\grimj\OneDrive\Desktop\FreeMoveShoot\FreeMoveShoot\FreeMoveShoot\BM.wav");
        SoundPlayer GameTune = new SoundPlayer(@"C:\Users\grimj\OneDrive\Desktop\FreeMoveShoot\FreeMoveShoot\FreeMoveShoot\GameMusic2.wav");
        SoundPlayer WinTune = new SoundPlayer(@"C:\Users\grimj\OneDrive\Desktop\FreeMoveShoot\FreeMoveShoot\FreeMoveShoot\Winsound.wav");
        SoundPlayer LooseTune = new SoundPlayer(@"C:\Users\grimj\OneDrive\Desktop\FreeMoveShoot\FreeMoveShoot\FreeMoveShoot\GameOverSound.wav");
        public Form1()
        {
            /*
            lblHP.BringToFront();
            lblMessages.BringToFront();
            lblMissed.BringToFront();
            lblMoving.BringToFront();
            */

            InitializeComponent();
            MainMenuCall();


        }

        public void MainMenu(bool Change)
        {
            Point Player = new Point(61, 416);
            Point GunRangeBox = new Point(61, 81);

            /*
            lblMainMenu.Visible = Change;
            btnPlay.Visible = Change;
            btnPlay.Enabled = Change;
            btnQuit.Visible = Change;
            btnQuit.Enabled = Change;
            btnHelp.Visible = Change;
            btnHelp.Enabled = Change;
            */
            if (Change == true)
            {
                int C = 0;
                while (C < 5)
                {
                    MainMenuMaker(C);
                    C = C + 1;
                }
            }
            if (Change == false)
            {
                foreach (PictureBox i in GUIList)
                {
                    this.Controls.Remove(i);
                }
            }

        }
        public void MainMenuMaker(int C)
        {
            PictureBox picWinner = new PictureBox();
            if (C == 0)
            {

                picWinner.Visible = true;
                picWinner.AutoSize = false;
                picWinner.SizeMode = PictureBoxSizeMode.StretchImage;
                picWinner.Tag = "Winlbl";
                picWinner.Image = Properties.Resources.MainMenuTitle;
                picWinner.Size = new Size(546, 99);
                picWinner.Left = 498;
                picWinner.Top = 122;
                //picWinner.Location = new Point(561, 51);

            }
            if (C == 1)
            {
                picWinner.Visible = true;
                picWinner.AutoSize = false;
                picWinner.SizeMode = PictureBoxSizeMode.StretchImage;
                picWinner.Tag = "Wintrophy";
                picWinner.Image = Properties.Resources.MainMenuPlay;
                picWinner.Size = new Size(321, 121);
                picWinner.Left = 623;
                picWinner.Top = 323;
                picWinner.Click += new EventHandler(this.btnPlay_Click);
                //picWinner.Location = new Point(561, 195);
            }
            if (C == 2)
            {
                picWinner.Visible = true;
                picWinner.AutoSize = false;
                picWinner.SizeMode = PictureBoxSizeMode.StretchImage;
                picWinner.Tag = "Winback";
                picWinner.Image = Properties.Resources.MainMenuQuit;
                picWinner.Size = new Size(321, 121);
                picWinner.Left = 623;
                picWinner.Top = 461;
                picWinner.Click += new EventHandler(this.btnQuit_Click);
                //picWinner.Location = new Point(561, 716);
            }
            if (C == 3)
            {
                picWinner.Visible = true;
                picWinner.AutoSize = false;
                picWinner.SizeMode = PictureBoxSizeMode.StretchImage;
                picWinner.Tag = "Winback";
                picWinner.Image = Properties.Resources.MainMenuHelp;
                picWinner.Size = new Size(321, 121);
                picWinner.Left = 623;
                picWinner.Top = 603;
                picWinner.Click += new EventHandler(this.btnHelp_Click);
            }
            if (C == 4)
            {
                picWinner.Visible = true;
                picWinner.AutoSize = false;
                picWinner.SizeMode = PictureBoxSizeMode.StretchImage;
                picWinner.Tag = "Winback";
                picWinner.Image = Properties.Resources.OptionsBtn;
                picWinner.Size = new Size(325, 101);
                picWinner.Left = 653;
                picWinner.Top = 733;
                picWinner.Click += new EventHandler(this.btnOptions_Click);
            }
            GUIList.Add(picWinner);
            this.Controls.Add(picWinner);
            picWinner.BringToFront();
        }

        public void ActiveGame(bool Change)
        {

            PlayerPiece.Visible = Change;
            lblMoving.Visible = Change;
            lblHP.Visible = Change;
            lblMissed.Visible = Change;
            lblMessages.Visible = Change;
            GameTimer.Enabled = Change;


            //picBackGround2.Visible = Change;

            Background();
            if(Change == true)
            {
                BattleMusic.Load();
                BattleMusic.PlayLooping();
            }
            lblHP.BringToFront();
            lblMessages.BringToFront();
            lblMissed.BringToFront();
            lblMoving.BringToFront();
        }

        public void HelpMenu(bool Change)
        {
            /*
            lblHelpInfo.Visible = Change;
            pichelp1.Visible = Change;
            pichelp2.Visible = Change;
            pichelp3.Visible = Change;
            btnBack.Visible = Change;
            btnBack.Enabled = Change;
            */
            if (Change == true)
            {
                int C = 0;
                while (C < 2)
                {
                    HelpMenuMaker(C);
                    C = C + 1;
                }
            }
            if (Change == false)
            {
                foreach (PictureBox i in GUIList)
                {
                    this.Controls.Remove(i);
                }
            }
        }
        public void HelpMenuMaker(int C)
        {
            PictureBox picWinner = new PictureBox();
            if (C == 0)
            {

                picWinner.Visible = true;
                picWinner.AutoSize = false;
                picWinner.SizeMode = PictureBoxSizeMode.StretchImage;
                picWinner.Tag = "Winlbl";
                picWinner.Image = Properties.Resources.HelpInfo;
                picWinner.Size = new Size(546, 667);
                picWinner.Left = 528;
                picWinner.Top = 29;
                //picWinner.Location = new Point(561, 51);

                GUIList.Add(picWinner);
                this.Controls.Add(picWinner);
            }
            if (C == 1)
            {
                picWinner.Visible = true;
                picWinner.AutoSize = false;
                picWinner.SizeMode = PictureBoxSizeMode.StretchImage;
                picWinner.Tag = "Winback";
                picWinner.Image = Properties.Resources.HelpMenuBack;
                picWinner.Size = new Size(321, 121);
                picWinner.Left = 623;
                picWinner.Top = 716;
                picWinner.Click += new EventHandler(this.btnBack_Click);
            }
            GUIList.Add(picWinner);
            this.Controls.Add(picWinner);
            picWinner.BringToFront();
        }

        public void GameOverScreen(bool Change)
        {
            /*
            lblGameOver.Visible = Change;
            picAlien.Visible = Change;
            picTryAgain.Visible = Change;
            picTryAgain.Enabled = Change;
            picGiveUp.Visible = Change;
            picGiveUp.Enabled = Change;
            */

            if (Change == true)
            {
                int C = 0;
                while (C < 4)
                {
                    GameOverScreenMaker(C);
                    C = C + 1;
                }
                LooseTune.Load();
                LooseTune.Play();
            }
            if (Change == false)
            {
                foreach (PictureBox i in GUIList)
                {
                    this.Controls.Remove(i);
                }
                GameTune.Load();
                GameTune.PlayLooping();
            }
        }
        public void GameOverScreenMaker(int C)
        {
            PictureBox picWinner = new PictureBox();
            if (C == 0)
            {

                picWinner.Visible = true;
                picWinner.AutoSize = false;
                picWinner.SizeMode = PictureBoxSizeMode.StretchImage;
                picWinner.Tag = "Winlbl";
                picWinner.Image = Properties.Resources.GameOverlbl;
                picWinner.Size = new Size(450, 131);
                picWinner.Left = 561;
                picWinner.Top = 51;
                //picWinner.Location = new Point(561, 51);

                GUIList.Add(picWinner);
                this.Controls.Add(picWinner);
            }
            if (C == 1)
            {
                picWinner.Visible = true;
                picWinner.AutoSize = false;
                picWinner.SizeMode = PictureBoxSizeMode.StretchImage;
                picWinner.Tag = "Wintrophy";
                picWinner.Image = Properties.Resources.alien;
                picWinner.Size = new Size(450, 450);
                picWinner.Left = 561;
                picWinner.Top = 195;
                //picWinner.Location = new Point(561, 195);
            }
            if (C == 2)
            {
                picWinner.Visible = true;
                picWinner.AutoSize = false;
                picWinner.SizeMode = PictureBoxSizeMode.StretchImage;
                picWinner.Tag = "Winback";
                picWinner.Image = Properties.Resources.GiveUp;
                picWinner.Size = new Size(383, 133);
                picWinner.Left = 234;
                picWinner.Top = 716;
                picWinner.Click += new EventHandler(this.picGiveUp_Click);
                //picWinner.Location = new Point(561, 716);
            }
            if (C == 3)
            {
                picWinner.Visible = true;
                picWinner.AutoSize = false;
                picWinner.SizeMode = PictureBoxSizeMode.StretchImage;
                picWinner.Tag = "Winback";
                picWinner.Image = Properties.Resources.TryAgain;
                picWinner.Size = new Size(450, 131);
                picWinner.Left = 963;
                picWinner.Top = 716;
                picWinner.Click += new EventHandler(this.picTryAgain_Click);
            }
            GUIList.Add(picWinner);
            this.Controls.Add(picWinner);
            picWinner.BringToFront();
        }

        public void WinScreen(bool Change)
        {

            //lblWinner.Visible = Change;
            if (Change == true)
            {
                int C = 0;
                while (C < 3)
                {
                    WinMaker(C);
                    C = C + 1;
                }
                WinTune.Load();
                WinTune.Play();
            }
            if (Change == false)
            {
                foreach (PictureBox i in GUIList)
                {
                    this.Controls.Remove(i);
                }
                GameTune.Load();
                GameTune.PlayLooping();
            }
            //picWin.Visible = Change;
            //btnWin.Visible = Change;
            //btnWin.Enabled = Change;
        }
        public void WinMaker(int C)
        {
            PictureBox picWinner = new PictureBox();
            if (C == 0)
            {

                picWinner.Visible = true;
                picWinner.AutoSize = false;
                picWinner.SizeMode = PictureBoxSizeMode.StretchImage;
                picWinner.Tag = "Winlbl";
                picWinner.Image = Properties.Resources.WinnerLabel1;
                picWinner.Size = new Size(450, 131);
                picWinner.Left = 561;
                picWinner.Top = 51;
                //picWinner.Location = new Point(561, 51);

                GUIList.Add(picWinner);
                this.Controls.Add(picWinner);
            }
            if (C == 1)
            {
                picWinner.Visible = true;
                picWinner.AutoSize = false;
                picWinner.SizeMode = PictureBoxSizeMode.StretchImage;
                picWinner.Tag = "Wintrophy";
                picWinner.Image = Properties.Resources.Winner;
                picWinner.Size = new Size(450, 450);
                picWinner.Left = 561;
                picWinner.Top = 195;
                //picWinner.Location = new Point(561, 195);
            }
            if (C == 2)
            {
                picWinner.Visible = true;
                picWinner.AutoSize = false;
                picWinner.SizeMode = PictureBoxSizeMode.StretchImage;
                picWinner.Tag = "Winback";
                picWinner.Image = Properties.Resources.WinMainMenu;
                picWinner.Size = new Size(450, 131);
                picWinner.Left = 561;
                picWinner.Top = 716;
                picWinner.Click += new EventHandler(this.btnWin_Click);
                //picWinner.Location = new Point(561, 716);
            }
            GUIList.Add(picWinner);
            this.Controls.Add(picWinner);
            picWinner.BringToFront();
        }

        public void OptionsScreen(bool Change)
        {
            lblControls.Visible = Change;
            lblASDWLayout.Visible = Change;
            lblASDWLayout.Enabled = Change;
            lblArrowLayout.Visible = Change;
            lblArrowLayout.Enabled = Change;
            lblOptionsBack.Visible = Change;
            lblOptionsBack.Enabled = Change;
        }
        public void OptionsMaker(int C)
        {

        }//not used yet, remove if never used

        public void MainMenuCall()
        {

            HelpMenu(false);
            ActiveGame(false);
            GameOverScreen(false);
            WinScreen(false);
            MainMenu(true);
            GameTune.Load();
            GameTune.PlayLooping();
        }



        public void Background()
        {
            picBackGround.Size = new Size((this.ClientSize.Width) + (this.ClientSize.Width), this.ClientSize.Height);
            picBackGround.Left = (0);
            picBackGround.Top = (0);


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Background();
            Movingzone.Location = new Point(0, this.ClientSize.Height / 2);
            Movingzone.Size = new Size(this.ClientSize.Width, 400);
        }


        public void BulletPhysics(string Enemy)
        {
            foreach (Control j in this.Controls)
            {
                //j is PictureBox && (string)j.Tag == "bullet"
                //x is PictureBox && (string)x.Tag == "zombie"

                foreach (Control x in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == Enemy)
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            ((PictureBox)x).Dispose();
                            zombiesList.Remove((PictureBox)x);
                            kills++;
                            if (kills < 69)
                            {
                                MakeZombies();
                            }
                        }
                    }
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == Enemy)
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {

                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            ((PictureBox)x).Dispose();
                            zombiesList.Remove((PictureBox)x);
                            kills++;
                            if (kills < 69)
                            {
                                MakeZombies();
                            }
                        }
                    }
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == Enemy)
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {

                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            ((PictureBox)x).Dispose();
                            zombiesList.Remove((PictureBox)x);
                            kills++;
                            if (kills < 69)
                            {
                                MakeZombies();
                            }
                        }

                    }

                }
            }
        }
        private void MainTimeEvent(object sender, EventArgs e)
        {

            


                if (goLeft == true && PlayerPiece.Left > 0)
                {
                    PlayerPiece.Left -= speed;
                    BulletRange.Left -= speed;
                }
                if (goRight == true && PlayerPiece.Left + PlayerPiece.Width < this.ClientSize.Width)
                {
                    PlayerPiece.Left += speed;
                    BulletRange.Left += speed;
                }
                if (goUp == true && PlayerPiece.Top > 90)
                {
                    PlayerPiece.Top -= speed;
                    BulletRange.Top -= speed;
                }
                if (goDown == true && PlayerPiece.Top + PlayerPiece.Height < this.ClientSize.Height)
                {
                    PlayerPiece.Top += speed;
                    BulletRange.Top += speed;
                }
            

            if (kills == 0 || kills == 25 || kills == 50)
            {
                if (kills == 0)
                {
                    lblMessages.Visible = true;
                    lblMessages.Text = ("Enemy vessels incomming, kill 75 to drive them away!");

                }
                else if (kills == 25)
                {
                    lblMessages.Visible = true;
                    lblMessages.Text = ("25 Down, 50 to go!");

                }
                else if (kills == 50)
                {
                    lblMessages.Visible = true;
                    lblMessages.Text = ("Thats 50, you are almost there!");

                }
            }
            else
            {
                lblMessages.Visible = false;
            }

            if (MadePast > 4 || PlayerHP <= 0)
            {
                GameOver();
            }


            if (kills == 75)
            {
                PlayerPiece.BringToFront();
                PlayerPiece.Left += speed;
                BulletRange.Left += speed;
            }

            if (PlayerPiece.Left > this.ClientSize.Width)
            {
                Point Player = new Point(61, 416);
                Point GunRangeBox = new Point(61, 81);
                BulletRange.Location = GunRangeBox;
                PlayerPiece.Location = Player;
                kills = 0;
                ActiveGame(false);
                WinScreen(true);
            }
            lblHP.Text = ("Health: " + PlayerHP.ToString());

            lblMissed.Text = ("Enemies made it past: " + MadePast.ToString());
            lblMoving.Text = ("Kills: " + kills);
        }
        private void SpaceTimer_Tick(object sender, EventArgs e)
        {
            if (picBackGround.Left > 0 - (this.ClientSize.Width))
            {
                picBackGround.Left -= speed;
            }
            else
            {
                picBackGround.Left = 0;
            }

            if (Movingzone.Top < 90)
            {
                parraleldirection = "down";
            }
            if (Movingzone.Bottom > this.ClientSize.Height)
            {
                parraleldirection = "up";
            }
            if (parraleldirection == "up")
            {
                Movingzone.Top -= parralelspeed;
            }
            if (parraleldirection == "down")
            {
                Movingzone.Top += parralelspeed;
            }
        }
        private void EnemyTimer_Tick(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "zombie")
                {
                    if (x.Bounds.IntersectsWith(PlayerPiece.Bounds))
                    {
                        ((PictureBox)x).Dispose();
                        zombiesList.Remove((PictureBox)x);
                        PlayerHP--;
                        if (PlayerHP > 0)
                        {
                            MakeZombies();
                        }
                    }
                    x.Left -= zombieSpeed;
                    //normal enemy

                }
                if (x is PictureBox && (string)x.Tag == "fzombie")
                {
                    if (x.Bounds.IntersectsWith(PlayerPiece.Bounds))
                    {
                        ((PictureBox)x).Dispose();
                        zombiesList.Remove((PictureBox)x);
                        PlayerHP--;
                        if (PlayerHP > 0)
                        {
                            MakeZombies();
                        }
                    }
                    x.Left -= zombieTopSpeed;
                    //fast enemy

                }
                if (x is PictureBox && (string)x.Tag == "mzombie")
                {
                    if (x.Bounds.IntersectsWith(PlayerPiece.Bounds))
                    {

                        ((PictureBox)x).Dispose();
                        zombiesList.Remove((PictureBox)x);
                        PlayerHP--;
                        if (PlayerHP > 0)
                        {
                            MakeZombies();
                        }
                    }
                    if (x.Bounds.IntersectsWith(Movingzone.Bounds))
                    {
                        if (parraleldirection == "up")
                        {
                            x.Top += zombieTopSpeed;
                            x.Left -= zombieSpeed;
                        }
                        if (parraleldirection == "down")
                        {
                            x.Top -= zombieTopSpeed;
                            x.Left -= zombieSpeed;
                        }

                    }
                    else
                    {

                        x.Left -= zombieSpeed;
                    }

                    //moving enemy

                }

                if (x is PictureBox && (string)x.Tag == "zombie" && x.Right < 0)
                {

                    this.Controls.Remove(x);
                    ((PictureBox)x).Dispose();
                    MadePast++;
                    MakeZombies();

                }
                if (x is PictureBox && (string)x.Tag == "fzombie" && x.Right < 0)
                {

                    this.Controls.Remove(x);
                    ((PictureBox)x).Dispose();
                    MadePast++;
                    MakeZombies();

                }
                if (x is PictureBox && (string)x.Tag == "mzombie" && x.Right < 0)
                {

                    this.Controls.Remove(x);
                    ((PictureBox)x).Dispose();
                    MadePast++;
                    MakeZombies();

                }
            }
            foreach (Control j in this.Controls)
            {
                //j is PictureBox && (string)j.Tag == "bullet"
                //x is PictureBox && (string)x.Tag == "zombie"
                if (j is PictureBox && (string)j.Tag == "bullet")
                {
                    if (j.Bounds.IntersectsWith(BulletRange.Bounds))
                    {

                    }
                    else { this.Controls.Remove(j); }

                }
                foreach (Control x in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "zombie")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            ((PictureBox)x).Dispose();
                            zombiesList.Remove((PictureBox)x);
                            kills++;
                            if (kills < 69)
                            {
                                MakeZombies();
                            }
                        }
                    }
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "fzombie")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {

                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            ((PictureBox)x).Dispose();
                            zombiesList.Remove((PictureBox)x);
                            kills++;
                            if (kills < 69)
                            {
                                MakeZombies();
                            }
                        }
                    }
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "mzombie")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {

                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            ((PictureBox)x).Dispose();
                            zombiesList.Remove((PictureBox)x);
                            kills++;
                            if (kills < 69)
                            {
                                MakeZombies();
                            }
                        }

                    }

                }
            }
        }

        private void GameOver()
        {
            Point Player = new Point(61, 416);
            Point GunRangeBox = new Point(61, 81);
            BulletRange.Location = GunRangeBox;
            PlayerPiece.Location = Player;
            GameTimer.Enabled = false;
            if (MadePast > 4)
            {
                foreach (PictureBox i in zombiesList)
                {
                    this.Controls.Remove(i);
                }

                zombiesList.Clear();
                lblMissed.Text = ("Enemies made it past: " + MadePast.ToString());
                GameOverScreen(true);
                ActiveGame(false);
            }

            if (PlayerHP == 0)
            {
                foreach (PictureBox i in zombiesList)
                {
                    this.Controls.Remove(i);
                }

                zombiesList.Clear();
                lblHP.Text = ("Health: " + PlayerHP.ToString());

                GameOverScreen(true);
                ActiveGame(false);
            }
        }

        private void btnDown(object sender, KeyEventArgs e)
        {
            if (controlscheme == "asdw")
            {
                if (e.KeyCode == Keys.A)
                {
                    movementleft(true);
                }

                if (e.KeyCode == Keys.D)
                {
                    movementright(true);
                }

                if (e.KeyCode == Keys.W)
                {
                    movementup(true);
                }

                if (e.KeyCode == Keys.S)
                {
                    movementdown(true);
                }
            }
            if (controlscheme == "arrow")
            {
                if (e.KeyCode == Keys.Left)
                {
                    movementleft(true);
                }

                if (e.KeyCode == Keys.Right)
                {
                    movementright(true);
                }

                if (e.KeyCode == Keys.Up)
                {
                    movementup(true);
                }

                if (e.KeyCode == Keys.Down)
                {
                    movementdown(true);
                }
            }

            if (e.KeyCode == Keys.Space)
            {
                if(e.KeyCode == Keys.Space && e.KeyCode == Keys.Left && e.KeyCode == Keys.Up)
                {
                    this.BackColor = Color.White;
                }
                //if (PlayerPiece.Visible == true){shootbullet();}
                shootbullet();

            }

            

            if (e.KeyCode == Keys.R)
            {
                foreach (PictureBox i in zombiesList)
                {
                    this.Controls.Remove(i);
                }
                MainMenu(false);
                ActiveGame(false);
                GameOverScreen(false);
                HelpMenu(false);
                WinScreen(true);

            }
        }

        private void btnUp(object sender, KeyEventArgs e)
        {
            if (controlscheme == "asdw")
            {
                if (e.KeyCode == Keys.A)
                {
                    movementleft(false);
                }

                if (e.KeyCode == Keys.D)
                {
                    movementright(false);
                }

                if (e.KeyCode == Keys.W)
                {
                    movementup(false);
                }

                if (e.KeyCode == Keys.S)
                {
                    movementdown(false);
                }
            }
            if (controlscheme == "arrow")
            {
                if (e.KeyCode == Keys.Left)
                {
                    movementleft(false);
                }

                if (e.KeyCode == Keys.Right)
                {
                    movementright(false);
                }

                if (e.KeyCode == Keys.Up)
                {
                    movementup(false);
                }

                if (e.KeyCode == Keys.Down)
                {
                    movementdown(false);
                }
            }

            
        }

        private void movementdown(bool Change)
        {
            if(Change == true)
            {
                goDown = true;
            }
            if(Change == false)
            {
                goDown = false;
            }
        }

        private void movementleft(bool Change)
        {
            if (Change == true)
            {
                goLeft = true;
            }
            if (Change == false)
            {
                goLeft = false;
            }
        }

        private void movementup(bool Change)
        {
            if (Change == true)
            {
                goUp = true;
            }
            if (Change == false)
            {
                goUp=false;
            }
        }

        private void movementright(bool Change)
        {
            if (Change == true)
            {
                goRight = true;
            }
            if (Change == false)
            {
                goRight=false;
            }
        }




        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            Background();
            Movingzone.Location = new Point(0, this.ClientSize.Height / 2);
            Movingzone.Size = new Size(this.ClientSize.Width, 400);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            MainMenu(false);
            ActiveGame(true);
            RestartGame();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MainMenu(false);
            HelpMenu(true);
        }
        private void btnOptions_Click(object sender, EventArgs e)
        {
            MainMenu(false);
            OptionsScreen(true);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            HelpMenu(false);
            MainMenu(true);
        }

        private void picGiveUp_Click(object sender, EventArgs e)
        {
            GameOverScreen(false);
            MainMenu(true);
        }

        private void picTryAgain_Click(object sender, EventArgs e)
        {
            GameOverScreen(false);
            ActiveGame(true);
            RestartGame();
        }

        private void btnWin_Click(object sender, EventArgs e)
        {
            WinScreen(false);
            MainMenu(true);


        }



        private void shootbullet()
        {
            Bullet shootbullet = new Bullet();
            shootbullet.bulletX = PlayerPiece.Left + (PlayerPiece.Width);
            shootbullet.bulletY = PlayerPiece.Top + (PlayerPiece.Height / 2);
            shootbullet.MakeBullet(this);
            

        }

        private void MakeZombies()
        {
            PictureBox zombie = new PictureBox();
            zombie.Size = new Size(90, 90);
            int x = randNum.Next(1, 4);
            if (x == 1)
            {
                zombie.Tag = "fzombie";
                zombie.Image = Properties.Resources.Fastenemy;
                zombie.Left = randNum.Next(this.ClientSize.Width + 100, this.ClientSize.Width + 200);
                zombie.Top = randNum.Next(90, this.ClientSize.Height - 90);
                zombie.SizeMode = PictureBoxSizeMode.StretchImage;
                zombiesList.Add(zombie);
                this.Controls.Add(zombie);
                zombie.BringToFront();
                PlayerPiece.BringToFront();
            }
            if (x == 2)
            {
                zombie.Tag = "mzombie";
                zombie.Image = Properties.Resources.saucer;
                zombie.Left = randNum.Next(this.ClientSize.Width + 100, this.ClientSize.Width + 200);
                zombie.Top = randNum.Next(90, this.ClientSize.Height - 90);
                zombie.SizeMode = PictureBoxSizeMode.StretchImage;
                zombiesList.Add(zombie);
                this.Controls.Add(zombie);
                zombie.BringToFront();
                PlayerPiece.BringToFront();
            }
            if (x == 3)
            {
                zombie.Tag = "zombie";
                zombie.Image = Properties.Resources.enemy;
                zombie.Left = randNum.Next(this.ClientSize.Width + 100, this.ClientSize.Width + 200);
                zombie.Top = randNum.Next(90, this.ClientSize.Height - 90);
                zombie.SizeMode = PictureBoxSizeMode.StretchImage;
                zombiesList.Add(zombie);
                this.Controls.Add(zombie);
                zombie.BringToFront();
                PlayerPiece.BringToFront();
            }



        }

        private void RestartGame()
        {

            goUp = false;
            goLeft = false;
            goRight = false;
            goDown = false;

            GameTimer.Enabled = true;
            MadePast = 0;
            PlayerHP = 3;
            kills = 0;
            foreach (PictureBox i in zombiesList)
            {
                this.Controls.Remove(i);
            }

            zombiesList.Clear();

            for (int i = 0; i < 7; i++)
            {

                MakeZombies();

            }

            GameTimer.Start();

        }

        private void lblOptionsBack_Click(object sender, EventArgs e)
        {
            OptionsScreen(false);
            MainMenu(true);
        }

        private void lblArrowLayout_Click(object sender, EventArgs e)
        {
            controlscheme = "arrow";
            OptionsScreen(false);
            MainMenu(true);
        }

        private void lblASDWLayout_Click(object sender, EventArgs e)
        {
            controlscheme = "asdw";
            OptionsScreen(false);
            MainMenu(true);
        }
    }
}