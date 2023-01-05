using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public EnnemiScript objetASpawner;
    public float tempsRespawn;
    public Transform parent;
    public float compteur;
    public VictoryorDefeat vd;
    public Sprite spriPac;

        // Start is called before the first frame update
    void Start()
    {
        //var newObject = Instantiate(objetASpawner, new Vector2(Random.Range(-1, 1), Random.Range(-1, 1)), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

        compteur -= Time.deltaTime;
        if (compteur <= 0)
        {
            
            compteur -= Time.deltaTime;
            if (compteur <= 0)
            {
                var hauteur = Random.Range(-4f, -1.5f);
                var hostilite = Random.Range(0, 4);
                EnnemiScript clone = Instantiate(objetASpawner, parent.position, parent.rotation);
                if (hostilite == 0)
                {
                    clone.GetComponent<EnnemiScript>().hostile = false;
                    clone.GetComponent<SpriteRenderer>().sprite = spriPac ;
                }
                if (hostilite == 1 || hostilite == 2 || hostilite == 3)
                {
                    clone.GetComponent<EnnemiScript>().hostile = true;
                }


                clone.transform.position = new Vector2(clone.transform.position.x, hauteur);
                //clone.transform.position = Vector2.Lerp(clone.transform.position, parent.position,Time.deltaTime);
                clone.transform.position = clone.transform.position + new Vector3(1, 0, 0);
                compteur = tempsRespawn;
            }
        }

    }
}
