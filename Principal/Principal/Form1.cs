using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
       
        private  void btnCorrer_Click(object sender, EventArgs e)

        {  

            AccionesComunes.LlenarCombo( textBox1.Text, comboBox1, "id", "nombre");

            AccionesComunes.LlenarDataGrid(textBox1.Text, dataGrid);
            AccionesComunes.LlenarListView(textBox1.Text, listView1);
          
        }
        
       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.SelectedValue.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
