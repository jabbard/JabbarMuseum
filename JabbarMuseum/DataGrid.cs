using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            String path = @"Data.csv";
            using (StreamReader reader = new StreamReader(path))
            {
                String line = "";
                if (File.Exists(path))
                {
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();
                        String[] rowData = line.Split(',');
                        dataGridTable.Rows.Add(rowData[0], rowData[1], rowData[2], rowData[3], rowData[4], rowData[5], rowData[6]);
                    }

                    
                }

            }
            
        }

        

        private void btnRegister_Click(object sender, EventArgs e)
        {
            form1.Show();         
        }
    }
}
