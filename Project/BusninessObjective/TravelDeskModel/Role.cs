using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusninessObject.TravelDeskModel
{
    public class Role
    {
        //[Range(1, 5)]
        public int id{ get; set; }

        public string name { get; set; }


        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

        public bool isactive { get; set; }

    }
}
