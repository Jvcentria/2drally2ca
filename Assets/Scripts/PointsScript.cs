using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class PointsScript : MonoBehaviour
{
    public float timer = 300f;

    public float coin = 0f;

    private GameObject t1 = null;
    private GameObject t2 = null;

    // Start is called before the first frame update
    void Start()
    {
        this.t1 = GameObject.Find("text1");
        this.t2 = GameObject.Find("text2");
    }

    // Update is called once per frame
    void Update()
    {
        this.timer -= Time.deltaTime * 10f;
        this.t1.GetComponent<Text>().text = "Time left " + this.timer.ToString("0");
        this.t2.GetComponent<Text>().text = "Coin " + this.coin.ToString("0.00");

        //aika loppuu ja tulee game over
        if (this.timer < 0f)
        {
            //tallentaa kerätyt kolikot
            PlayerPrefs.SetFloat("Collect coins", this.coin);
            SceneManager.LoadScene("FinishScene");
        }
    }


}
