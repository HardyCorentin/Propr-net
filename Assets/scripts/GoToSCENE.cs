using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace Alexis
{

     public class GoToScene : MonoBehaviour
    {
        public AudioSource source;
        public void LoadScene(string sceneName)
        {
            var source = GameObject.FindObjectOfType<AudioSource>();
            DontDestroyOnLoad(source);
            SceneManager.LoadScene(sceneName);
        }
        //banana

    }
}
