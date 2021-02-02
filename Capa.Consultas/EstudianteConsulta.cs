using Capa.Datos.Entity_Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Capa.Consultas
{
    public class EstudianteConsulta
    {
        private EscuelaDbContext Db = new EscuelaDbContext();
        public List<Estudiante> GetEstudiantes()
        {
            try
            {
                return Db.Estudiantes.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Estudiante GetEstudiante(Int64 id)
        {
            try
            {
                return Db.Estudiantes.Where(x => x.Estudiante_id == id).First();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void InsertEstudiante(Estudiante estudiante)
        {
            try
            {
                Db.Estudiantes.Add(estudiante);
                Db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateEstudiante(Estudiante estudiante)
        {
            try
            {
                Db.Estudiantes.Add(estudiante);
                Db.Entry(estudiante).State = System.Data.Entity.EntityState.Modified;
                Db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteEstudiante(Int64 id)
        {
            try
            {
                Db.Estudiantes.Remove(Db.Estudiantes.Where(x => x.Estudiante_id == id).First());
                Db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
