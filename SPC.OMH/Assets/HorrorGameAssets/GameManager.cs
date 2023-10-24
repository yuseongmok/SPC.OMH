using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public Text timer;
    public Text WoodText;
    static public int time = 800;
    public int woodNum = 0;
    float minX, minY, maxX, maxY;

    public GameObject SZS;

    // Use this for initialization
    void Start()
    {
        WoodText.text = "CardKey : " + woodNum.ToString();
        StartCoroutine(timerF());
    }

    // Update is called once per frame
    void Update()
    {
        if (time <= 0)
        {
            SceneManager.LoadScene("GameOver01");
        }
        // Check if the player has collected 4 CardKey objects
        if (woodNum >= 4)
        {
            SceneManager.LoadScene("PlayScene24"); // Replace "NextScene" with the name of the scene you want to load
        }
    }

    IEnumerator timerF()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            time -= 1;
            timer.text = "Remain : " + time.ToString();
        }
    }

    public void GetWood()
    {
        woodNum++;
        WoodText.text = "CardKey : " + woodNum.ToString();
    }

}
