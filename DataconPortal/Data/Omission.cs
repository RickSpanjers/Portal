using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataconPortal.Data
{
    class Omission
    {
        private int id;
        private DateTime begindate;
        private DateTime endDate;
        private string type;
        private string description;
        private int code;
        private int userID;
        private string username;

        public Omission()
        {
      
        }

        public Omission(int id, DateTime begindate, DateTime endDate, string type, string description, int code)
        {
        this.id = id;
        this.begindate = begindate;
        this.endDate = endDate;
        this.type = type;
        this.description = description;
        this.code = code;
        }


        public Omission(int UserID)
        {
            this.UserID = UserID;
        }

        public Omission(string type)
        {
            this.type = type;
        }

       

        public int Id
        {
            get { return id; }
            set { id = value;}
        }

        public DateTime BeginDate
        {
            get { return begindate;  }
            set { begindate = value; }
        }

        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int Code
        {
            get { return code; }
            set { code = value; }
        }

        public string UserName
        {
            get { return username; }
            set { username = value; }
        }

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }
    }
}
