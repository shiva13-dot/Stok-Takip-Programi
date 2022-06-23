using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductStock
{
    public partial class formUnit : Form
    {
        public formUnit()
        {
            InitializeComponent();
        }

        //class of database functions
        MsAccess msA = new MsAccess();

        //dialog result
        DialogResult dR = new DialogResult();

        private void formUnit_Load(object sender, EventArgs e)
        {
            msA._showUnit(UNITDGW);
        }
        private void ADDBTTN_Click(object sender, EventArgs e)
        {
            bool situation = textCheck.emptyCheck(UNITTXTB.Text);
            if (situation == true)
            {
                msA._unitAdd(UNITTXTB.Text.ToUpper());
                msA._showUnit(UNITDGW);
            }
            else
            {
                MessageBox.Show("Giriş yerlerini boş bırakmayınız !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void DELETEBTTN_Click(object sender, EventArgs e)
        {
            bool situation = textCheck.emptyCheck(UNITTXTB.Text);
            if (situation == true)
            {
                dR = MessageBox.Show("Birimi silmek istediğinize emin misiniz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dR == DialogResult.Yes)
                {
                    msA._unitDelete(Convert.ToInt32(UNITDGW.CurrentRow.Cells["U_ID"].Value.ToString()));
                    msA._showUnit(UNITDGW);
                }
            }
            else
            {
                MessageBox.Show("Giriş yerlerini boş bırakmayınız !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void UPDATEBTTN_Click(object sender, EventArgs e)
        {
            bool situation = textCheck.emptyCheck(UNITTXTB.Text);
            if (situation == true)
            {
                dR = MessageBox.Show("Birimi güncellemek istediğinize emin misiniz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dR == DialogResult.Yes)
                {
                    msA._unitUpdate(UNITTXTB.Text.ToUpper(), Convert.ToInt32(UNITDGW.CurrentRow.Cells["U_ID"].Value.ToString()));
                    msA._showUnit(UNITDGW);
                }
            }
            else
            {
                MessageBox.Show("Giriş yerlerini boş bırakmayınız !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void UNITDGW_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                UNITTXTB.Text = UNITDGW.CurrentRow.Cells["U_NAME"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
