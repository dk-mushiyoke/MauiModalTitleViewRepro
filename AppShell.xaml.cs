using MauiApp1;

namespace MauiModalTitleView;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute("ModalPage", typeof(ModalPage));
    }
}
