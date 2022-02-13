using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOverScripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float Coins = PlayerPrefs.GetFloat("Coins");
        GameObject.Find("coins").GetComponent<Text>().text = "Collect coins: " + Coins.ToString("0.00");
    }
}
