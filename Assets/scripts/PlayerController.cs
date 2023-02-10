using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace HardyCorentin
{

    public class PlayerController : MonoBehaviour
    {
        private Animator thisAnim;
        // Start is called before the first frame update
        void Start()
        {
            thisAnim = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            var h = Input.GetAxis("Horizontal");
            thisAnim.SetFloat("Speed", Mathf.Abs(h));
        }
    }
}
