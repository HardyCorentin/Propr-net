using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartArtificiel : MonoBehaviour
{
    public GameObject joystickRef;
    // Start is called before the first frame update
    void Start()
    {
        joystickRef.GetComponent<JoystickUI>().pointA = new Vector2(joystickRef.GetComponent<JoystickUI>().batonDeJoie.transform.position.x, joystickRef.GetComponent<JoystickUI>().batonDeJoie.transform.position.y);
        joystickRef.GetComponent<JoystickUI>().pointB = new Vector2(joystickRef.GetComponent<JoystickUI>().batonDeJoie.transform.position.x, joystickRef.GetComponent<JoystickUI>().batonDeJoie.transform.position.y); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
