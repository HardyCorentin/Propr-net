using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace HardyCorentin
{

    public class Portique : MonoBehaviour
    {
        public GameObject PDS;
        public VictoryorDefeat vd;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Physics.Raycast(PDS.transform.position, new Vector3(PDS.transform.position.x, PDS.transform.position.y - 100, 0), out var other, 10f))
            {
                if (other.collider.GetComponent<EnnemiScript>().hostile == true)
                {
                    vd.hp = vd.hp - 0.335f;

                    Destroy(other.transform.gameObject);
                }
                else if (other.collider.GetComponent<EnnemiScript>().hostile == false & vd.hp < 1)
                {
                    vd.hp = vd.hp + 0.111f;

                    Destroy(other.transform.gameObject);
                }
            }
        }
    }
}