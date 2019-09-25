using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissapear : MonoBehaviour
{
    public GameObject gandalf;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        print(Time.time);
        yield return new WaitForSeconds(10);
        gandalf.SetActive(false);
        print(Time.time);
    }
}
