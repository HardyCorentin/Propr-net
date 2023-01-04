using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject currentTouchedObject;
    public GameObject player;
    public float move = 0.09f;
    public bool horizontal;
    public bool vertical;
    public bool left;
    public bool up;
    public int direction = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update(){
        Debug.Log(up);
    }

    public void OnTouch()
    {
        if (direction == 1)
        {
            Debug.Log("Mooove to left");
            player.GetComponent<VictoryorDefeat>().side = false;
            player.GetComponent<SpriteRenderer>().flipX = true;
            if (player.transform.position.x < -3.6f)
            {

                player.transform.position = new Vector3(player.transform.position.x + 0f, player.transform.position.y, 0f);
            }
            else if (player.transform.position.x > -3.6f)
            {
                player.transform.position = new Vector3(player.transform.position.x + -move, player.transform.position.y, 0f);
            }
        }
        if (direction == 2)
        {
            player.GetComponent<VictoryorDefeat>().side = true;
            player.GetComponent<SpriteRenderer>().flipX = false;
            Debug.Log("Mooove to right");
            if (player.transform.position.x > 6f)
            {

                player.transform.position = new Vector3(player.transform.position.x + 0f, player.transform.position.y, 0f);
            }
            else
            {
                player.transform.position = new Vector3(player.transform.position.x + move, player.transform.position.y, 0f);
            }


        }

        if (direction == 3)
        {
            Debug.Log("Mooove UP");
            if (player.transform.position.y > 0f)
            {
                player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 0f, 0f);
            }
            else if (player.transform.position.y < 0f)
            {

                player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + move, 0f);
            }
        }
        if (direction == 4)
        {
            Debug.Log("DOWN");
            if (player.transform.position.y < -4f)
            {
                player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 0f, 0f);
            }
            else if (player.transform.position.y > -4f)
            {
                player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y - move, 0f);

            }
        }
    }



    public void TouchUp()
    {
        Debug.Log("Touched Ended with " + player);
        Debug.Log("JesuisPlustouche");
    }


    /*{
        Debug.Log("UP");
        
        if(player.transform.position.y > -1)
        {
            player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 0f, 0f);
        }
        else {
            player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + moveUp, 0f);
        }
    }*/
}
