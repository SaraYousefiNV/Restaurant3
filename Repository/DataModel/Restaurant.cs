using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DataModel
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string OwnerFullName { get; set; }
        public string NationalCode { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan StartEnd { get; set; }
        public int UserId { get; set; }
        public string Address { get; set; }
    
      
   
    }
}
