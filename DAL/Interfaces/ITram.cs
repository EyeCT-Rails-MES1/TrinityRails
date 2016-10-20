using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Types;

namespace DAL.Interfaces
{
    public interface ITram
    {
        List<Tram> getTrams();
        void setStatus(Tram tram, Status status);
        void setLocation(Tram tram, int location);
    }
}
