namespace Microsoft.EntityFrameworkCore.Query
{
    public abstract class QueryFilterFuncletizationFixtureBase : SharedStoreFixtureBase<QueryFilterFuncletizationContext>
    {
        protected override string StoreName { get; } = "QueryFilterFuncletizationTest";

        protected override void Seed(QueryFilterFuncletizationContext context)
            => QueryFilterFuncletizationContext.SeedData(context);
    }
}
