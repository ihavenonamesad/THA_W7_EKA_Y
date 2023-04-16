using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace THA_W7_EKA_Y
{
    public partial class Form1 : Form
    {
        List<Image> movieposters = new List <Image>();
        DataTable dtschedule = new DataTable();
        Random rnd = new Random();
        int movieid = 0;
        string[] movies = File.ReadAllText($@"C:\Users\{Environment.UserName}\source\repos\THA_W7_EKA_Y\THA_W7_EKA_Y\bin\debug\Movie Titles.txt").Split(',');
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtschedule.Columns.Add("Name");
            dtschedule.Columns.Add("Poster");
            dtschedule.Columns.Add("Schedule 10.30");
            dtschedule.Columns.Add("Schedule 13.00");
            dtschedule.Columns.Add("Schedule 15.30");
            dtschedule.Columns.Add("Schedule 18.00");
            dtschedule.Columns.Add("Schedule 20.45");
            dtschedule.Columns.Add("Schedule 23.00");
            for (int i = 0; i < movies.Length; i++)
            {
                string[] namepostersplitter = movies[i].Split('_');
                dtschedule.Rows.Add(namepostersplitter[0], namepostersplitter[1], randomseats(), randomseats(), randomseats(), randomseats(), randomseats(), randomseats());
            }
            AddPics();
        }
        private string randomseats()
        {
            string randomseat = "";
            for (int i =0; i < 100; i++)
            {
                int percent = rnd.Next(1, 101);
                if (percent > 30)
                {
                    randomseat = randomseat + rnd.Next(0, 2).ToString();
                }
                else
                {
                    randomseat = randomseat + "0";
                }
            }
            return randomseat;
        }
        private void AddPics()
        {
            int plcounter1 = 0;
            int plcounter2 = 0;
            int blcounter1 = 0;
            int blcounter2 = 0;
            for (int i = 0; i < 4; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromFile($@"C:\Users\{Environment.UserName}\source\repos\THA_W7_EKA_Y\THA_W7_EKA_Y\Movie Posters\{dtschedule.Rows[i][1]}");
                movieposters.Add(Image.FromFile($@"C:\Users\{Environment.UserName}\source\repos\THA_W7_EKA_Y\THA_W7_EKA_Y\Movie Posters\{dtschedule.Rows[i][1]}"));
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Location = new Point(76 + plcounter1, 70);
                pictureBox.Size = new Size(110, 135);
                pictureBox.Visible = true;
                plcounter1 = plcounter1 + 175;
                this.Controls.Add(pictureBox);
                Button button = new Button();
                button.Enabled = true;
                button.Visible = true;
                button.Location = new Point(92 + blcounter1, 217);
                button.Size = new Size(75, 23);
                button.Tag = i.ToString();
                movieid = i;
                button.Text = "WATCH";
                blcounter1 = blcounter1 + 175;
                button.Click += btn_click;
                this.Controls.Add(button);
            }
            for (int i = 4; i < 8; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromFile($@"C:\Users\{Environment.UserName}\source\repos\THA_W7_EKA_Y\THA_W7_EKA_Y\Movie Posters\{dtschedule.Rows[i][1]}");
                movieposters.Add(Image.FromFile($@"C:\Users\{Environment.UserName}\source\repos\THA_W7_EKA_Y\THA_W7_EKA_Y\Movie Posters\{dtschedule.Rows[i][1]}"));
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Location = new Point(76 + plcounter2, 260);
                pictureBox.Size = new Size(110, 135);
                pictureBox.Visible = true;
                plcounter2 = plcounter2 + 175;
                this.Controls.Add(pictureBox);
                Button button = new Button();
                button.Enabled = true;
                button.Visible = true;
                button.Location = new Point(92 + blcounter2, 403);
                button.Size = new Size(75, 23);
                button.Tag = i.ToString();
                movieid = i;
                button.Text = "WATCH";
                blcounter2 = blcounter2 + 175;
                button.Click += btn_click;
                this.Controls.Add(button);
            }
        }
        private void btn_click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            int index = Convert.ToInt32(b.Tag);
            Check(index);
        }
        private void Check(int id)
        {
            Movies movies = new Movies(dtschedule.Rows[id][0].ToString(), movieposters, dtschedule);
            panel1.Visible = true;
            movies.Dock = DockStyle.Fill;
            movies.TopLevel = false;
            movies.refer = this;
            this.panel1.Controls.Add(movies);
            movies.Show();
        }
       
        public void back()
        {
            panel1.Visible = false;
        }
        public void schedule(int id,int time, string data)
        {
            dtschedule.Rows[id][time] = data;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
