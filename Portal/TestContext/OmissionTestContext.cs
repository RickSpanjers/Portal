using DataconPortal.Data;
using DataconPortal.Interfaces;
using System;
using System.Collections.Generic;

namespace DataconPortal.TestContext
{
    class OmissionTestContext : IOmission
    {
        private List<Omission> omissions = new List<Omission>();

        public OmissionTestContext()
        {
            Omission o = new Omission();
            { o.BeginDate = Convert.ToDateTime("21-3-2018"); o.EndDate = Convert.ToDateTime("25-3-2018"); o.Description = "Ik ben op vakantie."; o.Code = 0; o.UserID = 2; o.Type = "Vakantie"; }
            omissions.Add(o);
            Omission om = new Omission();
            { o.BeginDate = Convert.ToDateTime("22-3-2018"); o.EndDate = Convert.ToDateTime("1-04-2018"); o.Description = "Ik ben vader geworden."; o.Code = 1; o.UserID = 4; o.Type = "Verlof"; }
            omissions.Add(om);
        }

        public List<Omission> GetAllOmissions()
        {
            List<Omission> omlist = new List<Omission>();

            foreach (Omission o in omissions)
            {
                omlist.Add(o);
            }

            return omlist;
        }

        public bool isOmissionAllowed(Omission o, int code)
        {
            throw new NotImplementedException();
        }

        public string GetUsername(int id)
        {
            throw new NotImplementedException();
        }

        public void AddOmission(Omission o)
        {
            if (!string.IsNullOrEmpty(o.Type))
            {
                if (o.Code == 0 || o.Code == 1 || o.Code == 2 || o.Code == 3 || o.UserID != -1)
                {
                    if (o.BeginDate != null)
                    {
                        if (o.EndDate != null)
                        {
                            omissions.Add(o);
                        }
                    }
                }
            }
        }

        public List<Omission> GetSingleUserOmission(Omission om)
        {
            throw new NotImplementedException();
        }
    }
}
