using UnityEngine;
using System.Collections;

public class MovingShip : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Rotate(0, 1, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Rotate(0, -1, 0);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Translate(Vector3.back * Time.deltaTime*20);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(Vector3.forward * Time.deltaTime*20);
        }
    }
}
