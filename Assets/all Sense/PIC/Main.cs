using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MAIN : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void loads()
    {

        SceneManager.LoadScene("Rush1");

    }
    public void exitt()
    {
        Application.Quit();
    }
    public void loadmain()
    {
        SceneManager.LoadScene("Rush1");
    }
}
