﻿namespace LabRepaso_BryanMacario_1283816
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Toda la música");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Listas de Reproducción", new System.Windows.Forms.TreeNode[] {
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Ascendente");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Descendente");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Nombre", new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode26});
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Ascendente");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Descendente");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Duración", new System.Windows.Forms.TreeNode[] {
            treeNode28,
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Interprete");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Albúm");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Música", new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode30,
            treeNode31,
            treeNode32});
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
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.macTrackStatus = new XComponent.SliderBar.MACTrackBar();
            this.macTrackVolumen = new XComponent.SliderBar.MACTrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelCancion = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.btnVolumen = new System.Windows.Forms.PictureBox();
            this.btnPause = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.gBBiblioteca.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gBCrearLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeView1.Location = new System.Drawing.Point(6, 19);
            this.treeView1.Name = "treeView1";
            treeNode23.Name = "NodoTodo";
            treeNode23.Text = "Toda la música";
            treeNode24.Name = "NodoListas";
            treeNode24.Text = "Listas de Reproducción";
            treeNode25.Name = "NodoTituloA";
            treeNode25.Text = "Ascendente";
            treeNode26.Name = "NodoTituloD";
            treeNode26.Text = "Descendente";
            treeNode27.Name = "NodoTitulo";
            treeNode27.Text = "Nombre";
            treeNode28.Name = "NodoTamañoA";
            treeNode28.Text = "Ascendente";
            treeNode29.Name = "NodoTamañoD";
            treeNode29.Text = "Descendente";
            treeNode30.Name = "NodoTamaño";
            treeNode30.Text = "Duración";
            treeNode31.Name = "NodoInterprete";
            treeNode31.Text = "Interprete";
            treeNode32.Name = "NodoAlbum";
            treeNode32.Text = "Albúm";
            treeNode33.Name = "NodoMusica";
            treeNode33.Text = "Música";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode24,
            treeNode33});
            this.treeView1.Size = new System.Drawing.Size(146, 292);
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
            this.agregarMúsicaToolStripMenuItem.Click += new System.EventHandler(this.agregarMúsicaToolStripMenuItem_Click);
            // 
            // crearListaDeReproduccionToolStripMenuItem
            // 
            this.crearListaDeReproduccionToolStripMenuItem.Name = "crearListaDeReproduccionToolStripMenuItem";
            this.crearListaDeReproduccionToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.crearListaDeReproduccionToolStripMenuItem.Text = "Crear Lista de Reproduccion";
            this.crearListaDeReproduccionToolStripMenuItem.Click += new System.EventHandler(this.crearListaDeReproduccionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
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
            this.ascendenteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ascendenteToolStripMenuItem.Text = "Ascendente";
            this.ascendenteToolStripMenuItem.Click += new System.EventHandler(this.ascendenteToolStripMenuItem_Click);
            // 
            // descendenteToolStripMenuItem
            // 
            this.descendenteToolStripMenuItem.Name = "descendenteToolStripMenuItem";
            this.descendenteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.descendenteToolStripMenuItem.Text = "Descendente";
            this.descendenteToolStripMenuItem.Click += new System.EventHandler(this.descendenteToolStripMenuItem_Click);
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
            this.ascendenteToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.ascendenteToolStripMenuItem1.Text = "Ascendente";
            this.ascendenteToolStripMenuItem1.Click += new System.EventHandler(this.ascendenteToolStripMenuItem1_Click);
            // 
            // descendenteToolStripMenuItem1
            // 
            this.descendenteToolStripMenuItem1.Name = "descendenteToolStripMenuItem1";
            this.descendenteToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.descendenteToolStripMenuItem1.Text = "Descendente";
            this.descendenteToolStripMenuItem1.Click += new System.EventHandler(this.descendenteToolStripMenuItem1_Click);
            // 
            // interpreteToolStripMenuItem
            // 
            this.interpreteToolStripMenuItem.Name = "interpreteToolStripMenuItem";
            this.interpreteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.interpreteToolStripMenuItem.Text = "Interprete";
            this.interpreteToolStripMenuItem.Click += new System.EventHandler(this.interpreteToolStripMenuItem_Click);
            // 
            // albúmToolStripMenuItem
            // 
            this.albúmToolStripMenuItem.Name = "albúmToolStripMenuItem";
            this.albúmToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.albúmToolStripMenuItem.Text = "Albúm";
            this.albúmToolStripMenuItem.Click += new System.EventHandler(this.albúmToolStripMenuItem_Click);
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
            this.acercaDelSoftwareToolStripMenuItem.Click += new System.EventHandler(this.acercaDelSoftwareToolStripMenuItem_Click);
            // 
            // gBBiblioteca
            // 
            this.gBBiblioteca.BackColor = System.Drawing.SystemColors.Menu;
            this.gBBiblioteca.Controls.Add(this.treeView1);
            this.gBBiblioteca.Location = new System.Drawing.Point(13, 28);
            this.gBBiblioteca.Name = "gBBiblioteca";
            this.gBBiblioteca.Size = new System.Drawing.Size(158, 329);
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
            this.panel1.Controls.Add(this.txtBusqueda);
            this.panel1.Location = new System.Drawing.Point(177, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 329);
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
            this.gBCrearLista.Size = new System.Drawing.Size(171, 312);
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
            this.listViewCanciones.Size = new System.Drawing.Size(623, 283);
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
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.ForeColor = System.Drawing.Color.DimGray;
            this.txtBusqueda.Location = new System.Drawing.Point(266, 14);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(181, 21);
            this.txtBusqueda.TabIndex = 2;
            this.txtBusqueda.Tag = "";
            this.txtBusqueda.Text = "Buscar";
            this.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBusqueda.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBusqueda_MouseClick);
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda_KeyPress);
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(592, 450);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(118, 46);
            this.WMP.TabIndex = 0;
            this.WMP.Visible = false;
            this.WMP.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.WMP_PlayStateChange);
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
            // macTrackStatus
            // 
            this.macTrackStatus.BackColor = System.Drawing.Color.Transparent;
            this.macTrackStatus.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.macTrackStatus.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macTrackStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.macTrackStatus.IndentHeight = 6;
            this.macTrackStatus.Location = new System.Drawing.Point(50, 47);
            this.macTrackStatus.Maximum = 100;
            this.macTrackStatus.Minimum = 0;
            this.macTrackStatus.Name = "macTrackStatus";
            this.macTrackStatus.Size = new System.Drawing.Size(693, 25);
            this.macTrackStatus.TabIndex = 8;
            this.macTrackStatus.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackStatus.TickColor = System.Drawing.Color.Red;
            this.macTrackStatus.TickHeight = 4;
            this.macTrackStatus.TickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackStatus.TrackerColor = System.Drawing.Color.Red;
            this.macTrackStatus.TrackerSize = new System.Drawing.Size(13, 13);
            this.macTrackStatus.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.macTrackStatus.TrackLineHeight = 3;
            this.macTrackStatus.TrackLineSelectedColor = System.Drawing.Color.Red;
            this.macTrackStatus.Value = 0;
            // 
            // macTrackVolumen
            // 
            this.macTrackVolumen.BackColor = System.Drawing.Color.Transparent;
            this.macTrackVolumen.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.macTrackVolumen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.macTrackVolumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macTrackVolumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.macTrackVolumen.IndentHeight = 6;
            this.macTrackVolumen.Location = new System.Drawing.Point(650, 13);
            this.macTrackVolumen.Maximum = 100;
            this.macTrackVolumen.Minimum = 0;
            this.macTrackVolumen.Name = "macTrackVolumen";
            this.macTrackVolumen.Size = new System.Drawing.Size(93, 24);
            this.macTrackVolumen.TabIndex = 9;
            this.macTrackVolumen.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackVolumen.TickColor = System.Drawing.Color.Red;
            this.macTrackVolumen.TickHeight = 4;
            this.macTrackVolumen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackVolumen.TrackerColor = System.Drawing.Color.Red;
            this.macTrackVolumen.TrackerSize = new System.Drawing.Size(10, 12);
            this.macTrackVolumen.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.macTrackVolumen.TrackLineHeight = 3;
            this.macTrackVolumen.TrackLineSelectedColor = System.Drawing.Color.Red;
            this.macTrackVolumen.Value = 0;
            this.macTrackVolumen.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.macTrackVolumen_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.btnPause);
            this.groupBox1.Controls.Add(this.labelCancion);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.macTrackVolumen);
            this.groupBox1.Controls.Add(this.btnPlay);
            this.groupBox1.Controls.Add(this.btnVolumen);
            this.groupBox1.Controls.Add(this.macTrackStatus);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(13, 363);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(791, 72);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelCancion
            // 
            this.labelCancion.AutoSize = true;
            this.labelCancion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCancion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCancion.Location = new System.Drawing.Point(28, 24);
            this.labelCancion.Name = "labelCancion";
            this.labelCancion.Size = new System.Drawing.Size(0, 17);
            this.labelCancion.TabIndex = 14;
            // 
            // btnStop
            // 
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Image = global::LabRepaso_BryanMacario_1283816.Properties.Resources.detener;
            this.btnStop.Location = new System.Drawing.Point(486, 7);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(46, 44);
            this.btnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStop.TabIndex = 12;
            this.btnStop.TabStop = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Image = global::LabRepaso_BryanMacario_1283816.Properties.Resources.boton_de_reproduccion;
            this.btnPlay.Location = new System.Drawing.Point(421, 7);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(48, 44);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPlay.TabIndex = 10;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnVolumen
            // 
            this.btnVolumen.Image = global::LabRepaso_BryanMacario_1283816.Properties.Resources.altavoz;
            this.btnVolumen.Location = new System.Drawing.Point(611, 13);
            this.btnVolumen.Name = "btnVolumen";
            this.btnVolumen.Size = new System.Drawing.Size(33, 28);
            this.btnVolumen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVolumen.TabIndex = 13;
            this.btnVolumen.TabStop = false;
            // 
            // btnPause
            // 
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.Image = global::LabRepaso_BryanMacario_1283816.Properties.Resources.boton_redondo_de_pausa;
            this.btnPause.Location = new System.Drawing.Point(356, 7);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(49, 44);
            this.btnPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPause.TabIndex = 15;
            this.btnPause.TabStop = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(816, 441);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gBBiblioteca);
            this.Controls.Add(this.WMP);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Reproductor de Música  by Bryan Macario";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gBBiblioteca.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gBCrearLista.ResumeLayout(false);
            this.gBCrearLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).EndInit();
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
        private System.Windows.Forms.TextBox txtBusqueda;
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
        private System.Windows.Forms.PictureBox btnPlay;
        private XComponent.SliderBar.MACTrackBar macTrackVolumen;
        private XComponent.SliderBar.MACTrackBar macTrackStatus;
        private System.Windows.Forms.PictureBox btnStop;
        private System.Windows.Forms.PictureBox btnVolumen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelCancion;
        private System.Windows.Forms.PictureBox btnPause;
    }
}

