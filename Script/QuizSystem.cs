using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class QuizSystem : MonoBehaviour
{
    int i, j;
    public static int QuizScore = 0;
    public static int OutCount = 0;
    public int GameCount = 1;
    public string[] answer = new string[3];
    public Text choiceText1, choiceText2, choiceText3, choiceText4, choiceText5, choiceText6,quizText,ScoreText,countText;
    public Button button1, button2, button3, button4, button5, button6;
    int[] item = new int[] { 3, 6, 1, 5, 4, 2 };
    string[] item_name = new string[] { "�ʋl", "��", "�d�r", "�����d��", "�u�����P�b�g", "�r�X�P�b�g", "�낤�����Ɖ�", "���W�I", "�R��", "�J������", "�m��", "���", "���ʊ�", "������", "�w�����b�g", "����" };
    string[] quiz_name = new string[] { "�ǂ����Ă������������Ă��܂���", "��Ƃ����Ă�����A�������Ă��܂���", "���Œ�d�I���������Ȃ��Ȃ��Ă��܂���", "�~�����I�ǂ��ɂ������𗽂��Ȃ���", "�M���o�Ă����I����ȏ㈫�������Ȃ��悤�ɂ�", "��������Ă����I�ǂ����悤", "�]�k�����I������邽�߂̓���͂ǂ���", "��ƒ��ɉ�������Ă��܂����c�~�����Ȃ��Ă�", "���ꂫ�̓P����ƒ��J���c���̂܂܂��ƕ��ׂ������Ă��܂�", "��Ƃ����Ă������Ɂc���肪�Â��Ȃ��Ă���", "�g�т̓d�����؂ꂽ�c�ǂ�����ď����W�߂悤", "�d�r�����o�C���o�b�e���[�̏[�d���؂�Ă��܂���" };
    string[,] question_mg = new string[,] { { "�ʋl", "�r�X�P�b�g", "" }, { "��", "", "" }, { "�����d��", "�낤�����Ɖ�", "" }, { "�u�����P�b�g", "�R��", "�J������" }, { "�����", "", "" }, { "�m��", "���ʊ�", "" }, { "�u�����P�b�g", "�m��", "�w�����b�g" }, { "�m��", "���", "" }, { "�J������", "�m��", "" }, { "�����d��", "�낤�����Ɖ�", "" }, { "���W�I", "", "" }, { "�d�r", "", "" } };
    void Start()
    {
        choiceText1 = GameObject.Find("choice1").GetComponent<Text>();
        choiceText2 = GameObject.Find("choice2").GetComponent<Text>();
        choiceText3 = GameObject.Find("choice3").GetComponent<Text>();
        choiceText4 = GameObject.Find("choice4").GetComponent<Text>();
        choiceText5 = GameObject.Find("choice5").GetComponent<Text>();
        choiceText6 = GameObject.Find("choice6").GetComponent<Text>();
        quizText = GameObject.Find("Question").GetComponent<Text>();
        ScoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        countText = GameObject.Find("CountText").GetComponent<Text>();
        GameCount = 1;
        countText.text = GameCount.ToString();
        Answerlabelset();
        Questionlabelset();
        
    }

    void Answerlabelset()
    {
        for (i = 1; i <= 16; i++)
        {
            if (item[0] == i)
            {
                choiceText1.text = item_name[i - 1];
            }
        }
        for (i = 1; i <= 16; i++)
        {
            if (item[1] == i)
            {
                choiceText2.text = item_name[i - 1];
            }
        }
        for (i = 1; i <= 16; i++)
        {
            if (item[2] == i)
            {
                choiceText3.text = item_name[i - 1];
            }
        }
        for (i = 1; i <= 16; i++)
        {
            if (item[3] == i)
            {
                choiceText4.text = item_name[i - 1];
            }
        }
        for (i = 1; i <= 16; i++)
        {
            if (item[4] == i)
            {
                choiceText5.text = item_name[i - 1];
            }
        }
        for (i = 1; i <= 16; i++)
        {
            if (item[5] == i)
            {
                choiceText6.text = item_name[i - 1];
            }
        }
    }

    public string[] Questionlabelset()
    {
        int rnd = Random.Range(0, 12);
        quizText.text = quiz_name[rnd];
        for (i = 0; i < 3; i++)
        {
            answer[i] = question_mg[rnd,i];
            Debug.Log(answer[i]);
        }
        return answer;
    }

   
}

