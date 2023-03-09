using SymetriskKrytpering;
using System.Text;

//Setup encrytion and decryption
var encryptionAES = new AESEncryption();
var encryptionDES = new DESEncrytion();
var encryptionTripleDES = new TripleDESEncryption();

var randomNumberGenerator = new RandomNumberGenerator();
var textToEncrptingAES = "Dette er min AES kryptering";
var textToEncrptingDES = "Dette er min DES kryptering";
var textToEncrpting3DES = "Dette er min 3DES kryptering";

//AES Encryption start
var keyAES = randomNumberGenerator.GenerateRandomNumber(32);
var ivAES = randomNumberGenerator.GenerateRandomNumber(16);

var encryptedAES = encryptionAES.Encrypt(Encoding.UTF8.GetBytes(textToEncrptingAES), keyAES, ivAES);
var decryptedAES = encryptionAES.Decrypt(encryptedAES, keyAES, ivAES);

var decryptedMessageAES = Encoding.UTF8.GetString(decryptedAES);

//cosnole 
Console.WriteLine("Original Text: " + textToEncrptingAES);
Console.WriteLine("AES Krypteret Text: " + Convert.ToBase64String(encryptedAES));
Console.WriteLine("Dekrypteret Text: " + decryptedMessageAES);
//AES Encryption end
Console.WriteLine(" ");
//DES Encryption start
var keyDES = randomNumberGenerator.GenerateRandomNumber(8);
var ivDES = randomNumberGenerator.GenerateRandomNumber(8);

var encryptedDES = encryptionDES.Encrypt(Encoding.UTF8.GetBytes(textToEncrptingDES), keyDES, ivDES);
var decryptedDES = encryptionDES.Decrypt(encryptedDES, keyDES, ivDES);

var decryptedMessageDES = Encoding.UTF8.GetString(decryptedDES);

//cosnole 
Console.WriteLine("Original Text: " + textToEncrptingDES);
Console.WriteLine("DES Krypteret Text: " + Convert.ToBase64String(encryptedDES));
Console.WriteLine("Dekrypteret Text: " + decryptedMessageDES);
//DES Encryption end

Console.WriteLine(" ");
//DES Encryption start
var key3DES = randomNumberGenerator.GenerateRandomNumber(16);
var iv3DES = randomNumberGenerator.GenerateRandomNumber(8);

var encrypted3DES = encryptionTripleDES.Encrypt(Encoding.UTF8.GetBytes(textToEncrpting3DES), key3DES, iv3DES);
var decrypted3DES = encryptionTripleDES.Decrypt(encrypted3DES, key3DES, iv3DES);

var decryptedMessage3DES = Encoding.UTF8.GetString(decrypted3DES);

//cosnole 
Console.WriteLine("Original Text: " + textToEncrpting3DES);
Console.WriteLine("DES Krypteret Text: " + Convert.ToBase64String(encrypted3DES));
Console.WriteLine("Dekrypteret Text: " + decryptedMessage3DES);
//DES Encryption end

