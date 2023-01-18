using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPoint : MonoBehaviour
{
     public GameObject player;
    public DetectObject dO;
    private Vector3 targetPosition;
    // Start is called before the first frame update
    void Start()
    {
        targetPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        player.transform.position = Vector3.MoveTowards(player.transform.position, targetPosition,0.05f); ;

    }
    public void OnTouch(Vector3 raycastHitPosition)
    {
        Debug.Log("Le touch marche");
        targetPosition = raycastHitPosition;
        Debug.LogWarning("mon raycast a touché a" + raycastHitPosition);
        if (player.transform.position.x<dO.currentTouchedObject.transform.position.x)
        {
            player.GetComponent<VictoryorDefeat>().side = false;
            player.GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            player.GetComponent<VictoryorDefeat>().side = true;
            player.GetComponent<SpriteRenderer>().flipX = false;
        }

    }
    public void OnMouseDown()
    {
        Debug.Log("Le click");
        targetPosition = Input.mousePosition;
        //Debug.LogWarning("mon raycast a touché a" + raycastHitPosition);
        if (player.transform.position.x < dO.currentTouchedObject.transform.position.x)
        {
            player.GetComponent<VictoryorDefeat>().side = false;
            player.GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            player.GetComponent<VictoryorDefeat>().side = true;
            player.GetComponent<SpriteRenderer>().flipX = false;
        }
    }
}
