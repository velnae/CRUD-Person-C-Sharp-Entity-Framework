using appdeskperson.DataAccessLayer.Connection;
using appdeskperson.DataAccessLayer.Entities;
using appdeskperson.DataTransferLayer;
using System.Collections.Generic;
using System.Linq;

namespace appdeskperson.DataAccessLayer.Queries
{
    public class QPerson
    {
        public int update(DtoPerson dtoPerson)
        {
            using (DataBaseContext dbc = new DataBaseContext())
            {
                Person person = new Person();

                person.idPerson = dtoPerson.idPerson;
                person.dni = dtoPerson.dni;
                person.firstName = dtoPerson.firstName;
                person.surName = dtoPerson.surName;
                person.birthDate = dtoPerson.birthDate;

                dbc.Persons.Add(person);
                dbc.Entry(person).State = System.Data.Entity.EntityState.Modified;

                return dbc.SaveChanges();
            }
        }
        public int delete(DtoPerson dtoPerson)
        {
            using (DataBaseContext dbc = new DataBaseContext())
            {
                Person person = new Person();

                person.idPerson = dtoPerson.idPerson;

                dbc.Persons.Attach(person);
                dbc.Persons.Remove(person);

                return dbc.SaveChanges();
            }
        }

        public int insert(DtoPerson dtoPerson)
        {
            using (DataBaseContext dbc = new DataBaseContext())
            {
                Person person = new Person();

                person.idPerson = dtoPerson.idPerson;
                person.dni = dtoPerson.dni;
                person.firstName = dtoPerson.firstName;
                person.surName = dtoPerson.surName;
                person.birthDate = dtoPerson.birthDate;

                dbc.Persons.Add(person);

                return dbc.SaveChanges();
            }
        }

        public List<DtoPerson> getAll()
        {
            using (DataBaseContext dbc = new DataBaseContext())
            {
                List<Person> listPerson = dbc.Persons.ToList();

                List<DtoPerson> listDtoPerson = new List<DtoPerson>();

                foreach (Person item in listPerson)
                {
                    DtoPerson dtoPerson = new DtoPerson();

                    dtoPerson.idPerson = item.idPerson;
                    dtoPerson.dni = item.dni;
                    dtoPerson.firstName = item.firstName;
                    dtoPerson.surName = item.surName;
                    dtoPerson.birthDate = item.birthDate;

                    listDtoPerson.Add(dtoPerson);
                }

                return listDtoPerson;
            }
        }
    }
}