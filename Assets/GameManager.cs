using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int coinCount = 0;
    public TextMeshProUGUI coinText;
    void GetCoin()
    {
        coinCount++;
        coinText.text = coinCount + "";
        Debug.Log("동전 : " + coinCount);
    }
    void RedCoinStart()
    {
        DestroyObstacles();
    }
    void DestroyObstacles()
    {
        GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacles");
        for (int i = 0; i < obstacles.Length; i++)
        {
            Destroy(obstacles[i]);
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
