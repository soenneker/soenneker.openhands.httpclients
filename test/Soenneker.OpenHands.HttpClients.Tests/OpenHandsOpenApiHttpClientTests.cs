using Soenneker.OpenHands.HttpClients.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.OpenHands.HttpClients.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class OpenHandsOpenApiHttpClientTests : HostedUnitTest
{
    private readonly IOpenHandsOpenApiHttpClient _httpclient;

    public OpenHandsOpenApiHttpClientTests(Host host) : base(host)
    {
        _httpclient = Resolve<IOpenHandsOpenApiHttpClient>(true);
    }

    [Test]
    public void Default()
    {

    }
}
