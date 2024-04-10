using ShellTest.MVVM.ViewModels;

namespace ShellTest
{
    public partial class AppShell : Shell
    {
        public AppShell(TestViewModel vm)
        {
            InitializeComponent();           

            BindingContext = vm;


        }
    }
}
