using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiShell;

public partial class PlayerEntry : ContentPage
{
    public PlayerEntry()
    {
        InitializeComponent();
    }

    private async void StartGame_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(Scoreboard)}");
    }
}