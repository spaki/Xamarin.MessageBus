
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.MessageBus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();

            MessagingCenter.Subscribe<MainPage, string>(this, "TopicoMensagemEnviada", (sender, arg) => {
                labelDaPagina1.Text = arg;
            });
		}
	}
}