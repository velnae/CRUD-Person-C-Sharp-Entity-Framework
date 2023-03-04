using appdeskperson.BusinessLayer;
using appdeskperson.DataTransferLayer;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace appdeskperson.PresentationLayer
{
    public class FrmPersonLogic
    {

        public void dgvPerson_MouseDoubleClick(DataGridView dgvPerson, TextBox txtIdPerson, TextBox txtDni, TextBox txtFirstName, TextBox txtSurName, DateTimePicker dateBirthDate)
        {
            if (dgvPerson.CurrentRow == null)
            {
                return;
            }

            txtIdPerson.Text = dgvPerson.CurrentRow.Cells["IdPerson"].Value.ToString();
            txtDni.Text = dgvPerson.CurrentRow.Cells["DNI"].Value.ToString();
            txtFirstName.Text = dgvPerson.CurrentRow.Cells["firstName"].Value.ToString();
            txtSurName.Text = dgvPerson.CurrentRow.Cells["surName"].Value.ToString();
            dateBirthDate.Value= Convert.ToDateTime(dgvPerson.CurrentRow.Cells["birthDate"].Value.ToString());

        }

        public void btnDelete_Click(DataGridView dgvPerson, TextBox txtIdPerson, TextBox txtDni, TextBox txtFirstName, TextBox txtSurName, DateTimePicker dateBirthDate)
        {
            if (dgvPerson.CurrentRow == null)
            {
                MessageBox.Show("Nada que eliminar. no existen registros");
                return;
            }

            DtoPersonNatural dtoPerson = new DtoPersonNatural();
            dtoPerson.idPerson = dgvPerson.CurrentRow.Cells["IdPerson"].Value.ToString();

            if (new BusinessPersonNatural().delete(dtoPerson) > 0)
            {
                showListPerson(dgvPerson);
                CleanForm(txtIdPerson, txtDni, txtFirstName, txtSurName, dateBirthDate);
                MessageBox.Show("Registro eliminado correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            MessageBox.Show("No se pudo eliminar el registro.", "Error Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void btnInsert_Click(TextBox txtIdPerson, TextBox txtDni, TextBox txtFirstName, TextBox txtSurName, DateTimePicker dateBirthDate, DataGridView dgvPerson) 
        {
            if (!validateData(txtDni, txtFirstName, txtSurName))
                return;

            bool insert = txtIdPerson.Text == "";

            DtoPersonNatural dtoPerson = new DtoPersonNatural();

            dtoPerson.idPerson = txtIdPerson.Text;
            dtoPerson.dni = txtDni.Text;
            dtoPerson.firstName = txtFirstName.Text;
            dtoPerson.surName = txtSurName.Text;
            dtoPerson.birthDate = dateBirthDate.Value;

            if (insert)
            {
                if (new BusinessPersonNatural().insert(dtoPerson) > 0)
                {
                    showListPerson(dgvPerson);
                    CleanForm(txtIdPerson, txtDni, txtFirstName, txtSurName, dateBirthDate);
                    MessageBox.Show("Registro realizado correctamente.", "Guardo con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }

                MessageBox.Show("No se pudo registrar los datos.", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (new BusinessPersonNatural().update(dtoPerson) > 0)
                {
                    showListPerson(dgvPerson);
                    CleanForm(txtIdPerson, txtDni, txtFirstName, txtSurName, dateBirthDate);
                    MessageBox.Show("La actualización se realizo correctamente.", "Actulzado con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }

                MessageBox.Show("No se pudo actualizar los datos.", "Error al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FrmPerson_Load(DataGridView dgvPerson)
        {
            showListPerson(dgvPerson);
        }

        private void showListPerson(DataGridView dgvPerson)
        {
            List<DtoPersonNatural> listDtoPerson = new BusinessPersonNatural().getAll();
            dgvPerson.Rows.Clear();

            for (int i = 0; i < listDtoPerson.Count; i++)
            {
                dgvPerson.Rows.Add();

                dgvPerson.Rows[i].Cells["IdPerson"].Value = listDtoPerson[i].idPerson;
                dgvPerson.Rows[i].Cells["dni"].Value = listDtoPerson[i].dni;
                dgvPerson.Rows[i].Cells["firstName"].Value = listDtoPerson[i].firstName;
                dgvPerson.Rows[i].Cells["surName"].Value = listDtoPerson[i].surName;
                dgvPerson.Rows[i].Cells["yearOld"].Value = listDtoPerson[i].yearOld;
                dgvPerson.Rows[i].Cells["birthDate"].Value = listDtoPerson[i].birthDate;
            }
        }

        private bool validateData(TextBox txtDni, TextBox txtFirstName, TextBox txtSurName)
        {
            Regex dniRegex = new Regex(@"^\d{8}$");
            Regex namesRegex = new Regex(@"^([A-Za-zÑñÁáÉéÍíÓóÚú]+['\-]{0,1}[A-Za-zÑñÁáÉéÍíÓóÚú]+)(\s+([A-Za-zÑñÁáÉéÍíÓóÚú]+['\-]{0,1}[A-Za-zÑñÁáÉéÍíÓóÚú]+))*$");

            if (!dniRegex.IsMatch(txtDni.Text))
            {
                MessageBox.Show("Debe contener 8 numeros enteros, sin espacios", "Error en DNI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!namesRegex.IsMatch(txtFirstName.Text))
            {
                MessageBox.Show("Debe ser una palabra minimamente y no empezar con espacio en blanco o contener números", "Error en Nombre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!namesRegex.IsMatch(txtSurName.Text))
            {
                MessageBox.Show("Puede ser mas de una palabra, sin espacio vacio al inicio, ni números", "Error en Apellido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void CleanForm(TextBox txtIdPerson, TextBox txtDni, TextBox txtFirstName, TextBox txtSurName, DateTimePicker dateBirthDate)
        {
            txtIdPerson.Text = "";
            txtDni.Text = "";
            txtFirstName.Text = "";
            txtSurName.Text = "";
            dateBirthDate.Value = DateTime.Now;
        }
    }
}