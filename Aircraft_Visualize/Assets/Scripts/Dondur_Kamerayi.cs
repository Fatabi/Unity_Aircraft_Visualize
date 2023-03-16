using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dondur_Kamerayi : MonoBehaviour
{
    public GameObject Dondurulecek_Camera;
    public float rotation_vel_deg_sn;

    private void Update()
    {
        Vector3 eksenim = new Vector3(0f, 1f, 0f);
        Dondurulecek_Camera.transform.Rotate(eksenim, rotation_vel_deg_sn * Time.deltaTime);

    }
    
}
