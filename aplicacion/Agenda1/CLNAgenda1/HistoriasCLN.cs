using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CADAgenda1;

namespace CLNAgenda1
{
    public class HistoriasCLN
    {
        ScrumBDModelContainer contexto = new ScrumBDModelContainer();
        public HistoriasCLN()
        {
        }
        public void crearHistoria(Historia h)
        {
            contexto.AddToHistorias(h);
            contexto.SaveChanges();
        }
        public void eliminarHistoria(Historia h)
        {
            contexto.Historias.DeleteObject(h);
            contexto.SaveChanges();
        }

        public List<Historia> listar()
        {
            var historia = contexto.Historias;
            return historia.ToList();
        }
        public IQueryable<object> listar2()
        {
            var resultado = from consulta in contexto.Historias
                            select new { ID = consulta.id, DESCRIPCION = consulta.Descripcion,
                                PRIORIDAD = consulta.Prioridad , HABILITADO = consulta.Habilitado,
                                ID_PROYECTO = consulta.Proyecto_id};

            return resultado;
        }
    }
}
