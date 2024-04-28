using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using System.Drawing;

namespace ERInv;

public partial class Map : ContentPage
{

    public string[] racklocale;
    public string rackNum;
    public string shelfNum;
    public SolidColorBrush mybrush = new SolidColorBrush(Colors.Green);
    public SolidColorBrush myoldbrush = new SolidColorBrush(Colors.DarkGray);
    public string location = Preferences.Get("location", "Unknown");
    public Map()
        
    {
        InitializeComponent();

        //private string _location;

        racklocale = location.Split("-", StringSplitOptions.TrimEntries);
        if(racklocale.Length < 3)
        {
            //if response.IsSuccessStatusCode fails - inform user via community toolkit's toast
            CancellationTokenSource cancellationTokenSource = new();
            string text = "Invalid location identifer: " + location;
            ToastDuration duration = ToastDuration.Long;
            double fontSize = 14;

            var toast = Toast.Make(text, duration, fontSize);

            toast.Show(cancellationTokenSource.Token);
        }
        else if (racklocale[0] != "3C108") 
        {
            //if response.IsSuccessStatusCode fails - inform user via community toolkit's toast
            CancellationTokenSource cancellationTokenSource = new();
            string text = "Product is not located in Barsamian!" + location;
            ToastDuration duration = ToastDuration.Long;
            double fontSize = 14;

            var toast = Toast.Make(text, duration, fontSize);

            toast.Show(cancellationTokenSource.Token);
        }
        else
        {
        rackNum = racklocale[1];
        rackNum = "C" + rackNum;
        shelfNum = racklocale[2];
        C01.Fill = myoldbrush;
        C02.Fill = myoldbrush;
        C03.Fill = myoldbrush;
        C04.Fill = myoldbrush;
        C05.Fill = myoldbrush;
        C06.Fill = myoldbrush;
        C07.Fill = myoldbrush;
        C08.Fill = myoldbrush;
        C09.Fill = myoldbrush;
        C10.Fill = myoldbrush;
        C11.Fill = myoldbrush;
        C12.Fill = myoldbrush;
        C13.Fill = myoldbrush;
        C14.Fill = myoldbrush;
        C15.Fill = myoldbrush;
        C16.Fill = myoldbrush;
        C17.Fill = myoldbrush;
        C18.Fill = myoldbrush;
        C19.Fill = myoldbrush;
        C20.Fill = myoldbrush;
        C21.Fill = myoldbrush;
        C22.Fill = myoldbrush;
        C23.Fill = myoldbrush;
        C24.Fill = myoldbrush;
        C25.Fill = myoldbrush;
        C26.Fill = myoldbrush;
        C27.Fill = myoldbrush;
        C28.Fill = myoldbrush;
        C29.Fill = myoldbrush;
        C30.Fill = myoldbrush;
        C31.Fill = myoldbrush;
        C32.Fill = myoldbrush;
        C33.Fill = myoldbrush;
        C34.Fill = myoldbrush;
        C35.Fill = myoldbrush;
        C36.Fill = myoldbrush;
        C37.Fill = myoldbrush;
        C38.Fill = myoldbrush;
        C39.Fill = myoldbrush;
        C40.Fill = myoldbrush;
        C41.Fill = myoldbrush;
        C42.Fill = myoldbrush;
        C43.Fill = myoldbrush;
        C44.Fill = myoldbrush;

        if (rackNum == "C01")
        {
            C01.Fill = mybrush;
            T01.Text = shelfNum;
            T01.TextColor = Colors.White;
            }
        else if (rackNum == "C02")
        {
            C02.Fill = mybrush;
            T02.Text = shelfNum;
            T02.TextColor = Colors.White;
            }
        else if (rackNum == "C03")
        {
            C03.Fill = mybrush;
            T03.Text = shelfNum;
            T03.TextColor = Colors.White;
            }
        else if (rackNum == "C04")
        {
            C04.Fill = mybrush;
            T04.Text = shelfNum;
            T04.TextColor = Colors.White;
        }
        else if (rackNum == "C05")
        {
            C05.Fill = mybrush;
            T05.Text = shelfNum;
            T05.TextColor = Colors.White;
        }
        else if (rackNum == "C06")
        {
            C06.Fill = mybrush;
            T06.Text = shelfNum;
            T06.TextColor = Colors.White;
        }
        else if (rackNum == "C07")
        {
            C07.Fill = mybrush;
            T07.Text = shelfNum;
            T07.TextColor = Colors.White;
        }
        else if (rackNum == "C08")
        {
            C08.Fill = mybrush;
            T08.Text = shelfNum;
            T08.TextColor = Colors.White;
        }
        else if (rackNum == "C09")
        {
            C09.Fill = mybrush;
            T09.Text = shelfNum;
            T09.TextColor = Colors.White;
        }
            else if (rackNum == "C10")
        {
            C10.Fill = mybrush;
            T10.Text = shelfNum;
            T10.TextColor = Colors.White;
        }
        else if (rackNum == "C11")
        {
            C11.Fill = mybrush;
            T11.Text = shelfNum;
            T11.TextColor = Colors.White;
        }
        else if (rackNum == "C12")
        {
            C12.Fill = mybrush;
            T12.Text = shelfNum;
            T12.TextColor = Colors.White;
        }
        else if (rackNum == "C13")
        {
            C13.Fill = mybrush;
            T13.Text = shelfNum;
            T13.TextColor = Colors.White;
        }
        else if (rackNum == "C14")
        {
            C14.Fill = mybrush;
            T14.Text = shelfNum;
            T14.TextColor = Colors.White;
        }
        else if (rackNum == "C15")
        {
            C15.Fill = mybrush;
            T15.Text = shelfNum;
            T15.TextColor = Colors.White;
        }
        else if (rackNum == "C16")
        {
            C16.Fill = mybrush;
            T16.Text = shelfNum;
            T16.TextColor = Colors.White;
        }
        else if (rackNum == "C17")
        {
            C17.Fill = mybrush;
            T17.Text = shelfNum;
            T17.TextColor = Colors.White;
        }
        else if (rackNum == "C18")
        {
            C18.Fill = mybrush;
            T18.Text = shelfNum;
            T18.TextColor = Colors.White;
        }
        else if (rackNum == "C19")
        {
            C19.Fill = mybrush;
            T19.Text = shelfNum;
            T19.TextColor = Colors.White;
        }
        else if (rackNum == "C20")
        {
            C20.Fill = mybrush;
            T20.Text = shelfNum;
            T20.TextColor = Colors.White;
        }
        else if (rackNum == "C21")
        {
            C21.Fill = mybrush;
            T21.Text = shelfNum;
            T21.TextColor = Colors.White;
        }
        else if (rackNum == "C22")
        {
            C22.Fill = mybrush;
            T22.Text = shelfNum;
            T22.TextColor = Colors.White;
        }
        else if (rackNum == "C23")
        {
            C23.Fill = mybrush;
            T23.Text = shelfNum;
            T23.TextColor = Colors.White;
        }
        else if (rackNum == "C24")
        {
            C24.Fill = mybrush;
            T24.Text = shelfNum;
            T24.TextColor = Colors.White;
        }
        else if (rackNum == "C25")
        {
            C25.Fill = mybrush;
            T25.Text = shelfNum;
            T25.TextColor = Colors.White;
        }
        else if (rackNum == "C26")
        {
            C26.Fill = mybrush;
            T26.Text = shelfNum;
            T26.TextColor = Colors.White;
        }
        else if (rackNum == "C27")
        {
            C27.Fill = mybrush;
            T27.Text = shelfNum;
            T27.TextColor = Colors.White;
        }
        else if (rackNum == "C28")
        {
            C28.Fill = mybrush;
            T28.Text = shelfNum;
            T28.TextColor = Colors.White;
        }
        else if (rackNum == "C29")
        {
            C29.Fill = mybrush;
            T29.Text = shelfNum;
            T29.TextColor = Colors.White;
        }
        else if (rackNum == "C30")
        {
            C30.Fill = mybrush;
            T30.Text = shelfNum;
            T30.TextColor = Colors.White;
        }
        else if (rackNum == "C31")
        {
            C31.Fill = mybrush;
            T31.Text = shelfNum;
            T31.TextColor = Colors.White;
        }
        else if (rackNum == "C32")
        {
            C32.Fill = mybrush;
            T32.Text = shelfNum;
            T32.TextColor = Colors.White;
        }
        else if (rackNum == "C33")
        {
            C33.Fill = mybrush;
            T33.Text = shelfNum;
            T33.TextColor = Colors.White;
        }
        else if (rackNum == "C34")
        {
            C34.Fill = mybrush;
            T34.Text = shelfNum;
            T34.TextColor = Colors.White;
        }
        else if (rackNum == "C35")
        {
            C35.Fill = mybrush;
            T35.Text = shelfNum;
            T35.TextColor = Colors.White;
        }
        else if (rackNum == "C36")
        {
            C36.Fill = mybrush;
            T36.Text = shelfNum;
            T36.TextColor = Colors.White;
        }
        else if (rackNum == "C37")
        {
            C37.Fill = mybrush;
            T37.Text = shelfNum;
            T37.TextColor = Colors.White;
        }
        else if (rackNum == "C38")
        {
            C38.Fill = mybrush;
            T38.Text = shelfNum;
            T38.TextColor = Colors.White;
        }
        else if (rackNum == "C39")
        {
            C39.Fill = mybrush;
            T39.Text = shelfNum;
            T39.TextColor = Colors.White;
        }
        else if (rackNum == "C40")
        {
            C40.Fill = mybrush;
            T40.Text = shelfNum;
            T40.TextColor = Colors.White;
        }
        else if (rackNum == "C41")
        {
            C41.Fill = mybrush;
            T41.Text = shelfNum;
            T41.TextColor = Colors.White;
        }
        else if (rackNum == "C42")
        {
            C42.Fill = mybrush;
            T42.Text = shelfNum;
            T42.TextColor = Colors.White;
        }
        else if (rackNum == "C43")
        {
            C43.Fill = mybrush;
            T43.Text = shelfNum;
            T43.TextColor = Colors.White;
        }
        else if (rackNum == "C44")
        {
            C44.Fill = mybrush;
            T44.Text = shelfNum;
            T44.TextColor = Colors.White;
        }
   
        }    
    }

}
    

            
        
    

    




    
        


    
    
