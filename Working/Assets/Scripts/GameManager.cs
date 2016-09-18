using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour 
{
	#region Fields

    public Player[] Players;

    public int[] Stones = new int[13] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
    
	#endregion //Fields
	
	#region Unity Methods
	
	private void Start () 
	{
		Initalize();
	}
	
	private void Update () 
	{
	
	}
	
	#endregion //Unity Methods
	
	#region Public Methods
	
	public void Initalize()
	{
        Player player = new Player();
        player.Id = 0;
        player.name = "First";
	}
	
	#endregion // Public Methods
	
	#region Private Methods
	
	private void SamplePrivateMethods()
	{
	
	}	
	
	#endregion //Private Methods
}


/*

    Toplam 106 adet taş bulunmaktadır. 
 *  1  - 13 taş numaraları vardır.
 *  4 renk bulunmaktadır. 
 *  Her sayıdan iki tane var
 *  2 tanede siyah " Sahte Okey " vardır.
 *  

*/