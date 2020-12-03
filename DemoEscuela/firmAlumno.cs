using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoEscuela
{
    public partial class firmAlumno : Form
    {
        EscuelaDBEntities contexto;

        public firmAlumno()
        {
            InitializeComponent();
        }

        private void firmAlumno_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxApellidoMaterno_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxApellidoPaterno_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIdAlumno_TextChanged(object sender, EventArgs e)
        {

        }

        private void idAlumno_Click(object sender, EventArgs e)
        {

        }

        private void Nombre_Click(object sender, EventArgs e)
        {

        }

        private void ApellidoMaterno_Click(object sender, EventArgs e)
        {

        }

        private void LimpiarTextos()
        {
            textBoxIdAlumno.Text = "";
            textBoxNombre.Text = "";
            textBoxApellidoPaterno.Text = "";
            textBoxApellidoMaterno.Text = "";
            textBoxRutaImagen.Text = "";
            pictureBoxFotografia.ImageLocation = "";
        }

        private void LlenarGrid()
        {
            try
            {
                contexto = new EscuelaDBEntities();
                var datos = from a in contexto.Alumnoes
                            select new
                            {
                                Nombre = a.Nombre,
                                ApellidoPaterno = a.ApellidoPaterno,
                                ApellidoMaterno = a.ApellidoMaterno                      
                            };
                dgvDatos.DataSource = datos.ToList();
                dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error: " + ex.ToString());
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                contexto = new EscuelaDBEntities();

                //Creamos un nuevo alumno
                Alumno alumno = new Alumno()
                {
                    Id = int.Parse(textBoxIdAlumno.Text),
                    Nombre = textBoxNombre.Text,
                    ApellidoPaterno = textBoxApellidoPaterno.Text,
                    ApellidoMaterno = textBoxApellidoMaterno.Text,
                    Fotografía = textBoxRutaImagen.Text,
                };

                //Agregar el objeto a la BD
                contexto.Alumnoes.Add(alumno);
                contexto.SaveChanges();
                MessageBox.Show("Alumno agregado correctamente");
                LimpiarTextos();
                LlenarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.ToString());

            }

        }

        private void Examinar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openfile = new OpenFileDialog();
                openfile.Title = "Abrir Imagen";
                openfile.Filter = "Archivos.JPG (*.jpg, *.jpeg)| *.jpg; *.jpeg ";

                if (openfile.ShowDialog() == DialogResult.OK)
                {
                    string image = openfile.FileName;
                    textBoxRutaImagen.Text = image;
                    pictureBoxFotografia.Image = Image.FromFile(image);
                }
                else
                {
                    MessageBox.Show("No se seleccioo Imagen");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.ToString());
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxIdAlumno.Text != string.Empty)
                {
                    int clave = int.Parse(textBoxIdAlumno.Text);
                    contexto = new EscuelaDBEntities();

                    Alumno buscar = (from a in contexto.Alumnoes
                                     where a.Id == clave
                                     select a).SingleOrDefault();
                    if (buscar!=null)
                    {
                        textBoxNombre.Text = buscar.Nombre;
                        textBoxApellidoPaterno.Text = buscar.ApellidoPaterno;
                        textBoxApellidoMaterno.Text = buscar.ApellidoMaterno;
                        textBoxRutaImagen.Text = buscar.Fotografía;
                        pictureBoxFotografia.Image = Image.FromFile(buscar.Fotografía);
                    }
                    else
                    {
                        LimpiarTextos();
                        MessageBox.Show("No se encontro el registro");
                        
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error: " + ex.ToString());
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxIdAlumno.Text != string.Empty)
                {
                    int clave = int.Parse(textBoxIdAlumno.Text);

                    contexto = new EscuelaDBEntities();

                    Alumno eliminar = (from a in contexto.Alumnoes
                                       where a.Id == clave
                                       select a).SingleOrDefault();

                    if (eliminar != null)
                    {
                        //Preguntar si se va eliminar
                        contexto.Alumnoes.Remove(eliminar);
                        contexto.SaveChanges();
                        MessageBox.Show("Registro Eliminado");
                        LlenarGrid();

                    }
                    else
                    {
                        MessageBox.Show("No se encontro el registro");
                
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error: " + ex.ToString());
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxIdAlumno.Text != string.Empty)
                {
                    int clave = int.Parse(textBoxIdAlumno.Text);

                    contexto = new EscuelaDBEntities();

                    Alumno actualizar = (from a in contexto.Alumnoes
                                         where a.Id == clave
                                         select a).SingleOrDefault();
                    if (actualizar != null)
                    {
                        actualizar.Nombre = textBoxNombre.Text;
                        actualizar.ApellidoPaterno = textBoxApellidoPaterno.Text;
                        actualizar.ApellidoMaterno = textBoxApellidoMaterno.Text;
                        actualizar.Fotografía = textBoxRutaImagen.Text; 
               
                        contexto.SaveChanges();
                        MessageBox.Show("Registro Actualizado");
                        LimpiarTextos();
                        LlenarGrid();
                    }
                    else
                    {
                        MessageBox.Show("No se encontro el registro");
                 
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error: " + ex.ToString());
            }
        }
    }
}
