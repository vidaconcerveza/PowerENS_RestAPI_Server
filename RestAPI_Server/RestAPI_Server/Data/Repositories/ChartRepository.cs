using RestAPI_Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI_Server.Data.Repositories
{
    public class ChartRepository : IChartRepository
    {
        private readonly ChartContext _context;

        public ChartRepository(ChartContext context)
        {
            _context = context;
        }

        public void AddChartItem(Chart chart)
        {
            _context.Charts.AddAsync(chart);
        }

        public void SaveChartItem()
        {
            _context.SaveChanges();
        }

        public Chart GetChart(int Id)
        {
            var result = _context.Charts.Find((long)Id);
            return result;
        }

        public IEnumerable<Chart> GetAllCharts()
        {
            var result = _context.Charts.ToList();
            return result;
        }

       
    }
}
