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

        public List<Rol> listarRoles()
        {
            var roles = contexto.Roles;
            return roles.ToList();
        }

        public Rol getRolNombre(String nombre)
        {
            Rol r = new Rol();
            r = contexto.Roles.FirstOrDefault(consulta => consulta.NombreCompleto == nombre);
            return r;
        }

        public void modificarRol(Rol r)
        {
            contexto.Roles.ApplyCurrentValues(r);
            contexto.SaveChanges();
        }

        public Rol buscarRol(int id)
        {
            Rol r = new Rol();
            r = contexto.Roles.FirstOrDefault(consulta => consulta.id == id);
            return r;
        }
    }
}
