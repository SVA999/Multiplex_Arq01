using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Multiplex.Aspectos
{
	internal class InterceptorArchivo : IInterceptor
	{
		void IInterceptor.Intercept(IInvocation invocation)
		{

			//Antes de ejecutarse, Imprimimos el metodo que invoca
			Console.WriteLine($"Método que invoca: {invocation.Method.Name}");

			//Ejecutar el metodo (Abrir el wrap)
			invocation.Proceed();

			//Validacion - Escribo que el metodo termino su ejecucion
			Console.WriteLine($"Método: {invocation.Method.Name} Ha terminado, Retornando...\n");

		}
	}
}
