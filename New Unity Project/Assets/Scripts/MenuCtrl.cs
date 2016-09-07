using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuCtrl : MonoBehaviour {


    public void SceneLoad(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
