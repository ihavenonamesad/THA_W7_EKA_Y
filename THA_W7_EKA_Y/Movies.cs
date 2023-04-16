using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace THA_W7_EKA_Y
{
    public partial class Movies : Form
    {
        List<Image> movieposters = new List<Image>();
        DataTable dtschedule = new DataTable();
        string data = "";
        int datamovie = 0;
        int times = 0;

        public Movies(string lbl, List<Image> movieposters, DataTable dtschedule)
        {
            InitializeComponent();
            this.lbl_movietitle.Text = lbl;
            this.movieposters = movieposters;
            this.dtschedule = dtschedule;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button chairs = new Button();
                    chairs.Enabled = true;
                    chairs.Size = new Size(30, 30);
                    chairs.Location = new Point(30 + (30 * j), 30 + (30 * i));
                    if (i == 0)
                    {
                        chairs.Tag = j.ToString();
                    }
                    else
                    {
                        chairs.Tag = i.ToString() + j.ToString();
                    }
                  
                    chairs.Click += ChairClick;
                    pnl_seats.Controls.Add(chairs);
                }
            }
        }
        private void ChairClick(object sender, EventArgs e)
        {
            Button chair = sender as Button;
            if (chair.BackColor == Color.Gray)
            {
                chair.BackColor = Color.SeaGreen;

            }
            else if (chair.BackColor == Color.SeaGreen)
            {
                chair.BackColor = Color.Gray;
            }
        }

        private void Movies_Load(object sender, EventArgs e)
        {
            pnl_background.BackColor = Color.FromArgb(100, 0, 0, 0);
            if (lbl_movietitle.Text == "12 Years a Slave")
            {
                pic_poster.Image = movieposters[0];
                pic_poster.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (lbl_movietitle.Text == "Gladiator")
            {
                pic_poster.Image = movieposters[1];
                pic_poster.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (lbl_movietitle.Text == "Lord of The Rings: Return of The King")
            {
                pic_poster.Image = movieposters[2];
                pic_poster.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (lbl_movietitle.Text == "No Country For Old Men")
            {
                pic_poster.Image = movieposters[3];
                pic_poster.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (lbl_movietitle.Text == "The Departed")
            {
                pic_poster.Image = movieposters[4];
                pic_poster.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (lbl_movietitle.Text == "The Pianist")
            {
                pic_poster.Image = movieposters[5];
                pic_poster.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (lbl_movietitle.Text == "Requiem for a Dream")
            {
                pic_poster.Image = movieposters[6];
                pic_poster.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (lbl_movietitle.Text == "The Shawshank Redemption")
            {
                pic_poster.Image = movieposters[7];
                pic_poster.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_movietitle_Click(object sender, EventArgs e)
        {
        }
        private void seats(int time)
        {
            refer.schedule(datamovie, time, data);
            dtschedule.Rows[datamovie][time] = data;
            int counter = 0;
            foreach (Button button in pnl_seats.Controls.OfType<Button>())
            {
                if (data[counter] == '0')
                {
                    button.BackColor = Color.Gray;
                }
                else
                {
                    button.BackColor = Color.Red;
                }
                counter++;
            }
        }
        public Form1 refer { get; set; }
        private void btn_1030_Click(object sender, EventArgs e)
        {
            btn_Add.Enabled = true;
            btn_Reset.Enabled = true;
            for (int i = 0; i < 8; i++)
            {
                if (dtschedule.Rows[i][0].ToString() == lbl_movietitle.Text)
                {
                    datamovie = i;
                }
            }
            data = dtschedule.Rows[datamovie][2].ToString();
            seats(2);
            times = 2;
        }

        private void btn_1300_Click(object sender, EventArgs e)
        {
            btn_Add.Enabled = true;
            btn_Reset.Enabled = true;
            for (int i = 0; i < 8; i++)
            {
                if (dtschedule.Rows[i][0].ToString() == lbl_movietitle.Text)
                {
                    datamovie = i;
                }
            }
            data = dtschedule.Rows[datamovie][3].ToString();
            seats(3);
            times = 3;
        }

        private void btn_1530_Click(object sender, EventArgs e)
        {
            btn_Add.Enabled = true;
            btn_Reset.Enabled = true;
            for (int i = 0; i < 8; i++)
            {
                if (dtschedule.Rows[i][0].ToString() == lbl_movietitle.Text)
                {
                    datamovie = i;
                }
            }
            data = dtschedule.Rows[datamovie][4].ToString();
            seats(4);
            times = 4;
        }

        private void btn_1800_Click(object sender, EventArgs e)
        {
            btn_Add.Enabled = true;
            btn_Reset.Enabled = true;
            for (int i = 0; i < 8; i++)
            {
                if (dtschedule.Rows[i][0].ToString() == lbl_movietitle.Text)
                {
                    datamovie = i;
                }
            }
            data = dtschedule.Rows[datamovie][5].ToString();
            seats(5);
            times = 5;
        }

        private void btn_2045_Click(object sender, EventArgs e)
        {
            btn_Add.Enabled = true;
            btn_Reset.Enabled = true;
            for (int i = 0; i < 8; i++)
            {
                if (dtschedule.Rows[i][0].ToString() == lbl_movietitle.Text)
                {
                    datamovie = i;
                }
            }
            data = dtschedule.Rows[datamovie][6].ToString();
            seats(6);
            times = 6;
        }

        private void btn_2300_Click(object sender, EventArgs e)
        { 
            btn_Add.Enabled = true;
            btn_Reset.Enabled = true;
            for (int i = 0; i < 8; i++)
            {
                if (dtschedule.Rows[i][0].ToString() == lbl_movietitle.Text)
                {
                    datamovie = i;
                }
            }
            data = dtschedule.Rows[datamovie][7].ToString();
            seats(7);
            times = 7;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            refer.back();
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int counter = 0;
            List<string> taglist = new List<string>();
            foreach (Button button in pnl_seats.Controls.OfType<Button>())
            {
                if (button.BackColor == Color.SeaGreen)
                {
                    button.BackColor = Color.Red;
                    taglist.Add(button.Tag.ToString());
                }

            }
            string newdata = "";
            
            for (int o = 0; o < 100; o++)
            {
                bool yes = false;
                for (int i = 0; i < taglist.Count; i++)
                {
                    
                    if (taglist[i] == o.ToString())
                    {
                        yes = true;
                        break;
                    }
                }
                if (yes)
                {
                    newdata = newdata + "1";
                }
                else
                {
                    newdata = newdata+data[o].ToString();
                }
            }
            data = newdata;
            seats(times);
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            data = "0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000";
            seats(times);
        }
    }
}
