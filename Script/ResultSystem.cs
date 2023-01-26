using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class ResultSystem : MonoBehaviour
{
    Text resultText;
    void Start()
    {
        resultText = GameObject.Find("MainText").GetComponent<Text>();
    }
    void Update()
    {
        if (QuizSystem.OutCount == 3)
        {
            resultText.text = "ゲームオーバー\n正解が１つとは限らないよ！！";
        }
        else if(QuizSystem.QuizScore == 11)
        {
            resultText.text = "ゲームクリア！！\nこれで災害対策はバッチリ！！";
        }
        else
        {
            resultText.text = "ゲームクリア！！\n全問正解目指してもう一回！！";
        }
    }

    public void OnlickReturnbutton()
    {
        SceneManager.LoadScene("Title");
    }
}
