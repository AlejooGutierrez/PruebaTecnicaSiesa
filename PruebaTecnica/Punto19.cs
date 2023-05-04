using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica
{
    ///Casos de prueba en clase Program
    public class Punto19
    {

        public class Arbol
        {
            //Variables
            double pesoDelArbol;
            int alturaDelArbol = 1;
            Arbol raizDeDondeViene = null;
            public List<Arbol> subarboles;
            //int count = 1;

            //Constructores
            public Arbol(int peso)
            {
                pesoDelArbol = peso;
                subarboles = new List<Arbol>();
            }
            public Arbol(int peso, int altura)
            {
                pesoDelArbol = peso;
                subarboles = new List<Arbol>();
                alturaDelArbol = altura;
            }

            //Metodos
            public int ObtenerAltura()
            {
                //En caso de no tener altura asignada retorna 0
                if (alturaDelArbol == 0) return 0;
                return this.alturaDelArbol;
            }
            public void AgregarSubArbol(Arbol subarbol)
            {
                //Agrega el arból papá a la raíz del hijo 
                subarbol.raizDeDondeViene = this;
                subarboles.Add(subarbol);
            }

            public double CalcularPeso()
            {
                double pesoTotal = this.pesoDelArbol;

                //Recorre los subarboles encontrados y retorna la sumatoria total encontrada y de forma recursiva usa este mismo metodo con los subarboles de los subarboles encontrados
                foreach (Arbol subarbol in this.subarboles)
                {
                    pesoTotal += subarbol.CalcularPeso();
                }
                return pesoTotal;
            }

            public int obtenerCantidadArboles()
            {
                int contador = 1; 
                //Similar al anterior metodo, de forma recursiva obtiene la cantidad de arboles
                foreach (var subarbol in subarboles)
                {
                    contador += subarbol.obtenerCantidadArboles(); 
                }
                return contador;
            }

            public double CalcularPesoPromedio()
            {
                //Obtiene el peso y la cantidad de arboles y las divide obteniendo el promedio.
                double pesoTotal = this.CalcularPeso();
                int totalArboles = this.obtenerCantidadArboles();

                return pesoTotal / totalArboles;
            }
        }


    }
}
