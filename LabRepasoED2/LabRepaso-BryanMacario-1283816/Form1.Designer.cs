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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Vacio");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Listas de Reproducción", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Titulo");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Tamaño");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Interprete");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Música", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5});
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
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.listViewCanciones = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCrearLista = new System.Windows.Forms.Button();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gBBiblioteca.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(6, 19);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "NodoLista1";
            treeNode1.Text = "Vacio";
            treeNode2.Name = "NodoListas";
            treeNode2.Text = "Listas de Reproducción";
            treeNode3.Name = "NodoTitulo";
            treeNode3.Text = "Titulo";
            treeNode4.Name = "NodoTamaño";
            treeNode4.Text = "Tamaño";
            treeNode5.Name = "NodoInterprete";
            treeNode5.Text = "Interprete";
            treeNode6.Name = "NodoMusica";
            treeNode6.Text = "Música";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(146, 294);
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
            this.menuStrip1.Size = new System.Drawing.Size(628, 24);
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
            this.tamañoToolStripMenuItem.Text = "Tamaño";
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
            this.gBBiblioteca.Controls.Add(this.treeView1);
            this.gBBiblioteca.Location = new System.Drawing.Point(13, 28);
            this.gBBiblioteca.Name = "gBBiblioteca";
            this.gBBiblioteca.Size = new System.Drawing.Size(158, 319);
            this.gBBiblioteca.TabIndex = 2;
            this.gBBiblioteca.TabStop = false;
            this.gBBiblioteca.Text = "Biblioteca";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbBuscar);
            this.panel1.Controls.Add(this.btnCrearLista);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.listViewCanciones);
            this.panel1.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel1.Location = new System.Drawing.Point(177, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 319);
            this.panel1.TabIndex = 3;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(3, 267);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(430, 46);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // listViewCanciones
            // 
            this.listViewCanciones.Location = new System.Drawing.Point(3, 42);
            this.listViewCanciones.Name = "listViewCanciones";
            this.listViewCanciones.Size = new System.Drawing.Size(433, 219);
            this.listViewCanciones.TabIndex = 1;
            this.listViewCanciones.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(313, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Agregar Música";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCrearLista
            // 
            this.btnCrearLista.Location = new System.Drawing.Point(124, 13);
            this.btnCrearLista.Name = "btnCrearLista";
            this.btnCrearLista.Size = new System.Drawing.Size(102, 24);
            this.btnCrearLista.TabIndex = 4;
            this.btnCrearLista.Text = "Crear Playlist";
            this.btnCrearLista.UseVisualStyleBackColor = true;
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.Location = new System.Drawing.Point(267, 18);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(40, 13);
            this.lbBuscar.TabIndex = 5;
            this.lbBuscar.Text = "Buscar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 359);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gBBiblioteca);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gBBiblioteca.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
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
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.Button btnCrearLista;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listViewCanciones;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

