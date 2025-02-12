namespace Bases_de_datos
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Iniciosesion());
        }
    }
}