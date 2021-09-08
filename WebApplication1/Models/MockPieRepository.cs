using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class MockPieRepository : IPieRepository
    {
        public readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Pie> AllPies =>
            new List<Pie>
            {
                new Pie {PieId = 1, Name="Strawberry Pie", Price=15.95M, ShortDescription="Gayet güzel",CategoryId = 1,Category=this._categoryRepository.GetPieById(1), LongDescription="güzel"},
                new Pie {PieId = 2, Name="Cheese cake", Price=18.95M, ShortDescription="Gayet güzel",CategoryId = 2,Category=this._categoryRepository.GetPieById(2), LongDescription="güzel"},
                new Pie {PieId = 3, Name="Rhubard Pie", Price=15.95M, ShortDescription="Gayet güzel",CategoryId = 3,Category=this._categoryRepository.GetPieById(2), LongDescription="güzel"},
                new Pie {PieId = 4, Name="Pumpkin Pie", Price=12.95M, ShortDescription="Gayet güzel",CategoryId = 4,Category=this._categoryRepository.GetPieById(3), LongDescription="güzel"}
            };
        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
