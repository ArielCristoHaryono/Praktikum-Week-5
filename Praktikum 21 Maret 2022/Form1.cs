using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum_21_Maret_2022
{
    public partial class FormMateri : Form
    {
        int Aktif = 0;
        public FormMateri()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!listBoxData.Items.Contains(txtBoxData.Text))
               listBoxData.Items.Add(txtBoxData.Text);
            else
            {
                MessageBox.Show("data sudah penuh");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rdioBtnMerah_CheckedChanged(object sender, EventArgs e)
        {
            if (Aktif == 1)
                if (rdioBtnMerah.Checked == true)
                    labelOutput.ForeColor = Color.Red;
        }

        private void lblOutput_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxData.Text = "";
            rdioBtnMerah.Checked = false;
            rdioBtnBiru.Checked = false;
            lblOutput.Text = "";
            listBoxData.Items.Clear();
            
        }

        private void rdioBtnBiru_CheckedChanged(object sender, EventArgs e)
        {
            if (Aktif == 1)
                if (rdioBtnBiru.Checked == true)
                    labelOutput.ForeColor = Color.Blue;
        }

        private void chckBoxAktif_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBoxAktif.Checked == true)
            {
                Aktif = 1;
                    if (rdioBtnMerah.Checked == true) 
                       labelOutput.ForeColor = Color.Red;
                    if (rdioBtnBiru.Checked == true)
                       labelOutput.ForeColor = Color.Blue;
            }
            else
            {
                Aktif = 0;
                labelOutput.ForeColor = Color.Black;
            }
        }

        private void txtBoxData_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxData_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelOutput.Text = listBoxData.SelectedItem.ToString();    
        }

        private void FormMateri_Load(object sender, EventArgs e)
        {
            listBoxData.Text = "";
            labelOutput.Text = "";
        }

        private void labelOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
