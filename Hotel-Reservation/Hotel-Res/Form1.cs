<<<<<<< HEAD
using Hotel_Res;
using Hotel_Res.Models;

=======
>>>>>>> dbde9d76882aaa05da548767156143df68d30d2b
namespace Hotel_Reservations
{
    public partial class Form1 : Form
    {
<<<<<<< HEAD
        List<Room> Rooms = new List<Room>();
=======
>>>>>>> dbde9d76882aaa05da548767156143df68d30d2b
        public Form1()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
        private void Form1_Load(object sender, EventArgs e)
        {
            string filePath2 = $"..\\..\\..\\LocalStorage\\text.txt";
            using StreamReader reader = new StreamReader(filePath2);
            string t = null;
            while ((t = reader.ReadLine()) != null || t != "")
            {
                var newLine = t.Split(", ");
                int roomNumber = int.Parse(newLine[0]);
                string name = newLine[1];
                string roomType = newLine[2];

                var roomToAdd = new Room(roomNumber, name, roomType);

                Rooms.Add(roomToAdd);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllRoomsForm form = new AllRoomsForm();
            form.Show();
=======

        private void button1_Click(object sender, EventArgs e)
        {

>>>>>>> dbde9d76882aaa05da548767156143df68d30d2b
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CreditsForm creditsForm = new CreditsForm();

            creditsForm.Show();
            this.Hide();
        }
<<<<<<< HEAD

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

=======
>>>>>>> dbde9d76882aaa05da548767156143df68d30d2b
    }
}