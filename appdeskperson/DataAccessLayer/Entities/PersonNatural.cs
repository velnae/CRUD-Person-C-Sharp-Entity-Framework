using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace appdeskperson.DataAccessLayer.Entities
{

    [Table("tperson_natural")]
    public class PersonNatural : Person
    {
        public string dni { get; set; }
        public string firstName { get; set; }
        public string surName { get; set; }
        public DateTime birthDate { get; set; }
    }
}
