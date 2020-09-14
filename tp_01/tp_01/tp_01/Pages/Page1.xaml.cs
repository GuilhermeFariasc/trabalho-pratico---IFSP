using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tp_01.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private async void BtOk_ClickedAsync(object sender, EventArgs e)
        {
            string id = etId.Text;
            string pasw = etPasw.Text;

            if (id != "admin" || pasw != "@dmin")
            {
                await DisplayAlert("Erro", "Login invalido, tente novamente!", "Ok");
            }
            else
            {
                await DisplayAlert("Sucesso", "Login Realizado!", "Ok");
            }

        }
        void OnClickLimpar(object limpar, EventArgs args)
        {
            this.etId.Text = "";
            this.etPasw.Text = "";
        }

        async void OnClickCredito(object credito, EventArgs args)
        {
            await DisplayAlert("Creditos", "Guilherme Farias\r\nIgor Luiz", "OK");
        }
    }
}