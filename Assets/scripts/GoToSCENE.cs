using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace HardyCorentin
{

    public class GoToScene : MonoBehaviour
    {

        public void LoadScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }

    }
}
