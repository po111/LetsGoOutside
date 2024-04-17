using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsGoOutside.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace LetsGoOutside.Tests.Mocks
{
    public class DatabaseMock
    {
        public static LetsGoOutsideDbContext Instance
        {
            get
            {
                var dbContextOptions =  new DbContextOptionsBuilder<LetsGoOutsideDbContext>()
                    .UseInMemoryDatabase("LetsGoOutsideInMemoryDb"+DateTime.Now.Ticks.ToString())
                    .Options;

                return new LetsGoOutsideDbContext(dbContextOptions, false);
            }
        }
    }
}
