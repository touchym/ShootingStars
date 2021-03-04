using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreT : MonoBehaviour
{

    public Text scoreText;
    public Text hscoreText;

    public static int score;
    public int hscore;


    // Start is called before the first frame update
    void Start()
    {

        hscore = PlayerPrefs.GetInt("hscore", hscore);
        hscoreText.text = hscore.ToString();


    }

    // Update is called once per frame
    void Update()
    {
        if (hscore < score)
        {
            hscore = score;

            PlayerPrefs.SetInt("hscore", hscore);
        }
      

        scoreText.text = score.ToString();
        
    }

    public static void ResetScore()
    {
        score = 0;
    }
}
