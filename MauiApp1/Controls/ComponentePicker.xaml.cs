namespace MauiApp1.Controls;

public partial class ComponentePicker : ContentView
{

	public string Etichetta
    {
		get { return LblEtichetta.Text; }
		set { LblEtichetta.Text = value; }
    }
	

	public ComponentePicker()
	{
		InitializeComponent();
		//Etichetta = "Etichetta non inizializzata";
	}
}