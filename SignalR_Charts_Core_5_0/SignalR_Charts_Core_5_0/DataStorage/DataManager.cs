using System;
using System.Collections.Generic;
using SignalR_Charts_Core_5_0.Models;

namespace SignalR_Charts_Core_5_0.DataStorage
{
    public class DataManager
    {
        public static List<ChartModel> GetData()
        {
            var rc = new Random();
            return new List<ChartModel>
            {
                new ChartModel {Data = new List<int> { rc.Next(1, 50)}, Label = "Milano" },
                new ChartModel {Data = new List<int> { rc.Next(1, 50) }, Label = "Bergamo" },
                new ChartModel {Data = new List<int> { rc.Next(1, 50)}, Label = "Brescia"} ,
                new ChartModel {Data = new List<int> { rc.Next(1, 50)}, Label = "Monza" },
                new ChartModel {Data = new List<int> { rc.Next(1, 50)}, Label = "Cremona" },
                new ChartModel {Data = new List<int> { rc.Next(1, 50)}, Label = "Mantova" },
                new ChartModel {Data = new List<int> { rc.Next(1, 50)}, Label = "Pavia" },
                new ChartModel {Data = new List<int> { rc.Next(1, 50)}, Label = "Lecco" },
                new ChartModel {Data = new List<int> { rc.Next(1, 50)}, Label = "Sondrio" },
                new ChartModel {Data = new List<int> { rc.Next(1, 50)}, Label = "Como" },
                new ChartModel {Data = new List<int> { rc.Next(1, 50)}, Label = "Lodi" },
                new ChartModel {Data = new List<int> { rc.Next(1, 50)}, Label = "Monza" },
                new ChartModel {Data = new List<int> { rc.Next(1, 50)}, Label = "Varese" }
            };
        }
        public DataManager()
        {
        }
    }
}
