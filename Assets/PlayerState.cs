using UnityEngine;

public class PlayerState : MonoBehaviour
{
	public string playerName="Dr Charles";
	public int lives= 3;
	public float health= 0.8f;

	public string SaveToString()
	{
		return JsonUtility.ToJson(this);
	}



	// Given:
	// playerName = "Dr Charles"
	// lives = 3
	// health = 0.8f
	// SaveToString returns:
	// {"playerName":"Dr Charles","lives":3,"health":0.8}
}