using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownController : MonoBehaviour
{
    public int countdownTime;
    public Text countdownDisplay;
     
    public GameObject leftButton;
    public GameObject rightButton;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountDownToStart());
    }

    IEnumerator CountDownToStart()
    {
        while(countdownTime > 0)
        {

            countdownDisplay.text = countdownTime.ToString();
            yield return new WaitForSeconds(1f);
            countdownTime--;
            //GameObject.Find("SoundObject").GetComponents<AudioSource>()[1].Play();
        }
        //GameObject.Find("SoundObject").GetComponents<AudioSource>()[1].Play();
        countdownDisplay.text = "GO!";
        GameObject.Find("SoundObject").GetComponents<AudioSource>()[2].Play();
        yield return new WaitForSeconds(1f);
        countdownDisplay.gameObject.SetActive(false);
        leftButton.SetActive(true);
        rightButton.SetActive(true);
    }
}
