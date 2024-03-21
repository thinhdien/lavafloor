using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallDetect : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (gameObject.transform.position.y <= -10)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}