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

        
        public Form1()
        {
            InitializeComponent();
        }
    }
}
