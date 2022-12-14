using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random=System.Random;
using TMPro;
using System;

public class SelectQuestions3 : MonoBehaviour
{
    private List<List<string>> data;

    [SerializeField]
    private TMP_Text Question1,Question2,Question3,Question4,Question5,choice3_1,choice3_2,choice3_3,choice3_4,choice4_1,choice4_2,choice4_3,choice4_4,choice5_1,choice5_2,choice5_3,choice5_4;

    public static String Answer1,Answer2,Answer3,Answer4,Answer5;

    void Awake() {  
        Question1 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question1").GetComponent<TMP_Text>();
        Question2 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question2").GetComponent<TMP_Text>();
        Question3 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question3").GetComponent<TMP_Text>();
        Question4 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question4").GetComponent<TMP_Text>();
        Question5 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question5").GetComponent<TMP_Text>();

        choice3_1 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question3/ToggleGroup3/Toggle1/Answer1").GetComponent<TMP_Text>();
        choice3_2 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question3/ToggleGroup3/Toggle2/Answer2").GetComponent<TMP_Text>();
        choice3_3 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question3/ToggleGroup3/Toggle3/Answer3").GetComponent<TMP_Text>();
        choice3_4 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question3/ToggleGroup3/Toggle4/Answer4").GetComponent<TMP_Text>();

        choice4_1 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question4/ToggleGroup4/Toggle1/Answer1").GetComponent<TMP_Text>();
        choice4_2 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question4/ToggleGroup4/Toggle2/Answer2").GetComponent<TMP_Text>();
        choice4_3 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question4/ToggleGroup4/Toggle3/Answer3").GetComponent<TMP_Text>();
        choice4_4 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question4/ToggleGroup4/Toggle4/Answer4").GetComponent<TMP_Text>();

        choice5_1 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question5/ToggleGroup5/Toggle1/Answer1").GetComponent<TMP_Text>();
        choice5_2 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question5/ToggleGroup5/Toggle2/Answer2").GetComponent<TMP_Text>();
        choice5_3 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question5/ToggleGroup5/Toggle3/Answer3").GetComponent<TMP_Text>();
        choice5_4 = GameObject.Find("Canvas/Panel/Scroll View/Viewport/Content/Grid/Question5/ToggleGroup5/Toggle4/Answer4").GetComponent<TMP_Text>();
    }

    // Start is called before the first frame update
    void Start()
    {
        data = RealTimeDatabase.Questions_3;

        QuestionSelectorTrueFalse();
        QuestionSelectorMultipleChoice();
    }

    public void QuestionSelectorTrueFalse(){
        Random random = new Random();

        string firstQ = random.Next(0,6).ToString();

        string secondQ = random.Next(0,6).ToString();

        while (secondQ == firstQ){
            secondQ = random.Next(0,6).ToString();
        }

        for (int i = 0; i<data.Count; i++){
            if (data[i][0] == firstQ){
                //function to replace text on test
                Question1.text = data[i][2];
                Answer1 = data[i][1];
            }
            else if (data[i][0] == secondQ) {
                Question2.text = data[i][2];
                Answer2 = data[i][1];
            }
        }
    }

    public void QuestionSelectorMultipleChoice(){
        Random random = new Random();

        string firstQ = random.Next(6,12).ToString();

        string secondQ = random.Next(6,12).ToString();

        while (secondQ == firstQ){
            secondQ = random.Next(6,12).ToString();
        }

        string thirdQ = random.Next(6,12).ToString();

        while (thirdQ == firstQ || thirdQ == secondQ){
            thirdQ = random.Next(6,12).ToString();
        }

        for (int i = 0; i<data.Count; i++){
            if (data[i][0] == firstQ ){
                //function to replace text on test
                Question3.text = data[i][2];
                choice3_1.text = data[i][3];
                choice3_2.text = data[i][4];
                choice3_3.text = data[i][5];
                choice3_4.text = data[i][6];
                Answer3 = data[i][1];
            }
            else if (data[i][0] == secondQ){
                Question4.text = data[i][2];
                choice4_1.text = data[i][3];
                choice4_2.text = data[i][4];
                choice4_3.text = data[i][5];
                choice4_4.text = data[i][6];
                Answer4 = data[i][1];
            }
            else if (data[i][0] == thirdQ) {
                Question5.text = data[i][2];
                choice5_1.text = data[i][3];
                choice5_2.text = data[i][4];
                choice5_3.text = data[i][5];
                choice5_4.text = data[i][6];
                Answer5 = data[i][1];
            }
        }
    }
}