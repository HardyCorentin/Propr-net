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
                transform.position += dir;
                if(player.transform.position.x >= 13f){
                    player.transform.position = new Vector2 (player.transform.position.x - 0.5f, player.transform.position.y+0);
                }
                
            }
            


        }


        private void OnGUI()
        {
            GUILayout.Label("Current joystick is " + joystick);
        }
    }
}