using System;
using System.Windows.Input;
using PropertyChanged;
using TDMPW_3P_EX_74710.MVVM.Models;

namespace TDMPW_3P_EX_74710.MVVM.ViewModels
{
	[AddINotifyPropertyChangedInterface]

	public class MateriaViewModel
	{
        public Materia Materia { get; set; } = new Materia();
        public ICommand CalcularCalificacionCommand { get; private set; }
        public string CalificacionFinalTexto { get; set; }

        public MateriaViewModel()
        {
            CalcularCalificacionCommand = new Command(CalcularCalificacion);
        }

        private void CalcularCalificacion()
        {
            // Verificar que los rubros sumen 100%
            if (Materia.Rubros.Sum() != 100)
            {
                CalificacionFinalTexto = "Error: La suma de los porcentajes de los rubros debe ser 100%.";
                return; // Salir del método si no suman 100%
            }

            // Verificar que todas las calificaciones estén en el rango de 0 a 10
            if (Materia.Calificaciones.Any(c => c < 0 || c > 10))
            {
                CalificacionFinalTexto = "Error: Las calificaciones deben estar en el rango de 0 a 10.";
                return; // Salir del método si alguna calificación está fuera de rango
            }

            // Calcular la calificación final
            CalificacionFinalTexto = $"Calificación Final: {Materia.CalificacionFinal}";
        }
    }
}