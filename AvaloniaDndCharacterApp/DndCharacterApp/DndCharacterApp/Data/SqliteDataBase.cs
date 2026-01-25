using DndCharacterApp.Objects.Player;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tmds.DBus.Protocol;

namespace DndCharacterApp.Data
{
    /*
	 * FILE : SqliteDataBase.cs
	 * PROJECT : $safeprojectname$
	 * PROGRAMMER : George Shapka
	 * FIRST VERSION : 1/21/2026 7:53:50 PM
	 */
    internal class SqliteDataBase : IDataBase
    {
		private readonly DbConnectionFactory _factory;


		public SqliteDataBase(DbConnectionFactory factory)
		{
			_factory = factory;
		}



		public async Task<IReadOnlyList<Player_NonStatic>> GetAllAsync()
		{
			List<Player_NonStatic> result = new List<Player_NonStatic>();
			using SqliteConnection connection = _factory.Create(); 
			using SqliteCommand cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM players;";

			using var reader = await cmd.ExecuteReaderAsync();
			while(await reader.ReadAsync())
			{
				result.Add(ReadPlayer(reader));
			}
			return result;
        }



        public async Task<Player_NonStatic?> GetByIdAsync(int id)//update to use data of creation and name as pk
        {
            using var connection = _factory.Create();
            using var cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM characters WHERE id = $id;";
            cmd.Parameters.AddWithValue("$id", id);

            using var reader = await cmd.ExecuteReaderAsync();
            return await reader.ReadAsync()
                ? ReadPlayer(reader)
                : null;
        }



        public async Task<int> InsertAsync(Player_NonStatic c)
        {
            using var connection = _factory.Create();
            using var cmd = connection.CreateCommand();

            cmd.CommandText = "INSERT INTO characters (name) VALUES ($name);";

            Bind(cmd, c);

            return Convert.ToInt32(await cmd.ExecuteScalarAsync());
        }



        public async Task UpdateAsync(Player_NonStatic c)
        {
            using var connection = _factory.Create();
            using var cmd = connection.CreateCommand();

            cmd.CommandText = "UPDATE characters SETname = $name WHERE id = $id;";

            Bind(cmd, c);
            //cmd.Parameters.AddWithValue("$id", c.Id);

            await cmd.ExecuteNonQueryAsync();
        }



        public async Task DeleteAsync(int id)
        {
            using var connection = _factory.Create();
            using var cmd = connection.CreateCommand();

            cmd.CommandText = "DELETE FROM characters WHERE id = $id;";
            cmd.Parameters.AddWithValue("$id", id);

            await cmd.ExecuteNonQueryAsync();
        }



        private static void Bind(SqliteCommand cmd, Player_NonStatic c)
        {
            cmd.Parameters.AddWithValue("$name", c.CharacterName);
        }



        private static Player_NonStatic ReadPlayer(SqliteDataReader r)
        {
			return new Player_NonStatic
			{
				//Id = r.GetInt32(r.GetOrdinal("id")),
				CharacterName = r.GetString(r.GetOrdinal("name")),
			};
        }

    }//end of SqliteDataBase

}//end of DndCharacterApp.Data