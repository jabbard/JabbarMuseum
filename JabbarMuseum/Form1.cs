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
    public partial class Form1 : Form
    {
        
        private void ToCSV(String data)
        {
            String path = @"Data.csv";
            if (!File.Exists(path))
            {
                File.Create(path);
            }

            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(data);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

      

        

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            int cardNo = 1;
            String name = txtName.Text;
            String phNo = txtPhone.Text;
            String address = txtAddress.Text;
            String occupation = comboBoxOccupation.Text;
            String gender = "";
            if (radBtnMale.Checked)
            {
                gender = radBtnMale.Text;
            } else
            {
                gender = radBtnFemale.Text;
            }
            Visitors visitors = new Visitors(cardNo, name, phNo, occupation, gender, address);
            String data = "";
            ToCSV(data);
        }
    }
}
