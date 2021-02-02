using Capa.Datos.Entity_Framework;
using Capa.Logica;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;

namespace EscuelaWebAPI.Controllers
{
    public class EstudianteController : ApiController
    {
        EstudianteLogica Logica = new EstudianteLogica();

        // GET: api/Estudiante
        public IEnumerable<Estudiante> Get()
        {
            return Logica.GetEstudiantes();
        }

        // GET: api/Estudiante/5
        public Estudiante Get(Int64 estudiante_id)
        {
            return Logica.GetEstudiante(estudiante_id);
        }

        // POST: api/Estudiante
        public string Post([FromBody]Estudiante estudiante)
        {
            return Logica.InsertEstudiante(estudiante);
        }

        // PUT: api/Estudiante
        public string Put([FromBody]Estudiante estudiante)
        {
            return Logica.UpdateEstudiante(estudiante);
        }

        // DELETE: api/Estudiante/5
        public JsonResult<string> Delete(Int64 estudiante_id)
        {
            Logica.DeleteEstudiante(estudiante_id);
            string response = "Eliminado";
            return Json(response);
        }
    }
}
