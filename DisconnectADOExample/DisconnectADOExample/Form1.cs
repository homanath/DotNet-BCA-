using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        // Declare globally so both methods can access
        SqlDataAdapter adapter;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost;DataBase=BCAV;Security=SSPI;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM userList", conn);
            adapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "userList");
            dataGridView1.DataSource = ds.Tables["userList"];
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                adapter.Update(ds.Tables["userList"]);
                MessageBox.Show("Saved successfully.");
            }
            catch
            {
                MessageBox.Show("Error saving data.");
            }
        }
    }
}
