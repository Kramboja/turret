using UnityEngine;
using System.Collections;

public class EnemySpawnScript : MonoBehaviour {

	public GameObject Enemy;


	void OnGUI()
	{
		if(GUILayout.Button("Spawn random enemy"))
		{
			Instantiate (Enemy, this.transform.position, this.transform.rotation);
		}
	}
}
