using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using Npgsql;
using System.IO;

namespace ProductStock
{
    interface Iproduct
    {
        //mainform
        void productAdd(string barcode, string name, string category, string purchasePrice, string salePrice, string unit, string amount);
        void productDelete(string barcode);
        void productUpdate(string pk, string barcode, string name, string category, string purchasePrice, string salePrice, string unit, string amount);
        void showCategory(ComboBox category);
        void showUnit(ComboBox unit);
        void showProducts(DataGridView products);
        void searchProductWithBarcode(DataGridView products, string barcode);
        void searchProductWithName(DataGridView products, string name);
    }
    interface Icategory
    {
        //formCategory
        void categoryAdd_(string name);
        void categoryDelete_(int id);
        void categoryUpdate_(string name, int id);
        void showCategory_(DataGridView category);
    }
    interface Iunit
    {
        //formUnit
        void _unitAdd(string name);
        void _unitDelete(int id);
        void _unitUpdate(string name, int id);
        void _showUnit(DataGridView unit);
    }

    class MsAccess : Iproduct, Icategory, Iunit
    {
        //connection string
        static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =PRODUCT.accdb";

        //database objects
        OleDbConnection conn = new OleDbConnection(connectionString);
        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataTable dt;


        //mainform
        public void productAdd(string barcode, string name, string category, string purchasePrice, string salePrice, string unit, string amount)
        {
            try
            {
                conn.Open();
                cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO product_table (p_barcode, p_name, p_category, p_purchase_price, p_sale_price, p_amount, p_unit) VALUES (@barcode, @name, @category, @purchasePrice, @salePrice, @amount, @unit)";
                cmd.Parameters.AddWithValue("@barcode", barcode);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@purchasePrice", purchasePrice);
                cmd.Parameters.AddWithValue("@salePrice", salePrice);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@unit", unit);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Ekleme işlemi başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (System.Data.OleDb.OleDbException)
            {
                MessageBox.Show("Ürünlerin barkodları aynı olamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        public void productDelete(string barcode)
        {
            try
            {
                conn.Open();
                cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM product_table WHERE p_barcode = '" + barcode + "'";
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Silme işlemi başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        public void productUpdate(string pK, string barcode, string name, string category, string purchasePrice, string salePrice, string unit, string amount)
        {
            try
            {
                conn.Open();
                cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE product_table SET p_barcode = @barcode, p_name = @name, p_category = @category, p_purchase_price = @purchasePrice, p_sale_price = @salePrice, p_amount = @amount, p_unit = @unit WHERE p_barcode = @pK";
                cmd.Parameters.AddWithValue("@barcode", barcode);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@purchasePrice", purchasePrice);
                cmd.Parameters.AddWithValue("@salePrice", salePrice);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@unit", unit);
                cmd.Parameters.AddWithValue("@pK", pK);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Güncelleme işlemi başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        public void showCategory(ComboBox category)
        {
            try
            {
                conn.Open();
                da = new OleDbDataAdapter("SELECT * FROM product_category_table", conn);
                dt = new DataTable();
                da.Fill(dt);
                category.DataSource = dt;
                category.DisplayMember = "c_name";
                category.ValueMember = "c_id";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        public void showProducts(DataGridView products)
        {
            try
            {
                conn.Open();
                da = new OleDbDataAdapter("SELECT p_barcode, p_name, c_name, p_purchase_price, p_sale_price, u_name, p_amount FROM product_table, product_category_table, product_unit_table WHERE product_table.p_category = product_category_table.c_id AND product_table.p_unit = product_unit_table.u_id", conn);
                dt = new DataTable();
                da.Fill(dt);
                products.DataSource = dt;

                products.Columns["p_barcode"].HeaderText = "Ürünün Barkodu";
                products.Columns["p_barcode"].Width = 150;
                products.Columns["p_name"].HeaderText = "Ürünün Adı";
                products.Columns["p_name"].Width = 150;
                products.Columns["c_name"].HeaderText = "Ürünün Kategorisi";
                products.Columns["c_name"].Width = 150;
                products.Columns["p_purchase_price"].HeaderText = "Ürünün Alış Fiyatı";
                products.Columns["p_purchase_price"].Width = 100;
                products.Columns["p_sale_price"].HeaderText = "Ürünün Satış Fiyatı";
                products.Columns["p_sale_price"].Width = 100;
                products.Columns["u_name"].HeaderText = "Ürünün Birimi";
                products.Columns["u_name"].Width = 150;
                products.Columns["p_amount"].HeaderText = "Ürünün Miktarı";
                products.Columns["p_amount"].Width = 100;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        public void showUnit(ComboBox unit)
        {
            try
            {
                conn.Open();
                da = new OleDbDataAdapter("SELECT * FROM product_unit_table", conn);
                dt = new DataTable();
                da.Fill(dt);
                unit.DataSource = dt;
                unit.DisplayMember = "u_name";
                unit.ValueMember = "u_id";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        public void searchProductWithBarcode(DataGridView products, string barcode)
        {
            try
            {
                conn.Open();
                da = new OleDbDataAdapter("SELECT p_barcode, p_name, c_name, p_purchase_price, p_sale_price, u_name, p_amount FROM product_table, product_category_table, product_unit_table WHERE product_table.p_category = product_category_table.c_id AND product_table.p_unit = product_unit_table.u_id AND p_barcode LIKE '" + barcode + "%'", conn);
                dt = new DataTable();
                da.Fill(dt);
                products.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        public void searchProductWithName(DataGridView products, string name)
        {
            try
            {
                conn.Open();
                da = new OleDbDataAdapter("SELECT p_barcode, p_name, c_name, p_purchase_price, p_sale_price, u_name, p_amount FROM product_table, product_category_table, product_unit_table WHERE product_table.p_category = product_category_table.c_id AND product_table.p_unit = product_unit_table.u_id AND p_name LIKE '" + name + "%'", conn);
                dt = new DataTable();
                da.Fill(dt);
                products.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        
        //formCategory
        public void categoryAdd_(string name)
        {
            try
            {
                conn.Open();
                cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO product_category_table (c_name) VALUES ('" + name + "')";
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Ekleme işlemi başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        public void categoryDelete_(int id)
        {
            try
            {
                conn.Open();
                cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM product_category_table WHERE c_id = " + id + "";
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Silme işlemi başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        public void categoryUpdate_(string name, int id)
        {
            try
            {
                conn.Open();
                cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE product_category_table SET c_name = '" + name + "' WHERE c_id = " + id + "";
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Güncelleme işlemi başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        public void showCategory_(DataGridView category)
        {
            try
            {
                conn.Open();
                da = new OleDbDataAdapter("SELECT * FROM product_category_table", conn);
                dt = new DataTable();
                da.Fill(dt);
                category.DataSource = dt;
                category.Columns["c_id"].HeaderText = "Kategorinin Numarası";
                category.Columns["c_id"].Width = 210;
                category.Columns["c_name"].HeaderText = "Kategorinin Adı";
                category.Columns["c_name"].Width = 210;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        //formUnit
        public void _unitAdd(string name)
        {
            try
            {
                conn.Open();
                cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO product_unit_table (u_name) VALUES ('" + name + "')";
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Ekleme işlemi başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        public void _unitDelete(int id)
        {
            try
            {
                conn.Open();
                cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM product_unit_table WHERE u_id = " + id + "";
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Silme işlemi başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        public void _unitUpdate(string name, int id)
        {
            try
            {
                conn.Open();
                cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE product_unit_table SET u_name = '" + name + "' WHERE u_id = " + id + "";
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Güncelleme işlemi başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        public void _showUnit(DataGridView unit)
        {
            try
            {
                conn.Open();
                da = new OleDbDataAdapter("SELECT * FROM product_unit_table", conn);
                dt = new DataTable();
                da.Fill(dt);
                unit.DataSource = dt;
                unit.Columns["u_id"].HeaderText = "Birimin Numarası";
                unit.Columns["u_id"].Width = 210;
                unit.Columns["u_name"].HeaderText = "Birimin Adı";
                unit.Columns["u_name"].Width = 210;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
    }

    class PostgreSQL : Iproduct, Icategory, Iunit
    {
        //connection string
        static string connectionString;

        //database objects
        NpgsqlConnection conn = new NpgsqlConnection(connectionString);
        NpgsqlCommand cmd;
        NpgsqlDataAdapter da;
        DataTable dt;

        //mainform
        public void productAdd(string barcode, string name, string category, string purchasePrice, string salePrice, string unit, string amount)
        {
            try
            {
                conn.Open();
                cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO product_table (p_barcode, p_name, p_category, p_purchase_price, p_sale_price, p_amount, p_unit) VALUES (@barcode, @name, @category, @purchasePrice, @salePrice, @amount, @unit)";
                cmd.Parameters.AddWithValue("@barcode", barcode);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@purchasePrice", purchasePrice);
                cmd.Parameters.AddWithValue("@salePrice", salePrice);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@unit", unit);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Ekleme işlemi başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (System.Data.OleDb.OleDbException)
            {
                MessageBox.Show("Ürünlerin barkodları aynı olamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        public void productDelete(string barcode)
        {
            try
            {
                conn.Open();
                cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM product_table WHERE p_barcode = '" + barcode + "'";
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Silme işlemi başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        public void productUpdate(string pK, string barcode, string name, string category, string purchasePrice, string salePrice, string unit, string amount)
        {
            try
            {
                conn.Open();
                cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE product_table SET p_barcode = @barcode, p_name = @name, p_category = @category, p_purchase_price = @purchasePrice, p_sale_price = @salePrice, p_amount = @amount, p_unit = @unit WHERE p_barcode = @pK";
                cmd.Parameters.AddWithValue("@barcode", barcode);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@purchasePrice", purchasePrice);
                cmd.Parameters.AddWithValue("@salePrice", salePrice);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@unit", unit);
                cmd.Parameters.AddWithValue("@pK", pK);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Güncelleme işlemi başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        public void showCategory(ComboBox category)
        {
            try
            {
                conn.Open();
                da = new NpgsqlDataAdapter("SELECT * FROM product_category_table", conn);
                dt = new DataTable();
                da.Fill(dt);
                category.DataSource = dt;
                category.DisplayMember = "c_name";
                category.ValueMember = "c_id";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        public void showProducts(DataGridView products)
        {
            try
            {
                conn.Open();
                da = new NpgsqlDataAdapter("SELECT p_barcode, p_name, c_name, p_purchase_price, p_sale_price, u_name, p_amount FROM product_table, product_category_table, product_unit_table WHERE product_table.p_category = product_category_table.c_id AND product_table.p_unit = product_unit_table.u_id", conn);
                dt = new DataTable();
                da.Fill(dt);
                products.DataSource = dt;

                products.Columns["p_barcode"].HeaderText = "Ürünün Barkodu";
                products.Columns["p_barcode"].Width = 150;
                products.Columns["p_name"].HeaderText = "Ürünün Adı";
                products.Columns["p_name"].Width = 150;
                products.Columns["c_name"].HeaderText = "Ürünün Kategorisi";
                products.Columns["c_name"].Width = 150;
                products.Columns["p_purchase_price"].HeaderText = "Ürünün Alış Fiyatı";
                products.Columns["p_purchase_price"].Width = 100;
                products.Columns["p_sale_price"].HeaderText = "Ürünün Satış Fiyatı";
                products.Columns["p_sale_price"].Width = 100;
                products.Columns["u_name"].HeaderText = "Ürünün Birimi";
                products.Columns["u_name"].Width = 150;
                products.Columns["p_amount"].HeaderText = "Ürünün Miktarı";
                products.Columns["p_amount"].Width = 100;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        public void showUnit(ComboBox unit)
        {
            try
            {
                conn.Open();
                da = new NpgsqlDataAdapter("SELECT * FROM product_unit_table", conn);
                dt = new DataTable();
                da.Fill(dt);
                unit.DataSource = dt;
                unit.DisplayMember = "u_name";
                unit.ValueMember = "u_id";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        public void searchProductWithBarcode(DataGridView products, string barcode)
        {
            try
            {
                conn.Open();
                da = new NpgsqlDataAdapter("SELECT p_barcode, p_name, c_name, p_purchase_price, p_sale_price, u_name, p_amount FROM product_table, product_category_table, product_unit_table WHERE product_table.p_category = product_category_table.c_id AND product_table.p_unit = product_unit_table.u_id AND p_barcode LIKE '" + barcode + "%'", conn);
                dt = new DataTable();
                da.Fill(dt);
                products.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        public void searchProductWithName(DataGridView products, string name)
        {
            try
            {
                conn.Open();
                da = new NpgsqlDataAdapter("SELECT p_barcode, p_name, c_name, p_purchase_price, p_sale_price, u_name, p_amount FROM product_table, product_category_table, product_unit_table WHERE product_table.p_category = product_category_table.c_id AND product_table.p_unit = product_unit_table.u_id AND p_name LIKE '" + name + "%'", conn);
                dt = new DataTable();
                da.Fill(dt);
                products.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        //formCategory
        public void categoryAdd_(string name)
        {
            try
            {
                conn.Open();
                cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO product_category_table (c_name) VALUES ('" + name + "')";
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Ekleme işlemi başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        public void categoryDelete_(int id)
        {
            try
            {
                conn.Open();
                cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM product_category_table WHERE c_id = " + id + "";
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Silme işlemi başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        public void categoryUpdate_(string name, int id)
        {
            try
            {
                conn.Open();
                cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE product_category_table SET c_name = '" + name + "' WHERE c_id = " + id + "";
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Güncelleme işlemi başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        public void showCategory_(DataGridView category)
        {
            try
            {
                conn.Open();
                da = new NpgsqlDataAdapter("SELECT * FROM product_category_table", conn);
                dt = new DataTable();
                da.Fill(dt);
                category.DataSource = dt;
                category.Columns["c_id"].HeaderText = "Kategorinin Numarası";
                category.Columns["c_id"].Width = 210;
                category.Columns["c_name"].HeaderText = "Kategorinin Adı";
                category.Columns["c_name"].Width = 210;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        //formUnit
        public void _unitAdd(string name)
        {
            try
            {
                conn.Open();
                cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO product_unit_table (u_name) VALUES ('" + name + "')";
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Ekleme işlemi başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        public void _unitDelete(int id)
        {
            try
            {
                conn.Open();
                cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM product_unit_table WHERE u_id = " + id + "";
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Silme işlemi başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        public void _unitUpdate(string name, int id)
        {
            try
            {
                conn.Open();
                cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE product_unit_table SET u_name = '" + name + "' WHERE u_id = " + id + "";
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Güncelleme işlemi başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        public void _showUnit(DataGridView unit)
        {
            try
            {
                conn.Open();
                da = new NpgsqlDataAdapter("SELECT * FROM product_unit_table", conn);
                dt = new DataTable();
                da.Fill(dt);
                unit.DataSource = dt;
                unit.Columns["u_id"].HeaderText = "Birimin Numarası";
                unit.Columns["u_id"].Width = 210;
                unit.Columns["u_name"].HeaderText = "Birimin Adı";
                unit.Columns["u_name"].Width = 210;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
    }
}
