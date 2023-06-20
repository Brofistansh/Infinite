using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndRunSequence : MonoBehaviour
{
    public GameObject liveCoins;
    public GameObject liveDis;
    public GameObject endScreen;
    public GameObject fadeOut;
    void Start()
    {
        StartCoroutine(EndSequence()); 
    }

   IEnumerator EndSequence()
    {
        yield return new WaitForSeconds(5);
        liveCoins.SetActive(false);
        liveDis.SetActive(false);
        yield return new WaitForSeconds(5);
        endScreen.SetActive(true);

        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);
    }
}
