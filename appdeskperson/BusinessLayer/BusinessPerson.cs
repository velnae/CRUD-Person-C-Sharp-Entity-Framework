using appdeskperson.DataAccessLayer.Queries;
using appdeskperson.DataTransferLayer;
using System;
using System.Collections.Generic;

namespace appdeskperson.BusinessLayer
{
    public class BusinessPerson
    {
        public int update(DtoPerson dtoPerson)
        {
            return new QPerson().update(dtoPerson);
        }

        public int delete(DtoPerson dtoPerson)
        {
            return new QPerson().delete(dtoPerson);
        }

        public int insert(DtoPerson dtoPerson) 
        {
            dtoPerson.idPerson = Guid.NewGuid().ToString();

            return new QPerson().insert(dtoPerson);
        }

        public List<DtoPerson> getAll() 
        {
            List<DtoPerson> listDtoPerson = new QPerson().getAll();

            foreach (DtoPerson item in listDtoPerson)
            {
                var today = DateTime.Today;
                var age = today.Year - item.birthDate.Year;

                if (item.birthDate.Date > today.AddYears(-age)) 
                {
                    age--;
                }

                item.yearOld = age;
            }

            return listDtoPerson;
        }
    }
}