using EAProductService.Application.Common.Interfaces;
using EAProductService.Domain.Common;
using EAProductService.Domain.Entities;
using EAProductService.Infrastructure.Identity;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Options;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace EAProductService.Infrastructure.Persistence
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>, IApplicationDbContext 
    {
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;

        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions,
            ICurrentUserService currentUserService,
            IDateTime dateTime) : base(options, operationalStoreOptions)
        {
            _currentUserService = currentUserService;
            _dateTime = dateTime;
        }

        public DbSet<TodoList> TodoLists { get; set; }

        public DbSet<TodoItem> TodoItems { get; set; }


        public DbSet<Product> Products { get; set; }
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

        public DbSet<Roles> roles { get; set; }
        public DbSet<Users> users { get; set; }
        public DbSet<File> packages { get; set; }  
        public DbSet<Connection> connections { get; set; }



        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = _currentUserService.UserId;
                        entry.Entity.Created = _dateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedBy = _currentUserService.UserId;
                        entry.Entity.LastModified = _dateTime.Now;
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
