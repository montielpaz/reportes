using BL.Containers;
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

namespace login
{
    public partial class formContainers : Form
    {
        ContainersBL _containers;
        CategoriasBL _categorias;
        TiposBL _tiposBL;

        public formContainers()
        {
            InitializeComponent();

            _containers = new ContainersBL();
            listaContainersBindingSource.DataSource = _containers.ObtenerContainers();

            _categorias = new CategoriasBL();
            listaCategoriasBindingSource.DataSource = _categorias.ObtenerCategorias();

            _tiposBL = new TiposBL();
            listaTiposBindingSource.DataSource = _tiposBL.ObtenerTipos();
        }

        //Guardar
        private void listaContainersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaContainersBindingSource.EndEdit();
            var container = (BL.Containers.Container)listaContainersBindingSource.Current;

            if (fotoPictureBox.Image != null)
            {
                container.Foto = Program.imageTobyteArray(fotoPictureBox.Image);
            }
            else
            {
                container.Foto = null;
            }


            var resultado = _containers.GuardarProducto(container);

            if (resultado.Exitoso == true)
            {
                listaContainersBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("container guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        //Agregar

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _containers.AgregarProducto();
            listaContainersBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;

            toolStripButtonCancelar.Visible = !valor;
        }

        //Eliminar

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
           
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }
            }
        }

        private void Eliminar(int id)
        {
            
            var resultado = _containers.EliminarProducto(id);

            if (resultado == true)
            {
                listaContainersBindingSource.ResetBindings(false);
            }

            else
            {
                MessageBox.Show("Ocurrio un error al eleminar el producto");
            }
        }

        //Cancelar

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            _containers.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
            
        }

        private void formContainers_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var container = (BL.Containers.Container)listaContainersBindingSource.Current;

            if (container != null)
            {
                openFileDialog1.ShowDialog();
                var archivo = openFileDialog1.FileName;

                if (archivo != "")
                {
                    var fileInfo = new FileInfo(archivo);
                    var fileStream = fileInfo.OpenRead();

                    fotoPictureBox.Image = Image.FromStream(fileStream);
                }
            }
            else
            {
                MessageBox.Show("Cree un container antes de asignarle una imagen");
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fotoPictureBox.Image = null;
        }

        private void categoriraIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
