using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalStore.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string NameAut { get; set; }
        public string EmailAut { get; set; }
        public string SubjectAut { get; set; }
        public string MessageAut { get; set; }
    }
}
