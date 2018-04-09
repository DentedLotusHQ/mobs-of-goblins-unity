using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PolyNav;
[RequireComponent(typeof(PolyNavAgent))]
public class NavigateWaypoints : MonoBehaviour {

	private PolyNavAgent _agent;
	private Stack<Transform> _wpStack = new Stack<Transform>();
	// Use this for initialization
	void Start () {
		_agent = GetComponent<PolyNavAgent>();
		_agent.OnDestinationReached += onDestinationReached;
		getWaypoints();
		_agent.SetDestination(_wpStack.Pop().position);
	}
	
	// Update is called once per frame
	void Update () {
	}	

	private 

	void getWaypoints()
	{
		
		var wps = GameObject.FindGameObjectsWithTag("Waypoint");
		foreach(GameObject wp in wps){
			_wpStack.Push(wp.transform);
		}
	}

	void onDestinationReached(){
		Debug.Log("Arrived");
		if (_wpStack.Count == 0){
			getWaypoints();
		}
		_agent.SetDestination(_wpStack.Pop().position);
		
	}
}
