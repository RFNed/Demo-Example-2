using MySql.Data.MySqlClient;
using Demo_Example_2.Modules;
using Demo_Example_2.Forms;


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

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (loginBox.Text == "" || passBox.Text == "")
            {
                MessageBox.Show("Введите значения в поля", "Внимание", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Exclamation);
            }
            using (Database db = new((new JSONReader()).Reading()))
            {
                MySqlConnection connection = db.GetConnect();
                MySqlCommand cmd = new("select users.name as usersName, role_id, roles.name as roleName from users join roles on roles.id = users.role_id where login = @login and password = @password", connection);
                cmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginBox.Text;
                cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = passBox.Text;
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {

                    reader.Read();
                    string name = reader.GetString("usersName");
                    string roleName = reader.GetString("roleName");
                    int roleId = reader.GetInt32("role_id");
                    Catalog catalog_form = new(name, roleId, roleName);

                    this.Hide();

                    catalog_form.Show();


                }
                else
                {
                    MessageBox.Show("Логин/Пароль введены неверно", "Ошибка", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Stop);
                }
            }
        }

        private void guestButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Catalog catalog_form = new("Гость", 7, "Гость");
            catalog_form.Show();
        }
    }
}
