using appdeskperson.DataAccessLayer.Queries;
using appdeskperson.DataTransferLayer;
using System;
using System.Collections.Generic;

namespace appdeskperson.BusinessLayer
{
    public class BusinessPersonJuridica
    {
        public int update(DtoPersonJuridica dtoPerson)
        {
            return new QPersonJuridica().update(dtoPerson);
        }

        public int delete(DtoPersonJuridica dtoPerson)
        {
            return new QPersonJuridica().delete(dtoPerson);
        }

        public int insert(DtoPersonJuridica dtoPerson) 
        {
            dtoPerson.idPerson = Guid.NewGuid().ToString();

            return new QPersonJuridica().insert(dtoPerson);
        }

        public List<DtoPersonJuridica> getAll() 
        {
            List<DtoPersonJuridica> listDtoPersonJuridica = new QPersonJuridica().getAll();
            return listDtoPersonJuridica;
        }
    }
}