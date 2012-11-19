using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CADAgenda1;

namespace CLNAgenda1
{
    public class SprintCLN
    {
        ScrumBDModelContainer contexto = new ScrumBDModelContainer();
        public SprintCLN()
        {
        }

        public void crearSprint(Sprint s)
        {
            contexto.AddToSprints(s);
            contexto.SaveChanges();
        }

        public void eliminarSprint(Sprint s)
        {
            contexto.Sprints.DeleteObject(s);
            contexto.SaveChanges();
        }

        public void modificarSprint(Sprint s)
        {
            contexto.Sprints.ApplyCurrentValues(s);
            contexto.SaveChanges();
        }

        public List<Sprint> listarSprints()
        {
            var s = contexto.Sprints;
            return s.ToList();
        }

        public Sprint buscarSprint(int id)
        {
            Sprint s = new Sprint();
            s = contexto.Sprints.FirstOrDefault(consulta => consulta.id == id);
            return s;
        }

        public Sprint getSprintActivo(int idP, String estado)
        {
            Sprint s = new Sprint();
            s = contexto.Sprints.FirstOrDefault(consulta => consulta.Proyecto_id == idP && consulta.Estado == estado);
            return s;
        }

        public Sprint buscarSprintEstado(String estado)
        {
            Sprint s = new Sprint();
            s = contexto.Sprints.FirstOrDefault(consulta => consulta.Estado == estado);
            return s;
        }
    }
}
