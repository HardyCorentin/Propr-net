using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Alexis
{
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

            if (listeSprite.Count > 0)
            {

                comboIndicator.GetComponent<Image>().sprite = listeSprite[comboNumber];
                if (comboNumber >= 9)
                {
                    Debug.Log("CLEANING SPREE");

                }
            }

            //clone.GetComponent<SpriteRenderer>().sprite = spriPac
        }
    }
}
