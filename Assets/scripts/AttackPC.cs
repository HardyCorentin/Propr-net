using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alexis{
public class AttackPC : MonoBehaviour
{
    public GameObject player;
    public int countdown = 0;
    public ParticleSystem particleSystem;
    public ParticleSystem voix;


    // Start is called before the first frame update
    void Start()
    {
        //coup_fx.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            
            if (player.GetComponent<MovePC>().dir == true)
            {
                
                if (Physics.Raycast(player.transform.position, player.transform.right, out var other, 5f))
                {
                    countdown = countdown + 1;
                    if (countdown >= 2)
                    {
                        voix.transform.position = player.transform.position + new Vector3(0.044f,1.206f,0.33f);
                        voix.Play();
                        particleSystem.transform.position = other.point;
                        particleSystem.Play();

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
                        particleSystem.transform.position = other.point;
                        particleSystem.Play();
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
}
