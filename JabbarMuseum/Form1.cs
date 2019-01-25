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

        public List<Visitors> LsVisitors = new List<Visitors>();
        
        public void ToCSV(String data)
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

      

        

        

        public void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int cardNo = 0;
                String path = @"Data.csv";
                if (!File.Exists(path))
                {
                    File.Create(path);
                }
                using (StreamReader reader = new StreamReader(path))
                {
                    String line = "";
                    if (File.Exists(@"Data.csv"))
                    {
                        while (!reader.EndOfStream)
                        {
                            line = reader.ReadLine();
                            String[] rowData = line.Split(',');
                            cardNo = int.Parse(rowData[0]);
                        }

                        cardNo = ++cardNo;
                    }

                }

                String name = txtName.Text;
                String phNo = txtPhone.Text;
                String occupation = comboBoxOccupation.Text;
                String gender = "";
                if (radBtnMale.Checked)
                {
                    gender = radBtnMale.Text;
                }
                else
                {
                    gender = radBtnFemale.Text;
                }
                DateTime inTime = DateTime.Now;
                
                DayOfWeek day = inTime.DayOfWeek;
                Visitors visitors = new Visitors(cardNo, name, phNo, occupation, gender, inTime, day);
                LsVisitors.Add(visitors);
                String data = cardNo + "," + name + "," + phNo + "," + occupation + "," + gender + "," + inTime + "," + day;
                ToCSV(data);

            } catch (Exception f)
            {
                MessageBox.Show("The values entered are either missing or incorrect!");
            }


            
        }

        
    }
}
