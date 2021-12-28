using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using App1.Models;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class MainPageViewModel : ContentPage
    {
        // Tiskovina je abstraktní třída - polymorfismus!
        public ObservableCollection<Tiskovina> VsechnyTiskoviny { get; set; } =
            new ObservableCollection<Tiskovina>(Tiskovina.tiskoviny);

        // Abychom se dostali na template selektor ze stejného BindingContext
        public TiskovinaTemplateSelector TiskovinaTemplate { get; set; } =
            new TiskovinaTemplateSelector();
    }
}
