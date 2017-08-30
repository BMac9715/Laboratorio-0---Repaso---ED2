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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Toda la música");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Listas de Reproducción", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Ascendente");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Descendente");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Nombre", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Ascendente");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Descendente");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Duración", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Interprete");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Albúm");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Música", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode8,
            treeNode9,
            treeNode10});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarMúsicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearListaDeReproduccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenarPorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.títuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ascendenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descendenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tamañoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ascendenteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.descendenteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.interpreteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albúmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDelSoftwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gBBiblioteca = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gBCrearLista = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.listBoxMostrar = new System.Windows.Forms.ListBox();
            this.lblNombreLista = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.listViewCanciones = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnInterprete = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAlbum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDuracion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCrearLista = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gBBiblioteca.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gBCrearLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeView1.Location = new System.Drawing.Point(6, 19);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "NodoTodo";
            treeNode1.Text = "Toda la música";
            treeNode2.Name = "NodoListas";
            treeNode2.Text = "Listas de Reproducción";
            treeNode3.Name = "NodoTituloA";
            treeNode3.Text = "Ascendente";
            treeNode4.Name = "NodoTituloD";
            treeNode4.Text = "Descendente";
            treeNode5.Name = "NodoTitulo";
            treeNode5.Text = "Nombre";
            treeNode6.Name = "NodoTamañoA";
            treeNode6.Text = "Ascendente";
            treeNode7.Name = "NodoTamañoD";
            treeNode7.Text = "Descendente";
            treeNode8.Name = "NodoTamaño";
            treeNode8.Text = "Duración";
            treeNode9.Name = "NodoInterprete";
            treeNode9.Text = "Interprete";
            treeNode10.Name = "NodoAlbum";
            treeNode10.Text = "Albúm";
            treeNode11.Name = "NodoMusica";
            treeNode11.Text = "Música";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode11});
            this.treeView1.Size = new System.Drawing.Size(146, 344);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ordenarPorToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(816, 24);
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
            // ordenarPorToolStripMenuItem
            // 
            this.ordenarPorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.títuloToolStripMenuItem,
            this.tamañoToolStripMenuItem,
            this.interpreteToolStripMenuItem,
            this.albúmToolStripMenuItem});
            this.ordenarPorToolStripMenuItem.Name = "ordenarPorToolStripMenuItem";
            this.ordenarPorToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.ordenarPorToolStripMenuItem.Text = "Ordenar Por";
            // 
            // títuloToolStripMenuItem
            // 
            this.títuloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendenteToolStripMenuItem,
            this.descendenteToolStripMenuItem});
            this.títuloToolStripMenuItem.Name = "títuloToolStripMenuItem";
            this.títuloToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.títuloToolStripMenuItem.Text = "Nombre";
            // 
            // ascendenteToolStripMenuItem
            // 
            this.ascendenteToolStripMenuItem.Name = "ascendenteToolStripMenuItem";
            this.ascendenteToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.ascendenteToolStripMenuItem.Text = "Ascendente";
            // 
            // descendenteToolStripMenuItem
            // 
            this.descendenteToolStripMenuItem.Name = "descendenteToolStripMenuItem";
            this.descendenteToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.descendenteToolStripMenuItem.Text = "Descendente";
            // 
            // tamañoToolStripMenuItem
            // 
            this.tamañoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendenteToolStripMenuItem1,
            this.descendenteToolStripMenuItem1});
            this.tamañoToolStripMenuItem.Name = "tamañoToolStripMenuItem";
            this.tamañoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tamañoToolStripMenuItem.Text = "Duración";
            // 
            // ascendenteToolStripMenuItem1
            // 
            this.ascendenteToolStripMenuItem1.Name = "ascendenteToolStripMenuItem1";
            this.ascendenteToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.ascendenteToolStripMenuItem1.Text = "Ascendente";
            // 
            // descendenteToolStripMenuItem1
            // 
            this.descendenteToolStripMenuItem1.Name = "descendenteToolStripMenuItem1";
            this.descendenteToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.descendenteToolStripMenuItem1.Text = "Descendente";
            // 
            // interpreteToolStripMenuItem
            // 
            this.interpreteToolStripMenuItem.Name = "interpreteToolStripMenuItem";
            this.interpreteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.interpreteToolStripMenuItem.Text = "Interprete";
            // 
            // albúmToolStripMenuItem
            // 
            this.albúmToolStripMenuItem.Name = "albúmToolStripMenuItem";
            this.albúmToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.albúmToolStripMenuItem.Text = "Albúm";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDelSoftwareToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
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
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.gBCrearLista);
            this.panel1.Controls.Add(this.listViewCanciones);
            this.panel1.Controls.Add(this.btnCrearLista);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.WMP);
            this.panel1.Location = new System.Drawing.Point(177, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 369);
            this.panel1.TabIndex = 3;
            // 
            // gBCrearLista
            // 
            this.gBCrearLista.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.gBCrearLista.Controls.Add(this.btnCerrar);
            this.gBCrearLista.Controls.Add(this.btnGuardar);
            this.gBCrearLista.Controls.Add(this.btnQuitar);
            this.gBCrearLista.Controls.Add(this.btnAgregar);
            this.gBCrearLista.Controls.Add(this.listBoxMostrar);
            this.gBCrearLista.Controls.Add(this.lblNombreLista);
            this.gBCrearLista.Controls.Add(this.txtNombre);
            this.gBCrearLista.Enabled = false;
            this.gBCrearLista.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gBCrearLista.Location = new System.Drawing.Point(453, 14);
            this.gBCrearLista.Name = "gBCrearLista";
            this.gBCrearLista.Size = new System.Drawing.Size(171, 297);
            this.gBCrearLista.TabIndex = 6;
            this.gBCrearLista.TabStop = false;
            this.gBCrearLista.Visible = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCerrar.Location = new System.Drawing.Point(153, -2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 21);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Location = new System.Drawing.Point(33, 265);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(103, 26);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnQuitar.Location = new System.Drawing.Point(91, 232);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(62, 27);
            this.btnQuitar.TabIndex = 4;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.Location = new System.Drawing.Point(18, 232);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(62, 27);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // listBoxMostrar
            // 
            this.listBoxMostrar.FormattingEnabled = true;
            this.listBoxMostrar.Location = new System.Drawing.Point(6, 71);
            this.listBoxMostrar.Name = "listBoxMostrar";
            this.listBoxMostrar.Size = new System.Drawing.Size(159, 160);
            this.listBoxMostrar.TabIndex = 2;
            // 
            // lblNombreLista
            // 
            this.lblNombreLista.AutoSize = true;
            this.lblNombreLista.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombreLista.Location = new System.Drawing.Point(15, 22);
            this.lblNombreLista.Name = "lblNombreLista";
            this.lblNombreLista.Size = new System.Drawing.Size(138, 13);
            this.lblNombreLista.TabIndex = 1;
            this.lblNombreLista.Text = "Ingrese el nombre de la lista";
            this.lblNombreLista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(6, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(159, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "NuevaLista";
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNombre_MouseClick);
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
            this.listViewCanciones.Size = new System.Drawing.Size(623, 268);
            this.listViewCanciones.TabIndex = 5;
            this.listViewCanciones.UseCompatibleStateImageBehavior = false;
            this.listViewCanciones.View = System.Windows.Forms.View.Details;
            this.listViewCanciones.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewCanciones_MouseDoubleClick);
            // 
            // columnName
            // 
            this.columnName.Text = "Nombre";
            this.columnName.Width = 225;
            // 
            // columnInterprete
            // 
            this.columnInterprete.Text = "Interprete";
            this.columnInterprete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnInterprete.Width = 149;
            // 
            // columnAlbum
            // 
            this.columnAlbum.Text = "Albúm";
            this.columnAlbum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnAlbum.Width = 127;
            // 
            // columnDuracion
            // 
            this.columnDuracion.Text = "Duración";
            this.columnDuracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnDuracion.Width = 116;
            // 
            // btnCrearLista
            // 
            this.btnCrearLista.Location = new System.Drawing.Point(107, 11);
            this.btnCrearLista.Name = "btnCrearLista";
            this.btnCrearLista.Size = new System.Drawing.Size(84, 24);
            this.btnCrearLista.TabIndex = 4;
            this.btnCrearLista.Text = "Crear Playlist";
            this.btnCrearLista.UseVisualStyleBackColor = true;
            this.btnCrearLista.Click += new System.EventHandler(this.btnCrearLista_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(4, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Agregar Música";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(266, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 21);
            this.textBox1.TabIndex = 2;
            this.textBox1.Tag = "";
            this.textBox1.Text = "Buscar";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(4, 317);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(620, 46);
            this.WMP.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(197, 11);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(63, 25);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(816, 404);
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
            this.gBCrearLista.ResumeLayout(false);
            this.gBCrearLista.PerformLayout();
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
        private System.Windows.Forms.GroupBox gBCrearLista;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox listBoxMostrar;
        private System.Windows.Forms.Label lblNombreLista;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ToolStripMenuItem ascendenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descendenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ascendenteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem descendenteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem albúmToolStripMenuItem;
        private System.Windows.Forms.Button btnEliminar;
    }
}

