using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPoint : MonoBehaviour
{
    public GameObject currentTouchedObject;
    public GameObject player;
    public DetectObject dO;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onTouch()
    {
        if(player.transform.position.x<dO.transform.position.x)
        {
            player.GetComponent<VictoryorDefeat>().side = false;
            player.GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            player.GetComponent<VictoryorDefeat>().side = false;
            player.GetComponent<SpriteRenderer>().flipX = false;
        }
        player.transform.position = Vector3.MoveTowards(transform.position, dO.transform.position, 2f); ;
    }
}
