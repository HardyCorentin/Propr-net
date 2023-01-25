using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePC : MonoBehaviour
{
    public GameObject currentTouchedObject;
    public GameObject player;
    public float move = 0.02f;
    public bool horizontal;
    public bool vertical;
    public bool left;
    public bool up;
    public bool dir = true;
    public Animator moveAnim;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {
        Debug.Log(dir);
        if (Input.GetKey(KeyCode.Z))
        {
            transform.position = new Vector2(player.transform.position.x + 0f, player.transform.position.y + move);
        }

        if (Input.GetKey(KeyCode.Q))
         
        {
            moveAnim.Play("finalSVP");
            player.GetComponent<SpriteRenderer>().flipX = true;
            transform.position = new Vector2(player.transform.position.x - move, player.transform.position.y + 0f);
            dir = false;
       
        }

        if (Input.GetKey(KeyCode.S))
        {
            if (player.transform.position.y < -4f)
            {
                player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 0f, 0f);
            }
            else if (player.transform.position.y > -4f)
            {
                player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + -move, 0f);
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            player.GetComponent<SpriteRenderer>().flipX = false;
            transform.position = new Vector2(player.transform.position.x + move, player.transform.position.y + 0f);
            dir = true;
        }
    }

    /*public void OnTouch()
    {
        Debug.Log("Jesuistouch�");

        if (horizontal == true)
        {
            if (left == true)
            {
                Debug.Log("Mooove to left");
                player.transform.position = new Vector3(player.transform.position.x + -move, player.transform.position.y, 0f);

            }
            else
            {
                Debug.Log("Mooove to right");
                player.transform.position = new Vector3(player.transform.position.x + move, player.transform.position.y, 0f);

            }
        }
        else if (vertical == true)
        {
            if (up == true)
            {
                Debug.Log("Mooove UP");
                player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + move, 0f);

            }
            else
            {
                Debug.Log("Mooove DOWN");
                player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + -move, 0f);
                Debug.Log("Mooove DOWN");
            }
            /*if (player.transform.position.y > -1)
            {
                player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 0f, 0f);
            }
            else
            {
                player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + moveUp, 0f);
            }*/
    /*  }

      Debug.Log("Touched " + player);
  }
  public void TouchUp()
  {
      Debug.Log("Touched Ended with " + player);
      Debug.Log("JesuisPlustouch�");
  }/*


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