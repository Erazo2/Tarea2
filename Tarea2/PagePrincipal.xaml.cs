using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea2.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePrincipal : ContentPage
    {
        public PagePrincipal()
        {
            InitializeComponent();
        }

        private void BtnInformacion_Clicked(object sender, EventArgs e)
        {
            var emple = new Implementacion
            {

                Nombres = txtnombre.Text,
                Apellidos = txtapellido.Text,
                Edad = 0,
                correo = txtCorreo.Text,
            };

            var secondpage = new PageResultado();
            secondpage.BindingContext = emple; 
            Navigation.PushAsync(secondpage);

        }

        
    }
}