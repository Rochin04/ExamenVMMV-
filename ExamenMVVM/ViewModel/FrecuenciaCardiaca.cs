using ExamenMVVM.VistaModelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using ExamenMVVM.View;
using ExamenMVVM.ViewModel;

namespace ExamenMVVM.ViewModel
{
    public class FrecuenciaCardiaca : BaseViewModel
    {
        int _LatidoPorMinuto;
        double _HoreasSueño;
        double _NivelEstres;
        bool _VisibleEnableTrue;
        bool _VisibleEnableFalse;
        public FrecuenciaCardiaca(INavigation navigation)
        {
            Navigation = navigation;
        }
        public int Latidos
        {
            get { return _LatidoPorMinuto; }
            set { SetValue(ref _LatidoPorMinuto, value); }
        }
        public bool VisibleEnableTrue
        {
            get { return _VisibleEnableTrue; }
            set { SetValue(ref _VisibleEnableTrue, value); }
        }
        public bool VisibleEnableFalse
        {
            get { return _VisibleEnableFalse; }
            set { SetValue(ref _VisibleEnableFalse, value); }
        }
        public double HoreasSueño
        {
            get { return _HoreasSueño; }
            set { SetValue(ref _HoreasSueño, value); }
        }
        public double NivelEstres
        {
            get { return _HoreasSueño; }
            set { SetValue(ref _HoreasSueño, value); }
        }
        public async void CalcularNivelEstres(double latidos, double horas)
        {
            NivelEstres = (latidos / 100) + (0.2 * (8 - horas));
        }
        public async void BtnCalcularEstres()
        {
            CalcularNivelEstres(_LatidoPorMinuto, _HoreasSueño);
            if(NivelEstres < 1.5)
            {
                DisplayAlert("mensaje", "Estres Bajo", "Salir");
                VisibleEnableTrue = true;

            }
            else if(NivelEstres < 2.0)
            {
                 DisplayAlert("Mensaje", "Estres Moderado", "Salir");
            }
            else if(NivelEstres == 2.0 || NivelEstres > 2.0)
            {
                 DisplayAlert("Mensaje", "Estres alto", "Salir");
            }
            else
            {
                 DisplayAlert("Mensaje trol", "XDD", "Hasta la vista baybi");
            }
        }
        public ICommand CalculaEstresCommnd => new Command(BtnCalcularEstres);
    }
}
