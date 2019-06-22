using UnityEngine;
using System.Collections;

public class FindTarget : MonoBehaviour {
	public Transform target;
	public float distance;
	UnityEngine.AI.NavMeshAgent agent;
	float dis;
	public float minSpeed;
	public float maxSpeed;


	// Use this for initialization
	void Start () {
		agent = GetComponent <UnityEngine.AI.NavMeshAgent> ();
		agent.speed = UnityEngine.Random.Range(minSpeed, maxSpeed);
	}
	
	// Update is called once per frame
	void Update () {
		agent.destination = target.position;

		dis = Vector3.Distance(agent.nextPosition, target.position);
		if (dis <= distance) {
//			Debug.Log (dis);
			Destroy(gameObject);

		}

	}
}
