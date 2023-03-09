using SymetriskKrytpering;
using System.Text;

//Setup encrytion and decryption
var encryption = new Encryption();
var key = encryption.GenerateRandomNumber(32);
var iv = encryption.GenerateRandomNumber(16);

var textToEncrpting = "Dette er den text jeg vil kryptere";

var encrypted = encryption.Encrypt(Encoding.UTF8.GetBytes(textToEncrpting), key, iv);
var decrypted = encryption.Decrypt(encrypted, key, iv);

var decryptedMessage = Encoding.UTF8.GetString(decrypted);

//cosnole
Console.WriteLine("Original Text: " + textToEncrpting);
Console.WriteLine("Krypteret Text: " + Convert.ToBase64String(encrypted));
Console.WriteLine("Dekrypteret Text: " + decryptedMessage);