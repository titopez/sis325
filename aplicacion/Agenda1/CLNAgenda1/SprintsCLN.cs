using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CADAgenda1;
namespace CLNAgenda1
{
    public class SprintsCLN
    {
        ScrumBDModelContainer contexto = new ScrumBDModelContainer();
        
        public SprintsCLN()
        {

        }
        public void crearSprints(Sprint sprint)
        {
            contexto.Sprints.AddObject(sprint);
            contexto.SaveChanges();
        }
        public Sprint getid(int id)
        {
            Sprint sp = new Sprint();
            sp = contexto.Sprints.FirstOrDefault(consulta => consulta.id_Sprint == id);
            return sp;
        }
    }
}
