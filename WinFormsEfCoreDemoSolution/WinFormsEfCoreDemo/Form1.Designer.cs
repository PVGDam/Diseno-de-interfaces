namespace WinFormsEfCoreDemo
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRecargar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRecargar = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();

            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(12, 12);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(560, 250);

            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 280);
            this.lblNombre.Text = "Nombre:";

            this.txtNombre.Location = new System.Drawing.Point(70, 277);
            this.txtNombre.Size = new System.Drawing.Size(180, 23);

            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(270, 280);
            this.lblPrecio.Text = "Precio:";

            this.txtPrecio.Location = new System.Drawing.Point(320, 277);
            this.txtPrecio.Size = new System.Drawing.Size(100, 23);

            this.btnAgregar.Location = new System.Drawing.Point(12, 320);
            this.btnAgregar.Size = new System.Drawing.Size(80, 30);
            this.btnAgregar.Text = "Agregar";

            this.btnEditar.Location = new System.Drawing.Point(100, 320);
            this.btnEditar.Size = new System.Drawing.Size(80, 30);
            this.btnEditar.Text = "Editar";

            this.btnEliminar.Location = new System.Drawing.Point(190, 320);
            this.btnEliminar.Size = new System.Drawing.Size(80, 30);
            this.btnEliminar.Text = "Eliminar";

            this.btnRecargar.Location = new System.Drawing.Point(280, 320);
            this.btnRecargar.Size = new System.Drawing.Size(80, 30);
            this.btnRecargar.Text = "Recargar";

            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgvProductos);
            this.Text = "Gestión de Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
