using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPC : MonoBehaviour
{
    public GameObject player;
    public int countdown = 0;
    public GameObject coup_fx;
    private Animator animFX;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(player.transform.position, player.transform.right * 5f);
        if (Input.GetKey(KeyCode.Space))
        {
            
            if (player.GetComponent<MovePC>().dir == true)
            {
                
                if (Physics.Raycast(player.transform.position, player.transform.right, out var other, 5f))
                {
                    Debug.Log("click");
                    countdown = countdown + 1;
                    if (countdown >= 2)
                    {
                        GameObject FX= Instantiate(coup_fx, player.transform.position, player.transform.rotation); 
                        animFX = FX.GetComponent<Animator>();
                        animFX.Play();
                        /*if (animFX.isPlaying = false)
                        {
                            Destroy(FX);
                        }*/
                        Destroy(other.transform.gameObject);
                    }

                }
            }

            if (player.GetComponent<MovePC>().dir == false)
            {
                if (Physics.Raycast(player.transform.position, -player.transform.right, out var other, 5f))
                {
                    countdown = countdown + 1;
                    if (countdown >= 2)
                    {
                        Debug.Log("AH");
                        Destroy(other.transform.gameObject);
                    }
                }
            }
        }
    }
    public void OnMouseDown()
    {
        

    }

}
