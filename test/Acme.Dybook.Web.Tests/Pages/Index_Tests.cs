using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Acme.Dybook.Pages
{
    public class Index_Tests : DybookWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
