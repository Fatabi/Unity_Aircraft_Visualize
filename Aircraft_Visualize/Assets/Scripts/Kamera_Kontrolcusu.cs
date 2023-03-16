using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera_Kontrolcusu : MonoBehaviour
{
    public GameObject[] kameralar;
    
    void Start()
    {
        foreach (var kamera in kameralar)
        {
            if (kamera.name == "Takip_Kamerasi")
            {
                kamera.SetActive(true);
            }
            else
            {
                kamera.SetActive(false);
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            int counter = 0;
            foreach (var item in kameralar)
            {
                if (counter == 0) 
                {
                    item.SetActive(true);
                }
                else
                {
                    item.SetActive(false);
                }
                counter++;
            }
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            int counter = 0;
            foreach (var item in kameralar)
            {
                if (counter == 1)
                {
                    item.SetActive(true);
                }
                else
                {
                    item.SetActive(false);
                }
                counter++;
            }
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            int counter = 0;
            foreach (var item in kameralar)
            {
                if (counter == 2)
                {
                    item.SetActive(true);
                }
                else
                {
                    item.SetActive(false);
                }
                counter++;
            }
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            int counter = 0;
            foreach (var item in kameralar)
            {
                if (counter == 3)
                {
                    item.SetActive(true);
                }
                else
                {
                    item.SetActive(false);
                }
                counter++;
            }
        }
        if (Input.GetKey(KeyCode.Alpha5))
        {
            int counter = 0;
            foreach (var item in kameralar)
            {
                if (counter == 4)
                {
                    item.SetActive(true);
                }
                else
                {
                    item.SetActive(false);
                }
                counter++;
            }
        }
        if (Input.GetKey(KeyCode.Alpha6))
        {
            int counter = 0;
            foreach (var item in kameralar)
            {
                if (counter == 5)
                {
                    item.SetActive(true);
                }
                else
                {
                    item.SetActive(false);
                }
                counter++;
            }
        }
        if (Input.GetKey(KeyCode.Alpha7))
        {
            int counter = 0;
            foreach (var item in kameralar)
            {
                if (counter == 6)
                {
                    item.SetActive(true);
                }
                else
                {
                    item.SetActive(false);
                }
                counter++;
            }
        }
        if (Input.GetKey(KeyCode.Alpha8))
        {
            int counter = 0;
            foreach (var item in kameralar)
            {
                if (counter == 7)
                {
                    item.SetActive(true);
                }
                else
                {
                    item.SetActive(false);
                }
                counter++;
            }
        }
    }
}
