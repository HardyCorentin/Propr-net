using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace HardyCorentin
{

    public class Openingposition : MonoBehaviour
    {
        public GameObject player;
        // Start is called before the first frame update
        void Start()
        {

            player.transform.position = new Vector3(-2f, -3f, 0f);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
