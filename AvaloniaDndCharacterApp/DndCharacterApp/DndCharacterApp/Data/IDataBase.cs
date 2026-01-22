using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndCharacterApp.Objects.Player;

namespace DndCharacterApp.Data
{
    /*
	 * FILE : IDataBase.cs
	 * PROJECT : $safeprojectname$
	 * PROGRAMMER : George Shapka
	 * FIRST VERSION : 1/21/2026 7:53:19 PM
	 */
    public interface IDataBase
    {
        Task<IReadOnlyList<Player_NonStatic>> GetAllAsync();
        Task<Player_NonStatic?> GetByIdAsync(int id);
        Task<int> InsertAsync(Player_NonStatic player);
        Task UpdateAsync(Player_NonStatic player);
        Task DeleteAsync(int id);
    }//end of IDataBase

}//end of DndCharacterApp.Data