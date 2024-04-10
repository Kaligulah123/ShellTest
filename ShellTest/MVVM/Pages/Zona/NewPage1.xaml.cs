using ShellTest.MVVM.ViewModels;

namespace ShellTest.MVVM.Pages.Zona;

public partial class NewPage1 : ContentPage
{
	public NewPage1(TestViewModel vm)
	{
		InitializeComponent();
		

		BindingContext = vm;
	}
}