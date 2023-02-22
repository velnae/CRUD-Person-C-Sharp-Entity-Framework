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
            new FrmPersonLogic().dgvPerson_MouseDoubleClick(dgvPerson, txtIdPerson, txtDni, txtFirstName, txtSurName, dateBirthDate);
        }
        private void dgvPerson_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //new FrmPersonLogic().dgvPerson_MouseDoubleClick(dgvPerson, txtIdPerson, txtDni, txtFirstName, txtSurName, dateBirthDate);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            new FrmPersonLogic().btnDelete_Click(dgvPerson, txtIdPerson, txtDni, txtFirstName, txtSurName, dateBirthDate);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            new FrmPersonLogic().btnInsert_Click(txtIdPerson, txtDni, txtFirstName, txtSurName, dateBirthDate, dgvPerson);
        }

        private void FrmPerson_Load(object sender, EventArgs e)
        {
            new FrmPersonLogic().FrmPerson_Load(dgvPerson);
        }

    }
}
