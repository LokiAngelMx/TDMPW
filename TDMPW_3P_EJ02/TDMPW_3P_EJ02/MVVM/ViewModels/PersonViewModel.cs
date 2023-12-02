using System;
using TDMPW_3P_EJ02.MVVM.Models;
using System.Windows.Input;
using PropertyChanged;

namespace TDMPW_3P_EJ02.MVVM.ViewModels
{
	[AddINotifyPropertyChangedInterface]

	public class PersonViewModel
	{
		public Person Person { get; set; }
		public int Result { get; set; }
        public ICommand ClickCommand { get; }
		public ICommand AgeCmd => new Command(() => Result = Person.Age++);

		public PersonViewModel()
		{
			Person = new Person
			{
				Name = "Goku",
				Age = 30,
				Married = true,
				DaysOff = 5,
				Birthday = new DateTime(1985, 6, 7),
				LunchTime = new TimeSpan(10, 0, 0)
			};

			ClickCommand = new Command(() =>
			{
				App.Current.MainPage.DisplayAlert("COMANDO", "Se ejecutó el comando", "OK");
			});
		}
	}
}