using SignaturePad.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Firma_digital
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
           Stream image = await VistadeFirma.GetImageStreamAsync(SignatureImageFormat.Jpeg) ;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            VistadeFirma.Clear();
        }
    }
}
