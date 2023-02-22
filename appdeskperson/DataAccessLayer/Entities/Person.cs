using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appdeskperson.DataAccessLayer.Entities
{
    [Table("tperson")]
    public class Person
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string idPerson { get; set; }
        public string dni { get; set; }
        public string firstName { get; set; }
        public string surName { get; set; }
        public DateTime birthDate { get; set; }
    }
}