using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
namespace HardyCorentin
{

    public class NewBehaviourScript : MonoBehaviour, IPointerDownHandler, IPointerMoveHandler, IPointerUpHandler
    {
        public Vector2 positionOld;
        public Vector2 positionDifference;
        public Vector2 initialPostion;
        public GameObject player;
        public GameObject batonDeJoie;


        private bool clicked = false;
        public void OnPointerDown(PointerEventData eventData)
        {
            clicked = true;
            Debug.LogWarning(clicked);

        }

        public void OnPointerMove(PointerEventData eventData)
        {
            if (clicked == true)
            {
                Debug.LogWarning("NINJA");
                initialPostion = batonDeJoie.transform.position;
                positionOld = /*eventData.position*/initialPostion;
                positionDifference = positionOld - positionOld;
                MouvementPerso(positionDifference);
                //player.transform.position = new Vector2(positionDifference.x,positionDifference.y);
            }

        }

        public void OnPointerUp(PointerEventData eventData)
        {
            if (clicked == false)
            {

            }
            //throw new System.NotImplementedException();
        }
        void MouvementPerso(Vector2 positionDifference)
        {

            player.transform.Translate(positionDifference * 100);

        }
    }
}
