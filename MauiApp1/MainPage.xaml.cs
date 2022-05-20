namespace MauiApp1
{
    // questo e' il code behind
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCliccamiClicked(object sender, EventArgs e)
        {
            //CounterBtn.Text = CounterBtn.Text + ".";
            CounterBtn.Text += ".";
        }
        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Cliccato {count} volte";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void metodo1()
        {
        }

        int btnDinamicoCounter = 0;
        private void Button2_Clicked(object sender, EventArgs e)
        {
            var btnDinamico = new Button();
            btnDinamico.Text = $"Ciao {++btnDinamicoCounter}";
            vsl.Children.Add(btnDinamico);
            btnDinamico.Clicked += (o, e) =>
            {
                vsl.Children.Remove(btnDinamico);
            };
        }

        private void BtnDinamico_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}