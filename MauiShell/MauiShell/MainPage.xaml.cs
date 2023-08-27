namespace MauiShell;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void IndividualGame_Clicked(object sender, EventArgs e)
    {
        // Replace Player Entry as the root of the Navigation Stack
        await Shell.Current.GoToAsync($"//{nameof(PlayerEntry)}");
    }
}