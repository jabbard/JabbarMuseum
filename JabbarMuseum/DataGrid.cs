using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JabbarMuseum
{
    public partial class DataGrid : Form
    {
        List<Visitors> visitors;
        Form1 form1 = new Form1();
        public DataGrid()
        {
            InitializeComponent();
            Populate();
            
        }

        public void Populate()
        {
            visitors = form1.LsVisitors;
            foreach (Visitors v in visitors)
            {
                dataGridTable.Rows.Add(v.CardNo, v.Name, v.Address, v.PhNo, v.Occupation, v.Gender, v.InTime);
            }
        }

        

        private void btnRegister_Click(object sender, EventArgs e)
        {
            form1.Show();         
        }
    }
}
