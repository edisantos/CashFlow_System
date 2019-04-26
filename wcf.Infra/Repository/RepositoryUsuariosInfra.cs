using System;
using System.Collections.Generic;
using wcf.Domain.Entities;
using wcf.Domain.Interfaces.Repository;

namespace wcf.Infra.Repository
{
    public class RepositoryUsuariosInfra : ReposiotyBaseInfra<UsuariosDomain>,IRepositoryUsuariosDomain
    {
        public IEnumerable<UsuariosDomain> GetByUserName(string userName)
        {
            throw new NotImplementedException();
        }
    }
}
