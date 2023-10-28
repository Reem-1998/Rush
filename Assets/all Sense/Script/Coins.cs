using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;// ترا هذا يخص ال legecy
using TMPro; // ترا هذا يخص ال TMP

public class Coins : MonoBehaviour
{

    public static int Score0 = 0;
     //public Text Score;
    public TMP_Text Score2; //هذا// يخص TMP
    // Start is called before the first frame update
    void Start()
    {
        Score2 = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Score2.text = "Score: " + Score0; 
    }
}
