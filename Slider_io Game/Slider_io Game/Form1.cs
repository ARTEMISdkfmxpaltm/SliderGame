﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slider_io_Game
{
    public partial class Form1 : Form
    {
        private List<Circle> slider = new List<Circle>();
        private Circle dirt = new Circle();

        int maxWidth;
        int maxHeight;

        int score;
        int highScore;

        Random rand = new Random();

        bool goLeft, goRight, goDown, goUp;

        public Form1()
        {
            InitializeComponent();

            new Settings();
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && Settings.directions != "right")
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right && Settings.directions != "left")
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up && Settings.directions != "down")
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down && Settings.directions != "up")
            {
                goDown = true;
            }
        }

        private void StartGame(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void TakeSnapShot(object sender, EventArgs e)
        {
            Label caption = new Label();
            caption.Text = "My scored : " + score + " Highscore : " + highScore;
            caption.Font = new Font("Ariel", 20, FontStyle.Bold);
            caption.ForeColor = Color.Black;
            caption.AutoSize = false;
            caption.Width = picCanvas.Width;
            caption.Height = 30;
            caption.TextAlign = ContentAlignment.MiddleCenter;
            picCanvas.Controls.Add(caption);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "SnapShot";
            dialog.DefaultExt = "jpg";
            dialog.Filter = "JPG Image File | *.jpg";
            dialog.ValidateNames = true;
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {

        }

        private void UpdatePictureBoxGraphics(object sender, PaintEventArgs e)
        {

        }
        private void RestartGame()
        {            
            maxWidth = picCanvas.Width / Settings.Width - 1;
            maxHeight = picCanvas.Height / Settings.Height - 1;

            slider.Clear();

            startButton.Enabled = false;
            snapButton.Enabled = false;
            score = 0;
            txtScore.Text = "Score: " + score;

            Circle head = new Circle { X = 10, Y = 5 };
            slider.Add(head); 

            for (int i = 0; i < 10; i++)
            {
                Circle body = new Circle();
                slider.Add(body);
            }

            dirt = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };

            gameTimer.Start();

        }
    }
}
