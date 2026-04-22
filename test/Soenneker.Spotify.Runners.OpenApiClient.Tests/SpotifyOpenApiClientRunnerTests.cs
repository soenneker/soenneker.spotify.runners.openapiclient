using Soenneker.Tests.HostedUnit;

namespace Soenneker.Spotify.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class SpotifyOpenApiClientRunnerTests : HostedUnitTest
{
    public SpotifyOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
