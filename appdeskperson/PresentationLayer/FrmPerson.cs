using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appdeskperson.PresentationLayer
{
    public partial class FrmPerson : Form
    {
        public FrmPerson()
        {
            InitializeComponent();
        }

        private void dgvPerson_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new FrmPersonLogic().dgvPerson_MouseDoubleClick(dgvPerson, txtIdPerson, txtDni, txtFirstName, txtSurName, dateBirthDate, txtAddressN);
        }
        private void dgvPerson_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //new FrmPersonLogic().dgvPerson_MouseDoubleClick(dgvPerson, txtIdPerson, txtDni, txtFirstName, txtSurName, dateBirthDate);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            new FrmPersonLogic().btnDelete_Click(dgvPerson, txtIdPerson, txtDni, txtFirstName, txtSurName, dateBirthDate, txtAddressN);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            new FrmPersonLogic().btnInsert_Click(txtIdPerson, txtDni, erpDni, txtFirstName, erpFirstName, txtSurName, erpSurName, dateBirthDate, txtAddressN, dgvPerson);
        }

        private void FrmPerson_Load(object sender, EventArgs e)
        {
            new FrmPersonLogic().FrmPerson_Load(dgvPerson);
            new FrmPersonJuridicaLogic().FrmPerson_Load(dgvPersonJ);
        }

        #region Persona juridica
        private void btnInsertJ_Click(object sender, EventArgs e)
        {
            new FrmPersonJuridicaLogic().btnInsert_Click(txtIdPerson, txtRuc, erpRuc, txtRazonSocial, erpRazonSocial, txtAddressJ, dgvPersonJ);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion Persona juridica

        private void dgvPersonJ_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new FrmPersonJuridicaLogic().dgvPerson_MouseDoubleClick(dgvPersonJ, txtIdPerson, txtRuc, txtRazonSocial, txtAddressJ);
        }

        private void btnDeleteJ_Click(object sender, EventArgs e)
        {
            new FrmPersonJuridicaLogic().btnDelete_Click(dgvPersonJ, txtIdPersonJ, txtRuc, txtRazonSocial, txtAddressJ);
        }
    }
}
