using UnityEngine;
using System.Collections;

public class Delay : MonoBehaviour
{
    public GameObject fire;
    void Start()
    {
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        print(Time.time);
        yield return new WaitForSeconds(8);
        fire.SetActive(true);
        print(Time.time);
    }
}