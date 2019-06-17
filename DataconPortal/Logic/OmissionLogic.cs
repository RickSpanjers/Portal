using DataconPortal.Context;
using DataconPortal.Data;
using DataconPortal.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DataconPortal.Logic
{
    class OmissionLogic
    {
		OmissionRepository omRepo = new OmissionRepository(new OmissionContext());

		public List<Omission> GetAllOmissions()
        {
            List<Omission> om = new List<Omission>();
            om = omRepo.GetAllOmissions();

            return om;
        }

        public string GetUsername(int id)
        {
            string name = omRepo.GetUsername(id);
            return name;
        }

        /// <summary>
        /// bij de int isAllowed = 0 niet bekeken, 1 geaccepteerd, 2 afgewezen, 3 verlopen
        /// </summary>
        public bool IsOmissionAllowed(Omission o, int code)
        {
            bool hasBeenAllowed = false;

            hasBeenAllowed = omRepo.IsOmissionAllowed(o, code);

            return hasBeenAllowed;
        }

        public void AddOmission(Omission om)
        {
            var OmissiondateB = om.BeginDate;
            var OmissiondateE = om.EndDate;
            var TodayDate = DateTime.Now;

            if ((OmissiondateB - TodayDate).TotalDays < 6)
            {
                MessageBox.Show("Verzuim moet minimaal 7 dagen van te voren aangevraagd worden.");
            }
            else if ((OmissiondateE - om.BeginDate).TotalDays < 1)
            {
                MessageBox.Show("Verzuim moet minimaal 1 dag lang zijn");
            }
            else
            {
                omRepo.AddOmission(om);
            }

        }
        public List<Omission> GetSingleUserOmission(Omission om)
        {
            return omRepo.GetSingleUserOmission(om);
        }
    }
}
