using DataconPortal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataconPortal.Interfaces
{
    interface IOmission
    {
        List<Omission> GetAllOmissions();
        bool isOmissionAllowed(Omission o, int code);
        string GetUsername(int id);
        void AddOmission(Omission om);
        List<Omission> GetSingleUserOmission(Omission om);
    }
}
