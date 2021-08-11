using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PrototipoLaboratorio.Ventanas
{
    /// <summary>
    /// Lógica de interacción para wpfRequerimientosClinica.xaml
    /// </summary>
    public partial class wpfRequerimientosClinica : UserControl
    {
        Conexion cn = new Conexion();
        public wpfRequerimientosClinica()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, RoutedEventArgs e)
        {
            string cadena = "INSERT INTO" +
<<<<<<< HEAD
                " requerimientos_clinicos (id_requerimiento_clinico, descripcion_requerimiento_clinico) VALUES (" + "'" + txtIdRequerimiento.Text + "', '"+ txtDescripcion.Text + "' ); ";
=======
                " requerimientos_clinicos (id_requerimiento_clinico, descripcion_requerimiento_clinico, cantidad) VALUES (" + "'" + txtIdRequerimiento.Text + "', '"+ txtDescripcion.Text + "', '" + txtCantidad.Text + "' ); ";
>>>>>>> 076941c0598aa625faf85ae6ed0ec4c91387d08f

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
            MessageBox.Show("Inserción realizada");


            txtIdRequerimiento.Text = "";
            txtDescripcion.Text = "";
<<<<<<< HEAD
=======
            txtCantidad.Text = "";
>>>>>>> 076941c0598aa625faf85ae6ed0ec4c91387d08f
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
<<<<<<< HEAD
                //string MyConnection2 = "datasource=localhost;port=3306;username=root;password=6182";
                string cadena = "update CLINICA1.REQUERIMIENTOS_CLINICOS set id_requerimiento_clinico ='" + this.txtIdRequerimiento.Text
                    + "',descripcion_requerimiento_clinico ='" + this.txtDescripcion.Text + "';";
=======
                
                string cadena = "update CLINICA1.REQUERIMIENTOS_CLINICOS set id_requerimiento_clinico ='" + this.txtIdRequerimiento.Text
                    + "',descripcion_requerimiento_clinico ='" + this.txtDescripcion.Text + "',cantidad ='" + this.txtCantidad.Text  + "';";
>>>>>>> 076941c0598aa625faf85ae6ed0ec4c91387d08f


                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();

                MessageBox.Show("Modificacion realizada");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtIdRequerimiento.Text = "";
            txtDescripcion.Text = "";
<<<<<<< HEAD
            
=======
            txtCantidad.Text = "";
            txtIdRequerimiento.IsEnabled = true;
            btnInsertar.IsEnabled = true;

>>>>>>> 076941c0598aa625faf85ae6ed0ec4c91387d08f
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            txtIdRequerimiento.Text = "";
            txtDescripcion.Text = "";
<<<<<<< HEAD
=======
            txtCantidad.Text = "";
>>>>>>> 076941c0598aa625faf85ae6ed0ec4c91387d08f
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
            try
            {
                
                string Query = "select * from CLINICA1.REQUERIMIENTOS_CLINICOS where id_requerimiento_clinico='" + this.txtBuscar.Text + "';";
                

                OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
                consulta.ExecuteNonQuery();

                OdbcDataReader busqueda;
                busqueda = consulta.ExecuteReader();

                if (busqueda.Read())
                {
                    txtIdRequerimiento.Text = busqueda["id_requerimiento_clinico"].ToString();
                    txtDescripcion.Text = busqueda["descripcion_requerimiento_clinico"].ToString();
                    
                }
                else
                {
                    MessageBox.Show("Registro no encontrado");
                }
                //MyConn2.Close();
                this.txtBuscar.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
=======
            if (txtBuscar.Text != "")
            {
                try
                {

                    string Query = "select * from CLINICA1.REQUERIMIENTOS_CLINICOS where id_requerimiento_clinico='" + this.txtBuscar.Text + "';";


                    OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
                    consulta.ExecuteNonQuery();

                    OdbcDataReader busqueda;
                    busqueda = consulta.ExecuteReader();

                    if (busqueda.Read())
                    {
                        txtIdRequerimiento.Text = busqueda["id_requerimiento_clinico"].ToString();
                        txtDescripcion.Text = busqueda["descripcion_requerimiento_clinico"].ToString();
                        txtCantidad.Text = busqueda["cantidad"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Registro no encontrado");
                    }

                    this.txtBuscar.Text = "";

                    txtIdRequerimiento.IsEnabled = false;
                    btnInsertar.IsEnabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Ingrese dato a buscar");
>>>>>>> 076941c0598aa625faf85ae6ed0ec4c91387d08f
            }
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {

            try { 
            string cadena = "delete from CLINICA1.REQUERIMIENTOS_CLINICOS where id_requerimiento_clinico='" + this.txtIdRequerimiento.Text + "';";
            
            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            MessageBox.Show("Datos Eliminados");
            while (busqueda.Read())
            {
            }
            //MyConn2.Close();

            txtIdRequerimiento.Text = "";
            txtDescripcion.Text = "";
<<<<<<< HEAD
           
=======
            txtCantidad.Text = "";
            txtIdRequerimiento.IsEnabled = true;
            btnInsertar.IsEnabled = true;
>>>>>>> 076941c0598aa625faf85ae6ed0ec4c91387d08f
            }   

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
<<<<<<< HEAD
=======

 
>>>>>>> 076941c0598aa625faf85ae6ed0ec4c91387d08f
    }
}
