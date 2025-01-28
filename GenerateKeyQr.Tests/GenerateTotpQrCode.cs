using CheckTotpCode;
using Xunit;
using Xunit.Abstractions;

namespace GenerateKeyQr.Tests;

public class GenerateTotpQrCode
{
    private readonly ITestOutputHelper _output;

    public GenerateTotpQrCode(ITestOutputHelper output)
    {
        _output = output;
    }
    
    [Fact]
    public void GenerateQrCode()
    {
        var qrGenerator = new QrGenerator();
        var generatedQr = qrGenerator.GenerateQr(TestConstants.App, TestConstants.User, TestConstants.SecretKey);
        File.WriteAllBytes("..\\..\\..\\qrCode.png", generatedQr);
    }
}