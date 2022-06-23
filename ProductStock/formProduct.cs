using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProductStock
{
    public partial class formProduct : Form
    {
        public formProduct()
        {
            InitializeComponent();
        }

        //class of database functions
        MsAccess msA = new MsAccess();

        //dialog result
        DialogResult dR = new DialogResult();

        //variable for update
        string id;

        private void mainform_Load(object sender, EventArgs e)
        {
            msA.showCategory(CTGRYCMBBX);
            msA.showUnit(UNITCMBBX);
            msA.showProducts(PRODUCTSDGW);
        }
        private void CATEGORYBTTN_Click(object sender, EventArgs e)
        {
            formCategory fc = new formCategory();
            fc.Show();
        }
        private void UNITBTTN_Click(object sender, EventArgs e)
        {
            formUnit fu = new formUnit();
            fu.Show();
        }
        private void ADDBTTN_Click(object sender, EventArgs e)
        {
            bool situation = textCheck.emptyCheck(BARCODETXTB.Text, NAMETXTB.Text, PRCHSPRCTXTB.Text, SALEPRCTXTB.Text, AMOUNTTXTB.Text, CTGRYCMBBX.Text, UNITCMBBX.Text);
            if (situation == true)
            {
                msA.productAdd(barcode: BARCODETXTB.Text.ToUpper(), name: NAMETXTB.Text.ToUpper(), category: CTGRYCMBBX.SelectedValue.ToString(), purchasePrice: PRCHSPRCTXTB.Text, salePrice: SALEPRCTXTB.Text, unit: UNITCMBBX.SelectedValue.ToString(), amount: AMOUNTTXTB.Text);
                msA.showProducts(PRODUCTSDGW);
            }
            else
            {
                MessageBox.Show("Giriş yerlerini boş bırakmayınız !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void DELETEBTTN_Click(object sender, EventArgs e)
        {
            bool situation = textCheck.emptyCheck(BARCODETXTB.Text, NAMETXTB.Text, PRCHSPRCTXTB.Text, SALEPRCTXTB.Text, AMOUNTTXTB.Text, CTGRYCMBBX.Text, UNITCMBBX.Text);
            if (situation == true)
            {
                dR = MessageBox.Show("Ürünü silmek istediğinize emin misiniz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dR == DialogResult.Yes)
                {
                    msA.productDelete(BARCODETXTB.Text);
                    msA.showProducts(PRODUCTSDGW);
                }
            }
            else
            {
                MessageBox.Show("Giriş yerlerini boş bırakmayınız !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void UPDATEBTTN_Click(object sender, EventArgs e)
        {
            bool situation = textCheck.emptyCheck(BARCODETXTB.Text, NAMETXTB.Text, PRCHSPRCTXTB.Text, SALEPRCTXTB.Text, AMOUNTTXTB.Text, CTGRYCMBBX.Text, UNITCMBBX.Text);
            if (situation == true)
            {
                dR = MessageBox.Show("Ürünü güncellemek istediğinize emin misiniz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dR == DialogResult.Yes)
                {
                    msA.productUpdate(pK: id, barcode: BARCODETXTB.Text, name: NAMETXTB.Text.ToUpper(), category: CTGRYCMBBX.SelectedValue.ToString(), purchasePrice: PRCHSPRCTXTB.Text, salePrice: SALEPRCTXTB.Text, unit: UNITCMBBX.SelectedValue.ToString(), amount: AMOUNTTXTB.Text);
                    msA.showProducts(PRODUCTSDGW);
                }
            }
            else
            {
                MessageBox.Show("Giriş yerlerini boş bırakmayınız !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void PRODUCTSDGW_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                NAMETXTB.Text = PRODUCTSDGW.CurrentRow.Cells["p_name"].Value.ToString();
                BARCODETXTB.Text = PRODUCTSDGW.CurrentRow.Cells["p_barcode"].Value.ToString();
                id = PRODUCTSDGW.CurrentRow.Cells["p_barcode"].Value.ToString();
                CTGRYCMBBX.Text = PRCHSPRCTXTB.Text = PRODUCTSDGW.CurrentRow.Cells["c_name"].Value.ToString();
                PRCHSPRCTXTB.Text = PRODUCTSDGW.CurrentRow.Cells["p_purchase_price"].Value.ToString();
                SALEPRCTXTB.Text = PRCHSPRCTXTB.Text = PRODUCTSDGW.CurrentRow.Cells["p_sale_price"].Value.ToString();
                UNITCMBBX.Text = PRCHSPRCTXTB.Text = PRODUCTSDGW.CurrentRow.Cells["u_name"].Value.ToString();
                AMOUNTTXTB.Text = PRCHSPRCTXTB.Text = PRODUCTSDGW.CurrentRow.Cells["p_amount"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SEARCHBARCODETXTB_TextChanged(object sender, EventArgs e)
        {
            msA.searchProductWithBarcode(PRODUCTSDGW, SEARCHBARCODETXTB.Text);
        }

        private void SEARCHNAMETXTB_TextChanged(object sender, EventArgs e)
        {
            msA.searchProductWithName(PRODUCTSDGW, SEARCHNAMETXTB.Text);
        }
    }
}
