using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

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
        rackNum = racklocale[1];
        rackNum = "C" + rackNum;
        shelfNum = racklocale[2];
        if (racklocale.Length != 3)
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

        T01.Text = string.Empty;
        T02.Text = string.Empty;
        T03.Text = string.Empty;
        T04.Text = string.Empty;
        T05.Text = string.Empty;
        T06.Text = string.Empty;
        T07.Text = string.Empty;
        T08.Text = string.Empty;
        T09.Text = string.Empty;
        T10.Text = string.Empty;
        T11.Text = string.Empty;
        T12.Text = string.Empty;
        T13.Text = string.Empty;
        T14.Text = string.Empty;
        T15.Text = string.Empty;
        T16.Text = string.Empty;
        T17.Text = string.Empty;
        T18.Text = string.Empty;
        T19.Text = string.Empty;
        T20.Text = string.Empty;
        T21.Text = string.Empty;
        T22.Text = string.Empty;
        T23.Text = string.Empty;
        T24.Text = string.Empty;
        T25.Text = string.Empty;
        T26.Text = string.Empty;
        T27.Text = string.Empty;
        T28.Text = string.Empty;
        T29.Text = string.Empty;
        T30.Text = string.Empty;
        T31.Text = string.Empty;
        T32.Text = string.Empty;
        T33.Text = string.Empty;
        T34.Text = string.Empty;
        T35.Text = string.Empty;
        T36.Text = string.Empty;
        T37.Text = string.Empty;
        T38.Text = string.Empty;
        T39.Text = string.Empty;
        T40.Text = string.Empty;
        T41.Text = string.Empty;
        T42.Text = string.Empty;
        T43.Text = string.Empty;
        T44.Text = string.Empty;

        if (rackNum == "C01")
        {
            C01.Fill = mybrush;
            T01.Text = shelfNum;
        }
        else if (rackNum == "C02")
        {
            C02.Fill = mybrush;
            T02.Text = shelfNum;
        }
        else if (rackNum == "C03")
        {
            C03.Fill = mybrush;
            T03.Text = shelfNum;
        }
        else if (rackNum == "C04")
        {
            C04.Fill = mybrush;
            T04.Text = shelfNum;
        }
        else if (rackNum == "C05")
        {
            C05.Fill = mybrush;
            T05.Text = shelfNum;
        }
        else if (rackNum == "C06")
        {
            C06.Fill = mybrush;
            T06.Text = shelfNum;
        }
        else if (rackNum == "C07")
        {
            C07.Fill = mybrush;
            T07.Text = shelfNum;
        }
        else if (rackNum == "C08")
        {
            C08.Fill = mybrush;
            T08.Text = shelfNum;
        }
        else if (rackNum == "C09")
        {
            C09.Fill = mybrush;
            T09.Text = shelfNum;
        }
            else if (rackNum == "C10")
        {
            C10.Fill = mybrush;
            T10.Text = shelfNum;
        }
        else if (rackNum == "C11")
        {
            C11.Fill = mybrush;
            T11.Text = shelfNum;
        }
        else if (rackNum == "C12")
        {
            C12.Fill = mybrush;
            T12.Text = shelfNum;
        }
        else if (rackNum == "C13")
        {
            C13.Fill = mybrush;
            T13.Text = shelfNum;
        }
        else if (rackNum == "C14")
        {
            C14.Fill = mybrush;
            T14.Text = shelfNum;
        }
        else if (rackNum == "C15")
        {
            C15.Fill = mybrush;
            T15.Text = shelfNum;
        }
        else if (rackNum == "C16")
        {
            C16.Fill = mybrush;
            T16.Text = shelfNum;
        }
        else if (rackNum == "C17")
        {
            C17.Fill = mybrush;
            T17.Text = shelfNum;
        }
        else if (rackNum == "C18")
        {
            C18.Fill = mybrush;
            T18.Text = shelfNum;
        }
        else if (rackNum == "C19")
        {
            C19.Fill = mybrush;
            T19.Text = shelfNum;
        }
        else if (rackNum == "C20")
        {
            C21.Fill = mybrush;
            T21.Text = shelfNum;
        }
        else if (rackNum == "C21")
        {
            C21.Fill = mybrush;
            T21.Text = shelfNum;
        }
        else if (rackNum == "C22")
        {
            C22.Fill = mybrush;
            T22.Text = shelfNum;
        }
        else if (rackNum == "C23")
        {
            C23.Fill = mybrush;
            T23.Text = shelfNum;
        }
        else if (rackNum == "C24")
        {
            C24.Fill = mybrush;
            T24.Text = shelfNum;
        }
        else if (rackNum == "C25")
        {
            C25.Fill = mybrush;
            T25.Text = shelfNum;
        }
        else if (rackNum == "C26")
        {
            C26.Fill = mybrush;
            T26.Text = shelfNum;
        }
        else if (rackNum == "C27")
        {
            C27.Fill = mybrush;
            T27.Text = shelfNum;
        }
        else if (rackNum == "C28")
        {
            C28.Fill = mybrush;
            T28.Text = shelfNum;
        }
        else if (rackNum == "C29")
        {
            C29.Fill = mybrush;
            T29.Text = shelfNum;
        }
        else if (rackNum == "C30")
        {
            C30.Fill = mybrush;
            T30.Text = shelfNum;
        }
        else if (rackNum == "C31")
        {
            C31.Fill = mybrush;
            T31.Text = shelfNum;
        }
        else if (rackNum == "C32")
        {
            C32.Fill = mybrush;
            T32.Text = shelfNum;
        }
        else if (rackNum == "C33")
        {
            C33.Fill = mybrush;
            T33.Text = shelfNum;
        }
        else if (rackNum == "C34")
        {
            C34.Fill = mybrush;
            T34.Text = shelfNum;
        }
        else if (rackNum == "C35")
        {
            C35.Fill = mybrush;
            T35.Text = shelfNum;
        }
        else if (rackNum == "C36")
        {
            C36.Fill = mybrush;
            T36.Text = shelfNum;
        }
        else if (rackNum == "C37")
        {
            C37.Fill = mybrush;
            T37.Text = shelfNum;
        }
        else if (rackNum == "C38")
        {
            C38.Fill = mybrush;
            T38.Text = shelfNum;
        }
        else if (rackNum == "C39")
        {
            C39.Fill = mybrush;
            T39.Text = shelfNum;
        }
        else if (rackNum == "C40")
        {
            C40.Fill = mybrush;
            T40.Text = shelfNum;
        }
        else if (rackNum == "C41")
        {
            C41.Fill = mybrush;
            T41.Text = shelfNum;
        }
        else if (rackNum == "C42")
        {
            C42.Fill = mybrush;
            T42.Text = shelfNum;
        }
        else if (rackNum == "C43")
        {
            C43.Fill = mybrush;
            T43.Text = shelfNum;
        }
        else if (rackNum == "C44")
        {
            C44.Fill = mybrush;
            T44.Text = shelfNum;
        }
   
        }    
    }

}
    

            
        
    

    




    
        


    
    
