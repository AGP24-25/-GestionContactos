using Microsoft.VisualBasic;
using System.Runtime.Intrinsics.X86;

namespace GestionContactos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int Tam = 10;
        // Declaramos y damos tamaño a los vectores.
        string[] vNombre = new string[Tam];
        string[] vTelefono = new string[Tam];

        void LeerVNombreTelefono(string[] vNomb, string[] vTelef)
        {
            int u;
            int i;
            bool parar = false;
            for (i = 0; i < Tam && !parar; i++)
            {
                if (vNomb[i] == null || vNomb[i] == "")
                {
                    string aux;
                    bool rep = false;
                    MessageBox.Show("Introducir la persona: " + i);
                    aux = Interaction.InputBox("Introduzca tu nombre: ");
                    rep = ComprobarIguales(aux, vNomb);
                    if (!rep)
                    {
                        vNomb[i] = aux;
                        vTelef[i] = Interaction.InputBox("Introduzca telefono: ");
                    }
                    else
                    {
                        MessageBox.Show("Persona ya introducida.");
                    }
                    parar = true;
                }
            }
        }

        bool ComprobarIguales(string aux, string[] vNomb)
        {
            bool iguales = false;
            for (int j = 0; j < Tam && !iguales; j++)
            {
                if (aux == vNomb[j])
                {
                    iguales = true;
                }
            }
            return iguales;
        }

        bool EliminarContacto(string[] vNombre, string[] vTelef)
        {
            string nombre;
            bool parar = false;
            nombre = Interaction.InputBox("Introduzca nombre del contacto a borrar: ");
            for (int i = 0; i < Tam && !parar; i++)
            {
                if (vNombre[i] == nombre)
                {
                    vNombre[i] = "";
                    vTelef[i] = "";
                    parar = true;
                }
            }
            return parar;
        }

        private void btnAñadContac_Click(object sender, EventArgs e)
        {
            //Llamamos a la funcion para añadir el nombre
            //y telefono y que se guarde.
            //realizado por Alejandro Garcia
            LeerVNombreTelefono(vNombre, vTelefono);
        }

        private void btnEliminarContacto_Click(object sender, EventArgs e)
        {
            //realizado por Britney Zambrano
            bool eliminado;
            eliminado = EliminarContacto(vNombre, vTelefono);
            if (eliminado)
            {
                MessageBox.Show("Contacto eliminado correctamente");
            }
            else
            {
                MessageBox.Show("Error el contacto no existe");
            }
        }
    }
}
