using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateReversemode : MonoBehaviour
{
    public ReverseMode reversemodeactivater;
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
        if(reversemodeactivater.reverseModeActivated == false)
        {
            reversemodeactivater.reverseModeActivated = true;
        }
        if (reversemodeactivater.reverseModeActivated == true)
        {
            reversemodeactivater.reverseModeActivated = false;
        }
    }
}
