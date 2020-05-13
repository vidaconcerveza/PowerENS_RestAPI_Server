using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAPI_Server.Data;
using RestAPI_Server.Data.Repositories;
using RestAPI_Server.Models;



namespace RestAPI_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChartsController : ControllerBase
    {
        private readonly ChartContext _context;
        private readonly IChartRepository _repository;

        public ChartsController(ChartContext context, IChartRepository repository)
        {
            _repository = repository;
            _context = context;
        }

        // GET: api/Charts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Chart>>> GetCharts()
        {
            return await _context.Charts.ToListAsync();
        }

        // GET: api/Charts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Chart>> GetChart(long id)
        {
            var chart = await _context.Charts.FindAsync(id);

            if (chart == null)
            {
                return NotFound();
            }

            return chart;
        }

        // PUT: api/Charts/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChart(long id, Chart chart)
        {
            if (id != chart.Id)
            {
                return BadRequest();
            }

            _context.Entry(chart).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChartExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Charts
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Chart>> PostChart(Chart chart)
        {
           // _context.Charts.Add(chart);
           // await _context.SaveChangesAsync();

            try
            {
                _repository.AddChartItem(chart);
                _repository.SaveChartItem();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return CreatedAtAction("GetChart", new { id = chart.Id }, chart);
        }

        // DELETE: api/Charts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Chart>> DeleteChart(long id)
        {
            var chart = await _context.Charts.FindAsync(id);
            if (chart == null)
            {
                return NotFound();
            }

            _context.Charts.Remove(chart);
            await _context.SaveChangesAsync();

            return chart;
        }

        private bool ChartExists(long id)
        {
            return _context.Charts.Any(e => e.Id == id);
        }
    }
}
