using System;
using PropertyChanged;
using TDMPW_3P_EJ03.MVVM.Models;
using System.Windows.Input;
using System.Net.Http;
using System.Text.Json;

namespace TDMPW_3P_EJ03.MVVM.ViewModels
{
	[AddINotifyPropertyChangedInterface]
	public class DolarViewModel
	{
		HttpClient client = new HttpClient();
		public string valorDolar { get; set; }

		public ICommand consultar { get; }
		public DolarViewModel()
		{
			consultar = new Command(async () =>
			{
				try
				{
					HttpResponseMessage response = await client.GetAsync("https://sidof.segob.gob.mx/dof/sidof/indicadores/");
					if (response.IsSuccessStatusCode)
					{
						string content = await response.Content.ReadAsStringAsync();
						var data = JsonSerializer.Deserialize<Dolar>(content);
						valorDolar = data.ListaIndicadores[0].valor;
					}
				}
				catch (Exception ex)
				{
					valorDolar = "0";
				}
			});
		}
	}
}