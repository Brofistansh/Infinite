using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelDistance : MonoBehaviour
{
    public GameObject disDisplay;
    public GameObject disEndDisplay;
    public int disRu;
    public bool addingDis = false;
    void Update()
    {
        if (addingDis == false)
        {
            addingDis = true;
            StartCoroutine(AddingDis());
        }
    }
    IEnumerator AddingDis()
    {
        disRu += 1;
        disDisplay.GetComponent<Text>().text = "" + disRu;
        disEndDisplay.GetComponent<Text>().text = "" + disRu;
        yield return new WaitForSeconds(0.25f);
        addingDis = false;
    }
}
