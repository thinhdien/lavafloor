using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideText : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(RemoveAfterSeconds(3, gameObject));
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private IEnumerator RemoveAfterSeconds(int seconds, GameObject obj)
    {
        yield return new WaitForSeconds(seconds);
        obj.SetActive(false);
    }
}