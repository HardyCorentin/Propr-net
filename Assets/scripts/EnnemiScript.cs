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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ennemi.transform.position = new Vector3(Ennemi.transform.position.x - movetopoint, Ennemi.transform.position.y, Ennemi.transform.position.z);

    }
}
