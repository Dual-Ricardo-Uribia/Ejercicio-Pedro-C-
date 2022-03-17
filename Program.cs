using ConsoleApp1;
using ConsoleApp1.Recursos.Implementaciones;
using ConsoleApp1.Recursos.RecuperarInformacion;
using static ConsoleApp1.AppEventos;

namespace Eventos 
{ 
    class Program
    {
        static void Main(string[] args)
        {
            var DirectorioArchivo = @"C:\Debug";
            var NombreArchivo = "eventos.txt";
            var Controlador = new ControladorArchivo();
            IRecuperadorRegistros Recuperador = new RecuperadorRegistros(DirectorioArchivo, NombreArchivo, Controlador);
            IDesplegadorEventos Desplegador = new DesplegadorEventos();
            var Procesador = ProcesadorEvento();
            AppEventos App = new AppEventos(Recuperador, Desplegador, Procesador);
            App.Ejecutar();

        }

        private static object ProcesadorEvento()
        {
            throw new System.NotImplementedException();
        }
    }
}

