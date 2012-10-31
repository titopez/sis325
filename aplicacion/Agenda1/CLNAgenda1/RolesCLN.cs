using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CADAgenda1;

namespace CLNAgenda1
{
    public class RolesCLN
    {
        ScrumBDModelContainer contexto = new ScrumBDModelContainer();
        public RolesCLN()
        {
        }

        public void crearRol(Rol r)
        {
            contexto.AddToRoles(r);
            contexto.SaveChanges();
        }

        public void eliminarRol(Rol r)
        {
            contexto.Roles.DeleteObject(r);
            contexto.SaveChanges();
        }

        public List<Rol> mostrar()
        {
            var roles = contexto.Roles;
            return roles.ToList();
        }
    }
}
