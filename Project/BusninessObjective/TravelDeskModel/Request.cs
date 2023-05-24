using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BusninessObject.TravelDeskModel
{
    public class Request
    {

        public int RequestId { get; set; }
        public string Starting{ get; set; }
        public string Destination { get; set; }
        public DateTime TravalDate { get; set; }
        public string Reason { get; set; }
        public  User User { get; set; }

        //public int NoOfRequests { get; set; }   
    }
}
