using Hotel_Res.Models;
using Hotel_Res.Utilities;
using Hotel_Reservations;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Res
{
    public partial class AllRoomsForm : Form
    {
        List<Room> Rooms;
        public AllRoomsForm()
        {
            InitializeComponent();

            Rooms = new List<Room>();
        }

        private void AllRoomsForm_Load(object sender, EventArgs e)
        {
            string filePath2 = FilePaths.ReservationFileSavePath;
            using StreamReader reader = new StreamReader(filePath2);

            while (reader.EndOfStream != true)
            {
                var t = reader.ReadLine();
                var newLine = t.Split(", ");
                int roomNumber = int.Parse(newLine[0]);
                string name = newLine[1];
                string roomType = newLine[2];
                bool isCleaned = bool.Parse(newLine[3]);
                bool isOccupated = bool.Parse(newLine[4]);

                var roomToAdd = new Room(roomNumber, name, roomType, isCleaned, isOccupated);

                Rooms.Add(roomToAdd);

            }

            dataGridView1.DataSource = Rooms;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                for (int i = 0; i < 2; i++)
                {
                    if (Convert.ToBoolean(row.Cells[i].Value) == true)
                    {
                        row.Cells[i].Style.BackColor = Color.Green; 
                    }
                    else if (Convert.ToBoolean(row.Cells[i].Value) == false)
                    {
                        row.Cells[i].Style.BackColor = Color.Red;
                    }
                }
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
