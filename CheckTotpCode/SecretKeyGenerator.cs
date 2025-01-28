using OtpNet;

namespace CheckTotpCode;

public class SecretKeyGenerator
{
    public string GenerateSecretKey()
    {
        var secretKey = KeyGeneration.GenerateRandomKey(20);

// Кодирование ключа в Base32 для передачи пользователю
        string base32Key = Base32Encoding.ToString(secretKey);
        Console.WriteLine($"Секретный ключ (Base32): {base32Key}");
        
        return base32Key;
    }
}