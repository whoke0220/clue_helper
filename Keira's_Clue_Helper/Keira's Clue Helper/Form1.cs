using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Keira_s_Clue_Helper
{
    public partial class Form1 : Form
    {
        public bool miss_scarlet_clicked = true;
        public bool colonel_mustard_clicked = true;
        public bool mrs_peacock_clicked = true;
        public bool professor_plum_clicked = true;
        public bool mrs_white_clicked = true;
        public bool mr_green_clicked = true;
        public bool dining_room_clicked = true;
        public bool conservatory_clicked = true;
        public bool kitchen_clicked = true;
        public bool ballroom_clicked = true;
        public bool study_clicked = true;
        public bool lounge_clicked = true;
        public bool library_clicked = true;
        public bool hall_clicked = true;
        public bool billiard_room_clicked = true;
        public bool lead_pipe_clicked = true;
        public bool knife_clicked = true;
        public bool candlestick_clicked = true;
        public bool revolver_clicked = true;
        public bool rope_clicked = true;
        public bool wrench_clicked = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Miss_Scarlet_Click(object sender, EventArgs e)
        {

            if(miss_scarlet_clicked)
            {
                Miss_Scarlet.Image = Properties.Resources.not_miss_scarlet;
                miss_scarlet_clicked = false;
            }
            else
            {
                miss_scarlet_clicked = true;
                Miss_Scarlet.Image = Properties.Resources.miss_scarlet;
            }
        }

        private void Colonel_Mustard_Click(object sender, EventArgs e)
        {
            if (colonel_mustard_clicked)
            {
                Colonel_Mustard.Image = Properties.Resources.not_colonel_mustard;
                colonel_mustard_clicked = false;
            }
            else
            {
                colonel_mustard_clicked = true;
                Colonel_Mustard.Image = Properties.Resources.colonel_mustard;
            }
        }

        private void Mrs_White_Click(object sender, EventArgs e)
        {
            if (mrs_white_clicked)
            {
                Mrs_White.Image = Properties.Resources.not_mrs_white;
                mrs_white_clicked = false;
            }
            else
            {
                mrs_white_clicked = true;
                Mrs_White.Image = Properties.Resources.mrs_white;
            }
        }

        private void Mr_Green_Click(object sender, EventArgs e)
        {
            if (mr_green_clicked)
            {
                Mr_Green.Image = Properties.Resources.not_mr_green;
                mr_green_clicked = false;
            }
            else
            {
                mr_green_clicked = true;
                Mr_Green.Image = Properties.Resources.mr_green;
            }
        }

        private void Mrs_Peacock_Click(object sender, EventArgs e)
        {
            if (mrs_peacock_clicked)
            {
                Mrs_Peacock.Image = Properties.Resources.not_mrs_peacock;
                mrs_peacock_clicked = false;
            }
            else
            {
                mrs_peacock_clicked = true;
                Mrs_Peacock.Image = Properties.Resources.mrs_peacock;
            }
        }

        private void Professor_Plum_Click(object sender, EventArgs e)
        {
            if (professor_plum_clicked)
            {
                Professor_Plum.Image = Properties.Resources.not_professor_plum;
                professor_plum_clicked = false;
            }
            else
            {
                professor_plum_clicked = true;
                Professor_Plum.Image = Properties.Resources.professor_plum;
            }
        }

        private void Candlestick_Click(object sender, EventArgs e)
        {
            if (candlestick_clicked)
            {
                Candlestick.Image = Properties.Resources.not_candlestick;
                candlestick_clicked = false;
            }
            else
            {
                candlestick_clicked = true;
                Candlestick.Image = Properties.Resources.candlestick;
            }
        }

        private void Knife_Click(object sender, EventArgs e)
        {
            if (knife_clicked)
            {
                Knife.Image = Properties.Resources.not_knife;
                knife_clicked = false;
            }
            else
            {
                knife_clicked = true;
                Knife.Image = Properties.Resources.knife;
            }
        }

        private void lead_pipe_Click(object sender, EventArgs e)
        {
            if (lead_pipe_clicked)
            {
                lead_pipe.Image = Properties.Resources.not_lead_pipe;
                lead_pipe_clicked = false;
            }
            else
            {
                lead_pipe_clicked = true;
                lead_pipe.Image = Properties.Resources.lead_pipe;
            }
        }

        private void revolver_Click(object sender, EventArgs e)
        {
            if (revolver_clicked)
            {
                revolver.Image = Properties.Resources.not_revolover;
                revolver_clicked = false;
            }
            else
            {
                revolver_clicked = true;
                revolver.Image = Properties.Resources.revolover;
            }
        }

        private void Rope_Click(object sender, EventArgs e)
        {
            if (rope_clicked)
            {
                Rope.Image = Properties.Resources.not_Rope;
                rope_clicked = false;
            }
            else
            {
                rope_clicked = true;
                Rope.Image = Properties.Resources.Rope;
            }
        }

        private void wrench_Click(object sender, EventArgs e)
        {
            if (wrench_clicked)
            {
                wrench.Image = Properties.Resources.not_wrench;
                wrench_clicked = false;
            }
            else
            {
                wrench_clicked = true;
                wrench.Image = Properties.Resources.wrench;
            }
        }

        private void Ballroom_Click(object sender, EventArgs e)
        {
            if (ballroom_clicked)
            {
                Ballroom.Image = Properties.Resources.not_ballroom;
                ballroom_clicked = false;
            }
            else
            {
                ballroom_clicked = true;
                Ballroom.Image = Properties.Resources.Ballroom;
            }
        }

        private void Billiard_Room_Click(object sender, EventArgs e)
        {
            if (billiard_room_clicked)
            {
                Billiard_Room.Image = Properties.Resources.not_Billiard_Room;
                billiard_room_clicked = false;
            }
            else
            {
                billiard_room_clicked = true;
                Billiard_Room.Image = Properties.Resources.Billiard_Room;
            }
        }

        private void Conservatory_Click(object sender, EventArgs e)
        {
            if (conservatory_clicked)
            {
                Conservatory.Image = Properties.Resources.not_Conservatory;
                conservatory_clicked = false;
            }
            else
            {
                conservatory_clicked = true;
                Conservatory.Image = Properties.Resources.Conservatory;
            }
        }

        private void Dining_Room_Click(object sender, EventArgs e)
        {
            if (dining_room_clicked)
            {
                Dining_Room.Image = Properties.Resources.not_Dining_Room;
                dining_room_clicked = false;
            }
            else
            {
                dining_room_clicked = true;
                Dining_Room.Image = Properties.Resources.Dining_Room;
            }
        }

        private void Hall_Click(object sender, EventArgs e)
        {
            if (hall_clicked)
            {
                Hall.Image = Properties.Resources.not_Hall;
                hall_clicked = false;
            }
            else
            {
                hall_clicked = true;
                Hall.Image = Properties.Resources.Hall;
            }
        }

        private void Kitchen_Click(object sender, EventArgs e)
        {
            if (kitchen_clicked)
            {
                Kitchen.Image = Properties.Resources.not_Kitchen;
                kitchen_clicked = false;
            }
            else
            {
                kitchen_clicked = true;
                Kitchen.Image = Properties.Resources.Kitchen;
            }
        }

        private void Library_Click(object sender, EventArgs e)
        {
            if (library_clicked)
            {
                Library.Image = Properties.Resources.not_Library;
                library_clicked = false;
            }
            else
            {
                library_clicked = true;
                Library.Image = Properties.Resources.Library;
            }
        }

        private void Lounge_Click(object sender, EventArgs e)
        {
            if (lounge_clicked)
            {
                Lounge.Image = Properties.Resources.not_Lounge;
                lounge_clicked = false;
            }
            else
            {
                lounge_clicked = true;
                Lounge.Image = Properties.Resources.Lounge;
            }
        }

        private void Study_Click(object sender, EventArgs e)
        {
            if (study_clicked)
            {
                Study.Image = Properties.Resources.not_Study;
                study_clicked = false;
            }
            else
            {
                study_clicked = true;
                Study.Image = Properties.Resources.Study;
            }
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            Miss_Scarlet.Image = Properties.Resources.miss_scarlet;
            Colonel_Mustard.Image = Properties.Resources.colonel_mustard;
            Mrs_Peacock.Image = Properties.Resources.mrs_peacock;
            Professor_Plum.Image = Properties.Resources.professor_plum;
            Mrs_White.Image = Properties.Resources.mrs_white;
            Mr_Green.Image = Properties.Resources.mr_green;
            Dining_Room.Image = Properties.Resources.Dining_Room;
            Conservatory.Image = Properties.Resources.Conservatory;
            Kitchen.Image = Properties.Resources.Kitchen;
            Ballroom.Image = Properties.Resources.Ballroom;
            Study.Image = Properties.Resources.Study;
            Lounge.Image = Properties.Resources.Lounge;
            Library.Image = Properties.Resources.Library;
            Hall.Image = Properties.Resources.Hall;
            Billiard_Room.Image = Properties.Resources.Billiard_Room;
            lead_pipe.Image = Properties.Resources.lead_pipe;
            Knife.Image = Properties.Resources.knife;
            Candlestick.Image = Properties.Resources.candlestick;
            revolver.Image = Properties.Resources.revolover;
            Rope.Image = Properties.Resources.Rope;
            wrench.Image = Properties.Resources.wrench;

            miss_scarlet_clicked = true;
            colonel_mustard_clicked = true;
            mrs_peacock_clicked = true;
            professor_plum_clicked = true;
            mrs_white_clicked = true;
            mr_green_clicked = true;
            dining_room_clicked = true;
            conservatory_clicked = true;
            kitchen_clicked = true;
            ballroom_clicked = true;
            study_clicked = true;
            lounge_clicked = true;
            library_clicked = true;
            hall_clicked = true;
            billiard_room_clicked = true;
            lead_pipe_clicked = true;
            knife_clicked = true;
            candlestick_clicked = true;
            revolver_clicked = true;
            rope_clicked = true;
            wrench_clicked = true;
    }
    }
}
