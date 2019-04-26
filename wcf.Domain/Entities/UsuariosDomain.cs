using System;
using System.Collections.Generic;

namespace wcf.Domain.Entities
{
    public class UsuariosDomain
    {
        public int UsuariosId { get; set; }
        public DateTime DataRegistro { get; set; }
        public string Nome { get; set; }
        public string UserName { get; set; }
        public byte[] Senha { get; set; }
        public byte[] SenhaConfirmada { get; set; }

        public Guid RecuperacaoDeSenha { get; set; }
        public bool Ativo { get; set; }
        public ICollection<RoleUserDomain> RoleUser { get; set; }
    }
}
