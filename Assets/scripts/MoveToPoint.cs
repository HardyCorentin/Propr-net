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
        player.transform.position = dO.point;
    }
}
