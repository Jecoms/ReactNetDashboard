using ReactNETDashboard.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReactNETDashboard.Models
{
	public class DashboardVM
	{
		
		public int DashboardID { get; set; }

		[Display(Name = "Metric One!")]
		public decimal MetricOne { get; set; }

		[Display(Name = "Metric Two?!")]
		public decimal MetricTwo { get; set; }


		public decimal[] DataSeriesOne { get; set; }
		public decimal[] DataSeriesTwo { get; set; }

		private IDataStore db;

		public DashboardVM(IDataStore dataStore)
		{
			db = dataStore;
			Init();
		}

		private void Init()
		{
			RetrieveData();
			CalculateMetricOne();
			CalculateMetricTwo();
			// ...
		}

		private void RetrieveData()
		{
			DataSeriesOne = db.GetData();
			DataSeriesTwo = db.GetData(50);
		}

		private void CalculateMetricOne()
		{
			MetricOne = DataSeriesOne.Average();
		}

		private void CalculateMetricTwo()
		{
			MetricTwo = DataSeriesTwo.Max();
		}
	}
}