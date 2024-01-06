using Hotel_Res.Models;
using Hotel_Reservations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
        List<Room> newListRooms = new();
        public CleanRoomForm()
        {
            InitializeComponent();
            Rooms = new List<Room>();

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
        private void CleanRoomForm_Load(object sender, EventArgs e)
        {

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
                int inputNumber = int.Parse(input);
                if (inputNumber < 1 || inputNumber > 30)
                {
                    MessageBox.Show($"Такъв номер на стая не съществува! Стаите са с номера от 1-30!");
                }
                else
                {
                    Room currentRoom = Rooms.FirstOrDefault(x => x.RoomNumber == inputNumber);
                    string filePath2 = $"..\\..\\..\\LocalStorage\\text.txt";
                    using (StreamReader reader = new StreamReader(filePath2))
               

                    while (reader.EndOfStream != true)
                    {
                        var t = reader.ReadLine();
                        var newLine = t.Split(", ");
                        int currentNumber = int.Parse(newLine[0]);
                        string name = newLine[1];
                        string roomType = newLine[2];
                        if (currentNumber == inputNumber)
                        {
                            var roomToAdd = new Room(currentNumber, name, roomType);
                            newListRooms.Add(roomToAdd);
                        }
                    }

                    using (StreamWriter writer = new StreamWriter(filePath2)) //problem here with true value for append

                    foreach (var room in newListRooms)
                    {

                        // Write content to the file for the current room
                        writer.WriteLine($"{room.RoomNumber}, {room.ReservationName}, {room.RoomType}, false");

                    }

                }
            }
            else
            {
                MessageBox.Show("Използвайте само числа!");
            }
        }
    }
}
