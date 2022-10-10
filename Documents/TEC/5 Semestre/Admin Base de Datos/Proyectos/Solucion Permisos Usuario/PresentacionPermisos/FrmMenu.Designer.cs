
namespace PresentacionPermisos
{
    partial class FrmMenu
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
            this.tspMenu = new System.Windows.Forms.ToolStrip();
            this.optProductos = new System.Windows.Forms.ToolStripButton();
            this.optHerramientas = new System.Windows.Forms.ToolStripButton();
            this.optUsuarios = new System.Windows.Forms.ToolStripButton();
            this.tspMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tspMenu
            // 
            this.tspMenu.AutoSize = false;
            this.tspMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
            this.tspMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.tspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optProductos,
            this.optHerramientas,
            this.optUsuarios});
            this.tspMenu.Location = new System.Drawing.Point(0, 0);
            this.tspMenu.Name = "tspMenu";
            this.tspMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tspMenu.Size = new System.Drawing.Size(153, 532);
            this.tspMenu.TabIndex = 0;
            this.tspMenu.Text = "toolStrip1";
            // 
            // optProductos
            // 
            this.optProductos.AutoSize = false;
            this.optProductos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.optProductos.Image = global::PresentacionPermisos.Properties.Resources.Productos;
            this.optProductos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.optProductos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optProductos.Name = "optProductos";
            this.optProductos.Size = new System.Drawing.Size(100, 100);
            this.optProductos.Text = "Refacciones";
            this.optProductos.Click += new System.EventHandler(this.optProductos_Click);
            // 
            // optHerramientas
            // 
            this.optHerramientas.AutoSize = false;
            this.optHerramientas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.optHerramientas.Image = global::PresentacionPermisos.Properties.Resources.Herramienta;
            this.optHerramientas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.optHerramientas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optHerramientas.Name = "optHerramientas";
            this.optHerramientas.Size = new System.Drawing.Size(100, 100);
            this.optHerramientas.Text = "Taller";
            this.optHerramientas.Click += new System.EventHandler(this.optHerramientas_Click);
            // 
            // optUsuarios
            // 
            this.optUsuarios.AutoSize = false;
            this.optUsuarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.optUsuarios.Image = global::PresentacionPermisos.Properties.Resources.UsuariosM;
            this.optUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.optUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optUsuarios.Name = "optUsuarios";
            this.optUsuarios.Size = new System.Drawing.Size(100, 100);
            this.optUsuarios.Text = "Usuarios";
            this.optUsuarios.Click += new System.EventHandler(this.optUsuarios_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(859, 532);
            this.Controls.Add(this.tspMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agencia Automotriz";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tspMenu.ResumeLayout(false);
            this.tspMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspMenu;
        private System.Windows.Forms.ToolStripButton optProductos;
        private System.Windows.Forms.ToolStripButton optHerramientas;
        private System.Windows.Forms.ToolStripButton optUsuarios;
    }
}