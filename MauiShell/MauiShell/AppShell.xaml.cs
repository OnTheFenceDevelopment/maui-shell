using System.Windows.Input;

namespace MauiShell;

public partial class AppShell : Shell
{
    public ICommand MenuItemClicked { get; }
    
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(AboutPage), typeof(AboutPage));
        Routing.RegisterRoute(nameof(PlayerEntry), typeof(PlayerEntry));
        Routing.RegisterRoute(nameof(Scoreboard), typeof(Scoreboard));
        
        MenuItemClicked = new Command<string>(async route =>
        {
            Current.FlyoutIsPresented = false;
            await Current.GoToAsync(route);
        });

        BindingContext = this;
    }
}