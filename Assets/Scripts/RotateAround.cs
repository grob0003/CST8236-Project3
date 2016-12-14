using UnityEngine;
using System.Collections;

public class RotateAround : MonoBehaviour
{

    public class Planet
    {

        public string planetName;
        public float axisTilt;
        public float sunOrbit;
        public float axisRotation;

        public Planet(string name, float tilt, float orbit, float rotation)
        {
            planetName = name;
            axisTilt = tilt;
            sunOrbit = orbit;
            axisRotation = rotation;

        }
    }
    static float eO = 5.0f;
    static float eR = 365.0f;

    /*  Name    tilt    orbit       rotation*/
    Planet[] planets = {new Planet("Mercury",   0.03f,  1.59f*eO,   175.9f*eR),
                           new Planet("Venus",  2.64f,  1.18f*eO,   116.8f*eR),
                           new Planet("Earth",  23.44f, 1.0f*eO,    1.0f*eR),
                           new Planet("Mars",   25.19f, 0.828f*eO,  1.03f*eR),
                           new Planet("Jupiter",3.13f,  0.439f*eO,  0.414f*eR),
                           new Planet("Saturn", 26.73f, 0.325f*eO,  0.444f*eR),
                           new Planet("Uranus", 82.23f, 0.228f*eO,  0.718f*eR),
                           new Planet("Neptune",28.32f, 0.182f*eO,  0.671f*eR),
                           new Planet("Pluto",  57.47f, 0.157f*eO,  6.39f*eR)
                       };

    float timeMultiplier;

    // Use this for initialization
    void Start()
    {
        timeMultiplier = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        print("timemult: " + timeMultiplier);

        Planet planet = null;

        foreach (Planet temp in planets)
        {
            if (gameObject.name == temp.planetName)
            {
                planet = temp;
                if (Input.GetKey(KeyCode.R))
                {
                    if (timeMultiplier < 200)
                        timeMultiplier += 0.1f;
                }
                else if (Input.GetKey(KeyCode.T))
                {
                    if (timeMultiplier > 0.2f)
                        timeMultiplier -= 0.1f;
                }

                transform.RotateAround(transform.parent.position, Vector3.up, planet.sunOrbit * Time.deltaTime * timeMultiplier);
                transform.Rotate(new Vector3(0, planet.axisTilt, 0), planet.axisRotation * Time.deltaTime * timeMultiplier);
            }
        }

    }
}
