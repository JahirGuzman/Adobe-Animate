using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Xml;
using System.IO;
namespace ProyectoPEE
{
    //
    //Dialogo del proyecto final de la materia Programacion estructurada.
    //CFAC. 07/03/22
    //
    public partial class DlgProyecto :Form
    {
        char[] PalabrasAdivinadas;
        char[] PalabraSeleccionada;
        char[] Abecedario;
        int Oportunidades;
        string[] Palabras;
        //
        //Constructor
        //
        public DlgProyecto()
        {
            InitializeComponent();
        }

        private void DlgProyecto_Load(object sender, EventArgs e)
        {
            IniciarJuego();
        }


        private void BtnLlenar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                DgvCarrito.Rows.Add();
                DgvCarrito.Rows[i].Cells[0].Value = "Producto " + (i + 1); //Producto
                DgvCarrito.Rows[i].Cells[1].Value = 1; //Cantidad
            }
        }

        //
        //Limpia la tabla de Carrito
        //
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            DgvCarrito.Rows.Clear();

        }

        private void BtnLlenarTbl_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                DgvTblProductos.Rows.Add();
                DgvTblProductos.Rows[i].Cells[0].Value = "Producto " + (i + 1);

                switch (i)
                {
                    case 0:
                        DgvTblProductos.Rows[i].Cells[1].Value = "2"; //Alto
                        DgvTblProductos.Rows[i].Cells[2].Value = "2"; //Ancho
                        DgvTblProductos.Rows[i].Cells[3].Value = "2"; //LARGO
                        DgvTblProductos.Rows[i].Cells[4].Value = "0.2"; //Peso
                        DgvTblProductos.Rows[i].Cells[5].Value = "3"; //Fragilidad
                        break;

                    case 1:
                        DgvTblProductos.Rows[i].Cells[1].Value = "5"; //Alto
                        DgvTblProductos.Rows[i].Cells[2].Value = "3"; //Ancho
                        DgvTblProductos.Rows[i].Cells[3].Value = "2"; //LARGO
                        DgvTblProductos.Rows[i].Cells[4].Value = "0.5"; //Peso
                        DgvTblProductos.Rows[i].Cells[5].Value = "1"; //Fragilidad
                        break;

                    case 2:
                        DgvTblProductos.Rows[i].Cells[1].Value = "1"; //Alto
                        DgvTblProductos.Rows[i].Cells[2].Value = "2"; //Ancho
                        DgvTblProductos.Rows[i].Cells[3].Value = "3"; //LARGO
                        DgvTblProductos.Rows[i].Cells[4].Value = "1.0"; //Peso
                        DgvTblProductos.Rows[i].Cells[5].Value = "2"; //Fragilidad
                        break;

                    case 3:
                        DgvTblProductos.Rows[i].Cells[1].Value = "6"; //Alto
                        DgvTblProductos.Rows[i].Cells[2].Value = "8"; //Ancho
                        DgvTblProductos.Rows[i].Cells[3].Value = "10"; //LARGO
                        DgvTblProductos.Rows[i].Cells[4].Value = "1.1"; //Peso
                        DgvTblProductos.Rows[i].Cells[5].Value = "2"; //Fragilidad
                        break;
                }

            }
        }
        //
        //Obtiene un dato un producto determinado desde la tabla de productos.
        //
        private string GetDatoProducto(string Producto, string NombreColumna)
        {
            string Resultado;

            Resultado = null;

            for (int i = 0; i < DgvTblProductos.Rows.Count - 1; i++)
            {
                if (Producto == DgvTblProductos.Rows[i].Cells[0].Value.ToString())
                {
                    Resultado = DgvTblProductos.Rows[i].Cells[NombreColumna].Value.ToString();
                    break;
                }
            }
            return Resultado;
        }
        //
        //Limpa los datos de la tabla 
        //
        private void BtnLimpiarDatosTabla_Click(object sender, EventArgs e)
        {
            DgvTblProductos.Rows.Clear();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double PesoTotal;
            int FragilidadTotal;


            PesoTotal = 0;
            FragilidadTotal = 0;


            for (int i = 0; i < DgvCarrito.Rows.Count - 1; i++)
            {
                string Producto;
                int Cantidad;
                int Alto;
                int Largo;
                int Ancho;
                double Peso;
                int Fragilidad;

                Producto = DgvCarrito.Rows[i].Cells[0].Value.ToString();
                Cantidad = Convert.ToInt32(DgvCarrito.Rows[i].Cells[1].Value);

                Alto = Convert.ToInt32(GetDatoProducto(Producto, "ColAlto"));
                Largo = Convert.ToInt32(GetDatoProducto(Producto, "ColLargo"));
                Ancho = Convert.ToInt32(GetDatoProducto(Producto, "ColAncho"));
                Peso = Convert.ToDouble(GetDatoProducto(Producto, "ColPeso"));
                Fragilidad = Convert.ToInt32(GetDatoProducto(Producto, "ColFragilidad"));

                PesoTotal = PesoTotal + (Cantidad * Peso);

                if (Fragilidad > FragilidadTotal)
                {
                    FragilidadTotal = Fragilidad;
                }
            }
            TbxPeso.Text = PesoTotal + " kg. ";
            TbxFragilidad.Text = "Nivel " + FragilidadTotal;
            TbxAlto.Text = ("2");
            TbxAncho.Text = ("2");
            TbxLargo.Text = ("2");

        }

        //....................................................//
        //Llena los datos de prueba de los flujos de efectivo.//
        //....................................................//
        private void BtnLlenarP3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                DgvP3FlujosNeto.Rows.Add();
                DgvP3FlujosNeto.Rows[i].Cells[0].Value = "Año " + (i + 1); //Año
                DgvP3FlujosNeto.Rows[i].Cells[1].Value = 1000; //Efectivo
            }
        }
        //...........................................................//
        //Calcula el valor presente neto de un proyecto de inversion.//
        //...........................................................//
        private void BtnVPN_Click(object sender, EventArgs e)
        {
            double InversionInicial;
            double Sumatoria;
            double Salida;
            int i;

            //...............................//
            //Validacion de calidad de datos.//
            //...............................//
            if (TbxInversionInicial.Text == "")
            {
                MessageBox.Show("Capture la Inversion inicial.");
                TbxInversionInicial.Focus();
                return;
            }
            if (!double.TryParse(TbxInversionInicial.Text, out Salida))
            {
                MessageBox.Show("Capture un valor numerico para la inversion inicial.");
                TbxInversionInicial.Focus();
                return;
            }
            if (TbxTemar.Text == "")
            {
                MessageBox.Show("Capture la Tasa minima de rendimiento.");
                return;
            }
            if (!double.TryParse(TbxTemar.Text, out Salida))
            {
                MessageBox.Show("Capture un valor numerico.");
                TbxTemar.Focus();
                return;
            }

            //
            //
            //

            InversionInicial = 0;
            i = 0;
            Sumatoria = 0;
            InversionInicial = Convert.ToDouble(TbxInversionInicial.Text);

            while (i < DgvP3FlujosNeto.Rows.Count - 1)
            {

                double ValorFuturo;
                double Tasa;

                //........................//
                //Valida calidad de datos.//
                //........................//

                if ((DgvP3FlujosNeto.Rows[i].Cells[1].Value == null))
                {
                    MessageBox.Show("Capture un flujo de efectivo en el " + DgvP3FlujosNeto.Rows[i].Cells[0].Value.ToString() + ".");

                    return;
                }

                if (!double.TryParse(DgvP3FlujosNeto.Rows[i].Cells[1].Value.ToString(), out Salida))
                {
                    MessageBox.Show("Capture un valor numerico en el " + DgvP3FlujosNeto.Rows[i].Cells[0].Value.ToString() + ".");
                    return;
                }
                //
                //Calcula valor presente del flujo y actializa sumatoria
                //

                ValorFuturo = Convert.ToDouble(DgvP3FlujosNeto.Rows[i].Cells[1].Value);
                Tasa = Convert.ToDouble(TbxTemar.Text);

                Sumatoria = Sumatoria + CalculaValorPresente(ValorFuturo, Tasa, i + 1);

                i++;

            }
            //...............//
            //Calcula el VPN.//
            //...............//
            double VPN;

            VPN = 0;

            VPN = -InversionInicial + Sumatoria;

            //...................//
            //Devolver resulatdo.//
            //...................//
            TbxResultado.Text = VPN.ToString();

            if (Math.Round(VPN, 2) == 0)
            {

                TbxDecision.Text = "Indiferente.";
                TbxDecision.BackColor = System.Drawing.Color.Yellow;


            }
            else
            {
                if (VPN > 0)
                {
                    TbxDecision.Text = "Proyecto factible.";
                    TbxDecision.BackColor = System.Drawing.Color.Green;
                }
                else
                {

                    TbxDecision.Text = "Proyecto no factible.";
                    TbxDecision.BackColor = System.Drawing.Color.Red;
                }
            }



        }
        private double CalculaValorPresente(double ValorFuturo, double Tasa, int Año)
        {

            double Resultado;

            Resultado = ValorFuturo / Math.Pow(1 + (Tasa / 100), Año);


            return Resultado;

        }

        private void BtnP3Limpiar_Click(object sender, EventArgs e)
        {
            DgvP3FlujosNeto.Rows.Clear();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DgvP4DatosEspaciales.Rows.Clear();
            CbxP4Terrenos.SelectedIndex = -1;

        }

        private void CbxP4Terrenos_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CbxP4Terrenos.SelectedIndex)
            {
                case 0:
                    for (int i = 0; i < 3; i++)
                    {
                        DgvP4DatosEspaciales.Rows.Add();
                        DgvP4DatosEspaciales.Rows[i].Cells[0].Value = i + 1;
                        DgvP4DatosEspaciales.Rows[i].Cells[0].Value = "100";
                        DgvP4DatosEspaciales.Rows[i].Cells[0].Value = "200";
                    }
                    break;
                case 1:
                    for (int i = 0; i < 5; i++)
                    {
                        DgvP4DatosEspaciales.Rows.Add();
                        DgvP4DatosEspaciales.Rows[i].Cells[0].Value = i + 1;
                        DgvP4DatosEspaciales.Rows[i].Cells[0].Value = "44";
                        DgvP4DatosEspaciales.Rows[i].Cells[0].Value = "55";
                    }
                    break;
                case 2:
                    DgvP4DatosEspaciales.Rows.Add();
                    DgvP4DatosEspaciales.Rows[0].Cells[0].Value = 1;
                    DgvP4DatosEspaciales.Rows[0].Cells[1].Value = "0";
                    DgvP4DatosEspaciales.Rows[0].Cells[2].Value = "0";
                    DgvP4DatosEspaciales.Rows.Add();
                    DgvP4DatosEspaciales.Rows[1].Cells[0].Value = 2;
                    DgvP4DatosEspaciales.Rows[1].Cells[1].Value = "20";
                    DgvP4DatosEspaciales.Rows[1].Cells[2].Value = "55";
                    DgvP4DatosEspaciales.Rows.Add();
                    DgvP4DatosEspaciales.Rows[2].Cells[0].Value = 3;
                    DgvP4DatosEspaciales.Rows[2].Cells[1].Value = "10";
                    DgvP4DatosEspaciales.Rows[2].Cells[2].Value = "72";
                    DgvP4DatosEspaciales.Rows.Add();
                    DgvP4DatosEspaciales.Rows[3].Cells[0].Value = 4;
                    DgvP4DatosEspaciales.Rows[3].Cells[1].Value = "60";
                    DgvP4DatosEspaciales.Rows[3].Cells[2].Value = "131";
                    DgvP4DatosEspaciales.Rows.Add();
                    DgvP4DatosEspaciales.Rows[4].Cells[0].Value = 5;
                    DgvP4DatosEspaciales.Rows[4].Cells[1].Value = "180";
                    DgvP4DatosEspaciales.Rows[4].Cells[2].Value = "153";
                    break;
                case 3:
                    break;
            }

            DibujaPoligono(0, 0);

        }
        //.......................................//
        //Dibujar los puntos con base a la tabla.//
        //.......................................//
        private void DibujaPoligono(int XOrigen, int YOrigen)
        {
            //
            //Declaracion de variables.
            //

            Point[] Puntos;
            Pen Lapiz;
            Graphics Lienzo;

            //
            //Validacion de datos
            //

            if (DgvP4DatosEspaciales.Rows[0].Cells[0].Value == null)
            {
                return;
            }

            //
            //Creacion de Puntos
            //


            Puntos = new Point[DgvP4DatosEspaciales.Rows.Count];

            for (int i = 0; i < DgvP4DatosEspaciales.Rows.Count - 1; i++)
            {
                Puntos[i].X = Convert.ToInt32(DgvP4DatosEspaciales.Rows[i].Cells[1].Value) + XOrigen;
                Puntos[i].Y = Convert.ToInt32(DgvP4DatosEspaciales.Rows[i].Cells[2].Value) + YOrigen;
            }
            /*{
                new Point { X = 0, Y = 0},
                new Point { X = 20, Y = 55 },
                new Point { X = 10, Y = 72 },
                new Point { X = 60, Y = 131 },
                new Point { X = 180, Y = 153 }
            };
            */
            //
            //Construccion de objetos de dibujo.
            //

            Random rnd = new Random();
            Color randomColor = Color.FromArgb(rnd.Next(255), rnd.Next(256), rnd.Next(256));

            Lapiz = new Pen(randomColor, 2);
            Lienzo = TpgPractica4.CreateGraphics();
            //Lienzo.Clear(Color.White);

            //
            //Dibujo del Poligono.
            //

            Lienzo.DrawPolygon(Lapiz, Puntos);

        }


        //
        //Actualiza el dibujo del poligono.
        //
        private void BtnActializar_Click(object sender, EventArgs e)
        {
            DibujaPoligono(0, 0);
        }

        private void TpgPractica4_MouseClick(object sender, MouseEventArgs e)
        {
            int X;
            int Y;

            Y = e.Y;
            X = e.X;

            DibujaPoligono(X, Y);


            //MessageBox.Show(e.X.ToString() + " " + e.Y.ToString());
        }

        private void TpgPractica4_MouseMove(object sender, MouseEventArgs e)
        {
            int X;
            int Y;

            Y = e.Y;
            X = e.X;

            DibujaPoligono(X, Y);
        }

        public void IniciarJuego()
        {
            //............................
            //Valores del juego iniciales.
            //............................

            FlFichas.Controls.Clear();
            FlFichas.Enabled = true;
            PbxAsfixiado.Image = null;
            LblMensaje.Visible = false;

            Oportunidades = 0;

            BtnIniciarJuego.Image = Properties.Resources.Jugando;
            Palabras = new string[] { "computacion", "programacion", "funcion", "algoritmo", "paradigma", "variables", "metodo" };
            Abecedario = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ".ToCharArray();

            //.......................
            //Palabras para adivinar.
            //.......................

            Random random = new Random();
            int IndicePalabraSeleccionada = random.Next(0, Palabras.Length);
            PalabraSeleccionada = Palabras[IndicePalabraSeleccionada].ToUpper().ToCharArray();
            PalabrasAdivinadas = PalabraSeleccionada;


            //...................................
            //Carga del abecedario en flowlayout.
            //...................................

            foreach (char LetraAlfabeto in Abecedario)
            {
                Button BtnLetra = new Button();
                BtnLetra.Tag = "";
                BtnLetra.Text = LetraAlfabeto.ToString();
                BtnLetra.Width = 60;
                BtnLetra.Height = 40;
                BtnLetra.Click += Compara;
                BtnLetra.ForeColor = Color.White;
                BtnLetra.Font = new Font(BtnLetra.Font.Name, 15, FontStyle.Bold);
                BtnLetra.BackgroundImageLayout = ImageLayout.Center;
                BtnLetra.BackColor = Color.Black;
                BtnLetra.Name = LetraAlfabeto.ToString();
                FlFichas.Controls.Add(BtnLetra);
            }
            FlPalabra.Controls.Clear();

            //............................
            //Ciclo para agregar palabras.
            //............................

            for (int IndiceValorLetra = 0; IndiceValorLetra < PalabraSeleccionada.Length; IndiceValorLetra++)
            {
                Button Letra = new Button();
                Letra.Tag = PalabraSeleccionada[IndiceValorLetra].ToString();
                Letra.Width = 46;
                Letra.Height = 80;
                Letra.ForeColor = Color.Red;
                Letra.Text = "";
                Letra.Font = new Font(Letra.Font.Name, 32, FontStyle.Bold);
                Letra.BackgroundImageLayout = ImageLayout.Center;
                Letra.BackColor = Color.White;
                Letra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                Letra.Name = "Adivinado" + IndiceValorLetra.ToString();
                Letra.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.GnLetras));
                FlPalabra.Controls.Add(Letra);

            }
        }

        void Compara(object sender, EventArgs e)
        {
            bool encontrado;
            encontrado = false;

            //.................................
            //Se desactiva el boton presionado.
            //.................................

            Button Btn = (Button)sender;
            Btn.BackColor = Color.White;
            Btn.ForeColor = Color.Black;
            Btn.Enabled = false;

            //......................................................
            //Compara la letra seleccionada con las de las palabras.
            //......................................................

            for (int IndiceRevisar = 0; IndiceRevisar < PalabrasAdivinadas.Length; IndiceRevisar++)
            {
                if (PalabrasAdivinadas[IndiceRevisar] == Char.Parse(Btn.Text))
                {
                    Button Tbx = this.Controls.Find("Adivinado" + IndiceRevisar, true).FirstOrDefault() as Button;
                    Tbx.Text = PalabrasAdivinadas[IndiceRevisar].ToString();
                    PalabrasAdivinadas[IndiceRevisar] = '-';
                    encontrado = true;
                }
            }

            //.............
            //Verificacion.
            //.............

            bool Ganaste;
            Ganaste = true;

            for (int IndiceAnalizarGanador = 0; IndiceAnalizarGanador < PalabrasAdivinadas.Length; IndiceAnalizarGanador++)
            {
                //....................................................
                //Cambiar el estatus si se tienen letras por destapar.
                //....................................................

                if (PalabrasAdivinadas[IndiceAnalizarGanador] != '-')
                {
                    Ganaste = false;
                }
            }

            //............................
            //Por si no cambia el estatus.
            //............................

            if (Ganaste)
            {
                MessageBox.Show("Ganaste!");
                BtnIniciarJuego.Image = Properties.Resources.btnStart;
            }
            
            //........................................
            //Si no se encuentra letras de la palabra.
            //........................................
            if (!encontrado)
            {
                Oportunidades = Oportunidades + 1;
                PbxAsfixiado.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("ahorcado" + Oportunidades+1);
                
                //...............................
                //Si se acaban las oportunidades.
                //...............................

                if (Oportunidades == 8)
                {
                    LblMensaje.Visible = true; 

                    //.........................
                    //Mostrar palabra correcta.
                    //.........................

                    for (int IndiceValorLetra = 0; IndiceValorLetra < PalabraSeleccionada.Length; IndiceValorLetra++)
                    {
                        Button BtnLetra = this.Controls.Find("Adivinado" + IndiceValorLetra, true).FirstOrDefault() as Button;
                        BtnLetra.Text = BtnLetra.Tag.ToString();
                    }

                    //..............................................
                    //Desactivar fichas y cambiar boton de reinicio.
                    //..............................................

                    FlFichas.Enabled = false;
                    BtnIniciarJuego.Image = Properties.Resources.btnStart;
                    MessageBox.Show("Perdiste Jaja");
                }
            }
        }



        //.........................................................................................
        //Obtiene las coordenadas geograficas de un lugar a partir de los servicios de google maps.
        //.........................................................................................
        private async void BtnObtenerCoordenadas_Click(object sender, EventArgs e)
        {
           
            //
            //Validacion
            //
            if (TbxLugar.Text == "")
            {
                return;
            }

            //
            //Obtiene coordenadas.
            //

            await GetCoordenadas();
        }

        //
        //Obtiene las coordenadas geograficas de forma asincrona. 
        //

        public async Task GetCoordenadas()
        {
            //Declaracion de variables
            //

            HttpClient ClientHttp;
            Uri Direccion;
            HttpResponseMessage RespuestaHttp;
            string ContenidoHttp;
            XmlDocument DocumentoXml;
            XmlNodeList ElemList;
            XmlElement BookElement;
            string Descripcion;
            string Lugar;
            string Latitud;
            string Longitud;
            string Llave;
            string Status;

            //
            //Prepara datos de trabajo
            //

            Llave = "AIzaSyAqPyie1EMOOceRXH7Nk7fSUBoxuhNv9wI";
            Lugar = TbxLugar.Text;

            //
            //Consulta la API de geolocalizacion de google maps.
            //


            ClientHttp = new HttpClient();
            Direccion = new Uri("https://maps.googleapis.com/maps/api/geocode/");
            ClientHttp.BaseAddress = Direccion;

            RespuestaHttp = await ClientHttp.GetAsync("xml?address=" + Lugar + "&key=" + Llave);
            //RespuestaHttp = await ClientHttp.GetAsync("xml?address=Av. Universidad 203, colonia ixtapa, puerto vallarta l&key=AIzaSyAqPyie1EMOOceRXH7Nk7fSUBoxuhNv9wI");
            ContenidoHttp = await RespuestaHttp.Content.ReadAsStringAsync();

            //MessageBox.Show(ContenidoHttp);

            //extrae la descripcion , la latidu y longitud del xml.

            DocumentoXml = new XmlDocument();
            DocumentoXml.LoadXml(ContenidoHttp);

            ElemList = DocumentoXml.GetElementsByTagName("status");
            BookElement = (XmlElement)ElemList[0];
            Status = BookElement.InnerText;

            if (Status == "ZERO_RESULTS")
            {
                TbxDescripcion.Text = "Lugar no encontrado.";
                TbxLatitud.Text = "Lugar no encontrado";
                TbxLongitud.Text = "Lugar no encontrado";
                return;
            }

            ElemList = DocumentoXml.GetElementsByTagName("formatted_address");
            BookElement = (XmlElement)ElemList[0];
            Descripcion = BookElement.InnerText;

            ElemList = DocumentoXml.GetElementsByTagName("location");
            BookElement = (XmlElement)ElemList[0];
            Latitud = BookElement["lat"].InnerText;
            Longitud = BookElement["lng"].InnerText;

            TbxDescripcion.Text = Descripcion;
            TbxLatitud.Text = Latitud;
            TbxLongitud.Text = Longitud;

        }

        private void BtnGenerarKML_Click(object sender, EventArgs e)
        {
            //.........................
            //Declaracion de variables.
            //.........................

            string Ruta;
            string Nombre;
            string Contenido;
            bool Exito;

            //...............
            //Inicializacion.
            //...............

            Ruta = @"C:\Users\JOSSELIN C. ORTEGA\Desktop ";
            Nombre = TbxLugar.Text + ".KML";
            Contenido =
                "<?xml version = \"1.0\" encoding = \"UTF-8\"?>\n" +
                "<kml xmlns = \"http://www.opengis.net/kml/2.2\">\n" +
                "  <Placemark>\n" +
                "   <name>\n" +
                "       " + TbxLugar.Text + "\n" +
                "    </name>\n" +
                "    <description>\n" +
                "       " + TbxDescripcion.Text + "\n" +
                "    </description>\n" +
                "    <Point>\n" +
                "      <coordinates>\n" +
                "         " + TbxLongitud.Text + "," + TbxLatitud.Text + ", 0\n" +
                "      </coordinates>\n" +
                "    </Point>\n" +
                "  </Placemark>\n" +
                "</kml>\n";

            //.........................
            //creacion del archivo KML.
            //.........................

            try
            {
                using (StreamWriter Escritor = File.CreateText(Ruta + Nombre))
                {
                    Escritor.WriteLine(Contenido);
                }
                Exito = true;

            }
            catch (Exception Error)
            {
                Exito = false;
            }

            if (Exito)
            {
                RtbxContenidoKML.Clear();
                RtbxContenidoKML.Text = Contenido;
                MessageBox.Show("El acrhivo KML se genero con exito");
            }
            else
            {
                MessageBox.Show("Ocurrio un error al intentar generar el archivo");

            }

        }

        private void BtnCopiarCoordenadas_Click(object sender, EventArgs e)
        {
            TxbP7Latitud.Text = TbxLatitud.Text;
            TxbP7Longitud.Text = TbxLongitud.Text;
        }

        private async void BtnBusacarLugares_Click(object sender, EventArgs e)
        {
            //Validaciones 

            if (TbxBuscar.Text == "")
            {
                return;
            }

            await GetLugares();

        }

        private async Task GetLugares()
        {
            //................
            //DECLARACION DE VARIABLES 
            //
            HttpClient ClienteHttp;
            Uri direccion;
            HttpResponseMessage respuestaHttp;
            string contenidoHttp;
            XmlDocument documetoXML;
            XmlNodeList elemList;
            XmlElement bookElement;
            string Descripcion;
            string Latitud;
            string Longitud;
            string Llave;
            string Lugar;
            string Status;
            string Buscar;
            string Nombre;
            string Domicilio;
            string Radio;
            string LatitudP7;
            string LongitudP7;



            //PREPARA LOS DATOS DEL TRABAJO 
            Llave = "AIzaSyAqPyie1EMOOceRXH7Nk7fSUBoxuhNv9wI";
            Latitud = TxbP7Latitud.Text;
            Longitud = TxbP7Longitud.Text;
            Buscar = TbxBuscar.Text;
            Radio = TbxRadio.Text;



            //CONSULTA LA API DE GEOLOCALIZACION DE GOOGLE MAPS 

            ClienteHttp = new HttpClient();
            direccion = new Uri("https://maps.googleapis.com/maps/api/place/nearbysearch/");
            ClienteHttp.BaseAddress = direccion;

            respuestaHttp = await ClienteHttp.GetAsync("xml?location=" + Latitud + "," + Longitud + "&radius=" + Radio + "&type=" + Buscar + "&key=" + Llave);
            contenidoHttp = await respuestaHttp.Content.ReadAsStringAsync();

            //MessageBox.Show(contenidoHttp);

            //Obtiene y muestra las lista de lugares 
            documetoXML = new XmlDocument();
            documetoXML.LoadXml(contenidoHttp);
            elemList = documetoXML.GetElementsByTagName("result");

            MessageBox.Show("se encontraron " + elemList.Count + " luagres. ");
            DgvP7Lugares.Rows.Clear();

            for (int i = 0; i < elemList.Count; i++)
            {
                bookElement = (XmlElement)elemList[i];
                Nombre = bookElement["name"].InnerText;
                Domicilio = bookElement["vicinity"].InnerText;

                LatitudP7 = bookElement["geometry"].ChildNodes[0].ChildNodes[0].InnerText;
                LongitudP7 = bookElement["geometry"].ChildNodes[0].ChildNodes[1].InnerText;

                DgvP7Lugares.Rows.Add();
                DgvP7Lugares.Rows[i].Cells[0].Value = i + 1;
                DgvP7Lugares.Rows[i].Cells[1].Value = Nombre;
                DgvP7Lugares.Rows[i].Cells[2].Value = Domicilio;
                DgvP7Lugares.Rows[i].Cells[3].Value = LatitudP7;
                DgvP7Lugares.Rows[i].Cells[4].Value = LongitudP7;

            }

        }
        //conviete grados decimales a radianes
        private float EnRadianes(float GradosDecimales)
        {
            return (float)(Math.PI / 180) * GradosDecimales;

        }
        // calcular la distacia de dos coordenadas con base en la formula de semiverso
        private float CalularDistacia(float PosOrigenLatitud, float PosDestinoLatitud, float PosOrigenLongitud, float PosDestinoLongitud)
        {
            var DifLatitud = EnRadianes(PosDestinoLatitud - PosOrigenLatitud);
            var DifLogitud = EnRadianes(PosDestinoLongitud - PosOrigenLongitud);

            var a = Math.Pow(Math.Sin(DifLatitud / 2), 2) +
                    Math.Cos(EnRadianes(PosOrigenLatitud)) *
                    Math.Cos(EnRadianes(PosDestinoLatitud)) *
                    Math.Pow(Math.Sin(DifLogitud / 2), 2);

            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            return 6378.0F * Convert.ToSingle(c);
        }


        private void BtnCopiarCoordenadasDestinoP8_Click_1(object sender, EventArgs e)
        {
            TbxLongitud2.Text = TbxLongitud.Text;
            TbxLatitud2.Text = TbxLatitud.Text;
            TbxLugar2.Text = TbxLugar.Text;
        }

        private void BtnCopiarCoordenadaOrigenP8_Click_1(object sender, EventArgs e)
        {
            TbxLongitud1.Text = TbxLongitud.Text;
            TbxLatitud1.Text = TbxLatitud.Text;
            TbxLugar1.Text = TbxLugar.Text;
        }

        private void BtnCalcularDistanciaP8_Click_1(object sender, EventArgs e)
        {
            // declaracion de variables locales
            float PosOrigenLtitud;
            float PosOrigenLongitud;
            float PosDestinoLatitud;
            float PosDestinoLongitud;
            float Resultado;

            //inicializacion de trabajo

            PosOrigenLtitud = (float)Convert.ToDouble(TbxLatitud1.Text);
            PosOrigenLongitud = (float)Convert.ToDouble(TbxLongitud1.Text);
            PosDestinoLatitud = (float)Convert.ToDouble(TbxLatitud2.Text);
            PosDestinoLongitud = (float)Convert.ToDouble(TbxLongitud2.Text);

            // calcular la distancia en kilometros
            Resultado = CalularDistacia(PosOrigenLtitud, PosDestinoLatitud, PosOrigenLongitud, PosDestinoLongitud);
            TbxDistanciaP8.Text = Resultado + "Kms";
        }

        private void BtnAbrirP7_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            ofile.Filter = ("Image File (*.bmp, jpg)|*bmp;*.jpg");

            if (DialogResult.OK == ofile.ShowDialog())
            {
                this.PbxImagenOrg.Image = new Bitmap(ofile.FileName);
            }
            
        }

        private void BtnGris_Click(object sender, EventArgs e)
        {
            Bitmap copiar = new Bitmap(this.PbxImagenOrg.Image);

            Procesar.ConvertirEnGris(copiar);
            this.PbxImagenGris.Image = copiar;
        }

        private void BtnGuardarP7_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = ("JPEG(*.JPG)|*.JPG|BMP(*.BMP)|*.BMP");
            Image Imagen1 = PbxImagenGris.Image;
            guardar.ShowDialog();

            Imagen1.Save(guardar.FileName);

            MessageBox.Show("Imagen guardada correctamente.");
        }
       
        private void BtnRedimencionar_Click(object sender, EventArgs e)
        {
            /*Bitmap bmp = new Bitmap(files[i].Trim());
           bmp.Save(TxbNomenclatura.Text, System.Drawing.Imaging.ImageFormat.Jpeg);

           PgbProgreso.Value = (100 * i + 1) / (files.Length);
            */

       }

        private void BtnNegativo_Click(object sender, EventArgs e)
        {
            Bitmap copiar = new Bitmap(this.PbxImagenOrg.Image);

            Procesar.ConvertirNegativo(copiar);
            this.PbxImagenGris.Image = copiar;
        }

        private void TpgPractica9_Click(object sender, EventArgs e)
        {

        }

        //public static Bitmap RedimensionarImagen(Image ImagenOriginal, int width, int height)
        //{
        /*
      //......................................
      //Obtener el tamaño maximo de la imagen.
      //......................................

      var radio = Math.Max((double)width / ImagenOriginal.Width, (double)height / ImagenOriginal.Height);

      //......................................................
      //Nuevo ancho o alto dependiendo del radio dimensionado.
      //......................................................

      var NuevoAncho = (int)(ImagenOriginal.Width * radio);
      var NuevoAlto = (int)(ImagenOriginal.Height * radio);

      //.........................................
      //Se crea el Bitmap con los nuevos tamaños.
      //.........................................

      var ImagenRedimensionada = new Bitmap(NuevoAncho, NuevoAlto);

      //.........................................
      //Se crea el Bitmap con los nuevos tamaños.
      //.........................................

      Graphics.FromImage(ImagenRedimensionada).DrawImage(ImagenOriginal, 0, 0, NuevoAncho, NuevoAlto);
      Bitmap ImagenFinal = new Bitmap(ImagenRedimensionada);
        */
        //}

    }
    }