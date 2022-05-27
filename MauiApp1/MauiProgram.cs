namespace MauiApp1
{
    public static class MauiProgram
    {
        // qui definiamo l'avvio dell'applicazione
        // passiamo la palla ad App
        // Program -> App -> AppShell -> Tutto il resto (in questo caso e' MainPage)
        public static MauiApp CreateMauiApp()
        {
            FixWorkingFolder();
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            return builder.Build();
        }

        private static void FixWorkingFolder()
        {
            string location = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string dllDir = Path.GetDirectoryName(location);
            Directory.SetCurrentDirectory(dllDir);
        }
    }
}