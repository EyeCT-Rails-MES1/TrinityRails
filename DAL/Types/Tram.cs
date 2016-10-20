using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Types
{
    public class Tram
    {
        public int number { get; set; }
        public Enum status { get; set; } //TODO create enum
        public int sector { get; set; }
        public int RFID { get; set; }
        public int location { get; set; }
        Tram(int number, Enum status, int sector, int RFID, int location)
        {
            this.number = number;
            this.status = status;
            this.sector = sector;
            this.RFID = RFID;
            this.location = location;
        }
    }
}
