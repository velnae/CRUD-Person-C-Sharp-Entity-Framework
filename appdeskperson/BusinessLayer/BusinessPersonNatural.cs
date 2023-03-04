using appdeskperson.DataAccessLayer.Queries;
using appdeskperson.DataTransferLayer;
using System;
using System.Collections.Generic;

namespace appdeskperson.BusinessLayer
{
    public class BusinessPersonNatural
    {
        public int update(DtoPersonNatural dtoPerson)
        {
            return new QPersonNatural().update(dtoPerson);
        }

        public int delete(DtoPersonNatural dtoPerson)
        {
            return new QPersonNatural().delete(dtoPerson);
        }

        public int insert(DtoPersonNatural dtoPerson) 
        {
            dtoPerson.idPerson = Guid.NewGuid().ToString();

            return new QPersonNatural().insert(dtoPerson);
        }

        public List<DtoPersonNatural> getAll() 
        {
            List<DtoPersonNatural> listDtoPersonNatural = new QPersonNatural().getAll();

            foreach (DtoPersonNatural item in listDtoPersonNatural)
            {
                var today = DateTime.Today;
                var age = today.Year - item.birthDate.Year;

                if (item.birthDate.Date > today.AddYears(-age)) 
                {
                    age--;
                }

                item.yearOld = age;
            }

            return listDtoPersonNatural;
        }
    }
}