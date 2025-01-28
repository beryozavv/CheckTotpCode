using CheckTotpCode;
using Xunit;
using Xunit.Abstractions;

namespace GenerateKeyQr.Tests;

public class GenerateSecretKey
{
    private readonly ITestOutputHelper _output;

    public GenerateSecretKey(ITestOutputHelper output)
    {
        _output = output;
    }
    
    [Fact]
    public void SendParamsCommandAsyncTimeoutExTest()
    {
        var secretKeyGenerator = new SecretKeyGenerator();
        var key = secretKeyGenerator.GenerateSecretKey();
        _output.WriteLine("Secret Key: {0}", key);
    }
}