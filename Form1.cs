using Microsoft.Data.SqlClient;
using System.Data;

namespace testApp
{
    public partial class Form1 : Form
    {
        const string conString = "Data Source=DESKTOP-9N46EPK\\DANIIL_BANK1230;Initial Catalog=exam_winForms;Integrated Security=True;TrustServerCertificate=True";

        SqlConnection con = new SqlConnection(conString);

        SqlCommand cmd = new SqlCommand(conString);
        SqlDataAdapter adapter = new SqlDataAdapter();

        DataTable table = new DataTable();

        public Form1()
        {
            InitializeComponent();
            initData();
        }

        private void initData()
        {
            table.Clear();
            con.Open();
            adapter = new SqlDataAdapter("SELECT * FROM product", con);
            adapter.Fill(table);
            con.Close();

            dataView.DataSource = table;
            dataView.Columns[0].HeaderText = "ID";
            dataView.Columns[1].HeaderText = "Name";
            dataView.Columns[2].HeaderText = "Count";
            dataView.Columns[3].HeaderText = "Unit";
            dataView.Columns[4].HeaderText = "Price";

            dataView.MultiSelect = false;
            dataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataView.SelectionChanged += DataView_SelectionChanged;
        }

        private void DataView_SelectionChanged(object? sender, EventArgs e)
        {
            var row = dataView.SelectedRows;
            if (row.Count == 1)
            {
                txtName.Text = dataView.SelectedRows[0].Cells[1].Value.ToString();
                txtCount.Text = dataView.SelectedRows[0].Cells[2].Value.ToString();
                txtUnit.Text = dataView.SelectedRows[0].Cells[3].Value.ToString();
                txtPrice.Text = dataView.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cmd.CommandText = $"INSERT INTO product (name,count,unit,price) VALUES(" +
                // $"{Convert.ToInt32(txtId.Text)}," +
                $"'{txtName.Text}'," +
                $"{Convert.ToInt32(txtCount.Text)}," +
                $"'{txtUnit.Text}'," +
                $"{Convert.ToDouble(txtPrice.Text)})";

            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();

            initData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataView.SelectedRows.Count == 1)
            {
                var idDel = dataView.SelectedRows[0].Cells[0].Value.ToString();
                cmd.CommandText = $"DELETE FROM product WHERE id={Convert.ToInt32(idDel)}";

                con.Open();
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();

                initData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataView.SelectedRows.Count == 1)
            {
                var idUpdate = dataView.SelectedRows[0].Cells[0].Value.ToString();
                cmd.CommandText = $"UPDATE product " +
                    $"SET name='{txtName.Text}'," +
                    $"count={Convert.ToInt32(txtCount.Text)}," +
                    $"unit= '{txtUnit.Text}'," +
                    $"price={Convert.ToDouble(txtPrice.Text)}" +
                    $"WHERE id={Convert.ToInt32(idUpdate)}";

                con.Open();
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();

                initData();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            BindingSource bs = new BindingSource();
            bs.DataSource = table;
            bs.Filter = "name" + " like '%" + txtSearch.Text + "%'";
            dataView.DataSource = bs;
        }
    }
}
