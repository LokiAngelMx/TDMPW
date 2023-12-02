using System;
using PropertyChanged;

namespace TDMPW_3P_EJ03.MVVM.Models
{
	[AddINotifyPropertyChangedInterface]
	public class Dolar
	{
		public string response { get; set; }
		public int messageCode { get; set; }
		public List<Indicador> ListaIndicadores { get; set; }
		public Dolar()
		{
		}
	}

    [AddINotifyPropertyChangedInterface]
    public class Indicador
	{
		public string valor { get; set; }
		public int codTipoIndicador { get; set; }
	}
}