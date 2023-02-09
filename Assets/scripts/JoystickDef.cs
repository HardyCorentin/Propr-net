using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Alexis{
public class JoystickDef : MonoBehaviour
{
    public GameObject player;
    public float speed = 0.02f;
    private bool debutTouche = false;
    public Vector2 pointA;
    public Vector2 pointB;
    public GameObject cercle;
    public GameObject cercleExterieur;
    public bool dir = true;
    public Vector2 startPos;
    private Touch touch;


    // Start is called before the first frame update
    void Start()
    {
        pointA = new Vector2(cercle.transform.position.x, cercle.transform.position.y);
        pointB = new Vector2(cercle.transform.position.x, cercle.transform.position.y);

        
    }

    // Update is called once per frame
    void Update()
    {
        
         if (Input.touchCount > 0)
        {
            //var rectRight = Rect(0, -Screen.height/2, Screen.width / 2, Screen.height);
            Touch touch = Input.GetTouch(0);
            Debug.Log(touch.position.x);
            // Handle finger movements based on touch phase.
            if (touch.position.x<800){
            switch (touch.phase)
            {
                // Record initial touch position.
                case TouchPhase.Began:
                    
                        debutTouche = true;
                        pointB = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, Camera.main.transform.position.z));
                    
                break;
                    
                // Report that a direction has been chosen when the finger is lifted.
                case TouchPhase.Ended:
                debutTouche=false;
                    cercle.transform.position = pointA;
                    break;
            }
            }
        }

        if (Input.GetMouseButton(0)) {
            debutTouche = true;
            pointB = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
            //pointB = Camera.main.ScreenToWorldPoint(new Vector3(-7,-7,-7));
        }
        else {
            debutTouche = false;
            //pointB = Camera.main.ScreenToWorldPoint(new Vector3(0,0,0));
        }
        if (debutTouche) {
            Vector2 offset = pointB - pointA;
            Vector2 direction = Vector2.ClampMagnitude(offset, 1.0f);
            //Debug.Log(offset);
            if (offset.x <= 0)
            {
                player.GetComponent<VictoryorDefeat>().side = false;
                player.GetComponent<SpriteRenderer>().flipX = true;
                
            }
            if (offset.x > 0)
                {   
                    player.GetComponent<VictoryorDefeat>().side = true;
                    player.GetComponent<SpriteRenderer>().flipX = false;
                }
            MouvementPerso(direction * 1);
            cercle.transform.position = new Vector2(pointB.x, pointB.y);
            cercle.transform.position = pointA + Vector2.ClampMagnitude(offset, 1.0f); //Le probl�me vient de l�
        }
        if (pointB.x < 0)

            /*if (player.transform.position.x < -3.6f)
            {

                player.transform.position = new Vector3(player.transform.position.x + 0f, player.transform.position.y, 0f);
            }
            else if (player.transform.position.x > -3.6f)
            {
                player.transform.position = new Vector3(player.transform.position.x + -speed, player.transform.position.y, 0f);
            }*/

           if (pointB.x > 0)
            {

                /*if (player.transform.position.x > 6f)
                {

                    player.transform.position = new Vector3(player.transform.position.x + 0f, player.transform.position.y, 0f);
                }
                else
                {
                    player.transform.position = new Vector3(player.transform.position.x + speed, player.transform.position.y, 0f);
                }*/
            }
            //MouvementPerso(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
        }

       /* void OnTouch()
        {

            debutTouche = true;
            pointB = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));

        }

        void TouchUp()
        {
            debutTouche = false;
        }*/

        void MouvementPerso(Vector2 direction)
        {
            
            player.transform.Translate(direction * speed);
            
        }
    }
}

