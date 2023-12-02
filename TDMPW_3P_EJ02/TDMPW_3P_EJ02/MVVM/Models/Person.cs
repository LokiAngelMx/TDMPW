using System;
using PropertyChanged;

namespace TDMPW_3P_EJ02.MVVM.Models
{
	[AddINotifyPropertyChangedInterface]

	public class Person
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public bool Married { get; set; }
		public int DaysOff { get; set; }
		public DateTime Birthday { get; set; }
		public TimeSpan LunchTime { get; set; }

		public Person()
		{
		}
	}
}