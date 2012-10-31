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

    }
}
