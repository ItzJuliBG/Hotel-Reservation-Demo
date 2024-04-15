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
    public partial class FindingRoomForm : Form
    {
        List<Room> Rooms;
        public FindingRoomForm()
        {
            InitializeComponent();


            Rooms = new List<Room>();

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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool isInputDigit = int.TryParse(textBox1.Text, out int parsedInput);
            if (isInputDigit)
            {
                if (parsedInput < 1 || parsedInput > 30)
                {
                    MessageBox.Show(ExceptionMessages.nonExistantRoomNumber);
                }
                else
                {
                    List<Room> roomToDisplay = new();
                    roomToDisplay.Add(Rooms.FirstOrDefault(r => r.RoomNumber == parsedInput));
                    dataGridView1.DataSource = roomToDisplay;
                }
            }
            else
            {
                MessageBox.Show(ExceptionMessages.useOnlyNums);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}