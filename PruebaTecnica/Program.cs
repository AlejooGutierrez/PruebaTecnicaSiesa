using PruebaTecnica;
using static PruebaTecnica.Punto19;



Console.WriteLine("\nTesting Punto 17 \n");
Console.WriteLine(Punto17.Dividir(5,3));



Console.WriteLine("\nTesting Punto 18 \n");
Console.WriteLine(Punto18.ObtenerBase(287, 1));
Console.WriteLine(Punto18.ObtenerBase(287, 2));
Console.WriteLine(Punto18.ObtenerBase(287, 3));
Console.WriteLine(Punto18.ObtenerBase(287, 4));
Console.WriteLine(Punto18.ObtenerBase(287, 5));
Console.WriteLine(Punto18.ObtenerBase(287, 6));
Console.WriteLine(Punto18.ObtenerBase(287, 7));
Console.WriteLine(Punto18.ObtenerBase(287, 8));
Console.WriteLine(Punto18.ObtenerBase(287, 9));
Console.WriteLine(Punto18.ObtenerBase(287, 10));




Console.WriteLine("\nTesting Punto 19 \n");

//Forma uno agregando directamenete el arbol /*No funcionaría de forma adecuada esta forma ya que no se puede agregar un subArbol a un subArbol ya creado*/
Console.WriteLine("Forma 1");

Arbol f1Arbol = new Arbol(10);
Arbol f1Arbol2 = new Arbol(7);
Arbol f1Arbol3 = new Arbol(5,16);

f1Arbol.AgregarSubArbol(new Arbol(2));
f1Arbol2.AgregarSubArbol(new Arbol(3));
f1Arbol3.AgregarSubArbol(new Arbol(1,165));

double pesoTotal1 = f1Arbol.CalcularPeso();
Console.WriteLine("El peso total del árbol 1 forma 1 es: " + pesoTotal1);
Console.WriteLine("La áltura del árbol 1 forma 1 es: " + f1Arbol.ObtenerAltura());
Console.WriteLine("La áltura del subarbol del árbol 1 forma 1 es: " + f1Arbol.subarboles[0].ObtenerAltura());
Console.WriteLine("El promedio del peso del árbol 1 forma 1 es: " + f1Arbol.CalcularPesoPromedio());


double pesoTotal2 = f1Arbol2.CalcularPeso();
Console.WriteLine("El peso total del árbol 2 forma 1 es: " + pesoTotal2);
Console.WriteLine("La áltura del árbol 2 forma 1 es: " + f1Arbol2.ObtenerAltura());
Console.WriteLine("La áltura del subarbol del árbol 2 forma 1 es: " + f1Arbol2.subarboles[0].ObtenerAltura());
Console.WriteLine("El promedio del peso del árbol 2 forma 1 es: " + f1Arbol2.CalcularPesoPromedio());


double pesoTotal3 = f1Arbol3.CalcularPeso();
Console.WriteLine("El peso total del árbol 3 forma 1 es: " + pesoTotal3);
Console.WriteLine("La áltura del árbol 3 forma 1 es: " + f1Arbol3.ObtenerAltura());
Console.WriteLine("La áltura del subarbol del árbol 3 forma 1 es: " + f1Arbol3.subarboles[0].ObtenerAltura());
Console.WriteLine("El promedio del peso del árbol 3 forma 1 es: " + f1Arbol3.CalcularPesoPromedio());


//Forma dos, creando los subarboles primero y luego relacionarlos al arbol padre. Aquí es posible agregar los niveles de subarboles necesarios
Console.WriteLine("\nForma 2");
Arbol f2Arbol = new Arbol(10);
Arbol f2Arbol2 = new Arbol(7);
Arbol f2Arbol3 = new Arbol(5);

Arbol f2SubArbol = new Arbol(5,45);
Arbol f2SubArbol2 = new Arbol(10,235);
Arbol f2SubArbol3 = new Arbol(7,454);

Arbol f2SubSubArbol = new Arbol(50, 450);
Arbol f2SubSubArbol2 = new Arbol(100, 2035);
Arbol f2SubSubArbol3 = new Arbol(70, 4054);

f2Arbol.AgregarSubArbol(f2SubArbol);
f2Arbol2.AgregarSubArbol(f2SubArbol2);
f2Arbol3.AgregarSubArbol(f2SubArbol3);

f2SubArbol.AgregarSubArbol(f2SubSubArbol);
f2SubArbol2.AgregarSubArbol(f2SubSubArbol2);
f2SubArbol3.AgregarSubArbol(f2SubSubArbol3);

double f2pesoTotal1 = f2Arbol.CalcularPeso();
Console.WriteLine("El peso total del árbol 1 forma 2 es: " + f2pesoTotal1);
Console.WriteLine("La áltura del árbol 1 forma 2 es: " + f2Arbol.ObtenerAltura());
Console.WriteLine("La áltura del subarbol del árbol 1 forma 2 es: " + f2Arbol.subarboles[0].ObtenerAltura());
Console.WriteLine("El promedio del peso del árbol 1 forma 2 es: " + f2Arbol.CalcularPesoPromedio());


double f2pesoTotal2 = f2Arbol2.CalcularPeso();
Console.WriteLine("El peso total del árbol 2 forma 2 es: " + f2pesoTotal2);
Console.WriteLine("La áltura del árbol 2 forma 2 es: " + f2Arbol2.ObtenerAltura());
Console.WriteLine("La áltura del subarbol del árbol 2 forma 2 es: " + f2Arbol2.subarboles[0].ObtenerAltura());
Console.WriteLine("El promedio del peso del árbol 2 forma 2 es: " + f2Arbol2.CalcularPesoPromedio());


double f2pesoTotal3 = f2Arbol3.CalcularPeso();
Console.WriteLine("El peso total del árbol 3 forma 2 es: " + f2pesoTotal3);
Console.WriteLine("La áltura del árbol 3 forma 2 es: " + f2Arbol3.ObtenerAltura());
Console.WriteLine("La áltura del subarbol del árbol 3 forma 2 es: " + f2Arbol3.subarboles[0].ObtenerAltura());
Console.WriteLine("El promedio del peso del árbol 3 forma 2 es: " + f2Arbol3.CalcularPesoPromedio());


//double pesoTotal = arbol.CalcularPeso();
//Console.WriteLine("El peso total del árbol es: " + pesoTotal);


Console.ReadLine();

