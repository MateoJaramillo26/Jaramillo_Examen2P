namespace mjnotas
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(Views.MJnotepage), typeof(Views.MJnotepage));
            Routing.RegisterRoute(nameof(Views.MJContarpage), typeof(Views.MJContarpage));
        }
    }
}
