using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public int score = 0;
    // Update is called once per frame
    void Update()
    {
        // scoreText.text = player.position.z.ToString("0");
        scoreText.text = score.ToString();
        
    }
  public  void getBonus()
    {
        score += 100;
        scoreText.text += score.ToString("0");
    }


}
