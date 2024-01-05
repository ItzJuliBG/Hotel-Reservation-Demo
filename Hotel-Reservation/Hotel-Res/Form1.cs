using Hotel_Res;
using Hotel_Res.Models;
using System.DirectoryServices.ActiveDirectory;

namespace Hotel_Reservations
{
    public partial class Form1 : Form
    {
        List<Room> Rooms = new List<Room>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //string filePath2 = $"..\\..\\..\\LocalStorage\\text.txt";
            //using StreamReader reader = new StreamReader(filePath2);

            //while (reader.EndOfStream != true)
            //{
            //    var t = reader.ReadLine();
            //    var newLine = t.Split(", ");
            //    int roomNumber = int.Parse(newLine[0]);
            //    string name = newLine[1];
            //    string roomType = newLine[2];

            //    var roomToAdd = new Room(roomNumber, name, roomType);

            //    Rooms.Add(roomToAdd);

            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllRoomsForm form = new AllRoomsForm();
            form.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CreditsForm creditsForm = new CreditsForm();

            creditsForm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MakeReservationForm makeReservationForm = new MakeReservationForm();
            makeReservationForm.Show();
        }

    }
}