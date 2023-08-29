using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MauiShell;

public partial class AppShell : Shell
{
    public ICommand MenuItemClicked { get; }
    
    public ObservableCollection<Button> SmiteMenuItems { get; }
    
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
        
        SmiteMenuItems=new ObservableCollection<Button>
        {
            new () { Text = "Home", Command = MenuItemClicked, CommandParameter = nameof(MainPage) },
            new () { Text = "About", Command = MenuItemClicked, CommandParameter = nameof(AboutPage) },
        };


        BindingContext = this;
    }
}