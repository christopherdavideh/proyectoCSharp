using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Alumno : ObjetoEscuelaBase
    {
        //No los uso aqui xq ya heredan de la clase ObjetoEscuelaBase
        //public string UniqueId { get; private set; }
        //public string Nombre { get; set; }

        public List<Evaluacion> Evaluaciones { get; set; } = new List<Evaluacion>();

        //public Alumno() => UniqueId = Guid.NewGuid().ToString();
    }
}