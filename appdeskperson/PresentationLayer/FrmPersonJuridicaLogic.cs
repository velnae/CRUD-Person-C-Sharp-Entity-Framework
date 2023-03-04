using appdeskperson.BusinessLayer;
using appdeskperson.DataTransferLayer;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace appdeskperson.PresentationLayer
{
    public class FrmPersonJuridicaLogic
    {

        public void dgvPerson_MouseDoubleClick(DataGridView dgvPersonj, TextBox txtIdPerson, TextBox txtRuc, TextBox txtRazonSocial, TextBox txtAddressJ)
        {
            if (dgvPersonj.CurrentRow == null)
            {
                return;
            }

            txtIdPerson.Text = dgvPersonj.CurrentRow.Cells["IdPersonJ"].Value.ToString();
            txtRuc.Text = dgvPersonj.CurrentRow.Cells["ruc"].Value.ToString();
            txtRazonSocial.Text = dgvPersonj.CurrentRow.Cells["razonSocial"].Value.ToString();
            txtAddressJ.Text = dgvPersonj.CurrentRow.Cells["addressJ"].Value.ToString();

        }

        public void btnDelete_Click(DataGridView dgvPersonj, TextBox txtIdPerson, TextBox txtRuc, TextBox txtRazonSocial, TextBox txtAddressJ, DateTimePicker dateBirthDate)
        {
            if (dgvPersonj.CurrentRow == null)
            {
                MessageBox.Show("Nada que eliminar. no existen registros");
                return;
            }

            DtoPersonJuridica dtoPerson = new DtoPersonJuridica();
            dtoPerson.idPerson = dgvPersonj.CurrentRow.Cells["IdPerson"].Value.ToString();

            if (new BusinessPersonJuridica().delete(dtoPerson) > 0)
            {
                showListPerson(dgvPersonj);
                CleanForm(txtIdPerson, txtRuc, txtRazonSocial, txtAddressJ);
                MessageBox.Show("Registro eliminado correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            MessageBox.Show("No se pudo eliminar el registro.", "Error Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void btnInsert_Click(TextBox txtIdPerson, TextBox txtRuc, TextBox txtRazonSocial, TextBox txtAddressJ, DataGridView dgvPersonj) 
        {
            if (!validateData(txtRuc, txtRazonSocial))
                return;

            bool insert = txtIdPerson.Text == "";

            DtoPersonJuridica dtoPerson = new DtoPersonJuridica();

            dtoPerson.idPerson = txtIdPerson.Text;
            dtoPerson.ruc = txtRuc.Text;
            dtoPerson.razonSocial = txtRazonSocial.Text;
            dtoPerson.address = txtAddressJ.Text;

            if (insert)
            {
                if (new BusinessPersonJuridica().insert(dtoPerson) > 0)
                {
                    showListPerson(dgvPersonj);
                    CleanForm(txtIdPerson, txtRuc, txtRazonSocial, txtAddressJ);
                    MessageBox.Show("Registro realizado correctamente.", "Guardo con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }

                MessageBox.Show("No se pudo registrar los datos.", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (new BusinessPersonJuridica().update(dtoPerson) > 0)
                {
                    showListPerson(dgvPersonj);
                    CleanForm(txtIdPerson, txtRuc, txtRazonSocial, txtAddressJ);
                    MessageBox.Show("La actualización se realizo correctamente.", "Actulzado con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }

                MessageBox.Show("No se pudo actualizar los datos.", "Error al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FrmPerson_Load(DataGridView dgvPersonj)
        {
            showListPerson(dgvPersonj);
        }

        private void showListPerson(DataGridView dgvPersonj)
        {
            List<DtoPersonJuridica> listDtoPerson = new BusinessPersonJuridica().getAll();
            dgvPersonj.Rows.Clear();

            for (int i = 0; i < listDtoPerson.Count; i++)
            {
                dgvPersonj.Rows.Add();

                dgvPersonj.Rows[i].Cells["IdPersonJ"].Value = listDtoPerson[i].idPerson;
                dgvPersonj.Rows[i].Cells["ruc"].Value = listDtoPerson[i].ruc;
                dgvPersonj.Rows[i].Cells["razonSocial"].Value = listDtoPerson[i].razonSocial;
                dgvPersonj.Rows[i].Cells["addressJ"].Value = listDtoPerson[i].address;
            }
        }

        private bool validateData(TextBox txtRuc, TextBox txtRazonSocial)
        {
            Regex rucRegex = new Regex(@"^\d{11}$");
            Regex namesRegex = new Regex(@"^([A-Za-zÑñÁáÉéÍíÓóÚú]+['\-]{0,1}[A-Za-zÑñÁáÉéÍíÓóÚú]+)(\s+([A-Za-zÑñÁáÉéÍíÓóÚú]+['\-]{0,1}[A-Za-zÑñÁáÉéÍíÓóÚú]+))*$");

            if (!rucRegex.IsMatch(txtRuc.Text))
            {
                MessageBox.Show("Debe contener 11 numeros enteros, sin espacios", "Error en RUC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!namesRegex.IsMatch(txtRazonSocial.Text))
            {
                MessageBox.Show("Debe ser una palabra minimamente y no empezar con espacio en blanco o contener números", "Error en Nombre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void CleanForm(TextBox txtIdPerson, TextBox txtRuc, TextBox txtRazonSocial, TextBox txtAddressJ)
        {
            txtIdPerson.Text = "";
            txtRuc.Text = "";
            txtRazonSocial.Text = "";
            txtAddressJ.Text = "";
        }
    }
}