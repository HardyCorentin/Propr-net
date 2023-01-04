using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class Move1 : MonoBehaviour
{
    public GameObject currentTouchedObject;
    public GameObject player;
    public float move = 0.02f;
    public int direction;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update(){
        Debug.Log(up);
    }

    void OnTouch()
    {
        Debug.Log("Jesuistouche");

            if(direction==1)
            {
                if(player.transform.position.x <-3.6f){
                Debug.Log("Mooove to left");
                player.transform.position = new Vector3(player.transform.position.x+ 0f, player.transform.position.y, 0f);
                }
                else if(player.transform.position.x >-3.6f){
                    player.transform.position = new Vector3(player.transform.position.x+-move, player.transform.position.y, 0f);
                }
            }
            if(direction==2)
            {
                if(player.transform.position.x >6f){
                    Debug.Log("Mooove to right");
                    player.transform.position = new Vector3(player.transform.position.x + 0f, player.transform.position.y, 0f);
                }
                else{
                    player.transform.position = new Vector3(player.transform.position.x + move, player.transform.position.y, 0f);
                }

               
            }
        }
        else{
            if(up == true)
            {
                if(player.transform.position.y > 0f){
                    player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 0f, 0f);
                }else if(player.transform.position.y < 0f){
                    Debug.Log("Mooove UP");
                    player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y+ move, 0f);
            }else if(up==false){
                Debug.Log("DOWN");
                    if (player.transform.position.y < -4f)  {
                    player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 0f, 0f);
                    }else if (player.transform.position.y > -4f){
                        player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + -move, 0f);
                    }
                }
            }
            /*if (player.transform.position.y > -1)
            {
                player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 0f, 0f);
            }
            else
            {
                player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + moveUp, 0f);
            }*/
       /* }
        
         void TouchUp()
    {
        Debug.Log("Touched Ended with " + player);
        Debug.Log("JesuisPlustouche");
    }
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

