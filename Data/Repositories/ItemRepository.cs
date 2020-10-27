namespace Eraware.Modules.LanaguageTroubleshooter.Data.Repositories
{
    using Eraware.Modules.LanaguageTroubleshooter.Data.Entities;

    /// <summary>
    /// Provides access to Items data.
    /// </summary>
    public class ItemRepository : GenericRepository<Item>, IItemRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemRepository"/> class.
        /// </summary>
        /// <param name="dbContext">The module database context.</param>
        public ItemRepository(ModuleDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}