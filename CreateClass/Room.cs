using System;
using System.Collections.Generic;
using System.Text;

namespace CreateClass
{
    public class Room
    {
        public int roomNumber;

        public Room(int roomNumber)
        {
            this.roomNumber = roomNumber;
        }

        public int RoomNumber
        {
            set { roomNumber = value; }
            get { return roomNumber; }
        }

        public override string ToString()
        {
            return roomNumber.ToString();
        }
    }
    
    
}
