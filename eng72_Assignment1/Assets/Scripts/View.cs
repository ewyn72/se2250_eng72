using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View : MonoBehaviour
{
    public GameObject cameraOne;
    public GameObject cameraTwo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switchCamera();
    }

    void switchCamera()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (cameraOne.activeInHierarchy)
            {
                cameraTwo.SetActive(true);
                cameraOne.SetActive(false);
            }
            else
            {
                cameraOne.SetActive(true);
                cameraTwo.SetActive(false);
            }

        }
    }
}
