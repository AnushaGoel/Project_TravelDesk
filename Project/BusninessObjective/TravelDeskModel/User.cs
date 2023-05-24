using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BusninessObject.TravelDeskModel
{
    public class User
    {
        public  int id  { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

        public bool isactive { get; set; }

        public Role role { get; set; }  

    }
}
            