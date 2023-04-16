namespace THA_W7_EKA_Y
{
    partial class Movies
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Movies));
            this.pnl_seats = new System.Windows.Forms.Panel();
            this.lbl_movietitle = new System.Windows.Forms.Label();
            this.btn_1030 = new System.Windows.Forms.Button();
            this.btn_1300 = new System.Windows.Forms.Button();
            this.btn_1530 = new System.Windows.Forms.Button();
            this.btn_1800 = new System.Windows.Forms.Button();
            this.btn_2045 = new System.Windows.Forms.Button();
            this.btn_2300 = new System.Windows.Forms.Button();
            this.pic_poster = new System.Windows.Forms.PictureBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_booked = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_avail = new System.Windows.Forms.Button();
            this.lbl_booked = new System.Windows.Forms.Label();
            this.lbl_Avail = new System.Windows.Forms.Label();
            this.lbl_select = new System.Windows.Forms.Label();
            this.btn_screen = new System.Windows.Forms.Button();
            this.pnl_background = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_poster)).BeginInit();
            this.pnl_background.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_seats
            // 
            this.pnl_seats.BackColor = System.Drawing.Color.Transparent;
            this.pnl_seats.Location = new System.Drawing.Point(385, 70);
            this.pnl_seats.Name = "pnl_seats";
            this.pnl_seats.Size = new System.Drawing.Size(369, 347);
            this.pnl_seats.TabIndex = 0;
            this.pnl_seats.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_movietitle
            // 
            this.lbl_movietitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_movietitle.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_movietitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_movietitle.Location = new System.Drawing.Point(3, 10);
            this.lbl_movietitle.Name = "lbl_movietitle";
            this.lbl_movietitle.Size = new System.Drawing.Size(360, 70);
            this.lbl_movietitle.TabIndex = 1;
            this.lbl_movietitle.Text = "title";
            this.lbl_movietitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_movietitle.Click += new System.EventHandler(this.lbl_movietitle_Click);
            // 
            // btn_1030
            // 
            this.btn_1030.Location = new System.Drawing.Point(43, 312);
            this.btn_1030.Name = "btn_1030";
            this.btn_1030.Size = new System.Drawing.Size(75, 23);
            this.btn_1030.TabIndex = 2;
            this.btn_1030.Text = "10.30";
            this.btn_1030.UseVisualStyleBackColor = true;
            this.btn_1030.Click += new System.EventHandler(this.btn_1030_Click);
            // 
            // btn_1300
            // 
            this.btn_1300.Location = new System.Drawing.Point(143, 312);
            this.btn_1300.Name = "btn_1300";
            this.btn_1300.Size = new System.Drawing.Size(75, 23);
            this.btn_1300.TabIndex = 3;
            this.btn_1300.Text = "13.00";
            this.btn_1300.UseVisualStyleBackColor = true;
            this.btn_1300.Click += new System.EventHandler(this.btn_1300_Click);
            // 
            // btn_1530
            // 
            this.btn_1530.Location = new System.Drawing.Point(248, 312);
            this.btn_1530.Name = "btn_1530";
            this.btn_1530.Size = new System.Drawing.Size(75, 23);
            this.btn_1530.TabIndex = 4;
            this.btn_1530.Text = "15.30";
            this.btn_1530.UseVisualStyleBackColor = true;
            this.btn_1530.Click += new System.EventHandler(this.btn_1530_Click);
            // 
            // btn_1800
            // 
            this.btn_1800.Location = new System.Drawing.Point(43, 360);
            this.btn_1800.Name = "btn_1800";
            this.btn_1800.Size = new System.Drawing.Size(75, 23);
            this.btn_1800.TabIndex = 5;
            this.btn_1800.Text = "18.00";
            this.btn_1800.UseVisualStyleBackColor = true;
            this.btn_1800.Click += new System.EventHandler(this.btn_1800_Click);
            // 
            // btn_2045
            // 
            this.btn_2045.Location = new System.Drawing.Point(143, 360);
            this.btn_2045.Name = "btn_2045";
            this.btn_2045.Size = new System.Drawing.Size(75, 23);
            this.btn_2045.TabIndex = 6;
            this.btn_2045.Text = "20.45";
            this.btn_2045.UseVisualStyleBackColor = true;
            this.btn_2045.Click += new System.EventHandler(this.btn_2045_Click);
            // 
            // btn_2300
            // 
            this.btn_2300.Location = new System.Drawing.Point(248, 360);
            this.btn_2300.Name = "btn_2300";
            this.btn_2300.Size = new System.Drawing.Size(75, 23);
            this.btn_2300.TabIndex = 7;
            this.btn_2300.Text = "23.00";
            this.btn_2300.UseVisualStyleBackColor = true;
            this.btn_2300.Click += new System.EventHandler(this.btn_2300_Click);
            // 
            // pic_poster
            // 
            this.pic_poster.Location = new System.Drawing.Point(79, 93);
            this.pic_poster.Name = "pic_poster";
            this.pic_poster.Size = new System.Drawing.Size(157, 195);
            this.pic_poster.TabIndex = 8;
            this.pic_poster.TabStop = false;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Enabled = false;
            this.btn_Reset.Location = new System.Drawing.Point(267, 167);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.btn_Reset.TabIndex = 9;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(267, 196);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 10;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Enabled = false;
            this.btn_Add.Location = new System.Drawing.Point(267, 138);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 11;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_booked
            // 
            this.btn_booked.BackColor = System.Drawing.Color.Red;
            this.btn_booked.Location = new System.Drawing.Point(397, 22);
            this.btn_booked.Name = "btn_booked";
            this.btn_booked.Size = new System.Drawing.Size(30, 30);
            this.btn_booked.TabIndex = 12;
            this.btn_booked.UseVisualStyleBackColor = false;
            // 
            // btn_select
            // 
            this.btn_select.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_select.Location = new System.Drawing.Point(654, 22);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(30, 30);
            this.btn_select.TabIndex = 13;
            this.btn_select.UseVisualStyleBackColor = false;
            // 
            // btn_avail
            // 
            this.btn_avail.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn_avail.Location = new System.Drawing.Point(518, 22);
            this.btn_avail.Name = "btn_avail";
            this.btn_avail.Size = new System.Drawing.Size(30, 30);
            this.btn_avail.TabIndex = 14;
            this.btn_avail.UseVisualStyleBackColor = false;
            // 
            // lbl_booked
            // 
            this.lbl_booked.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_booked.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_booked.Location = new System.Drawing.Point(427, 26);
            this.lbl_booked.Name = "lbl_booked";
            this.lbl_booked.Size = new System.Drawing.Size(71, 23);
            this.lbl_booked.TabIndex = 15;
            this.lbl_booked.Text = "Booked";
            this.lbl_booked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Avail
            // 
            this.lbl_Avail.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Avail.Location = new System.Drawing.Point(548, 26);
            this.lbl_Avail.Name = "lbl_Avail";
            this.lbl_Avail.Size = new System.Drawing.Size(89, 21);
            this.lbl_Avail.TabIndex = 16;
            this.lbl_Avail.Text = "Available";
            this.lbl_Avail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_select
            // 
            this.lbl_select.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_select.Location = new System.Drawing.Point(684, 26);
            this.lbl_select.Name = "lbl_select";
            this.lbl_select.Size = new System.Drawing.Size(82, 21);
            this.lbl_select.TabIndex = 17;
            this.lbl_select.Text = "Selected";
            this.lbl_select.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_screen
            // 
            this.btn_screen.Location = new System.Drawing.Point(433, 58);
            this.btn_screen.Name = "btn_screen";
            this.btn_screen.Size = new System.Drawing.Size(262, 22);
            this.btn_screen.TabIndex = 0;
            this.btn_screen.Text = "Screen";
            this.btn_screen.UseVisualStyleBackColor = true;
            // 
            // pnl_background
            // 
            this.pnl_background.Controls.Add(this.btn_screen);
            this.pnl_background.Controls.Add(this.lbl_movietitle);
            this.pnl_background.Controls.Add(this.pnl_seats);
            this.pnl_background.Controls.Add(this.btn_1530);
            this.pnl_background.Controls.Add(this.btn_2300);
            this.pnl_background.Controls.Add(this.btn_1300);
            this.pnl_background.Controls.Add(this.pic_poster);
            this.pnl_background.Controls.Add(this.btn_Reset);
            this.pnl_background.Controls.Add(this.btn_Back);
            this.pnl_background.Controls.Add(this.btn_Add);
            this.pnl_background.Controls.Add(this.btn_2045);
            this.pnl_background.Controls.Add(this.btn_1030);
            this.pnl_background.Controls.Add(this.btn_1800);
            this.pnl_background.Location = new System.Drawing.Point(12, 12);
            this.pnl_background.Name = "pnl_background";
            this.pnl_background.Size = new System.Drawing.Size(776, 430);
            this.pnl_background.TabIndex = 18;
            // 
            // Movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_select);
            this.Controls.Add(this.lbl_Avail);
            this.Controls.Add(this.lbl_booked);
            this.Controls.Add(this.btn_avail);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.btn_booked);
            this.Controls.Add(this.pnl_background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Movies";
            this.Text = "Movies";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Movies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_poster)).EndInit();
            this.pnl_background.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_seats;
        private System.Windows.Forms.Label lbl_movietitle;
        private System.Windows.Forms.Button btn_1030;
        private System.Windows.Forms.Button btn_1300;
        private System.Windows.Forms.Button btn_1530;
        private System.Windows.Forms.Button btn_1800;
        private System.Windows.Forms.Button btn_2045;
        private System.Windows.Forms.Button btn_2300;
        private System.Windows.Forms.PictureBox pic_poster;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_booked;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_avail;
        private System.Windows.Forms.Label lbl_booked;
        private System.Windows.Forms.Label lbl_Avail;
        private System.Windows.Forms.Label lbl_select;
        private System.Windows.Forms.Button btn_screen;
        private System.Windows.Forms.Panel pnl_background;
    }
}