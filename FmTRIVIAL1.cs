namespace TRIVIAL
{
    public partial class FmTRIVIAL1 : Form
    {
        private string[] Paises;
        private string[] Capitales;

        private void InicializarCP()
        {
            Paises = new string[45]

            {
                "Espa�a", "Francia", "Alemania", "Italia", "Portugal",
             "Estados Unidos", "Canad�", "M�xico", "Argentina", "Brasil",
             "Chile", "Colombia", "Per�", "Ecuador", "Uruguay",
             "Venezuela", "Bolivia", "Paraguay", "Honduras", "Guatemala",
            "Costa Rica", "Panam�", "El Salvador", "Nicaragua", "Belice",
             "Cuba", "Rep�blica Dominicana", "Hait�", "Jamaica", "Puerto Rico",
             "Inglaterra", "Escocia", "Irlanda del Norte", "Gales", "Pa�ses Bajos",
             "B�lgica", "Luxemburgo", "Suiza", "Austria", "Polonia",
                 "Suecia", "Noruega", "Dinamarca", "Finlandia", "Grecia"};


            Capitales = new string[45]
            { "Madrid", "Par�s", "Berl�n", "Roma", "Lisboa",
             "Washington, D.C.", "Ottawa", "Ciudad de M�xico", "Buenos Aires", "Brasilia",
             "Santiago", "Bogot�", "Lima", "Quito", "Montevideo",
             "Caracas", "La Paz", "Asunci�n", "Tegucigalpa", "Guatemala",
             "San Jos�", "Ciudad de Panam�", "San Salvador", "Managua", "Belmop�n",
             "La Habana", "Santo Domingo", "Puerto Pr�ncipe", "Kingston", "San Juan",
             "Londres", "Edimburgo", "Belfast", "Cardiff", "�msterdam",
             "Bruselas", "Luxemburgo", "Berna", "Viena", "Varsovia",
             "Estocolmo", "Oslo", "Copenhague", "Helsinki", "Atenas" };

        }

        private void Introducir_datosPaisesCapitales()
        {


            Random random = new Random();
            int indicePais;
            int indiceCapital;
            indiceCapital = random.Next(Capitales.Length);
            indicePais = random.Next(Paises.Length);

            TxtOpcion.Text = Capitales[indiceCapital];

            TxtOpcionRES1.Text = Paises[indicePais];
            TxtOpcionRES2.Text = Paises[indicePais];
            TxtOpcionRES3.Text = Paises[indicePais];
            TxtOpcionRES4.Text = Paises[indicePais];

        }
        public FmTRIVIAL1()
        {
            InitializeComponent();
            InicializarCP();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MnuMultiOpciones.Checked = true;
            MnuNompreCapital.Checked = false;
            MnuNombrePais.Checked = true;
            LbPregunta.Text = "Capital";
            LbRespuesta.Text = "Pais";

            if (MnuNompreCapital.Checked && MnuMultiOpciones.Checked)
            {
                Introducir_datosPaisesCapitales();
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void multiplesOpcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {


            /*
             * Este evento sirve para cuando se pulse la opcion de multiples opcines  se muestren  las opcines de espuestas 2,3,4
             */
            MnuMultiOpciones.Checked = true;
            MnuEscribirRes.Checked = false;
            //hacer que solo se puedan leer

            TxtOpcionRES1.ReadOnly = true;
            // hacer que sean visiles
            TxtOpcionRES2.Visible = true;
            TxtOpcionRES3.Visible = true;
            TxtOpcionRES4.Visible = true;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MnuNompreCapital_Click(object sender, EventArgs e)
        {
            MnuNompreCapital.Checked = true;
            MnuNombrePais.Checked = false;
            LbPregunta.Text = "Pais";
            LbRespuesta.Text = "Capital";


        }

        private void MnuEscribirRes_Click(object sender, EventArgs e)
        {
            /*
             * Este evento sirve para cuando se pulse la opcion de escritura se oculten las opcines de espuestas 2,3,4
             */
            MnuMultiOpciones.Checked = false;
            MnuEscribirRes.Checked = true;
            TxtOpcionRES2.Visible = false;
            TxtOpcionRES3.Visible = false;
            TxtOpcionRES4.Visible = false;
        }
    }
}