using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsEfCoreDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.MultiSelect = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            btnAgregar.Click += BtnAgregar_Click;
            btnEditar.Click += BtnEditar_Click;
            btnEliminar.Click += BtnEliminar_Click;
            btnRecargar.Click += (s, e) => CargarDatos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            using var db = new AppDbContext();
            var datos = db.Productos.OrderBy(p => p.Nombre)
                .Select(p => new { p.Id, p.Nombre, p.Precio, p.Creado }).ToList();
            dgvProductos.DataSource = datos;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Nombre obligatorio"); return;
            }
            if (!decimal.TryParse(txtPrecio.Text, out var precio) || precio < 0)
            {
                MessageBox.Show("Precio inválido"); return;
            }

            using var db = new AppDbContext();
            db.Productos.Add(new Producto { Nombre = txtNombre.Text.Trim(), Precio = precio });
            db.SaveChanges();

            txtNombre.Clear(); txtPrecio.Clear();
            CargarDatos();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un producto"); return;
            }

            var id = (int)dgvProductos.CurrentRow.Cells["Id"].Value;
            if (!decimal.TryParse(txtPrecio.Text, out var precio) || precio < 0)
            {
                MessageBox.Show("Precio inválido"); return;
            }

            using var db = new AppDbContext();
            var prod = db.Productos.FirstOrDefault(p => p.Id == id);
            if (prod is null) { MessageBox.Show("No encontrado"); return; }

            if (!string.IsNullOrWhiteSpace(txtNombre.Text))
                prod.Nombre = txtNombre.Text.Trim();
            prod.Precio = precio;

            db.SaveChanges();
            CargarDatos();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un producto"); return;
            }

            var id = (int)dgvProductos.CurrentRow.Cells["Id"].Value;
            if (MessageBox.Show("¿Eliminar el producto seleccionado?", "Confirmar",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            using var db = new AppDbContext();
            var prod = db.Productos.FirstOrDefault(p => p.Id == id);
            if (prod is null) { MessageBox.Show("No encontrado"); return; }

            db.Productos.Remove(prod);
            db.SaveChanges();
            CargarDatos();
        }
    }
}
