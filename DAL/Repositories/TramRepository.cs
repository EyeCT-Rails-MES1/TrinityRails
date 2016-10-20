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
        public void setStatus(Tram tram, Status status)
        {
            tram.status = status;
            //context.setStatus(); weet niet of dit klopt
        }
        public void setLocation(Tram tram, int location)
        {
            //TODO
            tram.location = location;
            //context.setLocation(); weet niet of dit klopt
        }
    }
}
