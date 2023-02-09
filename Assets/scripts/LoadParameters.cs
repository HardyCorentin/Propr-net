using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace HardyCorentin
{

    public class LoadParameters : MonoBehaviour
    {
        public List<TestCreaMusique> listeniv;
        public int getIndex;
        public int choixMusique;
        //public GameObject recupere;
        public AudioSource hautParleur;

        // Start is called before the first frame update
        void Start()
        {
            Debug.Log(listeniv[choixMusique].track);
            choixMusique = PlayerPrefs.GetInt("choix");
            //recupere = GameObject.Find("Passeur");
            //getIndex =  recupere.GetComponent<LaunchScene>().index;
            hautParleur.clip = listeniv[choixMusique].track;
            hautParleur.Play(0);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
