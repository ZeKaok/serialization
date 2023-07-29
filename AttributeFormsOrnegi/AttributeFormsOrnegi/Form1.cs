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
using System.Xml.Serialization;

namespace AttributeFormsOrnegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee
            {
                Name = ad.Text,
                Phone = telefon.Text,
                DoB = tarih.Value,
                Department = bolum.Text,
                Salary = Convert.ToInt32(maas.Text),
                additonalInfo = "Serileşme istemiyoruz"

            };
            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            FileStream fsout = new FileStream("employee.xml", FileMode.Create, FileAccess.Write, FileShare.None);

            try
            {
                using (fsout)
                {
                    xs.Serialize(fsout, emp);
                    MessageBox.Show("Bilgiler Serialize Edildi");

                    ad.Text = "";
                    telefon.Text = "";
                    bolum.Text = "";
                    maas.Text = "";
                    tarih.Value = System.DateTime.Now;
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();

            }
            finally
            {
                fsout.Close();
            }
        }
    }
    }

