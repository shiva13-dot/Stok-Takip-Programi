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
    public partial class formCategory : Form
    {
        public formCategory()
        {
            InitializeComponent();
        }

        //class of database functions
        MsAccess msA = new MsAccess();

        //dialog result
        DialogResult dR = new DialogResult();

        private void formCategory_Load(object sender, EventArgs e)
        {
            msA.showCategory_(CTGRYDGW);
        }
        private void ADDBTTN_Click(object sender, EventArgs e)
        {
            bool situation = textCheck.emptyCheck(CTGRYTXTB.Text);
            if (situation == true)
            {
                msA.categoryAdd_(CTGRYTXTB.Text.ToUpper());
                msA.showCategory_(CTGRYDGW);
            }
            else
            {
                MessageBox.Show("Giriş yerlerini boş bırakmayınız !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void DELETEBTTN_Click(object sender, EventArgs e)
        {
            bool situation = textCheck.emptyCheck(CTGRYTXTB.Text);
            if (situation == true)
            {
                dR = MessageBox.Show("Kategoriyi silmek istediğinize emin misiniz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dR == DialogResult.Yes)
                {
                    msA.categoryDelete_(Convert.ToInt32(CTGRYDGW.CurrentRow.Cells["c_id"].Value.ToString()));
                    msA.showCategory_(CTGRYDGW);
                }
            }
            else
            {
                MessageBox.Show("Giriş yerlerini boş bırakmayınız !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void UPDATEBTTN_Click(object sender, EventArgs e)
        {
            bool situation = textCheck.emptyCheck(CTGRYTXTB.Text);
            if (situation == true)
            {
                dR = MessageBox.Show("Kategoriyi güncellemek istediğinize emin misiniz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dR == DialogResult.Yes)
                {
                    msA.categoryUpdate_(CTGRYTXTB.Text.ToUpper(), Convert.ToInt32(CTGRYDGW.CurrentRow.Cells["c_id"].Value.ToString()));
                    msA.showCategory_(CTGRYDGW);
                }
            }
            else
            {
                MessageBox.Show("Giriş yerlerini boş bırakmayınız !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void CTGRYDGW_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CTGRYTXTB.Text = CTGRYDGW.CurrentRow.Cells["c_name"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
