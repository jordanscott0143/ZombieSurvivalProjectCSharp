﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace SurviveTheNight
{
    class Bullet
    {
        public string direction;
        public int bulletLeft;
        public int bulletTop;

        private int speed = 20;
        private PictureBox bullet = new PictureBox();

        private Timer bulletTimer = new Timer();

        public void MakeBullet(Form form)
        {
            bullet.BackColor = Color.OrangeRed;
            bullet.Size = new Size(5, 5);
            bullet.Tag = "bullet";
            bullet.Top = bulletTop;
            bullet.Left = bulletLeft;
            bullet.BringToFront();

            form.Controls.Add(bullet);

            bulletTimer.Interval = speed;
            bulletTimer.Tick += new EventHandler(bulletTimerEvent);
            bulletTimer.Start();
        }

        private void bulletTimerEvent(object sender, EventArgs e)
        {
            if (direction == "left")
            {
                bullet.Left -= speed;
            }
            if (direction == "right")
            {
                bullet.Left += speed;
            }
            if (direction == "up")
            {
                bullet.Top -= speed;
            }
            if (direction == "down")
            {
                bullet.Top += speed;
            }

            if (bullet.Left < 10 || bullet.Left > 860 || bullet.Top < 10 || bullet.Top > 600)
            {
                bulletTimer.Stop();
                bulletTimer.Dispose();
                bullet.Dispose();
                bulletTimer = null;
                bullet = null;
            }

        }
    }
}
