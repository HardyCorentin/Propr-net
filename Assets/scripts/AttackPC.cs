using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPC : MonoBehaviour
{
    public GameObject player;
    public int countdown = 0;
    public GameObject coup_fx;
    private Animation animFX;


    // Start is called before the first frame update
    void Start()
    {
        coup_fx.SetActive(false);
        animFX = coup_fx.GetComponent<Animation>();

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(animFX.isPlaying);
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
                        coup_fx.transform.position = player.transform.position;
                        coup_fx.SetActive(true);
                        
                        animFX.Play("FX_coup_anim2");
                        Destroy(other.transform.gameObject);
                        if (animFX.isPlaying==false)
                        {
                            coup_fx.SetActive(false);
                        }
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
