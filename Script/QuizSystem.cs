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
    string[] item_name = new string[] { "缶詰", "水", "電池", "懐中電灯", "ブランケット", "ビスケット", "ろうそくと火", "ラジオ", "軍手", "雨かっぱ", "洋服", "包帯", "洗面器", "くすり", "ヘルメット", "お金" };
    string[] quiz_name = new string[] { "どうしてもお腹が減ってしまった", "作業をしていたら喉が渇いてしまった", "避難所で停電！何も見えなくなってしまった", "冬到来！どうにか寒さを凌がないと", "熱が出てきた！これ以上悪化させないようには", "服が汚れてきた！どうしよう", "余震発生！頭を守るための道具はどこに", "作業中に怪我をしてしまった…止血しなくては", "がれきの撤去作業中雨が…このままだと風邪を引いてしまう", "作業をしていたら夜に…周りが暗くなってきた", "携帯の電源が切れた…どうやって情報を集めよう", "電池式モバイルバッテリーの充電が切れてしまった" };
    string[,] question_mg = new string[,] { { "缶詰", "ビスケット", "" }, { "水", "", "" }, { "懐中電灯", "ろうそくと火", "" }, { "ブランケット", "軍手", "雨かっぱ" }, { "常備薬", "", "" }, { "洋服", "洗面器", "" }, { "ブランケット", "洋服", "ヘルメット" }, { "洋服", "包帯", "" }, { "雨かっぱ", "洋服", "" }, { "懐中電灯", "ろうそくと火", "" }, { "ラジオ", "", "" }, { "電池", "", "" } };
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

