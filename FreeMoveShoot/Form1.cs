using System.Media;
using ShooterLogic;
using ShooterDataObjects;

namespace FreeMoveShoot
{
    public partial class Form1 : Form
    {
        
        private SideShooterLogic _logicManager = new SideShooterLogic();

        bool goLeft;
        bool goRight;
        bool goUp; 
        bool goDown;
        readonly int speed = 15;
        int Enemymax = 0;

        int kills = 0;
        int Score = 0;
        int PlayerHP = 3;
        int MadePast = 0;

        int zombieSpeed = 5;
        int parralelspeed = 8;

        string parraleldirection = "up";
        int zombieTopSpeed = 10;
        List<PictureBox> zombiesList = new List<PictureBox>();
        Random randNum = new Random();
        string controlscheme = "asdw";
        string musicstate = "on";
        int MissionLV = 0;
        

        List<PictureBox> GUIList = new List<PictureBox>();
        SoundPlayer BattleMusic = new SoundPlayer(AppData.DataPath + "\\" + AppData.songlist[0]);
        SoundPlayer GameTune = new SoundPlayer(AppData.DataPath + "\\" + AppData.songlist[1]);
        SoundPlayer WinTune = new SoundPlayer(AppData.DataPath + "\\" + AppData.songlist[2]);
        SoundPlayer LooseTune = new SoundPlayer(AppData.DataPath + "\\" + AppData.songlist[3]);
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
                MissionLV = 0;
                zombieSpeed = 5;
                zombieTopSpeed = 10;
                int C = 0;
                while (C < 5)
                {
                    MainMenuMaker(C);
                    C = C + 1;
                }
                if (musicstate == "on")
                {
                    GameTune.Load();
                    GameTune.PlayLooping();
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
                picWinner.Left = 473;
                picWinner.Top = 293;
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
                picWinner.Left = 473;
                picWinner.Top = 431;
                picWinner.Click += new EventHandler(this.btnQuit_Click);
                //picWinner.Location = new Point(561, 716);
            }
            if (C == 3)
            {
                picWinner.Visible = true;
                picWinner.AutoSize = false;
                picWinner.SizeMode = PictureBoxSizeMode.StretchImage;
                picWinner.Tag = "Winback";
                picWinner.Image = Properties.Resources.Scorespic;
                picWinner.Size = new Size(311, 111);
                picWinner.Left = 525;
                picWinner.Top = 573;
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
                picWinner.Left = 513;
                picWinner.Top = 703;
                picWinner.Click += new EventHandler(this.btnOptions_Click);
            }
            GUIList.Add(picWinner);
            this.Controls.Add(picWinner);
            picWinner.BringToFront();
        }

        public void ActiveGame(bool Change)
        {

            PlayerPiece.Visible = Change;
            pickillspic.Visible = Change;
            lblMoving.Visible = Change;
            lblHP.Visible = Change;
            lblHP.Image = Properties.Resources.Health3;
            lblMissed.Visible = Change;
            picmadepast.Visible = Change;
            GameTimer.Enabled = Change;


            //picBackGround2.Visible = Change;

            Background();
            if(Change == true)
            {
                if (musicstate == "on")
                {
                    BattleMusic.Load();
                    BattleMusic.PlayLooping();
                }
            }
            
            lblHP.BringToFront();
            lblMessages.BringToFront();
            lblMissed.BringToFront();
            lblMoving.BringToFront();
        }
        private void MissionBrief(bool Change)
        {
            if(Change == true)
            {
                if(MissionLV>0)
                {
                    zombieSpeed++;
                    zombieTopSpeed++;
                }
                
                MissionLV++;
            }
            missionsetup();
            lblStart.Visible = Change;
            lblStart.Enabled = Change;
            lblMessages.Visible = Change;
            lblMessages.Text = ("Level " + MissionLV + "\n\nDestroy all " + Enemymax.ToString() + " incomming enemies");
            

        }

        public void HelpMenu(bool Change)
        {
            /*
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
            */

            lblHighScore.Visible = Change;
            

            //lstScoreBoard.Visible = Change;
            lblBack.Visible = Change;
            lblBack.Enabled = Change;
            lblReset.Visible = Change;
            lblReset.Enabled = Change;
            if(Change == true)
            {
                populateScoreBoard();
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
                Point Player = new Point(61, 416);
                Point GunRangeBox = new Point(61, 81);
                BulletRange.Location = GunRangeBox;
                PlayerPiece.Location = Player;
                kills = 0;
                
                int C = 0;
                while (C < 4)
                {
                    GameOverScreenMaker(C);
                    C = C + 1;
                }
                if(musicstate == "on")
                {
                    LooseTune.Load();
                    LooseTune.Play();
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

            Point Player = new Point(61, 416);
            Point GunRangeBox = new Point(61, 81);
            BulletRange.Location = GunRangeBox;
            PlayerPiece.Location = Player;
            kills = 0;



            lblFinalScore.Visible = Change;
            txtPlayerName.Visible = Change;
            txtPlayerName.Enabled = Change;
            
            
            

            //lblWinner.Visible = Change;
            if (Change == true)
            {
                int C = 0;
                while (C < 3)
                {
                    WinMaker(C);
                    C = C + 1;
                }
                if (musicstate == "on")
                {
                    WinTune.Load();
                    WinTune.Play();
                }
            }
            if (Change == false)
            {
                foreach (PictureBox i in GUIList)
                {
                    this.Controls.Remove(i);
                }
                if(musicstate == "on")
                {
                    GameTune.Load();
                    GameTune.PlayLooping();
                }
                
            }
            //picWin.Visible = Change;
            //btnWin.Visible = Change;
            //btnWin.Enabled = Change;
            lblFinalScore.Text = ("Final score: " + Score);
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
            lblMusic.Visible = Change;
            btnMON.Visible = Change;
            btnMON.Enabled = Change;
            btnMOFF.Visible = Change;
            btnMOFF.Enabled = Change;
        }
        public void OptionsMaker(int C)
        {

        }//not used yet, remove if never used

        public void MainMenuCall()
        {
            MissionBrief(false);
            HelpMenu(false);
            ActiveGame(false);
            GameOverScreen(false);
            WinScreen(false);
            MainMenu(true);
            if(musicstate == "on")
            {
                GameTune.Load();
                GameTune.PlayLooping();
            }
            
        }

        public void WinChecker()
        {
            foreach (PictureBox i in zombiesList)
            {
                this.Controls.Remove(i);
            }

            zombiesList.Clear();

            int x = 0;
            bool Scoreboardworthy = false;

            List<SavedScore> _scoreList = _logicManager.FetchScores();

            while (x < _scoreList.Count)
            {

                if (Score > int.Parse(_scoreList[x].Score) && Scoreboardworthy == false)
                {
                    Scoreboardworthy = true;


                }

                x++;
            }
            if(Scoreboardworthy==true)
            {
                GameOverScreen(false);
                WinScreen(true);
            }
            else
            {
                WinScreen(false);
                GameOverScreen(true);
            }
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
                            ((PictureBox)x).Tag = "dead";
                            ((PictureBox)x).Image = Properties.Resources.deadenemy;
                            //zombiesList.Remove((PictureBox)x);
                            kills++;
                            if (kills < (Enemymax-6))
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
                if (goUp == true && (PlayerPiece.Top > 90))
                {
                    PlayerPiece.Top -= speed;
                    BulletRange.Top -= speed;
                }
                if (goDown == true && (PlayerPiece.Top + PlayerPiece.Height < this.ClientSize.Height))
                {
                    PlayerPiece.Top += speed;
                    BulletRange.Top += speed;
                }
            

            

            if (MadePast > 4 || PlayerHP <= 0)
            {
                ActiveGame(false);
                WinChecker();
            }


            if (kills == Enemymax)
            {
                PlayerPiece.BringToFront();
                PlayerPiece.Left += speed;
                BulletRange.Left += speed;
            }

            
            if ((PlayerPiece.Left > this.ClientSize.Width))
            {
                foreach (PictureBox i in zombiesList)
                {
                    this.Controls.Remove(i);
                }

                zombiesList.Clear();

                Point Player = new Point(61, 416);
                Point GunRangeBox = new Point(61, 81);
                BulletRange.Location = GunRangeBox;
                PlayerPiece.Location = Player;
                kills = 0;
                ActiveGame(false);
                MissionBrief(true);
            }
            if (PlayerHP > 0)
            {
                if(PlayerHP == 2)
                {
                    lblHP.Image = Properties.Resources.Health2;
                }
                if(PlayerHP == 1)
                {
                    lblHP.Image = Properties.Resources.Health1;
                }
            }

            lblMissed.Text = (MadePast.ToString());
            lblMoving.Text = (""+Score);
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
                            
                                x.Top -= zombieTopSpeed;
                                x.Left -= zombieSpeed;
                            
                            
                        }
                        if (parraleldirection == "down")
                        {
                            
                                x.Top += zombieTopSpeed;
                                x.Left -= zombieSpeed;
                            
                        }
                        
                    }
                    else
                    {
                        
                        if (x.Top < 90 || (x.Top + x.Height > this.ClientSize.Height))
                        {

                            ((PictureBox)x).Dispose();
                            zombiesList.Remove((PictureBox)x);
                            
                            MakeZombies();
                            
                        }
                        else
                        {
                            x.Left -= zombieSpeed;
                        }


                    }

                    //moving enemy

                }
                if (x is PictureBox && (string)x.Tag == "dead")
                {
                    if (x.Top > this.ClientSize.Height)
                    {

                        ((PictureBox)x).Dispose();
                        zombiesList.Remove((PictureBox)x);
                        
                    }
                    else
                    {

                        x.Top += zombieSpeed;
                        x.Left -= zombieSpeed;
                    }

                    

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
                            Score = Score + 100;
                            BulletPhysics("zombie");
                        }
                    }
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "fzombie")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            Score = Score + 150;
                            BulletPhysics("fzombie");
                        }
                    }
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "mzombie")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            Score = Score + 200;
                            BulletPhysics("mzombie");
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

                
                ActiveGame(false);
                GameOverScreen(true);
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

                if (e.KeyCode == Keys.Enter)
                {
                    if(txtPlayerName.Enabled)
                    {
                        btnWin_Click(sender, e);
                    }
                    
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
                if (PlayerPiece.Visible == true)
                {
                    shootbullet();
                }
                if (lblStart.Visible == true)
                {
                    lblStart_Click(sender, e);
                }
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
            if (e.KeyCode == Keys.X)
            {
                
                HelpMenu(false);
                ActiveGame(false);
                GameOverScreen(false);
                WinScreen(false);
                MainMenu(false);
                MissionBrief(true);
            }
            if (e.KeyCode == Keys.L)
            {
                Save("TestSave","1");
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
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPlayerName.Enabled)
                {
                    btnWin_Click(sender, e);
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
            Score = 0;
            MainMenu(false);
            MissionBrief(true);
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
            FightstartGame();
        }

        private void btnWin_Click(object sender, EventArgs e)
        {
            if(txtPlayerName.Text != "")
            {

                Save(txtPlayerName.Text, Score.ToString());
                txtPlayerName.Text = "";

            }

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
                zombie.Top = randNum.Next(100, this.ClientSize.Height - 100);
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

        private void MakeZombiesStart()
        {
            PictureBox zombie = new PictureBox();
            zombie.Size = new Size(90, 90);
            int x = randNum.Next(1, 4);
            if (x == 1)
            {
                zombie.Tag = "fzombie";
                zombie.Image = Properties.Resources.Fastenemy;
                zombie.Left = randNum.Next(this.ClientSize.Width + 500, this.ClientSize.Width + 600);
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
                zombie.Left = randNum.Next(this.ClientSize.Width + 500, this.ClientSize.Width + 600);
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
                zombie.Left = randNum.Next(this.ClientSize.Width + 500, this.ClientSize.Width + 600);
                zombie.Top = randNum.Next(90, this.ClientSize.Height - 90);
                zombie.SizeMode = PictureBoxSizeMode.StretchImage;
                zombiesList.Add(zombie);
                this.Controls.Add(zombie);
                zombie.BringToFront();
                PlayerPiece.BringToFront();
            }
        }

        private void FightstartGame()
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

                MakeZombiesStart();

            }

            GameTimer.Start();

        }
        private void missionsetup()
        {
            Enemymax = (25 * MissionLV) + 5;
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

        private void btnMON_Click(object sender, EventArgs e)
        {
            musicstate = "on";
            GameTune.Load();
            GameTune.PlayLooping();
        }

        private void btnMOFF_Click(object sender, EventArgs e)
        {
            GameTune.Stop();
            musicstate = "off";
        }

        private void lblStart_Click(object sender, EventArgs e)
        {
            
            
            MissionBrief(false);
            ActiveGame(true);
            FightstartGame();
        }

        private void Save(string newName, string newscore)
        {
            
            SavedScore newScore = new SavedScore()
            {

                Name = newName,
                Score = newscore
            };
            int currentIndex = -1;

                try
                {
                    
                    List<SavedScore> scoreList = _logicManager.FetchScores();

                if(scoreList.Count < 1)
                {
                    
                    scoreList.Add(newScore);
                    currentIndex = scoreList.Count - 1;
                    if (_logicManager.EditScores(scoreList, currentIndex))
                    {
                        // close this form with DialogResult = OK
                        this.DialogResult = DialogResult.OK;
                    }

                }
                else
                {
                    
                    scoreList.Add(newScore);
                    currentIndex = scoreList.Count - 1;
                    if (_logicManager.EditScores(scoreList, currentIndex))
                    {
                        // close this form with DialogResult = OK
                        this.DialogResult = DialogResult.OK;
                    }
                    RemoveOneScore();
                }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n\n" + ex.InnerException.Message);
                }

            
        }

        private void populateScoreBoard()
        {
            List<SavedScore> _scoreList = _logicManager.FetchScores();
            
            // clear the current items in lstFruitList
            // Don't clear the list, just clear the items
            lstScoreBoard.Items.Clear();
            int b = _scoreList.Count-1;
            lblHighScore.Text = ("High Score: " + _scoreList[b].Score + "\n\nName: " + _scoreList[b].Name);
            for (int i = 0; i < _scoreList.Count; i++)
            {
                
                

                lstScoreBoard.Items.Add(_scoreList[b].Name);
                lstScoreBoard.Items[lstScoreBoard.Items.Count - 1].SubItems.Add(_scoreList[b].Score);
                b--;
            }

            
        }
        private void btnReset_Click(object sender, EventArgs e)
        {


            List<SavedScore> _scoreList = _logicManager.FetchScores();
            int Reset = _scoreList.Count;
            while (Reset > 0)
            {
                SavedScore TargetNpc = _scoreList[Reset - 1];
                try
                {
                    _scoreList.Remove(TargetNpc);
                    if (_logicManager.RemoveScore(_scoreList))
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n\n" + ex.InnerException.Message);
                }
                Reset--;
            }
            Save("Nobody","0");
            populateScoreBoard();
        }
        private void RemoveOneScore()
        {
            // make sure something is selected
            
            List<SavedScore> scoreList = _logicManager.FetchScores();
            int lowestScore = int.Parse(scoreList[0].Score);
            int c = 0;
            int lowscoreposition = 0;
            SavedScore TargetScore;
            while (c < scoreList.Count)
            {
                if(lowestScore > int.Parse(scoreList[c].Score))
                {
                    lowestScore = int.Parse(scoreList[c].Score);
                    lowscoreposition = c;
                }
                c++;
            }
            TargetScore = scoreList[lowscoreposition];


            try
            {
                scoreList.Remove(TargetScore);
                _logicManager.RemoveScore(scoreList);
                if (_logicManager.RemoveScore(scoreList))
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.InnerException.Message);
            }


            populateScoreBoard();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            HelpMenu(false);
            MainMenu(true);
        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            btnReset_Click(sender,e);
        }
    }
}