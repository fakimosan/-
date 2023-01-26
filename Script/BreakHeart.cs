using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakHeart : MonoBehaviour
{
    public GameObject HP1,HP2,HP3;

    void Start()
    {
        HP1 = GameObject.Find("Redheart1");
        HP2 = GameObject.Find("Redheart2");
        HP3 = GameObject.Find("Redheart3");
    }
    // Update is called once per frame
    void Update()
    {
        if(QuizSystem.OutCount == 1)
        {
            Destroy(HP1);
        }
        if(QuizSystem.OutCount == 2)
        {
            Destroy(HP2);
        }
        if (QuizSystem.OutCount == 3)
        {
            Destroy(HP3);
        }
    }
}
