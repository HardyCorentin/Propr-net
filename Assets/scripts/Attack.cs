using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject player;
    public int countdown = 0;
    public GameObject Ennemy;
    public int defeatcountdown = 0;
    public VictoryorDefeat vd;
    public ComboProgram cp;
    public ParticleSystem particleSystem;
    public ParticleSystem voix;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        Debug.DrawRay(player.transform.position, player.transform.right * 5f);
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Handle finger movements based on touch phase.
            switch (touch.phase)
            {
                // Record initial touch position.
                case TouchPhase.Began:
                 if (player.GetComponent<VictoryorDefeat>().side == true)
        {

            if (Physics.Raycast(player.transform.position, player.transform.right, out var other, 3f))
            {
                Debug.Log("click");
                countdown = countdown + 1;
                if (countdown >= 2)
                {
                    Debug.Log("AH");
                    if (other.collider.GetComponent<EnnemiScript>().side == true)
                    {
                        other.collider.GetComponent<SpriteRenderer>().flipX = true;
                    }
                    if (other.collider.GetComponent<EnnemiScript>().hostile == false)
                    {
                        voix.transform.position = player.transform.position + new Vector3(0.044f,1.206f,0.33f);
                        voix.Play();
                        particleSystem.transform.position = other.point;
                        particleSystem.Play();
                        cp.comboNumber = 0;
                        //play anim 
                        vd.hp = vd.hp - 0.335f;
                        Destroy(other.transform.gameObject);
                    }
                    else
                    {
                        voix.transform.position = player.transform.position + new Vector3(0.044f,1.206f,0.33f);
                        voix.Play();
                        particleSystem.transform.position = other.point;
                        particleSystem.Play();
                        cp.comboNumber = cp.comboNumber + 1;
                        //play anim 
                        Destroy(other.transform.gameObject);
                    }
                }
            }
        }

        if (player.GetComponent<VictoryorDefeat>().side ==false)
        {
            if (Physics.Raycast(player.transform.position, -player.transform.right, out var other, 3f))
            {
                countdown = countdown + 1;
                if (countdown >= 2)
                {
                    Debug.Log("AH");
                    if (other.collider.GetComponent<EnnemiScript>().side == false)
                    {
                        other.collider.GetComponent<SpriteRenderer>().flipX = true;
                    }
                    if (other.collider.GetComponent<EnnemiScript>().hostile == false)
                    {
                        voix.transform.position = player.transform.position + new Vector3(0.044f,1.206f,0.33f);
                        voix.Play();
                        particleSystem.transform.position = other.point;
                        particleSystem.Play();
                        //play anim 
                        cp.comboNumber = 0;
                        vd.hp = vd.hp - 0.335f;
                        Destroy(other.transform.gameObject);
                    }
                    else
                    {
                        voix.transform.position = player.transform.position + new Vector3(0.044f,1.206f,0.33f);
                        voix.Play();
                        particleSystem.transform.position = other.point;
                        particleSystem.Play();
                        cp.comboNumber = cp.comboNumber + 1;
                        //play anim 
                        Destroy(other.transform.gameObject);
                    }

                }
            }
        }
                    break;
            }
    }
    /*public void OnTouch()
    {
        if (player.GetComponent<VictoryorDefeat>().side == true)
        {

            if (Physics.Raycast(player.transform.position, player.transform.right, out var other, 3f))
            {
                Debug.Log("click");
                countdown = countdown + 1;
                if (countdown >= 2)
                {
                    Debug.Log("AH");
                    if (other.collider.GetComponent<EnnemiScript>().side == true)
                    {
                        other.collider.GetComponent<SpriteRenderer>().flipX = true;
                    }
                    if (other.collider.GetComponent<EnnemiScript>().hostile == false)
                    {
                        cp.comboNumber = 0;
                        //play anim 
                        vd.hp = vd.hp - 0.335f;
                        Destroy(other.transform.gameObject);
                    }
                    else
                    {
                        cp.comboNumber = cp.comboNumber + 1;
                        //play anim 
                        Destroy(other.transform.gameObject);
                    }
                }
            }
        }

        if (player.GetComponent<VictoryorDefeat>().side ==false)
        {
            if (Physics.Raycast(player.transform.position, -player.transform.right, out var other, 3f))
            {
                countdown = countdown + 1;
                if (countdown >= 2)
                {
                    Debug.Log("AH");
                    if (other.collider.GetComponent<EnnemiScript>().side == false)
                    {
                        other.collider.GetComponent<SpriteRenderer>().flipX = true;
                    }
                    if (other.collider.GetComponent<EnnemiScript>().hostile == false)
                    {
                        //play anim 
                        cp.comboNumber = 0;
                        vd.hp = vd.hp - 0.335f;
                        Destroy(other.transform.gameObject);
                    }
                    else
                    {
                        cp.comboNumber = cp.comboNumber + 1;
                        //play anim 
                        Destroy(other.transform.gameObject);
                    }

                }
            }
        }



    }*/
}
}
