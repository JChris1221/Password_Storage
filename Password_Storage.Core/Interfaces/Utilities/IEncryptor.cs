namespace Password_Storage.Core.Interfaces.Utilities
{
    public interface IEncryptor
    {
        string CheckKey(byte[] key);
        string CheckKey(string key);
        byte[] Decrypt(byte[] enc_message, byte[] key);
        byte[] Encrypt(byte[] message, byte[] key);
        byte[] HashString(string key);
        string HashString_HexString(string key);
    }
}