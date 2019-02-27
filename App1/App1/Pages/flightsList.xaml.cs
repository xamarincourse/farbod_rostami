using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Pages
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class flightsList : ContentPage
  {
    public ObservableCollection<FlightModel> Items { get; set; }

    public flightsList()
    {
      InitializeComponent();


      Items = new ObservableCollection<FlightModel>()
            {
               new FlightModel(){
                 city="london",
                 STA="14:20",
                 ETA="14:35",
                 terminal="T3",
                 Status="Arrived",
                 ariline="JET AIRWAYS",
                 flightNo="9W2274",
                 s_color="#0c7c39"
               },
               new FlightModel(){
                 city="london",
                 STA="14:20",
                 ETA="14:35",
                 terminal="T3",
                 Status="Arrived",
                 ariline="JET AIRWAYS",
                 flightNo="9W2274",
                 s_color="#0c7c39"

               },
               new FlightModel(){
                 city="london",
                 STA="14:20",
                 ETA="14:35",
                 terminal="T3",
                 Status="Delayed",
                 ariline="JET AIRWAYS",
                 flightNo="9W2274",
                 s_color="#ad2c08"

               },
               new FlightModel(){
                 city="london",
                 STA="14:20",
                 ETA="14:35",
                 terminal="T3",
                 Status="Arrived",
                 ariline="JET AIRWAYS",
                 flightNo="9W2274",
                 s_color="#0c7c39"

               },
               new FlightModel(){
                 city="london",
                 STA="14:20",
                 ETA="14:35",
                 terminal="T3",
                 Status="Delayed",
                 ariline="JET AIRWAYS",
                 flightNo="9W2274",
                 s_color="#ad2c08"

               },
               new FlightModel(){
                 city="london",
                 STA="14:20",
                 ETA="14:35",
                 terminal="T3",
                 Status="Arrived",
                 ariline="JET AIRWAYS",
                 flightNo="9W2274",
                 s_color="#0c7c39"

               }

            };

      MyListView.ItemsSource = Items;
    }

    async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
    {
      //if (e.Item == null)
      //  return;

      //await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

      ////Deselect Item
      //((ListView)sender).SelectedItem = null;
    }
  }
}
