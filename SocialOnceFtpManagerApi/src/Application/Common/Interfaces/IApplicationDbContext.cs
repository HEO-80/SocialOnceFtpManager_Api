using EAProductService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace EAProductService.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<TodoList> TodoLists { get; set; }

        DbSet<TodoItem> TodoItems { get; set; }

        DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<PriceProfitCalculationType> PriceProfitCalculationTypes { get; set; }
        public DbSet<CostingMethodType> CostingMethodTypes { get; set; }
        public DbSet<ReserveType> ReserveTypes { get; set; }
        public DbSet<StockOutWarningType> StockOutWarningTypes { get; set; }
        public DbSet<PreventNegativeInventoryType> PreventNegativeInventoryTypes { get; set; }
        public DbSet<AssemblyPolicyType> AssemblyPolicyTypes { get; set; }
        public DbSet<FlushingMethodType> FlushingMethodTypes { get; set; }
        public DbSet<ReplenishmentSystemType> ReplenishmentSystemTypes { get; set; }
        public DbSet<ReorderingPolicyType> ReorderingPolicyTypes { get; set; }
        public DbSet<ManufacturingPolicyType> ManufacturingPolicyTypes { get; set; }
        public DbSet<RearBumperCutType> RearBumperCutTypes { get; set; }
        public DbSet<TowBallType> TowBallTypes { get; set; }
        public DbSet<PolicyType> PolicyTypes { get; set; }
        public DbSet<ClassType> ClassTypes { get; set; }
        public DbSet<ManufacturingCategoryType> ManufacturingCategoryTypes { get; set; }
        public DbSet<TypologyType> TypologyTypes { get; set; }
        public DbSet<OrderTrackingPolicyType> OrderTrackingPolicyTypes { get; set; }
        public DbSet<EstimatedAssemblyTimeType> EstimatedAssemblyTimeTypes { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
