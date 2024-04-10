using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellTest.MVVM.ViewModels
{
    
    public partial class TestViewModel : ObservableObject
    {


        [ObservableProperty]
        public bool isEnabledButton;//Propiedad que deberia de habilitar/deshabilitar la NavBar del Flyout

       
        private bool test;//este bool lo tengo para comprobar que TestCommand es ejecutado desde el Flyout

        [RelayCommand]
        public void Enable()
        {
            IsEnabledButton = true;
        }

        [RelayCommand]
        public void Disable()
        {
            IsEnabledButton = false;
        }


        //Este comando se ejecuta correctamente si pulso el MenuItem TestCommand
        [RelayCommand]
        public void Test()
        {
           test = false;
        }


        //Este Comando se activa desde la Page2 y abre el Flyout correctamente
        [RelayCommand]
        public void OpenFlyout()
        {
            Shell.Current.FlyoutIsPresented = true;
        }

        


    }
}
