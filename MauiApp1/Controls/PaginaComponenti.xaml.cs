namespace MauiApp1.Controls;
using LibreriaTwinsnet;

public partial class PaginaComponenti : ContentPage
{
    // https://docs.microsoft.com/en-us/dotnet/maui/user-interface/controls/

    // https://docs.microsoft.com/en-us/dotnet/maui/user-interface/layouts/

    // KeypadPage
    // https://docs.microsoft.com/en-us/dotnet/maui/xaml/fundamentals/mvvm

    public PaginaComponenti()
	{
		InitializeComponent();
        CreaFileEtichette();
        CaricaEtichetteDaFile();

    }

    private void CaricaEtichetteDaFile()
    {
        File.ReadAllLines("etichette.txt").ToList().ForEach((riga) =>
        {
            var comp = new ComponentePicker();
            comp.Etichetta = riga;
            MainLayout.Children.Add(comp);
        });
    }

    private void CreaFileEtichette()
    {

        var file = new FileInfo("etichette.txt");

        file.WriteText("");

        for (int i = 0; i < 10; i++)
        {
            file.AppendAllText($"Etichetta numero {i+1}\n");
        }

        
    }

    private void MonkeyPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        int selectedIndex = MonkeyPicker.SelectedIndex;

        if (selectedIndex != -1)
        {
            LblSelezionePicker.Text = (string)MonkeyPicker.ItemsSource[selectedIndex];
        }
        
    }
}