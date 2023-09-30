
using System;
using System.Collections;
using System.Collections.Generic;
namespace Clase_I_complijidad
{
	class Program
	{
		public static void Main(string[] args)
		{
		ArbolBinario<int> ArbolBinarioRaiz = new ArbolBinario<int>(8);
		
		ArbolBinario<int> HijoIzquierdoN2 = new ArbolBinario<int>(5);
		ArbolBinario<int> HijoDerechoN2 = new ArbolBinario<int>(22);
		
		ArbolBinario<int> HijoIzquierdoN3 = new ArbolBinario<int>(6);
		ArbolBinario<int> HijoDerechoN3 = new ArbolBinario<int>(18);
		
		ArbolBinario<int> HijoIzquierdoN4 = new ArbolBinario<int>(7);
		
		//agrego un hijo mas
		
		

		
		ArbolBinarioRaiz.agregarHijoIzquierdo(HijoIzquierdoN2);
		ArbolBinarioRaiz.agregarHijoDerecho(HijoDerechoN2);
		
		
		HijoDerechoN2.agregarHijoDerecho(HijoDerechoN3);
		HijoDerechoN2.agregarHijoIzquierdo(HijoIzquierdoN3);
		
		HijoIzquierdoN3.agregarHijoIzquierdo(HijoIzquierdoN4);
		
		//agrego un nivel 3
		
		
		
		
		
		
		
		/*Console.Write("Recorrido preorden: ");
		ArbolBinarioRaiz.preorden();
		Console.WriteLine(" ");
		
		Console.Write("Recorrido inorden: ");
		ArbolBinarioRaiz.inorden();
		Console.WriteLine(" ");
		
		Console.Write("Recorrido postorden: ");
		ArbolBinarioRaiz.postorden();
		Console.WriteLine(" ");
		
		Console.Write("Recorrido por niveles: ");
		ArbolBinarioRaiz.recorridoPorNiveles();
		Console.WriteLine("");
		
		Console.Write("Recorrido entre niveles: ");
		ArbolBinarioRaiz.recorridoentreNiveles(2,2);
		Console.WriteLine("");
		
		Console.WriteLine("Recorrido con separador por nivels: ");
		ArbolBinarioRaiz.recorridoporNivelesconSeparador();
		*/
		List<int> lista = ArbolBinarioRaiz.resolver(3);
		
		Console.WriteLine("valores de lista");
		foreach (int a in lista) {
			Console.WriteLine(a);
		}
		
		Console.ReadKey(true);
		
		                                 
		                                 
		
					
		                                   
		
		
		
			
			
		}
	}
}