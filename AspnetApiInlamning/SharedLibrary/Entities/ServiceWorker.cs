using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;


namespace SharedLibrary.Entities
{
    public partial class ServiceWorker
    {
        public ServiceWorker()
        {
            ErrandIssues = new HashSet<ErrandIssue>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public virtual ICollection<ErrandIssue> ErrandIssues { get; set; }


        public void CreatePasswordWithHash(string password)
        {
            using (var hmac = new HMACSHA512())
            {
                PasswordSalt = hmac.Key;
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }


        public bool ValidatePasswordHash(string password)
        {
            using (var hmac = new HMACSHA512(PasswordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != PasswordHash[i])
                        return false;
                }
            }

            return true;
        }
    }
}
