using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemiScript : MonoBehaviour
{
    public GameObject Ennemi;
    public float movetopoint = 0.8f;
    public int pv = 1;
    public bool hostile = false;
    public VictoryorDefeat vd;
    public bool side = false;
    public List<Sprite> listeDechets = new List<Sprite>(); 
    public GameObject dechetAInstantier;
    public Transform fromDechet;
    public Transform toDechet;
    public bool lancement;
    public bool lance = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ennemi.transform.position = new Vector3(Ennemi.transform.position.x - movetopoint, Ennemi.transform.position.y, Ennemi.transform.position.z);
        if (lancement==true)
        {
            if (lance==false)
            {
                Debug.Log("ça vient d'ici");
                lance = true;
                Throw();
                
            }
        }
    }

    public void Throw()
    {
        
        GameObject dechet = Instantiate(dechetAInstantier,Ennemi.transform.position, Ennemi.transform.rotation);
        var choixSpriteDechet = Random.Range(1,5);
        dechet.GetComponent<SpriteRenderer>().sprite = listeDechets[choixSpriteDechet];
        dechet.GetComponent<Rigidbody>().AddForce(transform.up * 100);
        dechet.GetComponent<Rigidbody>().AddForce(transform.right * 100);
    }
}
