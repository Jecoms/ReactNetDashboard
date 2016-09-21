using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReactNETDashboard.Repository
{
	public class DataStore : IDataStore
	{
		private Random _rand = new Random();

		public decimal[] GetData(int numberOfDataPoints = 100)
		{
			var data = new List<decimal>();

			for (int i = 0; i < data.Count; i++)
			{
				data[i] = _rand.Next(0, 255);
			}

			return data.ToArray();
		}
	}
}