using Humour.Respository;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Humour.Tests.Integration
{
    public class IntegrationTestBase
    {
        internal IntegrationTestBase()
        {
            Database.DefaultConnectionFactory = new SqlConnectionFactory("Data Source=(localdb)\\v11.0; Integrated Security=True; MultipleActiveResultSets=True");
            HumourContextInitializer.Init(true);
        }
    }
}
