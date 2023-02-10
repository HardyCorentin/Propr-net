using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
namespace Alexis
{

    public class JoystickViaButtonsMovement : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler
    {
        public Vector2 direction;
        //public MovePC movePC;

        // Update is called once per frame
        public void Update()
        {

        }
        public void Validate()
        {
            //movePC.joystick = this;
        }

        public void Unvalidate(bool absolute)
        {
            if (absolute)
            {
                //movePC.joystick = null;
            }
            else
            {
                //movePC.joystick = movePC.joystick == this ? null : movePC.joystick;
            }
        }


        public void OnPointerDown(PointerEventData eventData)
        {
            Validate();
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            Unvalidate(true);
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            if (eventData.pointerPress != null)
            {
                Validate();
            }
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            if (eventData.pointerPress != null)
            {
                Unvalidate(false);
            }
        }
    }
}
