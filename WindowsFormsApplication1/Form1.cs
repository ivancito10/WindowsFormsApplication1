using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebServiceSoapClient ws = new ServiceReference1.WebServiceSoapClient();
            ws.Modifica(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebServiceSoapClient ws = new ServiceReference1.WebServiceSoapClient();
            DateTime fechaNacimiento;
            if (DateTime.TryParse(textBox5.Text, out fechaNacimiento))
            {
                int resultado = ws.Agregar(textBox2.Text, textBox3.Text, fechaNacimiento, textBox4.Text);
                if (resultado == 1)
                {
                    MessageBox.Show("Registro agregado correctamente");
                }
                else
                {
                    MessageBox.Show("Error al agregar el registro");
                }
            }
            else
            {
                MessageBox.Show("Formato de fecha de nacimiento inválido");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebServiceSoapClient ws = new ServiceReference1.WebServiceSoapClient();
            int id = Convert.ToInt32(textBox1.Text);
            int resultado = ws.Eliminar(id);
            if (resultado == 1)
            {
                MessageBox.Show("Registro eliminado correctamente");
            }
            else
            {
                MessageBox.Show("Error al eliminar el registro");
            }
        }
    }
}
