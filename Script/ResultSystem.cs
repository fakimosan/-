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
            resultText.text = "�Q�[���I�[�o�[\n�������P�Ƃ͌���Ȃ���I�I";
        }
        else if(QuizSystem.QuizScore == 11)
        {
            resultText.text = "�Q�[���N���A�I�I\n����ōЊQ�΍�̓o�b�`���I�I";
        }
        else
        {
            resultText.text = "�Q�[���N���A�I�I\n�S�␳��ڎw���Ă������I�I";
        }
    }

    public void OnlickReturnbutton()
    {
        SceneManager.LoadScene("Title");
    }
}
