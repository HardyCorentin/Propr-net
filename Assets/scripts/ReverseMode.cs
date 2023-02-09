using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Alexis{
public class ReverseMode : MonoBehaviour
{
    public bool reverseModeActivated = false;
    public GameObject actor;
    // Start is called before the first frame update
    void Start()
    {
        if (reverseModeActivated == true)
        {
            transform.position = transform.position = new Vector3(actor.transform.position.x * -1f, actor.transform.position.y + 0, actor.transform.position.z);
        }
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
}
