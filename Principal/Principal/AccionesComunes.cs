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
    internal class AccionesComunes
    {
        public static void LlenarCombo(string consulta, ComboBox comboBox1, string id, string campo)
        {
            DataTable dt;
            dt = Conexion.EjecutaSeleccion(consulta);

            DataRow fila = dt.NewRow();

            fila[0] = 0;
            fila[1] = "Todos los datos";
            dt.Rows.InsertAt(fila, 0);
            if (dt == null)
            {
                return;
            }

            comboBox1.Items.Clear();
            comboBox1.DataSource = dt;
            comboBox1.ValueMember = id;
            comboBox1.DisplayMember = campo;
        }

        
        public static void LlenarDataGrid(string consulta, DataGridView dataGrid)
        {
            DataTable dt;
            dt = Conexion.EjecutaSeleccion(consulta);

            if (dt == null)
            {
                return;
            }

            dataGrid.DataSource = dt;
           
        }
        public static void LlenarListView(string consulta, ListView listView )
        {
            DataTable dt;          
            dt = Conexion.EjecutaSeleccion(consulta);
            ListViewItem lista = new ListViewItem();


            if (dt == null)
            {
                return;
            }

            
            listView.Items.Clear();
            listView.View = View.Details;
            listView.GridLines = true;
            int columnas = dt.Columns.Count;
            int filas = dt.Rows.Count;
            
            for (int i = 0; i < columnas; i++)
            {

                listView.Columns.Add(dt.Columns[i].ToString());
                  }
            foreach (DataRow ren in dt.Rows)
            {

                String[] arreglo = new String[filas];
              

                for (int j = 0; j < columnas; j++)
                {

                    arreglo[j] = ren[j].ToString();

                    lista = new ListViewItem(arreglo);

                }
                listView.Items.Add(lista);


            }

          
        }
    }
}
