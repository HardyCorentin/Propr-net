using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ListeNiveaux : MonoBehaviour
{
    public List<TestCreaMusique> listeniv;
    public GameObject panneau;
    public TextMeshPro nomMusique;
    public TextMeshPro nomArtiste;
    public float xPan = -5.5f;
    public float xTit = -5.5f;
    public int yPan = 0;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(listeniv);
        for (int i = 0; i < listeniv.Count; i++)
        {
            Debug.Log(listeniv.Count);
            Debug.Log("ffezfezfezfez");
            var newObject = Instantiate(panneau, new Vector2(xPan, yPan), Quaternion.identity);
            newObject.GetComponent<SpriteRenderer>().sprite = listeniv[i].jaquette;
            xPan = xPan + 6.75f;
            var newText = Instantiate(nomMusique, new Vector2(xTit, 3.5f), Quaternion.identity);
            xTit = xTit + 6.75f;
            newText.text = listeniv[i].nom;
            //newObject.GetComponent<LaunchScene>().morceau = listeniv[i];
            newObject.GetComponent<LaunchScene>().index = i;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }


}