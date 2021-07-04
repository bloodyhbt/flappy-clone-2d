using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Medal : MonoBehaviour
{
    //medals given when your get succesfull scores
    public Sprite normalMedal;
    public Sprite bronzeMedal;
    public Sprite silverMedal;
    public Sprite goldMedal;

    public GameObject sparkle1;

    Image img;

    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
        int gameScore = GameManager.gameScore;

        if(gameScore > 0 && gameScore <= 2)
        {
            img.sprite = normalMedal;
        }
        else if(gameScore > 2 && gameScore <= 4)
        {
            img.sprite = bronzeMedal;
            sparkle1.SetActive(true);
        }
        else if (gameScore > 4 && gameScore <= 6)
        {
            img.sprite = silverMedal;
            sparkle1.SetActive(true);
        }
        else if (gameScore > 6)
        {
            img.sprite = goldMedal;
            sparkle1.SetActive(true);
        }
    }

    
}
