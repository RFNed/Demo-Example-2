using MySql.Data.MySqlClient;
using Demo_Example_2.Modules;


namespace Demo_Example_2
{
    public partial class Auth : Form
    {
        public Auth()
        {
            // Открываем соединение для первоначальной проверки доступа к MySQL
            using (Database db = new((new JSONReader()).Reading()))
            {
                MySqlConnection connection = db.GetConnect();
            }
            InitializeComponent();
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
