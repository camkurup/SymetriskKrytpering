using SymetriskKrytpering;
using System.Text;

//Setup encrytion and decryption
var encryption = new AESEncryption();
var randomNumberGenerator = new RandomNumberGenerator();

//AES Encryption start
var keyAES = randomNumberGenerator.GenerateRandomNumber(32);
var ivAES = randomNumberGenerator.GenerateRandomNumber(16);

var textToEncrpting = "Dette er den text jeg vil kryptere";

var encrypted = encryption.Encrypt(Encoding.UTF8.GetBytes(textToEncrpting), keyAES, ivAES);
var decrypted = encryption.Decrypt(encrypted, keyAES, ivAES);

var decryptedMessage = Encoding.UTF8.GetString(decrypted);

//cosnole 
Console.WriteLine("Original Text: " + textToEncrpting);
Console.WriteLine("Krypteret Text: " + Convert.ToBase64String(encrypted));
Console.WriteLine("Dekrypteret Text: " + decryptedMessage);
//AES Encryption end