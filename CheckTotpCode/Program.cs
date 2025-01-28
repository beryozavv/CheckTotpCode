using OtpNet;

// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

//new SecretKeyGenerator().GenerateSecretKey();

var secretKey = "W5LIGQH5QTCK2T7KTX3VWNCOKXLAOUIC";
var app = nameof(CheckTotpCode);
var user = "bvv";

// var qrGenerator = new QrGenerator();
// qrGenerator.GenerateQr(app, user, secretKey);

var keyBytes = Base32Encoding.ToBytes(secretKey);
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
