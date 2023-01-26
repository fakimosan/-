using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using System.Threading;
public class judge : MonoBehaviour
{
    void Update()
    {
        QuizSystem system;
        GameObject obj = GameObject.Find("Quizwindow");
        system = obj.GetComponent<QuizSystem>();
        if (QuizSystem.OutCount == 3)
        {
            Invoke("GameEnd", 2);
        }

        if (system.GameCount == 11)
        {
            Invoke("GameEnd", 2);
        }
    }
    public void Onclickbutton()
    {
        QuizSystem system;
        GameObject obj = GameObject.Find("Quizwindow");
        system = obj.GetComponent<QuizSystem>();
        Text selectedBtn = this.GetComponentInChildren<Text>();
        for (int i = 0; i < 3; i++)
        {
            Debug.Log(system.answer[i]);
        }
        if (system.answer[0] == selectedBtn.text)
        {
            system.quizText.text ="〇正解";
            QuizSystem.QuizScore++;
            system.GameCount++;
            system.ScoreText.text = QuizSystem.QuizScore.ToString();
        }
        else if (system.answer[1] == selectedBtn.text)
        {
            system.quizText.text = "〇正解";
            QuizSystem.QuizScore++;
            system.GameCount++;
            system.ScoreText.text = QuizSystem.QuizScore.ToString();
        }
        else if (system.answer[2] == selectedBtn.text)
        {
            system.quizText.text = "〇正解";
            QuizSystem.QuizScore++;
            system.GameCount++;
            system.ScoreText.text = QuizSystem.QuizScore.ToString();
        }
        else
        {
            system.quizText.text = "不正解";
            system.GameCount++;
            QuizSystem.OutCount++;
            Debug.Log(QuizSystem.OutCount);
        }

        Invoke("Next", 2);
        
    }

    void Next()
    {
        QuizSystem system;
        GameObject obj = GameObject.Find("Quizwindow");
        system = obj.GetComponent<QuizSystem>();

        system.Questionlabelset();
        Debug.Log("次の問題に進みます");
        system.countText.text = system.GameCount.ToString();
    }
    void GameEnd()
    {
        SceneManager.LoadScene("Result");
    }
}
