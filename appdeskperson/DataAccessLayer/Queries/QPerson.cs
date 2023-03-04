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

                return 1;
            }
        }
        public int delete(DtoPerson dtoPerson)
        {
            using (DataBaseContext dbc = new DataBaseContext())
            {
                return 1;
            }
        }

        public int insert(DtoPerson dtoPerson)
        {
            using (DataBaseContext dbc = new DataBaseContext())
            {
                return 1;
            }
        }

        public List<DtoPerson> getAll()
        {
            using (DataBaseContext dbc = new DataBaseContext())
            {
                List<PersonNatural> listPerson = dbc.PersonsNatural.ToList();

                List<DtoPerson> listDtoPerson = new List<DtoPerson>();


                return listDtoPerson;
            }
        }
    }
}