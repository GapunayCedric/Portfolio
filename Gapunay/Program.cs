using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PSLP_CRUD
{
    public partial class MainForm : Form
    {
        private string connectionString = "server=localhost;database=pslp;user=root;password=;";
        
        public MainForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM DEPARTMENT";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView.DataSource = dt;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO DEPARTMENT (DEPT_CODE, DEPT_NAME, DEPT_DESCRIPTION) VALUES (@code, @name, @desc)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@code", txtDeptCode.Text);
                cmd.Parameters.AddWithValue("@name", txtDeptName.Text);
                cmd.Parameters.AddWithValue("@desc", txtDeptDesc.Text);
                cmd.ExecuteNonQuery();
                LoadData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE DEPARTMENT SET DEPT_NAME=@name, DEPT_DESCRIPTION=@desc WHERE DEPT_CODE=@code";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@code", txtDeptCode.Text);
                cmd.Parameters.AddWithValue("@name", txtDeptName.Text);
                cmd.Parameters.AddWithValue("@desc", txtDeptDesc.Text);
                cmd.ExecuteNonQuery();
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM DEPARTMENT WHERE DEPT_CODE=@code";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@code", txtDeptCode.Text);
                cmd.ExecuteNonQuery();
                LoadData();
            }
        }
    }
}
