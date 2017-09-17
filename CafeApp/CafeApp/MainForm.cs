using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.database1DataSet.Users);

        }

        private void usersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
