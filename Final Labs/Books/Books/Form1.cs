using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Books
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Database.connect();
            conn.Open();
            string search = searchtextBox.Text;
            string query = "SELECT * FROM Book where Name Like" + "'" + search + "%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];




           

        }

        private void searchtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null)
            {
                dataGridView1.CurrentRow.Selected = true;
                string id = dataGridView1.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
                string name = dataGridView1.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                string author = dataGridView1.Rows[e.RowIndex].Cells["Author"].FormattedValue.ToString();
                string edition = dataGridView1.Rows[e.RowIndex].Cells["Edition"].FormattedValue.ToString();
                
                Form2 f2 = new Form2(id,name, author,edition);
                f2.Show();
                


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

