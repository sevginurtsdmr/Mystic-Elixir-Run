using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
   [SerializeField] public TMP_Text YourScore;
   [SerializeField] public TMP_Text HighScore;

   private void Start()
   {
      ScoreDisplay();
      HighScoreDisplay();
   }

   private void ScoreDisplay()
   {
      YourScore.text = "Your Score:" + Character.PlayerCoin;
   }

   private void HighScoreDisplay()
   {
      HighScore.text = "High Score:" + PlayerPrefs.GetInt("highScore").ToString();
   }
}
