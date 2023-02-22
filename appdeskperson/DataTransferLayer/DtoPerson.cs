using System;

namespace appdeskperson.DataTransferLayer
{
    public class DtoPerson
    {
        #region properties

        public string idPerson { get; set; }
        public string dni { get; set; }
        public string firstName { get; set; }
        public string surName { get; set; }
        public DateTime birthDate { get; set; }

        #endregion

        #region additional properties

        public int yearOld { get; set; }

        #endregion
    }
}