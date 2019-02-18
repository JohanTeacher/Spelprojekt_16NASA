using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class high_score : MonoBehaviour
{


    //This variables, are representation of the texts on unity
    public Text ScoreText1;
    public Text ScoreText2;
    public Text ScoreText3;
    public Text name1;
    public Text name2;
    public Text name3;

    // Use this for initialization
    void Start()
    {




        print(PlayerPrefs.GetInt("1st"));
        print(PlayerPrefs.GetInt("2nd"));
        print(PlayerPrefs.GetInt("3rd"));
        print(PlayerPrefs.GetString("name1"));
        print(PlayerPrefs.GetString("name2"));
        print(PlayerPrefs.GetString("name3"));




        // If the score is above the "1st" score then change that into 1st position. 
        if (PlayerPrefs.GetInt("Score") > PlayerPrefs.GetInt("1st"))
        {
            PlayerPrefs.SetInt("3rd", PlayerPrefs.GetInt("2nd"));
            PlayerPrefs.SetInt("2nd", PlayerPrefs.GetInt("1st"));
            PlayerPrefs.SetInt("1st", PlayerPrefs.GetInt("Score"));
            PlayerPrefs.SetString("name3", PlayerPrefs.GetString("name2"));
            PlayerPrefs.SetString("name2", PlayerPrefs.GetString("name1"));
            PlayerPrefs.SetString("name1", PlayerPrefs.GetString("Username"));


        }


        //If Score higher than 2nd but less than 1st. then put that score into 2nd position
        if (PlayerPrefs.GetInt("Score") > PlayerPrefs.GetInt("2nd") && PlayerPrefs.GetInt("Score") < PlayerPrefs.GetInt("1st"))
        {

            PlayerPrefs.SetInt("3rd", PlayerPrefs.GetInt("2nd"));
            PlayerPrefs.SetInt("2nd", PlayerPrefs.GetInt("Score"));
            PlayerPrefs.SetString("name3", PlayerPrefs.GetString("name2"));
            PlayerPrefs.SetString("name2", PlayerPrefs.GetString("Username"));

        }


        //if the Score is higher than the 3rd but less than 2nd, then put it in the 3rd position.
        if (PlayerPrefs.GetInt("Score") > PlayerPrefs.GetInt("3rd") && PlayerPrefs.GetInt("Score") < PlayerPrefs.GetInt("2nd"))
        {

            PlayerPrefs.SetInt("3rd", PlayerPrefs.GetInt("Score"));
            PlayerPrefs.SetString("name3", PlayerPrefs.GetString("Username"));

        }





        //Make the memory of "1st" equel with score text that is which the 1st position etc.
        ScoreText1.text = PlayerPrefs.GetInt("1st").ToString();
        ScoreText2.text = PlayerPrefs.GetInt("2nd").ToString();
        ScoreText3.text = PlayerPrefs.GetInt("3rd").ToString();

        //Make the memory of "1st"  equel with name text that is which the 1st position etc.
        name1.text = PlayerPrefs.GetString("name1");
        name2.text = PlayerPrefs.GetString("name2");
        name3.text = PlayerPrefs.GetString("name3");




    }

}
