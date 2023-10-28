using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finel : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {



        if (other.gameObject.name == "Player")
        {
            SceneManager.LoadScene("finel");

        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}