using System;

namespace appdeskperson.DataTransferLayer
{
    public class DtoPersonJuridica : DtoPerson
    {
        #region properties

        public string ruc { get; set; }
        public string razonSocial { get; set; }

        #endregion
    }
}