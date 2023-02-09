using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoystickUI : MonoBehaviour, IPointerDownHandler,IPointerMoveHandler, IPointerUpHandler
{
    public Vector2 pointA;
    public Vector2 pointB;
    public Vector2 initialPostion;
    public GameObject player;
    public GameObject batonDeJoie;
    public GameObject fondBDDJ;


    private bool clicked = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        
        clicked = true;
        

    }

    public void OnPointerMove(PointerEventData eventData)
    {
        if (clicked == true)
        {
            Debug.LogWarning(pointB);
            pointB = Input.GetTouch(0).position;
            //pointB = Camera.main.ScreenToWorldPoint(new Vector3(eventData.position.x, eventData.position.y, Camera.main.transform.position.z));
            
            Vector2 offset = pointB - pointA;
            Vector2 direction = Vector2.ClampMagnitude(offset, 1.0f);
            Debug.LogWarning(direction);
            /*if (offset.x <= 0)
                {
                    player.GetComponent<VictoryorDefeat>().side = false;
                    player.GetComponent<SpriteRenderer>().flipX = true;

                }
                if (offset.x > 0)
                {
                    player.GetComponent<VictoryorDefeat>().side = true;
                    player.GetComponent<SpriteRenderer>().flipX = false;
                }*/
            MouvementPerso(direction*1);
            batonDeJoie.transform.position = new Vector2(pointB.x, pointB.y);
            batonDeJoie.transform.position = pointA + Vector2.ClampMagnitude(offset, 1.0f);
        }

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        clicked = false;
        if(clicked == false)
        {
           Debug.Log("chubadubabu");
           
            
           
        }
        //throw new System.NotImplementedException();
    }
    void MouvementPerso(Vector2 direction)
    {

        player.transform.Translate(direction * 0.2f);
           /*if (player.transform.position.y >= 1.5f)
            {
                player.transform.Translate(direction * -0.07f);
            }
            if (player.transform.position.y <= -5f)
            {
                player.transform.Translate(direction * -0.07f);
            }
            if (player.transform.position.x <= -9f)
            {
                player.transform.Translate(direction * -0.07f);
            }
            if (player.transform.position.x >= 13f)
            {
                player.transform.Translate(direction * -0.07f);
            } */

    }
}
