namespace wcf.Domain.Entities
{
    public class RoleUserDomain
    {
        public int RoleUserId { get; set; }
        public int RoleId { get; set; }
        public int UsuariosId { get; set; }

        public virtual UsuariosDomain Usuarios { get; set; }
        public virtual RoleDomain Role { get; set; }
    }
}
