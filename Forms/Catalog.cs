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
        private string name;
        private int role;
        private string roleName;
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
            Panel panel = new Panel
            {
                Width = 780, Height = 100, BackColor = Color.Black, Margin = new Padding(1)
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

            Panel imgPanel = new Panel { BackColor = Color.Gray, Dock = DockStyle.Fill };
            table.Controls.Add(imgPanel, 0, 0);

            panel.Controls.Add(table);

            

            itemList.Controls.Add(panel);
        }

    }
}
