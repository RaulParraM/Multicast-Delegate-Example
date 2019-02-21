using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate
{
    public delegate void MiDelegadoMultiCast(int i);
    class Test
    {
        public static void Main()
        {
            MiClase miClase = new MiClase();

            // instanciamos un delegado. Observa que el método MiMetodo1 de la clase 
            // MiClase cumple con la firma definida en el delegado
            MiDelegadoMultiCast delegado = miClase.MiMetodo1;
            delegado(83); // Se hace la llamada al delegado

            // agregamos ahora el Metodo2 
            delegado += miClase.MiMetodo2;
            // Se hace la llamada al delegado y se ejecutarán en orden secuencial ambos métodos
            delegado(55);

            // eliminamos ahora el Metodo1 
            delegado -= miClase.MiMetodo1;
            // Se hace la llamada al delegado y se ejecutará únicamente el Método2
            delegado(14);
 
        }
    }
}
