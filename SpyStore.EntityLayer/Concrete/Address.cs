using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpryStore.EntityLayer.Concrete
{
    public class Address
    {
        [Key]
        public int AddressID { get; set; }
        public string AboutTitle { get; set; }
        public string AbouDetails1 { get; set; }
        public string AboutDetails2 { get; set; }
        public string MapLocation { get; set; }
    }
}
