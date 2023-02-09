using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Alexis{
public class TriggerDechet : MonoBehaviour
{
    public GameObject zoneTrigger;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(zoneTrigger.transform.position, new Vector3(zoneTrigger.transform.position.x, zoneTrigger.transform.position.y - 100, 0), out var other, 10f))
        {
            if (other.collider.GetComponent<EnnemiScript>().hostile == true)
            {
                other.collider.GetComponent<EnnemiScript>().lancement = true;
            }
        }
    }
}
}