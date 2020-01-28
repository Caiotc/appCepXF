using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ApplicationCepXF.Service;
using ApplicationCepXF.Service.Model;

namespace ApplicationCepXF
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BUTTTON.Clicked += adressSearch; 
        }
        private void adressSearch(object sender,EventArgs args)
        {
            //Logica Botão

            //VAlidações
            string cep = CEP.Text.Trim();
            Adress end = ViaCepService.AdressSearch(cep);
            ADRESS.Text = string.Format("Endereço: {0},{1},{2}", end.localidade, end.uf, end.logradouro);
        }
    }
}
