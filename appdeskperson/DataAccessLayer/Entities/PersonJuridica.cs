using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace appdeskperson.DataAccessLayer.Entities
{

    [Table("tperson_juridica")]
    public class PersonJuridica : Person
    {
        public string ruc { get; set; }
        public string razonSocial{ get; set; }
    }
}
