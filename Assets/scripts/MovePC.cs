using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
namespace HardyCorentin
{

    public class MovePC : MonoBehaviour
    {
        public float speed = 2;
        public PointerEventData pointerEventData;
        public JoystickViaButtonsMovement joystick;

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
            }
        }


        private void OnGUI()
        {
            GUILayout.Label("Current joystick is " + joystick);
        }
    }
}