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
    public partial class MakeReservationForm : Form
    {
        List<Room> Rooms;
        List<Room> newListRooms = new();

        public MakeReservationForm()
        {
            InitializeComponent();

            Rooms = new();
        }
        private void MakeReservationForm_Load(object sender, EventArgs e)
        {
            string filePath2 = FilePaths.ReservationFileSavePath;
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
                    bool isCleaned = bool.Parse(newLine[3]);
                    bool isOccupated = bool.Parse(newLine[4]);

                    var roomToAdd = new Room(roomNumber, name, roomType, isCleaned, isOccupated);

                    Rooms.Add(roomToAdd);

                }
            }
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

            if (roomNumber <= 0 || roomNumber > 30)
            {
                MessageBox.Show($"Такъв номер на стая не съществува! Стаите са с номера от 1-30!");

            }
            else if (reservationName == null || reservationName == "")
            {
                MessageBox.Show($"Името на резервацията е задължително!");

            }
            else
            {
                var roomToUpdate = Rooms.FirstOrDefault(x => x.RoomNumber == roomNumber);
                if (roomToUpdate.IsCleaned == true)
                {
                    roomToUpdate.IsOccupated = true;
                    roomToUpdate.IsCleaned = false;

                    Room roomToAdd;
                    for (int i = 1; i <= 30; i++)
                    {


                        if (i % 2 == 0)
                        {
                            string roomType = "Стая";
                            if (i == roomNumber)
                            {
                                roomToAdd = new Room(i, reservationName, roomType, roomToUpdate.IsCleaned, roomToUpdate.IsOccupated);
                            }
                            else
                            {
                                roomToAdd = new Room(i, "", roomType, true, false);
                            }
                        }
                        else
                        {
                            string roomType = "Апартамент";
                            if (i == roomNumber)
                            {
                                roomToAdd = new Room(i, reservationName, roomType, roomToUpdate.IsCleaned, roomToUpdate.IsOccupated);
                            }
                            else
                            {
                                roomToAdd = new Room(i, "", roomType, true, false);
                            }
                        }

                        newListRooms.Add(roomToAdd);
                    }

                    string filePath2 = FilePaths.ReservationFileSavePath;
                    using (StreamWriter writer = new StreamWriter(filePath2))//problem here with true value for append

                        foreach (var room in newListRooms)
                        {
                            writer.WriteLine($"{room.RoomNumber}, {room.ReservationName}, {room.RoomType}, {room.IsCleaned}, {room.IsOccupated}");

                        }


                    MessageBox.Show($"Успешно направена резервация на името на {reservationName}!");
                }
                else
                {
                    MessageBox.Show($"Стаята не е изчистена. {Environment.NewLine}Резервацията не е възможна!");
                }
            }

        }








        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
