using UnityEngine;
using System.Collections;

public class Zooming : MonoBehaviour {
    Camera camera;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        print(Camera.main.fieldOfView);
        if (Input.GetKey(KeyCode.Q))
        {
            if (Camera.main.fieldOfView < 50.1f)
                Camera.main.fieldOfView++;
        }
        else if (Input.GetKey(KeyCode.E))
        {
            if (Camera.main.fieldOfView > 7.1f)
                Camera.main.fieldOfView--;
        }
	
	}
}
