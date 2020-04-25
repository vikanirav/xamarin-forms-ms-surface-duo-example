using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace MSSurfaceDuoDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnNavigateToSampleAsync(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            switch (button.Text)
            {
                case "Two Page":
                    await Navigation.PushAsync(new TwoPage.TwoPage());
                    break;
                case "Dual View":
                    await Navigation.PushAsync(new DualView.DualViewListPage());
                    break;
                case "Extend Canvas":
                    await Navigation.PushAsync(new ExtendedCanvas.ExtendCanvas());
                    break;
                case "Master Detail":
                    await Navigation.PushAsync(new MasterDetail.MasterDetail());
                    break;
                case "Companion Pane":
                    await Navigation.PushAsync(new CompanionPane.CompanionPane());
                    break;
                case "Dual Screen with Grid only":
                    await Navigation.PushAsync(new GridUsingDualScreen.GridUsingDualScreenInfo());
                    break;

            }
        }
    }
}
