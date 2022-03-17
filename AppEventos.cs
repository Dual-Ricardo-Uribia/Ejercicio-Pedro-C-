using static ConsoleApp1.AppEventos.DesplegadorEventos;

namespace ConsoleApp1
{
    internal class AppEventos
    {
        private IRecuperadorRegistros recuperador;
        private IDesplegadorEventos desplegador;

        public AppEventos(IRecuperadorRegistros recuperador, IDesplegadorEventos desplegador, object procesador)
        {
            this.recuperador = recuperador;
            this.desplegador = desplegador;
        }

        public void Ejecutar()
        {

        }

        public interface IDesplegadorEventos
        {
            void DesplegadorEventos(Evento EventoPorDesplegar);
        }

        public class DesplegadorEventos : IDesplegadorEventos
        {
            public DesplegadorEventos()
            {

            }

            void IDesplegadorEventos.DesplegadorEventos(Evento EventoPorDesplegar)
            {
                throw new System.NotImplementedException();
            }

            public class Evento
            {

            }
        }
    }
}