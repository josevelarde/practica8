using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.ComponentModel;

using System.Collections;

namespace practica8
{
	public class MySQL
	{
		protected MySqlConnection MyConnection;
		public MySQL ()
		{
		}
		
		protected void abrirConexion(){
			string connectionString =
				"Server=localhost;" +
					"Database=videojuegos;" +
					"User ID=videojuegos;" +
					"Password=videojuegos;" +
					"Pooling=false;";
			this.MyConnection = new MySqlConnection(connectionString);
			this.MyConnection.Open();
		}
		
		protected void cerrarConexion(){
			this.MyConnection.Close(); 
			this.MyConnection = null;
		}
	}
}