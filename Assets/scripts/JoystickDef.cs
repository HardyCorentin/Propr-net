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

    // Start is called before the first frame update
    void Start()
    {
        pointA = new Vector2 (cercle.position.x,cercle.position.y);
        pointB = new Vector2 (cercle.position.x,cercle.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            
        }
        if(Input.GetMouseButton(0)){
            debutTouche = true;
            pointB = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
            //pointB = Camera.main.ScreenToWorldPoint(new Vector3(-7,-7,-7));
        }
        else{
            debutTouche = false;
            //pointB = Camera.main.ScreenToWorldPoint(new Vector3(0,0,0));
        }
        if (debutTouche){
            Vector2 offset = pointB - pointA;
            Vector2 direction = Vector2.ClampMagnitude(offset, 1.0f);
            MouvementPerso(direction*1);
            cercle.transform.position = new Vector2(pointB.x,pointB.y);
            cercle.transform.position = pointA + Vector2.ClampMagnitude(offset, 1.0f); //Le problème vient de là
        }
        //MouvementPerso(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
    }
    
    public void OnTouch()
    {
        
        debutTouche = true;
        pointB = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
        
    }

    public void TouchUp()
    {
        debutTouche = false;
    }

    void MouvementPerso (Vector2 direction)
    {
        player.Translate(direction*speed);
    }
}
