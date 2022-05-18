
namespace RepasosBD3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.nuevoAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retirarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.nuevaNotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retirarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promedioDeAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadDeNotasPorAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnosToolStripMenuItem,
            this.notasToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.nuevoAlumnoToolStripMenuItem,
            this.retirarToolStripMenuItem,
            this.actualizarToolStripMenuItem});
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultaToolStripMenuItem.Text = "Consulta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // nuevoAlumnoToolStripMenuItem
            // 
            this.nuevoAlumnoToolStripMenuItem.Name = "nuevoAlumnoToolStripMenuItem";
            this.nuevoAlumnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoAlumnoToolStripMenuItem.Text = "Nuevo Alumno";
            this.nuevoAlumnoToolStripMenuItem.Click += new System.EventHandler(this.nuevoAlumnoToolStripMenuItem_Click);
            // 
            // retirarToolStripMenuItem
            // 
            this.retirarToolStripMenuItem.Name = "retirarToolStripMenuItem";
            this.retirarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.retirarToolStripMenuItem.Text = "Retirar";
            this.retirarToolStripMenuItem.Click += new System.EventHandler(this.retirarToolStripMenuItem_Click);
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.nuevaNotaToolStripMenuItem,
            this.retirarToolStripMenuItem1,
            this.actualizarToolStripMenuItem1});
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.notasToolStripMenuItem.Text = "Notas";
            // 
            // consultaToolStripMenuItem1
            // 
            this.consultaToolStripMenuItem1.Name = "consultaToolStripMenuItem1";
            this.consultaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.consultaToolStripMenuItem1.Text = "Consulta";
            this.consultaToolStripMenuItem1.Click += new System.EventHandler(this.consultaToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // nuevaNotaToolStripMenuItem
            // 
            this.nuevaNotaToolStripMenuItem.Name = "nuevaNotaToolStripMenuItem";
            this.nuevaNotaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevaNotaToolStripMenuItem.Text = "Nueva Nota";
            this.nuevaNotaToolStripMenuItem.Click += new System.EventHandler(this.nuevaNotaToolStripMenuItem_Click);
            // 
            // retirarToolStripMenuItem1
            // 
            this.retirarToolStripMenuItem1.Name = "retirarToolStripMenuItem1";
            this.retirarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.retirarToolStripMenuItem1.Text = "Retirar";
            this.retirarToolStripMenuItem1.Click += new System.EventHandler(this.retirarToolStripMenuItem1_Click);
            // 
            // actualizarToolStripMenuItem1
            // 
            this.actualizarToolStripMenuItem1.Name = "actualizarToolStripMenuItem1";
            this.actualizarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.actualizarToolStripMenuItem1.Text = "Actualizar";
            this.actualizarToolStripMenuItem1.Click += new System.EventHandler(this.actualizarToolStripMenuItem1_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.promedioDeAlumnosToolStripMenuItem,
            this.cantidadDeNotasPorAlumnoToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // promedioDeAlumnosToolStripMenuItem
            // 
            this.promedioDeAlumnosToolStripMenuItem.Name = "promedioDeAlumnosToolStripMenuItem";
            this.promedioDeAlumnosToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.promedioDeAlumnosToolStripMenuItem.Text = "Promedio de Alumnos";
            this.promedioDeAlumnosToolStripMenuItem.Click += new System.EventHandler(this.promedioDeAlumnosToolStripMenuItem_Click);
            // 
            // cantidadDeNotasPorAlumnoToolStripMenuItem
            // 
            this.cantidadDeNotasPorAlumnoToolStripMenuItem.Name = "cantidadDeNotasPorAlumnoToolStripMenuItem";
            this.cantidadDeNotasPorAlumnoToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.cantidadDeNotasPorAlumnoToolStripMenuItem.Text = "Cantidad de notas por alumno";
            this.cantidadDeNotasPorAlumnoToolStripMenuItem.Click += new System.EventHandler(this.cantidadDeNotasPorAlumnoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RepasosBD3.Properties.Resources.head_bg07;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Notas de Alumno";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nuevoAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retirarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem nuevaNotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retirarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promedioDeAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantidadDeNotasPorAlumnoToolStripMenuItem;
    }
}

