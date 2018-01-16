using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServiceTester : MonoBehaviour {

	void Start () {
        HelloWorldService service = new HelloWorldService();
        string result = service.hello("FenHeral");
        Debug.Log(result);
	}
}
