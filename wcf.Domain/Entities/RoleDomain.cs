using System.Collections.Generic;

namespace wcf.Domain.Entities
{
    public class RoleDomain
    {
        public int RoleId { get; set; }
        public string Nome { get; set; }

        public ICollection<RoleUserDomain> RoleUser { get; set; }
    }
}
