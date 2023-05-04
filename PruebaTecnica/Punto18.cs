

using System.Text;

namespace PruebaTecnica
{
    ///Casos de prueba en clase Program
    public class Punto18
    {
        public static string ObtenerBase(int numero, int baseAConvertir)
        {
            //Guarda el valor inicial 
            int valorInicial = numero;

            StringBuilder resultado = new StringBuilder();

            if (baseAConvertir < 2) return "El número ingresado debe ser mayor a 1";
            else if (baseAConvertir == 2) return valorInicial + " en base " + baseAConvertir + " es: " + Convert.ToString(numero, 2);

            //Guarda en un StringBuilder el residuo y le cambia el valor a la varia a con el cociente para retornar el while.
            while (numero % baseAConvertir != 0)
            {
                resultado.Append(numero % baseAConvertir);
                numero = numero / baseAConvertir;
            }

            //Despues de que la divison entre el número y la base de uno, guarda el residuo y el cociente
            resultado.Append(numero % baseAConvertir);
            resultado.Append(numero / baseAConvertir);

            //el valor guardado en "resultado" lo devuelve en reversa ya que ese es el resultado del número convertido a la base ingresada
            char[] chars = resultado.ToString().ToCharArray();
            Array.Reverse(chars);
            string valorEnReversa = new string(chars);

            //Texto de retorno.
            return valorInicial + " en base " + baseAConvertir + " es: " + int.Parse(valorEnReversa);
        }
    }
}
