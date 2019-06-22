using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	public GameObject nagent;
	public GameObject goalObject;
	public float spawntime1;
	public float spawntime2;
	// Use this for initialization
	void Start () {
		Invoke("SpawnAgent", 1);
	}
	
	// Update is called once per frame
	void SpawnAgent () {
		GameObject na = (GameObject)Instantiate (nagent, this.transform.position, Quaternion.identity);
		na.GetComponent<FindTarget>().target = goalObject.transform;
		Invoke("SpawnAgent",Random.Range(spawntime1,spawntime2));
	}
}
