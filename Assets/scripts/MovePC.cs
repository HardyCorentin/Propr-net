using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
namespace Alexis
{

    public class MovePC : MonoBehaviour
    {
        public float speed = 2;
        public PointerEventData pointerEventData;
        public JoystickViaButtonsMovement joystick;
        public GameObject player;

        // Start is called before the first frame update
        void Start()
        {
        }

        private void Update()
        {
            if (joystick != null)
            {
                var dir = (Vector3)(joystick.direction.normalized * speed);
                if(transform.position.x >= 2f & dir.x>0f){
                    transform.position = new Vector3 (transform.position.x + 0f, transform.position.y+dir,transform.position.z);
                }
                else if(transform.position.x <= -2f & dir.x<0f){
                    transform.position = new Vector3 (transform.position.x - 0f, transform.position.y+dir,transform.position.z);
                }
                else if(transform.position.y >= 2f & dir.y>0f){
                    transform.position = new Vector3 (transform.position.x + dir, transform.position.y+0f,transform.position.z);
                }
                else if(transform.position.y <= -2f & dir.y<0f){
                   transform.position = new Vector3 (transform.position.x +dir, transform.position.y-0f,transform.position.z);
                }
                else {
                    transform.position += dir;
                }
                
            }
            


        }


        private void OnGUI()
        {
            GUILayout.Label("Current joystick is " + joystick);
        }
    }
}