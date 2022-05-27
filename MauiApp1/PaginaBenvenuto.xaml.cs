namespace MauiApp1;

using MauiApp1.Controls;

public partial class PaginaBenvenuto : ContentPage
{
    public PaginaBenvenuto()
    {
        InitializeComponent();
        LblWorkingDir.Text = Directory.GetCurrentDirectory();        
    }

    private void BtnApriPaginaComponenti_Clicked(object sender, EventArgs e)
    {
        Application.Current.OpenWindow(new Window(new PaginaComponenti()));
    }


    private void BtnApriPaginaLayout_Clicked(object sender, EventArgs e)
    {
        Application.Current.OpenWindow(new Window(new PaginaLayout()));
    }
}