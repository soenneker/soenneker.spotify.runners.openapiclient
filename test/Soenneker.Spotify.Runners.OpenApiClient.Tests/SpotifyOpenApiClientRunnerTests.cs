using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Spotify.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class SpotifyOpenApiClientRunnerTests : FixturedUnitTest
{
    public SpotifyOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
