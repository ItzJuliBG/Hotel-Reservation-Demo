using Hotel_Res.Models;
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
            string filePath2 = $"..\\..\\..\\LocalStorage\\text.txt";
            using StreamReader reader = new StreamReader(filePath2);

            var t = reader.ReadLine();
            //peek

            while (t != null)
            {
                var newLine = t.Trim().Split(", ");
                int roomNumber = int.Parse(newLine[0]);
                string name = newLine[1];
                string roomType = newLine[2];

                Room roomToAdd;
                if (newLine.Length == 4)
                {
                    roomToAdd = new Room(roomNumber, name, roomType, false);
                }
                else
                {
                    roomToAdd = new Room(roomNumber, name, roomType);
                }


                Rooms.Add(roomToAdd);
                t = reader.ReadLine();
            }

            dataGridView1.DataSource = Rooms;



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

        private void button1_Click_1(object sender, EventArgs e)
        {
            string filePath2 = $"..\\..\\..\\LocalStorage\\text.txt";
            using (StreamWriter writer = new StreamWriter(filePath2)) ;
            this.Hide();
            AllRoomsForm form = new AllRoomsForm();
            form.Show();
        }
    }
}
