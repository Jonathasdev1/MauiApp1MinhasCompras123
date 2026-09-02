namespace MauiApp1MinhasCompras123
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = new Window(new NavigationPage(new Views.ListaProduto()));
            window.Title = "Lista Produto";
            return window;
        }
    }
}