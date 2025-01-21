using Microsoft.VisualBasic;

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
                if (vNomb[i] == null)
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


            /*int i = 0;
            // Leemos todos los elementos del vector.
            while (i < Tam)
            {
                string aux;
                bool rep = false;
                MessageBox.Show("Introducir la persona: " + i);
                aux = Interaction.InputBox("Introduzca tu nombre: ");
                rep = ComprobarIguales(aux, vNomb);
                if (!rep)
                {
                    vNomb[i] = aux;
                    i++;
                    vTelef[i] = Interaction.InputBox("Introduzca telefono: ");
                }
                else
                {
                    MessageBox.Show("Persona ya introducida.");
                }              
            }   */                    
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

        private void btnAñadContac_Click(object sender, EventArgs e)
        {
            //Llamamos a la funcion para añadir el nombre
            //y telefono y que se guarde.            
            LeerVNombreTelefono(vNombre, vTelefono);        
        }
    }
}
