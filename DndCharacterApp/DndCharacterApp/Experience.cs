//first version: 07/09/25
//programmer: George Shapka
namespace DndCharacterApp
{
	internal class Experience
	{

		public static int[] XpAtLevel = new int[20] 
		{ 
			0,//1
			300,//2
			900,//3
			1700,//4
			6500,//5
			14000,//6
			23000,//7
			34000,//8
			48000,//9
			64000,//10
			85000,//11
			100000,//12
			120000,//13
			140000,//14
			165000,//15
			195000,//16
			225000,//17
			265000,//18
			305000,//19
			355000//20
		};

		/// <summary>
		/// returns the equivalent xp of the level
		/// </summary>
		/// <param name="level"></param>
		/// <returns></returns>
		public static int LevelToXp(int level)
		{
			switch (level)
			{
				case 1: return XpAtLevel[0];
				case 2: return XpAtLevel[1];
				case 3: return XpAtLevel[2];
				case 4: return XpAtLevel[3];
				case 5: return XpAtLevel[4];
				case 6: return XpAtLevel[5];
				case 7: return XpAtLevel[6];
				case 8: return XpAtLevel[7];
				case 9: return XpAtLevel[8];
				case 10: return XpAtLevel[9];
				case 11: return XpAtLevel[10];
				case 12: return XpAtLevel[11];
				case 13: return XpAtLevel[12];
				case 14: return XpAtLevel[13];
				case 15: return XpAtLevel[14];
				case 16: return XpAtLevel[15];
				case 17: return XpAtLevel[16];
				case 18: return XpAtLevel[17];
				case 19: return XpAtLevel[18];
				case 20: return XpAtLevel[19];
				default: return 0;
			}//end of switch

		}//end of method

		/// <summary>
		/// returns the equivalent level of the xp
		/// </summary>
		/// <param name="xp"></param>
		/// <returns></returns>
		public static int XpToLevel(int xp)
		{
			switch (xp)
			{
				case int n when (XpAtLevel[0] <= n && n < XpAtLevel[1]): return 1;
				case int n when (XpAtLevel[1] <= n && n < XpAtLevel[2]): return 2;
				case int n when (XpAtLevel[2] <= n && n < XpAtLevel[3]): return 3;
				case int n when (XpAtLevel[3] <= n && n < XpAtLevel[4]): return 4;
				case int n when (XpAtLevel[4] <= n && n < XpAtLevel[5]): return 5;
                case int n when (XpAtLevel[5] <= n && n < XpAtLevel[6]): return 6;
                case int n when (XpAtLevel[6] <= n && n < XpAtLevel[7]): return 7;
                case int n when (XpAtLevel[7] <= n && n < XpAtLevel[8]): return 8;
                case int n when (XpAtLevel[8] <= n && n < XpAtLevel[9]): return 9;
                case int n when (XpAtLevel[9] <= n && n < XpAtLevel[10]): return 10;
                case int n when (XpAtLevel[10] <= n && n < XpAtLevel[11]): return 11;
                case int n when (XpAtLevel[11] <= n && n < XpAtLevel[12]): return 12;
                case int n when (XpAtLevel[12] <= n && n < XpAtLevel[13]): return 13;
                case int n when (XpAtLevel[13] <= n && n < XpAtLevel[14]): return 14;
                case int n when (XpAtLevel[14] <= n && n < XpAtLevel[15]): return 15;
                case int n when (XpAtLevel[15] <= n && n < XpAtLevel[16]): return 16;
                case int n when (XpAtLevel[16] <= n && n < XpAtLevel[17]): return 17;
                case int n when (XpAtLevel[17] <= n && n < XpAtLevel[18]): return 18;
                case int n when (XpAtLevel[18] <= n && n < XpAtLevel[19]): return 19;
                case int n when (XpAtLevel[19] <= n && n <= XpAtLevel[19]): return 20;
				default: return 1;
            }//end of switch
		}//end of method

	}//end of class
}
