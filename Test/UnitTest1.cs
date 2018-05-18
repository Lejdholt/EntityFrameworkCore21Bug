using System;
using System.Linq;
using System.Threading.Tasks;
using AutoFixture;
using Data;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace Test
{
    public class Test
    {
        private DbContextOptions<DataContext> options;

        public Test()
        {
            options = new DbContextOptionsBuilder<DataContext>()
                .UseSqlServer("Server=CLD12619\\MSSQLSERVER16;Database=Bug;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")
                .EnableSensitiveDataLogging()
              // .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
        }

        [Fact]
        public void JoinShouldNotFail()
        {
            var entityId = Guid.NewGuid();
            var fixture = new Fixture();

            using (var context = new DataContext(options))
            {
                context.Data1s.AddRange(fixture
                    .Build<Data1>()
                    .Without(d => d.Id)
                    .With(d => d.EntityId, entityId)
                    .CreateMany());

                context.Data2s.AddRange(fixture
                    .Build<Data2>()
                    .Without(d => d.Id)
                    .With(d => d.EntityId, entityId)
                    .CreateMany());


                context.Data3s.AddRange(fixture
                    .Build<Data3>()
                    .Without(d => d.Id)
                    .With(d => d.EntityId, entityId)
                    .CreateMany());
                try
                {

                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }

            using (var context = new DataContext(options))
            {
                Guid[] ids = new[] { entityId };

                var query = from data1 in context.Data1s
                            where ids.Contains(data1.EntityId)
                            join data2 in context.Data2s on data1.EntityId equals data2.EntityId
                            join data3 in context.Data3s on data1.EntityId equals data3.EntityId
                            select new { data1, data2, data3 };

                var result =  query.ToArray();
            }
        }
    }
}