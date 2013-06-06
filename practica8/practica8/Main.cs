using System;
using Gtk;

namespace practica8
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			practica8 acciones = new practica8();
			acciones.seleccionar();
			acciones.insertar();
			acciones.seleccionar();
			acciones.Editar();
			acciones.seleccionar();
			acciones.Eliminar();
			acciones.seleccionar();
		}
	}
}
