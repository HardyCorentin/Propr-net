using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboProgram : MonoBehaviour
{
    public GameObject comboIndicator;
    public int comboNumber = 0;
    public List<Sprite> listeSprite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
       comboIndicator.GetComponent<SpriteRenderer>().sprite = listeSprite[comboNumber];
        
        //clone.GetComponent<SpriteRenderer>().sprite = spriPac
    }
}
