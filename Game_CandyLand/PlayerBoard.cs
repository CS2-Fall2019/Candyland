//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Triple B & Schulze">
//     Copyright (c) Biles & Schulze. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Game_CandyLand
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class PlayerBoard : Form
    {
        public PlayerBoard()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            //set up locations for where each color is
            int[] GreenLocations = new int[21] {6,13,19,26,32,38,45,51,57,63,70,76,82,88,95,101,107,114,120,126,132};
            int[] OrangeLocations = new int[21] {5,12,18,25,31,37,44,50,56,62,68,75,81,87,94,100,106,113,119,125,131};
            int[] BlueLocations = new int[21] { 4, 11, 17, 24, 30, 36, 43, 49, 55, 61, 67, 74, 80, 86, 93, 99, 105, 112, 118, 124, 130 };
            int[] YellowLocations = new int[21] {3,10,16,23,29,35,41,48,54,60,66,73,79,85,91,98,105,111,117,123,129};
            int[] PurpleLocations = new int[21] { 2, 8, 15, 22, 28, 34, 40, 47, 53, 59, 65, 72, 78, 84, 90, 97, 104, 110, 116, 122, 128 };
            int[] RedLocations = new int[22] {1,7,14,21,27,33,39,46,52,58,64,71,77,83,89,96,103,109,115,121,127,133};
            int[] SpecialLocations = new int[6] {9,20,42,69,92,102};

            //create the board and initialize it
            Board PlayBoard = new Board();
            for (int i = 0; i < PlayBoard.Locations.Length; i++)
            {
                PlayBoard.Locations[i] = i;
            }

            //fill the locationcolor array
            int colorcounter = 0;
            int j = 1;
            while (colorcounter <= 20)
            {
                while(j <= 133)
                {
                    if (RedLocations[colorcounter] == j)
                    {
                        PlayBoard.LocationsColor[j] = "Red";
                    }
                    else if (PurpleLocations[colorcounter] == j)
                    {
                        PlayBoard.LocationsColor[j] = "Purple";
                    }
                    else if (YellowLocations[colorcounter] == j)
                    {
                        PlayBoard.LocationsColor[j] = "Yellow";
                    }
                    else if (BlueLocations[colorcounter] == j)
                    {
                        PlayBoard.LocationsColor[j] = "Blue";
                    }
                    else if (OrangeLocations[colorcounter] == j)
                    {
                        PlayBoard.LocationsColor[j] = "Orange";
                    }
                    else if (GreenLocations[colorcounter] == j)
                    {
                        PlayBoard.LocationsColor[j] = "Green";
                    }
                    
                    j++;
                }
                j = 0;
                colorcounter++;

            }

            outputlog_lbl.Text = "Arrays initialized...";
        }

        private void PlayerBoard_Load(object sender, EventArgs e)
        {

        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            DialogResult Closeform = MessageBox.Show("Are you sure you want to exit? All progress will be lost.","Exit CandyLand?", MessageBoxButtons.YesNo);
            if (Closeform == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }
    }
}
