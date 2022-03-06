using System;
using System.Collections.Generic;
using System.Text;

namespace CoreEscuela.Entidades
{
    public abstract class ObjetoEscuelaBase
    {
        //Abstract hace que la clase no se pueda instanciar, unicamente q hereden sus propiedades
        public string UniqueId { get; private set; } = Guid.NewGuid().ToString();
        public string Nombre { get; set; }

        //Se puede inicializar el Guid desde el constructor o desde la propiedad
        /*public ObjetoEscuelaBase()
        {
            UniqueId = Guid.NewGuid().ToString();
        }*/
    }
}
