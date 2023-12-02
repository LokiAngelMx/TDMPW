using System;
using PropertyChanged;

namespace TDMPW_3P_EX_74710.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]

    public class Semestre
    {
        public string Nombre { get; set; }
        public double Parcial1 { get; set; }
        public double Parcial2 { get; set; }
        public double PonderacionParcial1 { get; set; }
        public double PonderacionParcial2 { get; set; }
        public double NotaRequeridaPara6 { get; private set; }
        public double NotaRequeridaPara10 { get; private set; }
        public string Mensaje { get; set; }

        public void CalcularNotasNecesarias()
        {
            double ponderacionParcial3 = 100 - (PonderacionParcial1 + PonderacionParcial2);
            NotaRequeridaPara6 = CalcularNotaNecesaria(6, ponderacionParcial3);
            NotaRequeridaPara10 = CalcularNotaNecesaria(10, ponderacionParcial3);

            Mensaje = GenerarMensaje();
        }

        private double CalcularNotaNecesaria(double objetivo, double ponderacionParcial3)
        {
            // Calcular la nota necesaria en el tercer parcial
            double notaNecesaria = ((objetivo - Parcial1 * (PonderacionParcial1 / 100) - Parcial2 * (PonderacionParcial2 / 100)) * 100) / ponderacionParcial3;
            return notaNecesaria; // Permitir valores por encima de 10
        }

        private string GenerarMensaje()
        {
            if (NotaRequeridaPara6 > 10)
            {
                return "Necesitas más de 10 en el tercer parcial, ¡ya ni pa que te esfuerzas!";
            }
            else if (NotaRequeridaPara6 > 6 && NotaRequeridaPara6 <= 10)
            {
                return "Aún puedes aprobar, ¡tú puedes!";
            }
            else // (NotaRequeridaPara6 < 6)
            {
                return "¡Vas bien! Mantén el esfuerzo para asegurar tu aprobación.";
            }
        }

        public Semestre()
        {
        }
    }
}