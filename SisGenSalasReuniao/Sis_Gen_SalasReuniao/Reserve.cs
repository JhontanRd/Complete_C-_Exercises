using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sis_Gen_SalasReuniao
{
    public class Reserve
    {
        public string Responsible { get; private set; }
        public int Room {  get; private set; }
        public DateTime StartTime { get; private set; }
        public DateTime? EndTime { get; private set; }
        public bool ReserveStatus { get; private set; }
        

        public Reserve(string respon, int room, DateTime startT)
        {
            Responsible = respon;
            Room = room;
            StartTime = startT;
            ReserveStatus = true;
        }

        public Reserve(string respon, int room, DateTime startT, DateTime? endT) : this(respon ,room, startT)
        {
            Responsible = respon;
            Room = room;
            StartTime = startT;
            EndTime = endT;
            ReserveStatus = true;
        }

        public void UpdateRoom(int room)
        {
            Room = room;
        }

        public void UpdateCheckOut(DateTime checkOut)
        {
            EndTime = checkOut;
        }

        public void UpdateRoomAndCheckOut(int room, DateTime checkOut)
        {
            this.UpdateRoom(room);
            this.UpdateCheckOut(checkOut);
        }

        public override string ToString()
        {
            return $"Responsible: {Responsible}, Room: {Room}\nCheck-In: {StartTime}\nCheck-out: {EndTime}";
        }

    }
}
