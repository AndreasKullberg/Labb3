using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Labb3
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private double CalculateVat(int vat, double amount) => amount * vat / 100;
        private double CalculateAmount(int vat, double amount) => amount - (amount * vat / 100);

        private void SetLabels(int vat)
        {
            double entryValue = double.Parse(AmountEntry.Text);
            VatLabel.Text = vat + "%";
            AmountLabel.Text = AmountEntry.Text;
            CalculatedVatLabel.Text = Convert.ToString(CalculateVat(vat, entryValue)) + " SEK";
            CalculatedAmountLabel.Text = Convert.ToString(CalculateAmount(vat, entryValue)) + " SEK";
        }

        private void EightClicked(object sender, EventArgs args)
        {
            SetLabels(8);
        }
        private void TwelveClicked(object sender, EventArgs args)
        {
            SetLabels(12);
        }
        private void TwentyFiveClicked(object sender, EventArgs args)
        {
            SetLabels(25);
        }
        public MainPage()
        {
            InitializeComponent();
        }
    }
}
