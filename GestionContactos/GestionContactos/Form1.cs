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

        void LeerVNombre(string[] v)
        {
            int i;
            // Leemos todos los elementos del vector.
            for (i = 0; i < Tam; i++)
            {
                v[i] = Interaction.InputBox("Introduzca tu nombre: ");
            }
        }

        private void btnAñadContac_Click(object sender, EventArgs e)
        {
            //Llamamos a la funcion para añadir el nombre y que se guarde.
            LeerVNombre(vNombre);
        }
    }
}
