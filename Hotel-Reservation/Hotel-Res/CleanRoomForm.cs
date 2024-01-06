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
    public partial class CleanRoomForm : Form
    {
        List<Room> Rooms;
        public CleanRoomForm()
        {
            InitializeComponent();
            Rooms = new List<Room>();
        }
        private void CleanRoomForm_Load(object sender, EventArgs e)
        {
            string filePath2 = $"..\\..\\..\\LocalStorage\\text.txt";
            using StreamReader reader = new StreamReader(filePath2);

            int charsRemeining = reader.Peek();
            if (charsRemeining > 1)
            {
                while (reader.EndOfStream != true)
                {
                    var t = reader.ReadLine();
                    var newLine = t.Split(", ");
                    int roomNumber = int.Parse(newLine[0]);
                    string name = newLine[1];
                    string roomType = newLine[2];

                    var roomToAdd = new Room(roomNumber, name, roomType);

                    Rooms.Add(roomToAdd);

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            if (int.TryParse(input, out _))
            {
                int roomNumber = int.Parse(input);
                if (roomNumber < 1 || roomNumber > 30)
                {
                    MessageBox.Show($"Такъв номер на стая не съществува! Стаите са с номера от 1-30!");
                }
                Room currentRoom = Rooms.FirstOrDefault(x=> x.RoomNumber == roomNumber);
            }
            else
            {
                MessageBox.Show("Използвайте само числа!");
            }
        }
    }
}
