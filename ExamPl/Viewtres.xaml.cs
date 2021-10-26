using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamPl
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Viewtres : ContentPage
    {
        public Viewtres(string usuario, string nombre, double total)
        {
            InitializeComponent();
            txtUsuarioR.Text = usuario;
            txtNombreR.Text = nombre;
            txtPagoR.Text = Convert.ToString(total);
        }
    }
}