using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float delayInterval = 0;
    // Update is called once per frame
    void Update()
    {
        delayInterval += Time.deltaTime;
        // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space) && delayInterval > 0.5)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                delayInterval = 0;
            }
    }
}
