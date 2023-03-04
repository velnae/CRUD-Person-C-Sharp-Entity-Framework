using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appdeskperson.DataAccessLayer.Entities
{
    public class Person
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string idPerson { get; set; }
        public string address { get; set; }

    }
}