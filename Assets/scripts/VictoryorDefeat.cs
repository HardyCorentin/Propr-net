using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace Alexis{
public class VictoryorDefeat : MonoBehaviour
{
    public float hp =1f;
    public GameObject ennemyRight;
    public GameObject allyRight;
    public int count = 0;
    public string loseScene;
    public string winScene;
    public AudioSource source;
    public bool side = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(side);
        if(hp <= 0f)
        {
            SceneManager.LoadScene(loseScene);
        }
        if (source.isPlaying == false)
        {
            Debug.Log("Gagn�");
            SceneManager.LoadScene(winScene);
        }
    }
}
}
