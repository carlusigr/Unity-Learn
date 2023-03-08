using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{   
    public GameObject camera1;
    public GameObject camera2;
    public GameObject camera3;
    public GameObject camera4;
    // Start is called before the first frame update
    void Start()
    {
        camera1.SetActive(true);
        camera2.SetActive(false);
        camera3.SetActive(true);
        camera4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q)){
            CameraOne();
        }
        if(Input.GetKeyDown(KeyCode.E)){
            CameraTwo();
        }
    }

    void CameraOne(){
        camera1.SetActive(true);
        camera2.SetActive(false);
        camera3.SetActive(true);
        camera4.SetActive(false);
    }

    void CameraTwo(){
        camera2.SetActive(true);
        camera1.SetActive(false);
        camera4.SetActive(true);
        camera3.SetActive(false);
    }
}
