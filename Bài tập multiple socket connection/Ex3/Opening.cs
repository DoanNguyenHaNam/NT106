using System.Security.Cryptography;

namespace Ex3
{
    public partial class Opening : Form
    {
        public Opening()
        {
            InitializeComponent();
        }
        public const string ConnectionString =@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AuthDB;Integrated Security=True;";

        public static string username = "ơ kìa tên đâu";

        static public byte[] Sha256Bytes(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(input));
            }
        }
        private void Opening_Load(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
}
