namespace test.Views;
using test.ViewModels;

public partial class DogsPage : ContentPage
{
	public DogsPage()
	{
		InitializeComponent();
        BindingContext = new DogsViewModel();
    }
}