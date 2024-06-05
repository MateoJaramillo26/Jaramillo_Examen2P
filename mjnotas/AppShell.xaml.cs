namespace mjnotas
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            
            Routing.RegisterRoute(nameof(Views.MJAllNotesPage), typeof(Views.MJAllNotesPage));
            Routing.RegisterRoute(nameof(Views.MJContarpage), typeof(Views.MJContarpage));
            Routing.RegisterRoute(nameof(Views.MJaboutpage), typeof(Views.MJaboutpage));
        }

        private async void OnNotesTapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//notes");
        }

        private async void OnCountTapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//count");
        }

        private async void OnAboutTapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//about");
        }
    }
}
