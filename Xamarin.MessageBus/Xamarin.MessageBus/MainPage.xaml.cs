using System;
using Xamarin.Forms;

namespace Xamarin.MessageBus
{
    public partial class MainPage : ContentPage
    {
        Page1 page1 = new Page1();
        Page2 page2 = new Page2();

        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnEnviarMensagem_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "TopicoMensagemEnviada" , txtMensagem.Text);
            await DisplayAlert("Mensagem Espalhada", txtMensagem.Text, "OK");
        }

        private async void btnNavegarPagina1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(page1);
        }

        private async void btnNavegarPagina2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(page2);
        }
    }
}
