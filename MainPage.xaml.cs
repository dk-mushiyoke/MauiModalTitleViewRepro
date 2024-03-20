namespace MauiModalTitleView;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnButtonClicked(object sender, EventArgs e)
	{
		//Shell.GoToAsync() does not show the title view on the modal page
		Shell.Current.GoToAsync("ModalPage");

        //Only through non shell navigation can we get the title view
        //Navigation.PushModalAsync(new NavigationPage(new MauiApp1.ModalPage()));
    }
}

