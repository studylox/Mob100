using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpTo : MonoBehaviour
{
    public string SceneName;
    public void See(string sname)
    {
        SceneName = sname;
        SceneManager.LoadScene(SceneName);
    }
    public void F()
    {
        print("hello");
    }
}
