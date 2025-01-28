using QRCoder;

namespace CheckTotpCode;

public class QrGenerator
{
    public byte[] GenerateQr(string app, string user, string secretKey)
    {
        var qrContent = $"otpauth://totp/{app}:{user}?secret={secretKey}&issuer={app}";

        using var qrGenerator = new QRCodeGenerator();
        var qrCodeData = qrGenerator.CreateQrCode(qrContent, QRCodeGenerator.ECCLevel.Q);
        var qrCode = new BitmapByteQRCode(qrCodeData);
        byte[] qrCodeImage = qrCode.GetGraphic(20); // Байты изображения для фронтенда
        return qrCodeImage;
    }
}