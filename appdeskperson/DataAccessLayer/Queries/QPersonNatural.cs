using appdeskperson.DataAccessLayer.Connection;
using appdeskperson.DataAccessLayer.Entities;
using appdeskperson.DataTransferLayer;
using System.Collections.Generic;
using System.Linq;

namespace appdeskperson.DataAccessLayer.Queries
{
    public class QPersonNatural
    {
        public int update(DtoPersonNatural dtoPerson)
        {
            using (DataBaseContext dbc = new DataBaseContext())
            {
                PersonNatural person = new PersonNatural();

                person.idPerson = dtoPerson.idPerson;
                person.dni = dtoPerson.dni;
                person.firstName = dtoPerson.firstName;
                person.surName = dtoPerson.surName;
                person.address = dtoPerson.address;
                person.birthDate = dtoPerson.birthDate;

                dbc.PersonsNatural.Add(person);
                dbc.Entry(person).State = System.Data.Entity.EntityState.Modified;

                return dbc.SaveChanges();
            }
        }
        public int delete(DtoPersonNatural dtoPerson)
        {
            using (DataBaseContext dbc = new DataBaseContext())
            {
                PersonNatural person = new PersonNatural();

                person.idPerson = dtoPerson.idPerson;

                dbc.PersonsNatural.Attach(person);
                dbc.PersonsNatural.Remove(person);

                return dbc.SaveChanges();
            }
        }

        public int insert(DtoPersonNatural dtoPerson)
        {
            using (DataBaseContext dbc = new DataBaseContext())
            {
                PersonNatural person = new PersonNatural();

                person.idPerson = dtoPerson.idPerson;
                person.dni = dtoPerson.dni;
                person.firstName = dtoPerson.firstName;
                person.surName = dtoPerson.surName;
                person.birthDate = dtoPerson.birthDate;
                person.address = dtoPerson.address;

                dbc.PersonsNatural.Add(person);

                return dbc.SaveChanges();
            }
        }

        public List<DtoPersonNatural> getAll()
        {
            using (DataBaseContext dbc = new DataBaseContext())
            {
                List<PersonNatural> listPerson = dbc.PersonsNatural.ToList();

                List<DtoPersonNatural> listDtoPerson = new List<DtoPersonNatural>();

                foreach (PersonNatural item in listPerson)
                {
                    DtoPersonNatural dtoPerson = new DtoPersonNatural();

                    dtoPerson.idPerson = item.idPerson;
                    dtoPerson.dni = item.dni;
                    dtoPerson.firstName = item.firstName;
                    dtoPerson.surName = item.surName;
                    dtoPerson.address = item.address;
                    dtoPerson.birthDate = item.birthDate;

                    listDtoPerson.Add(dtoPerson);
                }

                return listDtoPerson;
            }
        }
    }
}