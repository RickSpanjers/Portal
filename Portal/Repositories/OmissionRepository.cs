using DataconPortal.Context;
using DataconPortal.Data;
using DataconPortal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataconPortal.Repositories
{
    class OmissionRepository
    {
        private IOmission omission;

        public OmissionRepository(IOmission omission)
        {
            this.omission = omission;
        }

        public List<Omission> GetAllOmissions()
        {
            return omission.GetAllOmissions();
        }

        public string GetUsername(int id)
        {
            return omission.GetUsername(id);
        }

        public bool IsOmissionAllowed(Omission o, int code)
        {
            return omission.isOmissionAllowed(o, code);
        }

        public void AddOmission(Omission om)
        {
            omission.AddOmission(om);
        }

        public List<Omission> GetSingleUserOmission(Omission om)
        {
            return omission.GetSingleUserOmission(om);
        }
    }
}
