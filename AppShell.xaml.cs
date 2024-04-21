namespace ERInv
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("Map", typeof(Map));
        }
    }
}
