
namespace Crud
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Nuevo = new System.Windows.Forms.Button();
            this.atras = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.producto,
            this.codigo,
            this.Existencia,
            this.Vencimiento,
            this.descripcion,
            this.categoria,
            this.Estado});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(64, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(652, 515);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Estado
            // 
            this.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Estado.HeaderText = "Estado(Activo/Inactivo)";
            this.Estado.Name = "Estado";
            this.Estado.Width = 144;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            // 
            // Vencimiento
            // 
            this.Vencimiento.HeaderText = "Vencimiento";
            this.Vencimiento.Name = "Vencimiento";
            // 
            // Existencia
            // 
            this.Existencia.HeaderText = "Existencia";
            this.Existencia.Name = "Existencia";
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            // 
            // producto
            // 
            this.producto.HeaderText = "Nombre del Producto";
            this.producto.Name = "producto";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.editar);
            this.panel1.Controls.Add(this.eliminar);
            this.panel1.Controls.Add(this.atras);
            this.panel1.Controls.Add(this.Nuevo);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 509);
            this.panel1.TabIndex = 0;
            // 
            // Nuevo
            // 
            this.Nuevo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("Nuevo.Image")));
            this.Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevo.ImageKey = "(none)";
            this.Nuevo.Location = new System.Drawing.Point(752, 172);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(114, 47);
            this.Nuevo.TabIndex = 1;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevo.UseVisualStyleBackColor = false;
            // 
            // atras
            // 
            this.atras.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.atras.Image = ((System.Drawing.Image)(resources.GetObject("atras.Image")));
            this.atras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.atras.Location = new System.Drawing.Point(752, 12);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(114, 44);
            this.atras.TabIndex = 2;
            this.atras.Text = "Atras";
            this.atras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.atras.UseVisualStyleBackColor = false;
            // 
            // eliminar
            // 
            this.eliminar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.eliminar.Image = ((System.Drawing.Image)(resources.GetObject("eliminar.Image")));
            this.eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminar.Location = new System.Drawing.Point(752, 362);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(114, 47);
            this.eliminar.TabIndex = 3;
            this.eliminar.Text = "Eliminar";
            this.eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.eliminar.UseVisualStyleBackColor = false;
            // 
            // editar
            // 
            this.editar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.editar.Image = ((System.Drawing.Image)(resources.GetObject("editar.Image")));
            this.editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editar.Location = new System.Drawing.Point(752, 266);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(114, 44);
            this.editar.TabIndex = 4;
            this.editar.Text = "Editar";
            this.editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editar.UseVisualStyleBackColor = false;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 509);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button atras;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.ImageList imageList2;
    }
}

