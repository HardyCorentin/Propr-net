using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTP : MonoBehaviour
{
    public Vector3 targetPosition;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(player.transform.position, targetPosition, 0.1f);
        /*if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("clikclak");
            targetPosition = Input.mousePosition;
            player.transform.position = targetPosition;

        }*/
    }
    public void onTouch()
    {
        targetPosition = Input.mousePosition;
        player.transform.position = targetPosition;
    }

}
