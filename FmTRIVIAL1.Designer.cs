namespace TRIVIAL
{
    partial class FmTRIVIAL1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            partidaToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            salirToolStripMenuItem = new ToolStripMenuItem();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            MnuNompreCapital = new ToolStripMenuItem();
            MnuNombrePais = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            MnuMultiOpciones = new ToolStripMenuItem();
            MnuEscribirRes = new ToolStripMenuItem();
            LbPregunta = new Label();
            TxtOpcion = new TextBox();
            LbRespuesta = new Label();
            TxtOpcionRES1 = new TextBox();
            TxtOpcionRES2 = new TextBox();
            TxtOpcionRES3 = new TextBox();
            TxtOpcionRES4 = new TextBox();
            BtnSiguiente = new Button();
            BtnSalir = new Button();
            TxtPorcentaje = new TextBox();
            Respuesta = new TextBox();
            toolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { partidaToolStripMenuItem, opcionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(184, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // partidaToolStripMenuItem
            // 
            partidaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, toolStripSeparator1, salirToolStripMenuItem });
            partidaToolStripMenuItem.Name = "partidaToolStripMenuItem";
            partidaToolStripMenuItem.Size = new Size(56, 20);
            partidaToolStripMenuItem.Text = "Partida";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(109, 22);
            nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(106, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(109, 22);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MnuNompreCapital, MnuNombrePais, toolStripSeparator2, MnuMultiOpciones, MnuEscribirRes });
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(72, 20);
            opcionesToolStripMenuItem.Text = "Opciones ";
            opcionesToolStripMenuItem.Click += opcionesToolStripMenuItem_Click;
            // 
            // MnuNompreCapital
            // 
            MnuNompreCapital.Name = "MnuNompreCapital";
            MnuNompreCapital.Size = new Size(180, 22);
            MnuNompreCapital.Text = "Nombre Capitales";
            MnuNompreCapital.Click += MnuNompreCapital_Click;
            // 
            // MnuNombrePais
            // 
            MnuNombrePais.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            MnuNombrePais.Name = "MnuNombrePais";
            MnuNombrePais.Size = new Size(180, 22);
            MnuNombrePais.Text = "Nombre pais";
            MnuNombrePais.Click += nombreToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // MnuMultiOpciones
            // 
            MnuMultiOpciones.Name = "MnuMultiOpciones";
            MnuMultiOpciones.Size = new Size(180, 22);
            MnuMultiOpciones.Text = "Multiples Opciones";
            MnuMultiOpciones.Click += multiplesOpcionesToolStripMenuItem_Click;
            // 
            // MnuEscribirRes
            // 
            MnuEscribirRes.Name = "MnuEscribirRes";
            MnuEscribirRes.Size = new Size(180, 22);
            MnuEscribirRes.Text = "Escribir Repuesta";
            MnuEscribirRes.Click += MnuEscribirRes_Click;
            // 
            // LbPregunta
            // 
            LbPregunta.AutoSize = true;
            LbPregunta.Location = new Point(12, 49);
            LbPregunta.Name = "LbPregunta";
            LbPregunta.Size = new Size(28, 15);
            LbPregunta.TabIndex = 1;
            LbPregunta.Text = "Pais";
            LbPregunta.Click += label1_Click;
            // 
            // TxtOpcion
            // 
            TxtOpcion.Location = new Point(12, 76);
            TxtOpcion.Name = "TxtOpcion";
            TxtOpcion.Size = new Size(160, 23);
            TxtOpcion.TabIndex = 2;
            // 
            // LbRespuesta
            // 
            LbRespuesta.AutoSize = true;
            LbRespuesta.Location = new Point(12, 120);
            LbRespuesta.Name = "LbRespuesta";
            LbRespuesta.Size = new Size(44, 15);
            LbRespuesta.TabIndex = 3;
            LbRespuesta.Text = "Capital";
            LbRespuesta.Click += label2_Click;
            // 
            // TxtOpcionRES1
            // 
            TxtOpcionRES1.Location = new Point(12, 138);
            TxtOpcionRES1.Name = "TxtOpcionRES1";
            TxtOpcionRES1.Size = new Size(160, 23);
            TxtOpcionRES1.TabIndex = 4;
            // 
            // TxtOpcionRES2
            // 
            TxtOpcionRES2.Location = new Point(12, 185);
            TxtOpcionRES2.Name = "TxtOpcionRES2";
            TxtOpcionRES2.Size = new Size(160, 23);
            TxtOpcionRES2.TabIndex = 5;
            // 
            // TxtOpcionRES3
            // 
            TxtOpcionRES3.Location = new Point(12, 224);
            TxtOpcionRES3.Name = "TxtOpcionRES3";
            TxtOpcionRES3.Size = new Size(160, 23);
            TxtOpcionRES3.TabIndex = 6;
            // 
            // TxtOpcionRES4
            // 
            TxtOpcionRES4.Location = new Point(12, 267);
            TxtOpcionRES4.Name = "TxtOpcionRES4";
            TxtOpcionRES4.Size = new Size(160, 23);
            TxtOpcionRES4.TabIndex = 7;
            // 
            // BtnSiguiente
            // 
            BtnSiguiente.Location = new Point(12, 358);
            BtnSiguiente.Name = "BtnSiguiente";
            BtnSiguiente.Size = new Size(75, 23);
            BtnSiguiente.TabIndex = 9;
            BtnSiguiente.Text = "Siguiente";
            BtnSiguiente.UseVisualStyleBackColor = true;
            BtnSiguiente.Click += button2_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.Location = new Point(12, 387);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(75, 23);
            BtnSalir.TabIndex = 10;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = true;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // TxtPorcentaje
            // 
            TxtPorcentaje.Location = new Point(93, 371);
            TxtPorcentaje.Name = "TxtPorcentaje";
            TxtPorcentaje.Size = new Size(65, 23);
            TxtPorcentaje.TabIndex = 11;
            // 
            // Respuesta
            // 
            Respuesta.BackColor = SystemColors.MenuHighlight;
            Respuesta.Location = new Point(12, 313);
            Respuesta.Name = "Respuesta";
            Respuesta.Size = new Size(160, 23);
            Respuesta.TabIndex = 12;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(180, 22);
            // 
            // FmTRIVIAL1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(184, 450);
            Controls.Add(Respuesta);
            Controls.Add(TxtPorcentaje);
            Controls.Add(BtnSalir);
            Controls.Add(BtnSiguiente);
            Controls.Add(TxtOpcionRES4);
            Controls.Add(TxtOpcionRES3);
            Controls.Add(TxtOpcionRES2);
            Controls.Add(TxtOpcionRES1);
            Controls.Add(LbRespuesta);
            Controls.Add(TxtOpcion);
            Controls.Add(LbPregunta);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FmTRIVIAL1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem partidaToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem MnuNompreCapital;
        private ToolStripMenuItem MnuNombrePais;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem MnuMultiOpciones;
        private ToolStripMenuItem MnuEscribirRes;
        private Label LbPregunta;
        private TextBox TxtOpcion;
        private Label LbRespuesta;
        private TextBox TxtOpcionRES1;
        private TextBox TxtOpcionRES2;
        private TextBox TxtOpcionRES3;
        private TextBox TxtOpcionRES4;
        private Button BtnSiguiente;
        private Button BtnSalir;
        private TextBox TxtPorcentaje;
        private TextBox Respuesta;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}