﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace SurviveTheNight
{
    public partial class About : Form
    {
        public About()
        {
            Sounds theme = new Sounds();
            theme.playSoundTheme();

            InitializeComponent();
        }

        private void returnToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainMenu mainMenu = new MainMenu();

            mainMenu.Show();

            Sounds click = new Sounds();
            click.playSoundButtonClick();
        }
    }
}
