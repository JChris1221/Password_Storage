using Password_Storage.Core.Models;
using Password_Storage.Core.Utilities;

namespace Password_Storage.Core.Interfaces.Utilities
{
    public interface ICRSPManager
    {
        List<Account> Accounts { get; set; }
        CrispyEncrypt Encryptor { get; }
        bool Add(Account _account);
        bool Delete(Account _account);
        bool Delete(int id);
        Account Get(int id);
        List<Account> Load(string filename, byte[] key);
        bool Save(string filename, List<Account> accounts, byte[] key);
        bool Update(Account _account);
    }
}