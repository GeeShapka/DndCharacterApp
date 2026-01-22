using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace DndCharacterApp.Data
{
	/*
	 * FILE : DbConnectionFactory.cs
	 * PROJECT : $safeprojectname$
	 * PROGRAMMER : George Shapka
	 * FIRST VERSION : 1/21/2026 7:53:35 PM
	 */
	internal class DbConnectionFactory
	{
		private readonly string _connectionString;

		public DbConnectionFactory(string connectionString)
		{
			_connectionString = connectionString;
		}


		public void Initialize()
		{
			using var connection = new SqliteConnection(_connectionString);
			connection.Open();

			using var cmd = connection.CreateCommand();

			cmd.CommandText = """
				CREATE TABLE IF NOT EXISTS characters (
				id INTEGER PRIMARY KEY,
				name TEXT NOT NULL
				);
				""";

			cmd.ExecuteNonQuery();
		}


		/// <summary>
		/// creates a connection to the database
		/// </summary>
		/// <returns></returns>
		public SqliteConnection Create()
		{
			var connection = new SqliteConnection(_connectionString);
			connection.Open();

			using var cmd = connection.CreateCommand();
			cmd.CommandText = "PRAGMA foreign_keys = ON;";
			cmd.ExecuteNonQuery();

			return connection;
		}
	}//end of DbConnectionFactory

}//end of DndCharacterApp.Data