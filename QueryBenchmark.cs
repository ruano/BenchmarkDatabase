using BenchmarkDotNet.Attributes;
using Microsoft.EntityFrameworkCore;

namespace BenchmarkTest
{
    [RankColumn]
    [MemoryDiagnoser]
    public class QueryBenchmark
    {
        private DbContext _dbContext;

        [Params(3)]
        public int hits;

        [GlobalSetup]
        public void GlobalSetup()
        {
            var builder = new DbContextOptionsBuilder<DbContext>().UseSqlServer("CONNECTION_STRING", x => x.UseNetTopologySuite());

            _dbContext = new DbContext(builder.Options);
        }

        [Benchmark]
        public async Task AsSplitQuery()
        {
            //for (int i = 0; i < hits; i++)
            //{

            //await _dbContext.ENTITY
            //.IgnoreQueryFilters()
            //.AsNoTrackingWithIdentityResolution()
            //.Include(v => v.NESTED_ENTITY)                
            // .FirstOrDefaultAsync(v => v.Id == 1538344719304622080);
            //}
        }
    }
}
