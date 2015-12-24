using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class FilmForm : Form
    {
        public FilmForm()
        {
            InitializeComponent();
        }

        private void table_filmBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table_filmBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tickectDataSet);

        }

        private void FilmForm_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“tickectDataSet.Table_film”中。您可以根据需要移动或删除它。
            this.table_filmTableAdapter.Fill(this.tickectDataSet.Table_film);

        }
    }
}
