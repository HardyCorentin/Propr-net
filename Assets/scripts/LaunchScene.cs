using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LaunchScene : MonoBehaviour
{
    //public Musique morceau;
    public int index;
    public string nextSceneName;
    //public GameObject conserve;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    public void OnMouseDown()
    {
        Debug.Log("fswfesfeffs");
        PlayerPrefs.SetInt("choix", index);
        //DontDestroyOnLoad(conserve);
        SceneManager.LoadScene("SampleScene");
    }


    public void OnTouch()
    {

        Debug.Log("fswfesfeffs");
        PlayerPrefs.SetInt("choix", index);
        //DontDestroyOnLoad(conserve);
        SceneManager.LoadScene(nextSceneName);
    }
}

