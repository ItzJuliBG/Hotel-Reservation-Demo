using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Res.Models
{
    public class Room
    {
		private string reservationName;
		private int roomNumber;

		private string roomType;
		private bool isDirty;

        public Room(int roomNumber, string reservationName, string roomType)
        {
            this.roomNumber = roomNumber;
            this.reservationName = reservationName;
            this.roomType = roomType;
			this.isDirty = false;
        }
        public Room(int roomNumber, string reservationName, string roomType, bool isDirty)
        {
            this.roomNumber = roomNumber;
            this.reservationName = reservationName;
            this.roomType = roomType;
			this.isDirty = isDirty;
        }

        public bool IsDirty
		{
			get { return isDirty; }
			private set { isDirty = value; }
		}

		public string RoomType
		{
			get { return roomType; }
			private set { roomType = value; }
		}

		public string ReservationName
		{
			get { return reservationName; }
			private set { reservationName = value; }
		}

		public int RoomNumber
		{
			get { return roomNumber; }
			private set { roomNumber = value; }
		}

	}
}
