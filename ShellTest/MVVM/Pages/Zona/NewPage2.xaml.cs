using ShellTest.MVVM.ViewModels;

namespace ShellTest.MVVM.Pages.Zona;

public partial class NewPage2 : ContentPage
{
	public NewPage2(TestViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}