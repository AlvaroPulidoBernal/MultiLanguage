using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LanguageExample.Properties;

namespace LanguageExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * Para agregar soporte de varios lenguajes se tiene que crear un directorio donde tengas todos los archivos de lenguajes
         * Se crea un archivo de recursos nombre.resx para que genere las referencias de nombre.Designer.cs para que sean visibles los lenguajes que se generen en adelante
         * en el archivo creado tiene: 
         *      "Nombre" - Identificador de la cadena de texto (ej HelloLabel)
         *      "Valor" - Valor de la cadena de texto (ej Hello)
         *      
         *  Con eso se creo el archivo de recursos de lenguaje, ahora a crear otro archivo de recursos para otro lenguaje
         *  
         *  Se crea con el mismo nombre del primero que se creo -> "nombre" pero agregando la cultura del lenguaje -> nombre.es-MX.resx
         *  con eso se tiene creado otro archivo de lenguaje para español 
         *  ahora para agregar una cadena de texto se usa el mismo formato, pero en el campo de valor iria el valor en español
         *  
         *      "Nombre" - Identificador de la cadena de texto (ej HelloLabel)
         *      "Valor" - Valor de la cadena de texto (ej Hola)
         * 
         * Con eso al cambiar la cultura el nomnbre de la cadena se busca al ser el mismo obtiene el valor acorde al idioma
         * 
         */



        private void button1_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("es-MX");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-MX");
            String text = Languajes.Language.Hello;
            Debug.WriteLine(text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            String text = Languajes.Language.Hello;
            Debug.WriteLine(text);
        }

        public static void getText()
        {
            //String text = Language.Language.Hello;
        }
    }
}
