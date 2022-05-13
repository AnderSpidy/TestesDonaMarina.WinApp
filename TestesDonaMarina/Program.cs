using System;
using System.Windows.Forms;
using TestesDonaMarina.Infra.Arquivos.Compartilhado;
using TestesDonaMarina.Infra.Arquivos.Compartilhado.Serializadores;

namespace TestesDonaMarina
{
    internal static class Program
    {
        static ISerializador serializador = new SerializadorDadosEmXml();

        static DataContext contexto = new DataContext(serializador);
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TelaPrincipalForm(contexto));

            contexto.GravarDados();
        }
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            contexto.GravarDados();
        }
    }
}
