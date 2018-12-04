
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.MessageBus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
		public Page2 ()
		{
			InitializeComponent ();

            MessagingCenter.Subscribe<MainPage, string>(this, "TopicoMensagemEnviada", (sender, arg) => {
                labelDaPagina2.Text = arg;
            });
        }
	}
}