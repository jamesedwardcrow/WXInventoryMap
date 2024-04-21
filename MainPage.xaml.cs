﻿using System.Net.Http.Headers;
using System.Text.Json;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using ERInv.Model;

namespace ERInv
{

    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }
        public string location;
        public List<Product> Products { get; set; }
        public async Task<List<Product>> CallMultiAPI(string srchTermv, string srchTerma)
        {
            Products = new List<Product>();
            NetworkAccess accessType = Connectivity.Current.NetworkAccess;

            // Make sure that there is an internet connection before defining client
            if (accessType == NetworkAccess.Internet)
            {


                string URL = "https://jamesc.pw/api/read.php?v=" + srchTermv + "&a=" + srchTerma;

                HttpClient client = new();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync(URL).Result;

                if (response.IsSuccessStatusCode)
                {
                    HttpContent content = response.Content;
                    string result = await content.ReadAsStringAsync();


                   Products = JsonSerializer.Deserialize<List<Product>>(result);

                   collectionView.ItemsSource= Products;

                    //var prods = new ObservableCollection<Product>();
                    //foreach (var product in list)
                    //{
                    //    //prods.Add(product);
                    //    prods.Add;
                    //}

                    //    Prods.Add(System.Text.Json.JsonSerializer.Deserialize<ProductList>(result));
                    
                }
                else
                {
                    //if response.IsSuccessStatusCode fails - inform user via community toolkit's toast
                    CancellationTokenSource cancellationTokenSource = new();
                    string text = "Item not found in this inventory!";
                    ToastDuration duration = ToastDuration.Long;
                    double fontSize = 14;

                    var toast = Toast.Make(text, duration, fontSize);

                    await toast.Show(cancellationTokenSource.Token);
                    
                }
            }
            else
            {
                //if Network.Internet fails - inform user via community toolkit's toast
                CancellationTokenSource cancellationTokenSource = new();
                string text = "No internet connection!";
                ToastDuration duration = ToastDuration.Long;
                double fontSize = 14;

                var toast = Toast.Make(text, duration, fontSize);

                await toast.Show(cancellationTokenSource.Token);
                
            }
            return Products;
        }

        private void ButtonSearch_Clicked(object sender, EventArgs e)
        {
            //int itemnum = int.Parse(entryIMF.Text);
            if (searchFor.Text != null)
            {
                string srchTerms = searchFor.Text.Trim();
                string[] subs = srchTerms.Split(null, 2);
                string srchTermv = subs[0];
                string srchTerma = string.Empty;
                if (subs.Length > 1)
                {
                    srchTerma = subs[1];
                }
                _ = CallMultiAPI(srchTermv, srchTerma);
            }
            else
            {
                CancellationTokenSource cancellationTokenSource = new();
                string text = "Please enter at least one search term!";
                ToastDuration duration = ToastDuration.Long;
                double fontSize = 14;

                var toast = Toast.Make(text, duration, fontSize);

                toast.Show(cancellationTokenSource.Token);
            }
            
        }

        public async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            location = (e.CurrentSelection.FirstOrDefault() as Product)?.Location;
            //bool keyExist = Preferences.ContainsKey("Location");
            Preferences.Default.Set("location", location);

            await Shell.Current.GoToAsync("Map");
        }

    }



}

//if response.IsSuccessStatusCode fails - inform user via community toolkit's toast
//CancellationTokenSource cancellationTokenSource = new();
//string text = "Item not found in this inventory!";
//ToastDuration duration = ToastDuration.Long;
//double fontSize = 14;

//var toast = Toast.Make(text, duration, fontSize);

// await toast.Show(cancellationTokenSource.Token);


//if Network.Internet fails - inform user via community toolkit's toast
//CancellationTokenSource cancellationTokenSource = new();
//string text = "No internet connection!";
//ToastDuration duration = ToastDuration.Long;
//double fontSize = 14;

//var toast = Toast.Make(text, duration, fontSize);

//await toast.Show(cancellationTokenSource.Token);
//int itemnum = int.Parse(entryIMF.Text);

