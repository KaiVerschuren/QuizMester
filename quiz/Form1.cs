using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=quiz;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearchKver_Click(object sender, EventArgs e)
        {
            if (txbSearchKver.Text == "")
            {
                FillDatagridView();
            }
            else
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    if (sqlConnection.State == ConnectionState.Closed)
                    {
                        sqlConnection.Open();
                    }

                    using (DataTable datatable = new DataTable("Datatablepropertyname"))
                    {
                        using (SqlCommand command = new SqlCommand("SELECT * FROM questions WHERE id = @id", sqlConnection))
                        {
                            command.Parameters.AddWithValue("@id", txbSearchKver.Text);

                            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);

                            sqlDataAdapter.Fill(datatable);

                            dgvInformationKver.DataSource = datatable;
                        }
                    }
                }
            }
            ResetDvgSize();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillDatagridView();
        }

        private void FillDatagridView()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                using (DataTable dataTable = new DataTable("datatablepropertyname"))
                {
                    using (SqlCommand command = new SqlCommand("SELECT * FROM questions", sqlConnection))
                    { 
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);

                        sqlDataAdapter.Fill(dataTable);

                        dgvInformationKver.DataSource = dataTable;
                    }
                }
            }
            ResetDvgSize();
        }

        private void ResetDvgSize()
        {
            dgvInformationKver.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            int totalWidth = dgvInformationKver.RowHeadersWidth;

            foreach (DataGridViewColumn column in dgvInformationKver.Columns)
            {
                totalWidth += column.Width;
            }

            dgvInformationKver.Width = totalWidth + 20;

            this.Width = totalWidth + 50;
        }

        private void btnResetKver_Click(object sender, EventArgs e)
        {
            txbSearchKver.Text = "";
            FillDatagridView();
        }
    }
}
