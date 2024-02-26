using System;
namespace _1AppNET
{
	class TrianguloPascal
	{
		static void Main(string[] args)
		{
			int pisos = 0;
			int[] arreglo = new int[1];

			//mostramos un mensaje y capturamos el dato ingresado desde la consola

			Console.WriteLine("Ingrese el número de pisos: ");
			pisos = Convert.ToInt16(Console.ReadLine());

			/* declaramos el primer ciclo forque va a recorrer dependiendo el dato ingresado en pisos */
			for(int i = 0; i < pisos; i++)
			{
				int[] pascal = new int[i]; //esto es lo alto que será el triangulo

				//Se ejecuta el segundo for j que se decrementa para formar el triangulo
				for(int j = pisos; j < i; j--)
				{
					Console.Write(" ");
				}

				//Ciclo for que genera las suma de las cifras
				for(int k = 0; k < i;k++)
				{

					//se agrega una condicion ue evaluará la variable del ciclo for k incial
					if (k == 0 || k == (i - 1))
					{
						pascal[k] = 1;
					}
					else
					{
						//sumamos los numeros de cada posicion del arreglo para formar el triangulo
						pascal[k] = arreglo[k] + arreglo[k - 1];
					}

					Console.Write("[" + pascal[k] + "]");
				} //OJITO que al salir del for que suma las cifras, k vuelve a iterarse con valor k = 0;


				arreglo = pascal;
				Console.WriteLine(" ");

			}

			Console.ReadLine();
		}
	}
}
// ten en cuenta, para entender el ejercicio
// arreglo[i] = son las colummnas (vertical) de la matriz, este arreglo completo va a lo horizontal
// pascal[k] = son las columnas en una fila i especifica,
// pascal [i] = son las filas (horizontal) de la matriz, este arreglo completo va a lo vertical
// es medio confuso pero dibujandolo a lapiz y papel se entiende

