using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public static int bestScore = 0;
    private float Playtime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Playtime += Time.deltaTime;
        score = Mathf.RoundToInt(Playtime);
        GetComponent<Text>().text = Score.score.ToString();
        //text_Score.text = "" + Mathf.Round(Playtime);
    }
}
