using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleHttpRest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		HttpUtil httpUtil = new HttpUtil();
		StartCoroutine(httpUtil.getHttpDataJson("http://openmultiplayer.com/mobileserver/persons/752", whenFinishPerson));		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void whenFinishPerson(string json){
		Person person = JsonUtility.FromJson<Person>(json);
		Debug.Log("Person name: " + person.name);
		Debug.Log("Person email: " + person.email);
	
	}
}
