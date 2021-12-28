using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using App1.Models;
using App1.Views;

namespace App1.ViewModels
{
    public class TiskovinaTemplateSelector : DataTemplateSelector
    {
        // Maximální počet template instancí je něco kolem 20,
        // proto budeme recyklovat templates pro obě možnosti
        private static CasopisTemplate casopisTemplate = new CasopisTemplate();
        private static KnihaTemplate knihaTemplate = new KnihaTemplate();

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is Casopis) return casopisTemplate; // posíláme pouze odkaz na existující template
            if (item is Kniha) return knihaTemplate;

            // + případné další templates (pro plakát, zprávu, atd.)

            throw new ArgumentException(item.ToString()); // k tomu by nemělo nikdy dojít ...
        }
    }
}
