using ProyectoAplicadoPC.BLL;
using ProyectoAplicadoPC.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAplicadoPC.UI.Registros
{
    public partial class rUsuarios : Form
    {
        public rUsuarios()
        {
            InitializeComponent();
        }



        private void Limpiar()
        {
            SuperErrorProvider.Clear();
            UsuarioId_numericUpDown.Value = 0;
            Clave_textBox.Text = string.Empty;
            Confirmar_textBox.Text = string.Empty;
            Usuario_textBox.Text = string.Empty;
            FechaIngreso_dateTimePicker.Value = DateTime.Now;
        }

        private string ElegirNivel()
        {
            string nivel = string.Empty;
            if (Administrador_radioButton.Checked)
                nivel = "Administrador";

            if (Cajero_radioButton.Checked)
                nivel = "Cajero";

            return nivel;
        }

        private Usuarios LlenaClase()
        {
            Usuarios usuarios = new Usuarios();
            usuarios.UsuarioId = Convert.ToInt32(UsuarioId_numericUpDown.Value);
            usuarios.Clave = Clave_textBox.Text;
            usuarios.Usuario = Usuario_textBox.Text;
            usuarios.Permiso = ElegirNivel();
            usuarios.Fecha = FechaIngreso_dateTimePicker.Value.ToString("dd/MM/yyyy");
            
            return usuarios;

        }

        private void LlenarRadioButton(Usuarios usuario)
        {
            if (usuario.Permiso == "Administrador")
                Administrador_radioButton.Checked = true;

            if (usuario.Permiso == "Contador")
                Cajero_radioButton.Checked = true;

        }

        private void LlenaCampo(Usuarios usuarios)
        {
            UsuarioId_numericUpDown.Value = usuarios.UsuarioId;
            Usuario_textBox.Text = usuarios.Usuario;
            Clave_textBox.Text = usuarios.Clave;
            FechaIngreso_dateTimePicker.Value = DateTime.ParseExact(usuarios.Fecha, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            LlenarRadioButton(usuarios);
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Usuarios usuarios = new Usuarios();
            RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();
            int.TryParse(UsuarioId_numericUpDown.Text, out int Id);
            usuarios = db.Buscar(Id);
            return usuarios != null;
        }

        private bool ValidarR()
        {
            bool paso = true;
            { 
           
                if (string.IsNullOrWhiteSpace(Clave_textBox.Text))
                {
                    SuperErrorProvider.SetError(Clave_textBox, "no se puede dejar vacio");
                    Clave_textBox.Focus();
                    paso = false;
                }
                if (string.IsNullOrWhiteSpace(Confirmar_textBox.Text))
                {
                    SuperErrorProvider.SetError(Confirmar_textBox, "no se puede dejar vacio");
                    Confirmar_textBox.Focus();
                    paso = false;
                }
                if (string.IsNullOrWhiteSpace(UsuarioId_numericUpDown.Text))
                {
                    SuperErrorProvider.SetError(UsuarioId_numericUpDown, "no se puede dejar vacio");
                    UsuarioId_numericUpDown.Focus();
                    paso = false;
                }

                //mYerrorprovier 
                //en la ventana un error y ponerle ese nombre

            }
            return paso;
        }
        public bool Validar(int error)
        {
            bool paso = false;

            if (error == 1 && UsuarioId_numericUpDown.Value == 0)
            {
                SuperErrorProvider.SetError(UsuarioId_numericUpDown, "Llenar ID");
                paso = true;
            }
         
            if (error == 3 && string.IsNullOrEmpty(Usuario_textBox.Text))
            {
                SuperErrorProvider.SetError(Usuario_textBox, "Favor LLenar");
                paso = true;
            }

            if (error == 2 && string.IsNullOrEmpty(Clave_textBox.Text))
            {
                SuperErrorProvider.SetError(Clave_textBox, "Favor LLenar");
                paso = true;
            }

         




            /*  if (error == 5 && this.Detalles.Count == 0)
              {
                  MyErrorProvider.SetError(dataGridView1, "debe agregar algun precio");
                  PrecioTexBox.Focus();
                  paso = true;
              }*/


            return paso;
        }


        private void Nuevo_button_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardar_button_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();

            bool paso = false;
            if (!ValidarR())
                return;

            usuario = LlenaClase();



            //Determinar si es guardar o modificar
            if (UsuarioId_numericUpDown.Value == 0)
                paso = db.Guardar(usuario);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("no se puede modificar", "exixte un fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = db.Modificar(usuario);
            }

            //infprmar el resultado
            if (paso)
            {
                MessageBox.Show("Guardado", "exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("Nose pudo guardar", "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Buscar_button_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            SuperErrorProvider.Clear();
            if (Validar(1))
            {
                MessageBox.Show("El TipoID esta vacio", "Llene Campo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int.TryParse(UsuarioId_numericUpDown.Text, out int ID);
            Usuarios usuario = repositorio.Buscar(ID);
            if (usuario != null)
            {
                MessageBox.Show("Usuario Encotnrado");
                LlenaCampo(usuario);
            }
            else
                MessageBox.Show("Usuario no Encontrado!!", ".", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Eliminar_button_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();
            SuperErrorProvider.Clear();
            if (Validar(1))
            {
                MessageBox.Show("El TipoID esta vacio", "Llene Campo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int id;
            int.TryParse(UsuarioId_numericUpDown.Text, out id);
            Limpiar();
            if (db.Eliminar(id))
                MessageBox.Show("eliminado");
            else
                SuperErrorProvider.SetError(UsuarioId_numericUpDown, "nos e puede eliminar un usuario que no exixte");
        }

        private void Administrador_radioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            SuperErrorProvider.Clear();
            if (Validar(1))
            {
                MessageBox.Show("El TipoID esta vacio", "Llene Campo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int.TryParse(UsuarioId_numericUpDown.Text, out int ID);
            Usuarios usuario = repositorio.Buscar(ID);
            if (usuario != null)
            {
                MessageBox.Show("Usuario Encotnrado");
                LlenaCampo(usuario);
            }
            else
                MessageBox.Show("Usuario no Encontrado!!", ".", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();

            bool paso = false;
            if (!ValidarR())
                return;

            usuario = LlenaClase();



            //Determinar si es guardar o modificar
            if (UsuarioId_numericUpDown.Value == 0)
                paso = db.Guardar(usuario);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("no se puede modificar", "exixte un fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = db.Modificar(usuario);
            }

            //infprmar el resultado
            if (paso)
            {
                MessageBox.Show("Guardado", "exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("Nose pudo guardar", "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
