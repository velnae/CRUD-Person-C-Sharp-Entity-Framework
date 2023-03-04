using appdeskperson.DataAccessLayer.Connection;
using appdeskperson.DataAccessLayer.Entities;
using appdeskperson.DataTransferLayer;
using System.Collections.Generic;
using System.Linq;

namespace appdeskperson.DataAccessLayer.Queries
{
    public class QPersonJuridica
    {
        public int update(DtoPersonJuridica dtoPerson)
        {
            using (DataBaseContext dbc = new DataBaseContext())
            {
                PersonJuridica person = new PersonJuridica();

                person.idPerson = dtoPerson.idPerson;
                person.ruc = dtoPerson.ruc;
                person.razonSocial = dtoPerson.razonSocial;
                person.address = dtoPerson.address;
                dbc.Entry(person).State = System.Data.Entity.EntityState.Modified;

                return dbc.SaveChanges();
            }
        }
        public int delete(DtoPersonJuridica dtoPerson)
        {
            using (DataBaseContext dbc = new DataBaseContext())
            {
                PersonJuridica person = new PersonJuridica();

                person.idPerson = dtoPerson.idPerson;

                dbc.PersonsJuridica.Attach(person);
                dbc.PersonsJuridica.Remove(person);

                return dbc.SaveChanges();
            }
        }

        public int insert(DtoPersonJuridica dtoPerson)
        {
            using (DataBaseContext dbc = new DataBaseContext())
            {
                PersonJuridica person = new PersonJuridica();

                person.idPerson = dtoPerson.idPerson;
                person.ruc = dtoPerson.ruc;
                person.razonSocial = dtoPerson.razonSocial;
                person.address = dtoPerson.address;

                dbc.PersonsJuridica.Add(person);

                return dbc.SaveChanges();
            }
        }

        public List<DtoPersonJuridica> getAll()
        {
            using (DataBaseContext dbc = new DataBaseContext())
            {
                List<PersonJuridica> listPerson = dbc.PersonsJuridica.ToList();

                List<DtoPersonJuridica> listDtoPersonJuridica = new List<DtoPersonJuridica>();

                foreach (PersonJuridica item in listPerson)
                {
                    DtoPersonJuridica dtoPerson = new DtoPersonJuridica();

                    dtoPerson.idPerson = item.idPerson;
                    dtoPerson.ruc = item.ruc;
                    dtoPerson.razonSocial = item.razonSocial;
                    dtoPerson.address = item.address;

                    listDtoPersonJuridica.Add(dtoPerson);
                }

                return listDtoPersonJuridica;
            }
        }
    }
}