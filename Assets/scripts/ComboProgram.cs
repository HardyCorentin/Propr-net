using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboProgram : MonoBehaviour
{
    public GameObject comboIndicator;
    public GameObject cleaningSpree;
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
        if (comboNumber>=9) {
            Debug.Log("CLEANING SPREE");
            
        }
        
        //clone.GetComponent<SpriteRenderer>().sprite = spriPac
    }
}
