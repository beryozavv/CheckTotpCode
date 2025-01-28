using CheckTotpCode;
using OtpNet;

Console.WriteLine("Hello, World!");

var keyBytes = Base32Encoding.ToBytes(TestConstants.SecretKey);
var totp = new Totp(keyBytes);
while (true)
{
    Console.WriteLine("Input totp code:");
    var totpCode = Console.ReadLine();
    if (totpCode == "exit")
    {
        break;
    }
    var verify = totp.VerifyTotp(totpCode, out var timeStepMatched);
    if (verify)
    {
        Console.WriteLine($"Totp code verified successfully, timeStepMatched={timeStepMatched}");
    }
    else
    {
        Console.WriteLine($"Totp code verification failed, timeStepMatched={timeStepMatched}");
    }
}
