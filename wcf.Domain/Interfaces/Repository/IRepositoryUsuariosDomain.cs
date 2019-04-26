using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wcf.Domain.Entities;

namespace wcf.Domain.Interfaces.Repository
{
    public interface IRepositoryUsuariosDomain:IRepositoyBaseDomain<UsuariosDomain>
    {
        /// <summary>
        /// Busca Usuário por Nome
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        IEnumerable<UsuariosDomain> GetByUserName(string userName);
    }
}
