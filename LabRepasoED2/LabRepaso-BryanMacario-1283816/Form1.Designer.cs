namespace LabRepaso_BryanMacario_1283816
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
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Vacio");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Listas de Reproducción", new System.Windows.Forms.TreeNode[] {
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Titulo");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Tamaño");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Interprete");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Música", new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode28,
            treeNode29});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenarPorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarMúsicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearListaDeReproduccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.títuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tamañoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interpreteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechaDeModificaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreDelArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDelSoftwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gBBiblioteca = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCrearLista = new System.Windows.Forms.Button();
            this.listViewCanciones = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnInterprete = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAlbum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDuracion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.gBBiblioteca.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.treeView1.Location = new System.Drawing.Point(6, 19);
            this.treeView1.Name = "treeView1";
            treeNode25.Name = "NodoLista1";
            treeNode25.Text = "Vacio";
            treeNode26.Name = "NodoListas";
            treeNode26.Text = "Listas de Reproducción";
            treeNode27.Name = "NodoTitulo";
            treeNode27.Text = "Titulo";
            treeNode28.Name = "NodoTamaño";
            treeNode28.Text = "Tamaño";
            treeNode29.Name = "NodoInterprete";
            treeNode29.Text = "Interprete";
            treeNode30.Name = "NodoMusica";
            treeNode30.Text = "Música";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode30});
            this.treeView1.Size = new System.Drawing.Size(146, 344);
            this.treeView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ordenarPorToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(741, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarMúsicaToolStripMenuItem,
            this.crearListaDeReproduccionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // ordenarPorToolStripMenuItem
            // 
            this.ordenarPorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.títuloToolStripMenuItem,
            this.tamañoToolStripMenuItem,
            this.interpreteToolStripMenuItem,
            this.fechaDeModificaciónToolStripMenuItem,
            this.nombreDelArchivoToolStripMenuItem});
            this.ordenarPorToolStripMenuItem.Name = "ordenarPorToolStripMenuItem";
            this.ordenarPorToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.ordenarPorToolStripMenuItem.Text = "Ordenar Por";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDelSoftwareToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // agregarMúsicaToolStripMenuItem
            // 
            this.agregarMúsicaToolStripMenuItem.Name = "agregarMúsicaToolStripMenuItem";
            this.agregarMúsicaToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.agregarMúsicaToolStripMenuItem.Text = "Agregar Música";
            // 
            // crearListaDeReproduccionToolStripMenuItem
            // 
            this.crearListaDeReproduccionToolStripMenuItem.Name = "crearListaDeReproduccionToolStripMenuItem";
            this.crearListaDeReproduccionToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.crearListaDeReproduccionToolStripMenuItem.Text = "Crear Lista de Reproduccion";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // títuloToolStripMenuItem
            // 
            this.títuloToolStripMenuItem.Name = "títuloToolStripMenuItem";
            this.títuloToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.títuloToolStripMenuItem.Text = "Título";
            // 
            // tamañoToolStripMenuItem
            // 
            this.tamañoToolStripMenuItem.Name = "tamañoToolStripMenuItem";
            this.tamañoToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.tamañoToolStripMenuItem.Text = "Duración";
            // 
            // interpreteToolStripMenuItem
            // 
            this.interpreteToolStripMenuItem.Name = "interpreteToolStripMenuItem";
            this.interpreteToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.interpreteToolStripMenuItem.Text = "Interprete";
            // 
            // fechaDeModificaciónToolStripMenuItem
            // 
            this.fechaDeModificaciónToolStripMenuItem.Name = "fechaDeModificaciónToolStripMenuItem";
            this.fechaDeModificaciónToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.fechaDeModificaciónToolStripMenuItem.Text = "Fecha de Modificación";
            // 
            // nombreDelArchivoToolStripMenuItem
            // 
            this.nombreDelArchivoToolStripMenuItem.Name = "nombreDelArchivoToolStripMenuItem";
            this.nombreDelArchivoToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.nombreDelArchivoToolStripMenuItem.Text = "Nombre del Archivo";
            // 
            // acercaDelSoftwareToolStripMenuItem
            // 
            this.acercaDelSoftwareToolStripMenuItem.Name = "acercaDelSoftwareToolStripMenuItem";
            this.acercaDelSoftwareToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.acercaDelSoftwareToolStripMenuItem.Text = "Acerca del Software";
            // 
            // gBBiblioteca
            // 
            this.gBBiblioteca.BackColor = System.Drawing.SystemColors.Menu;
            this.gBBiblioteca.Controls.Add(this.treeView1);
            this.gBBiblioteca.Location = new System.Drawing.Point(13, 28);
            this.gBBiblioteca.Name = "gBBiblioteca";
            this.gBBiblioteca.Size = new System.Drawing.Size(158, 369);
            this.gBBiblioteca.TabIndex = 2;
            this.gBBiblioteca.TabStop = false;
            this.gBBiblioteca.Text = "Biblioteca";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listViewCanciones);
            this.panel1.Controls.Add(this.btnCrearLista);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.WMP);
            this.panel1.Location = new System.Drawing.Point(177, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 369);
            this.panel1.TabIndex = 3;
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(4, 317);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(545, 46);
            this.WMP.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(367, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 21);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Buscar";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(29, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Agregar Música";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCrearLista
            // 
            this.btnCrearLista.Location = new System.Drawing.Point(168, 13);
            this.btnCrearLista.Name = "btnCrearLista";
            this.btnCrearLista.Size = new System.Drawing.Size(102, 24);
            this.btnCrearLista.TabIndex = 4;
            this.btnCrearLista.Text = "Crear Playlist";
            this.btnCrearLista.UseVisualStyleBackColor = true;
            // 
            // listViewCanciones
            // 
            this.listViewCanciones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnInterprete,
            this.columnAlbum,
            this.columnDuracion});
            this.listViewCanciones.Location = new System.Drawing.Point(4, 43);
            this.listViewCanciones.Name = "listViewCanciones";
            this.listViewCanciones.Size = new System.Drawing.Size(545, 268);
            this.listViewCanciones.TabIndex = 5;
            this.listViewCanciones.UseCompatibleStateImageBehavior = false;
            this.listViewCanciones.View = System.Windows.Forms.View.Details;
            this.listViewCanciones.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewCanciones_MouseDoubleClick);
            // 
            // columnName
            // 
            this.columnName.Text = "Nombre";
            this.columnName.Width = 259;
            // 
            // columnInterprete
            // 
            this.columnInterprete.Text = "Interprete";
            this.columnInterprete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnInterprete.Width = 118;
            // 
            // columnAlbum
            // 
            this.columnAlbum.Text = "Albúm";
            this.columnAlbum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnAlbum.Width = 88;
            // 
            // columnDuracion
            // 
            this.columnDuracion.Text = "Duración";
            this.columnDuracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnDuracion.Width = 75;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(741, 409);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gBBiblioteca);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gBBiblioteca.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarMúsicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearListaDeReproduccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenarPorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem títuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tamañoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interpreteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fechaDeModificaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreDelArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDelSoftwareToolStripMenuItem;
        private System.Windows.Forms.GroupBox gBBiblioteca;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCrearLista;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textBox1;
        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.ListView listViewCanciones;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnInterprete;
        private System.Windows.Forms.ColumnHeader columnAlbum;
        private System.Windows.Forms.ColumnHeader columnDuracion;
    }
}

