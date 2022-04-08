using NUnit.Framework;
using System.Threading.Tasks;
using static Testing;

namespace EAProductService.Application.IntegrationTests
{
    public class TestBase
    {
        [SetUp]
        public async Task TestSetUp()
        {
            await ResetState();
        }
    }
}
