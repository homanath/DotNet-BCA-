using Microsoft.Data.SqlClient;
using System.ComponentModel;

namespace DwsktopAppExample
{
    public partial class FormUserList : Form
    {
        private List<UserList> userList = new List<UserList>();
        private const string = "Data Source=localhost;Initial Catalog=BCAV;Integrated Security=SSPI; TrustSet=        b        ";
        private static SqlConnection conn = new SqlConnection(conString);
        private static SqlCommand cmd = new SqlCommand("", conn);
        public FormUserList()
        {
            InitializeComponent();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            LoadData();
            DgvUserList.DataSource = userList;
        }
        private void LoadData() {
            cmd.CommandText = "SELECT" ; 
            try
            {

            }
        }
       
    }
}
