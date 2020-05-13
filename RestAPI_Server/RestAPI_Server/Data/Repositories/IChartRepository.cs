using RestAPI_Server.Models;
using System.Collections.Generic;

namespace RestAPI_Server.Data.Repositories
{
    public interface IChartRepository
    {
        void AddChartItem(Chart chart);
        Chart GetChart(int Id);
        void SaveChartItem();

        public IEnumerable<Chart> GetAllCharts();
    }
}