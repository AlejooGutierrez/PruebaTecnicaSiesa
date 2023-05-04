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
            int alturaDelArbol = 0;
            Arbol raizDeDondeViene = null;
            public List<Arbol> subarboles;

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

            public double CalcularPesoPromedio()
            {
                double pesoTotal = this.pesoDelArbol;
                int count = 1;

                //similar a la función anterior, solo que suma la cantidad de iteraciones para saber cuantos arboles y subarboles fuerón tenidos en cuenta para la suma y así sacar el promedio
                foreach (Arbol subarbol in this.subarboles)
                {
                    pesoTotal += subarbol.CalcularPesoPromedio();
                    count++;
                }
                return pesoTotal / count;
            }
        }


    }
}
