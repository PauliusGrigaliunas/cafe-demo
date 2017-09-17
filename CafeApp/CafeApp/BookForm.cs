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
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bookATableDatabaseDataSet);

        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookDatabaseDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter1.Fill(this.bookDatabaseDataSet.Table);
            // TODO: This line of code loads data into the 'bookATableDatabaseDataSet.Table' table. You can move, or remove it, as needed.

        }
    }
}
