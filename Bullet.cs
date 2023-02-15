using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Timers;
using System.Windows.Forms;
//using Timer = System.Timers.Timer;

using Timer = System.Windows.Forms.Timer;

namespace FreeMoveShoot
{
    class Bullet
    {
        
        public int bulletX;
        public int bulletY;

        private int speed = 20;
        private PictureBox bullet = new PictureBox();
        private Timer bulletTimer = new Timer();

        public void MakeBullet(Form form)
        {
            bullet.BackColor = Color.Blue;
            bullet.Size = new Size(20, 20);
            bullet.Tag = "bullet";
            bullet.Left = bulletX;
            bullet.Top = bulletY;
            

            form.Controls.Add(bullet);
            bullet.BringToFront();

            bulletTimer.Interval = speed;
            bulletTimer.Tick += new EventHandler(BulletTimerEvent);
            bulletTimer.Start();
        }

        private void BulletTimerEvent(object sender, EventArgs e)
        {
            
            bullet.Left += speed;
            


        }



    }
}
