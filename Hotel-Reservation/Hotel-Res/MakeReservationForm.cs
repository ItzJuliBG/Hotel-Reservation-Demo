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
    public partial class MakeReservationForm : Form
    {
        List<Room> Rooms;

        public MakeReservationForm()
        {
            InitializeComponent();

            Rooms = new();
        }
        private void MakeReservationForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }






        private void button1_Click(object sender, EventArgs e)
        {
            int roomNumber = int.Parse(textBox1.Text);
            string reservationName = textBox2.Text;
            string roomType = comboBox1.Text;

            if (roomNumber <= 0 || roomNumber > 30)
            {
                MessageBox.Show($"Такъв номер на стая не съществува! Стаите са с номера от 1-30!");
            }
            if (roomType != "Апартамент" && roomType != "Стая")
            {
                MessageBox.Show($"Не пиши там :) {Environment.NewLine}Избери от стрелката вдясно!");
            }


            var roomToAdd = new Room(roomNumber, reservationName, roomType);

            Rooms.Add(roomToAdd);

            string filePath = $"..\\..\\..\\LocalStorage";
            Directory.CreateDirectory(filePath);
            string filePath2 = $"..\\..\\..\\LocalStorage\\text.txt";



            foreach (var room in Rooms)
            {
                using (StreamWriter writer = new StreamWriter(filePath2))
                {
                    // Write content to the file for the current room
                    writer.WriteLine($"{room.RoomNumber}, {room.ReservationName}, {room.RoomType}");
                }
            }

        }








        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
