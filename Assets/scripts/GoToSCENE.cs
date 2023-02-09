using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Alexis{
public class GoToSCENE : MonoBehaviour
{

    public string nextSceneName;
    public void OnTouch()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
}