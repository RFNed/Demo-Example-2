using Demo_Example_2.Modules;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Example_2.Forms
{
    public partial class Catalog : Form
    {
        private string? name;
        private int? role;
        private string? roleName;
        public Catalog(string name, int role, string roleName)
        {
            InitializeComponent();
            name = name;
            role = role;
            roleName = roleName;

            GreetLabel.Text += name;
            LoadItems();

        }

        public void LoadItems()
        {

            itemList.Controls.Clear();

            using (Database db = new((new JSONReader()).Reading()))
            {

                MySqlConnection connection = db.GetConnect();

                MySqlCommand cmd = new("select inventory.name as InvName, types.name as typeName, inventory.photo as photo, inventory.priceperday as Price, status_table.name as StatusName from inventory join types on types.id = inventory.typeID join status_table on status_table.id = inventory.statusid", connection);

                MySqlDataReader reader = cmd.ExecuteReader();



                while (reader.Read())
                {
                    Panel panel = new Panel
                    {
                        Width = 730,
                        Height = 130,
                        BackColor = Color.Black,
                        Margin = new Padding(10),
                        Cursor = Cursors.Hand
                    };
                    TableLayoutPanel table = new TableLayoutPanel
                    {
                        Dock = DockStyle.Fill,
                        ColumnCount = 3,
                        RowCount = 1
                    };
                    table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));
                    table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
                    table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));

                    PictureBox imgPanel = new PictureBox { Dock = DockStyle.Fill };

                    string Name = reader.GetString("InvName");
                    string TypeName = reader.GetString("typeName");
                    double Price = reader.GetDouble("Price");
                    string StatusName = reader.GetString("StatusName");
                    string ImagePath = $"Assets\\{reader.GetString("photo")}";

                    System.Diagnostics.Debug.WriteLine(ImagePath);

                    if (System.IO.File.Exists(ImagePath))
                        imgPanel.Image = Image.FromFile(ImagePath);
                    else
                        imgPanel.BackColor = Color.Gray;

                    table.Controls.Add(imgPanel, 0, 0);

                    TableLayoutPanel table_info = new TableLayoutPanel
                    {
                        Dock = DockStyle.Fill,
                        ColumnCount = 1,
                        RowCount = 2
                    };

                    Label itemTitle = new Label
                    {
                        Text = Name,
                        ForeColor = Color.White,
                        Margin = new Padding(10),
                        Font = new Font("Times New Roman", 13),
                        AutoSize = true
                    };

                    string itemInfoText = $"Тип: {TypeName}\nДоступ: {StatusName}";

                    Label itemInfo = new Label
                    {
                        Text = itemInfoText,
                        ForeColor = Color.White,
                        Margin = new Padding(10),
                        Font = new Font("Times New Roman", 9),
                        AutoSize = true
                    };


                    table_info.Controls.Add(itemTitle, 0, 1);
                    table_info.Controls.Add(itemInfo, 0, 2);

                    Label itemPrice = new Label
                    {
                        Text = $"{Price} ₽/день",
                        ForeColor = Color.White,
                        Margin = new Padding(10),
                        AutoSize = true,
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    table.Controls.Add(itemPrice, 2, 0);
                    table.Controls.Add(table_info, 1, 0);

                    panel.Controls.Add(table);

                    ContextMenuStrip MenuContext = new();

                    ToolStripMenuItem ItemMenuRedact = new ToolStripMenuItem("Редактировать");
                    ItemMenuRedact.Image = SystemIcons.Shield.ToBitmap();
                    ItemMenuRedact.Click += Redact;
                    ToolStripMenuItem ItemMenuDelete = new ToolStripMenuItem("Удалить");
                    ItemMenuDelete.Image = SystemIcons.Hand.ToBitmap();
                    ItemMenuDelete.Click += Delete;


                    MenuContext.Items.Add(ItemMenuRedact);
                    MenuContext.Items.Add(ItemMenuDelete);

                    panel.ContextMenuStrip = MenuContext;

                    itemList.Controls.Add(panel);
                }


            }


        }

        private void Redact(object sender, EventArgs e)
        {
            MessageBox.Show("Вы нажали на кнопку редактирования", "Готово");
        }

        private void Delete(object sender, EventArgs e)
        {
            MessageBox.Show("Вы нажали на кнопку удаления", "Готово");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            itemList.Visible = false;
            LoadItems();
            itemList.Visible = true;
            this.Cursor = Cursors.Default;
        }
    }
}
