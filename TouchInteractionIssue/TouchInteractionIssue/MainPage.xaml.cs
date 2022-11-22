
namespace TouchInteractionIssue;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		DisplayAlert("Alert!", "From first view button event", "ok");
	}
}
public class FirstView : ContentView
{

}

public class SecondView : ContentView
{

}