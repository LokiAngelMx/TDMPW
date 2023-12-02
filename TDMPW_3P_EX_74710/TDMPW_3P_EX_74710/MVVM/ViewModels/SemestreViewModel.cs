using System;
using System.Windows.Input;
using PropertyChanged;
using TDMPW_3P_EX_74710.MVVM.Models;

namespace TDMPW_3P_EX_74710.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class SemestreViewModel
    {
        public Semestre Materia { get; set; } = new Semestre();
        public ICommand CalcularNotasCommand { get; private set; }

        public SemestreViewModel()
        {
            CalcularNotasCommand = new Command(CalcularNotas);
        }

        private void CalcularNotas()
        {
            // Validación de que las calificaciones no son mayores de 10
            if (Materia.Parcial1 > 10 || Materia.Parcial2 > 10)
            {
                Materia.Mensaje = "Las calificaciones de los parciales no pueden ser mayores a 10.";
                return;
            }

            // Validación de que la suma de las ponderaciones no es mayor de 100
            if (Materia.PonderacionParcial1 + Materia.PonderacionParcial2 > 100)
            {
                Materia.Mensaje = "La suma de las ponderaciones no puede ser mayor a 100%.";
                return;
            }

            // Si todo está correcto, calcular las notas necesarias
            Materia.CalcularNotasNecesarias();
        }
    }
}