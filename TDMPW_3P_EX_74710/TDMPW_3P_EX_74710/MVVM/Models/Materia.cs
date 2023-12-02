using System;
using System.Collections.ObjectModel;
using PropertyChanged;

namespace TDMPW_3P_EX_74710.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]

	public class Materia
	{
        public string Nombre { get; set; }
        public ObservableCollection<double> Rubros { get; set; } = new ObservableCollection<double> { 0, 0, 0 };
        public ObservableCollection<double> Calificaciones { get; set; } = new ObservableCollection<double> { 0, 0, 0 };

        public double CalificacionFinal
        {
            get
            {
                double total = 0;
                for (int i = 0; i < 3; i++)
                {
                    total += Rubros[i] * Calificaciones[i] / 100;
                }
                return total;
            }
        }

        public Materia()
		{
		}
	}
}