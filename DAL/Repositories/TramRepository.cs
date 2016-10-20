using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Types;
using DAL.Interfaces;

namespace DAL.Repositories
{
    public class TramRepository : ITram
    {
        ITram context;
        List<Tram> trams = new List<Tram>();
        public TramRepository(ITram context)
        {
            this.context = context;
        }
        public List<Tram> getTrams()
        {
            return trams;
        }
        public void setStatus()
        {
            //TODO
        }
        public void setLocation()
        {
            //TODO
        }
    }
}
