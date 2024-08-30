using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Attributes
{
    // La clase 'AttributePeople' representa una persona con ciertos atributos.
    public class AttributePeople
    {
        // Campo privado para el identificador de la persona.
        private int iD;
        // Campo privado para el nombre de la persona.
        private string nombre;
        // Campo privado para el apellido de la persona.
        private string apellido;
        // Campo privado para el sexo de la persona.
        private string sexo;


        /*El propósito general de estas propiedades
         Encapsulación: Ayuda a mantener el principio de encapsulación al ocultar los campos privados y exponer solo lo necesario a través de las propiedades.
         Control de Acceso: Permite agregar lógica adicional en los métodos get y set si se requiere, por ejemplo, validaciones o transformaciones de datos.*/
        public int ID { get => iD; set => iD = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Sexo { get => sexo; set => sexo = value; }
    }
}
