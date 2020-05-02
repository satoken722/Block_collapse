using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject ClearUI;
    public GameObject GameOverUI;

    public void Update()
    {
        int count = GameObject.FindGameObjectsWithTag("Block").Length;
        int count1 = GameObject.FindGameObjectsWithTag("Player").Length;

        if (count == 0)
        {
            // ClearUIをアクティブにする
            ClearUI.SetActive(true);
            // クリア時にBallを消滅する
            GameObject obj = GameObject.Find("Ball");
            Destroy(obj);
        }
        // Ballが無くなり、かつBlockが残っている時にゲームオーバーとなる条件
        if (count1 == 0 && count != 0)
        {
            //GameOverUIをアクティブにする
            GameOverUI.SetActive(true);
        }
    }
}