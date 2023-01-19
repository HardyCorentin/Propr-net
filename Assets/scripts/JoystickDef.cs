using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickDef : MonoBehaviour
{
    public Transform player;
    public float speed = 0.02f;
    private bool debutTouche = false;
    public Vector2 pointA;
    public Vector2 pointB;
    public Transform cercle;
    public Transform cercleExterieur;
    public bool dir = true;

    // Start is called before the first frame update
    void Start()
    {
        pointA = new Vector2(cercle.position.x, cercle.position.y);
        pointB = new Vector2(cercle.position.x, cercle.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(pointB.x);
        if (Input.GetMouseButtonDown(0))
        {

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
            MouvementPerso(direction * 1);
            cercle.transform.position = new Vector2(pointB.x, pointB.y);
            cercle.transform.position = pointA + Vector2.ClampMagnitude(offset, 1.0f); //Le problème vient de là
        }
        if (pointB.x < 0)
        {
            player.GetComponent<VictoryorDefeat>().side = false;
            player.GetComponent<SpriteRenderer>().flipX = true;
            if (player.transform.position.x < -3.6f)
            {

                player.transform.position = new Vector3(player.transform.position.x + 0f, player.transform.position.y, 0f);
            }
            else if (player.transform.position.x > -3.6f)
            {
                player.transform.position = new Vector3(player.transform.position.x + -speed, player.transform.position.y, 0f);
            }

           if (pointB.x > 0)
            {

                player.GetComponent<VictoryorDefeat>().side = true;
                player.GetComponent<SpriteRenderer>().flipX = false;
                if (player.transform.position.x > 6f)
                {

                    player.transform.position = new Vector3(player.transform.position.x + 0f, player.transform.position.y, 0f);
                }
                else
                {
                    player.transform.position = new Vector3(player.transform.position.x + speed, player.transform.position.y, 0f);
                }
            }
            //MouvementPerso(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
        }

        void OnTouch()
        {

            debutTouche = true;
            pointB = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));

        }

        void TouchUp()
        {
            debutTouche = false;
        }

        void MouvementPerso(Vector2 direction)
        {
            player.Translate(direction * speed);
        }
    }
}
