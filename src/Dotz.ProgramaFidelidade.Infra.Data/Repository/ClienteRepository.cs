using Dotz.ProgramaFidelidade.Domain.Interface;
using Dotz.ProgramaFidelidade.Domain.Models.ClienteContext;
using Dotz.ProgramaFidelidade.Infra.Data.Context;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Dotz.ProgramaFidelidade.Infra.Data.Repository
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        protected new readonly DotzContext db;

        public ClienteRepository(DotzContext _db) : base(_db)
        {
            db = _db;
        }

        public async Task<Cliente> ValidarCredenciais(Cliente cliente)
        {
            var pass = ComputeHash(cliente.Password, new SHA256CryptoServiceProvider());
            return await Task.FromResult(db.Set<Cliente>().FirstOrDefault(p => p.Email.Equals(cliente.Email) && p.Password.Equals(pass)));
        }

        private string ComputeHash(string input, SHA256CryptoServiceProvider algorithm)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashedBytes = algorithm.ComputeHash(inputBytes);
            return BitConverter.ToString(hashedBytes);
        }
    }
}