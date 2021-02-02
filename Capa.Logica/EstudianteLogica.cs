using Capa.Consultas;
using Capa.Datos.Entity_Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica
{
    public class EstudianteLogica
    {
        EstudianteConsulta Consulta = new EstudianteConsulta();
        public List<Estudiante> GetEstudiantes()
        {
            try
            {
                return Consulta.GetEstudiantes();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public Estudiante GetEstudiante(Int64 id)
        {
            try
            {
                return Consulta.GetEstudiante(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public string InsertEstudiante(Estudiante estudiante)
        {
            try
            {
                Consulta.InsertEstudiante(estudiante);
                return "Estudiante insertado correctamente";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string UpdateEstudiante(Estudiante estudiante)
        {
            try
            {
                Consulta.UpdateEstudiante(estudiante);
                return "Estudiante actualizado correctamente";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string DeleteEstudiante(Int64 id)
        {
            try
            {
                Consulta.DeleteEstudiante(id);
                return "Estudiante eliminado correctamente";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
