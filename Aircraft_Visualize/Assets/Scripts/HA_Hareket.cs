using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HA_Hareket : MonoBehaviour
{
    public HA_Bilgileri ha_bilgileri; // Hava Araci Bilgileri
    public GameObject Burun_Ucu;
    private Vector3 unity_phi_theta_psi_der = new Vector3(0, 0f, 0f);
    private Vector3 unity_x_y_z_m = new Vector3(0f, 0f, 0f);
    private GameObject[] Butun_Childrens;

    private void FixedUpdate()
    {
        Burun_Ucu.transform.localPosition = new Vector3(ha_bilgileri.CG_Y_m * (-1), ha_bilgileri.CG_Z_m, ha_bilgileri.CG_X_m * (-1));
        unity_phi_theta_psi_der = new Vector3(ha_bilgileri.theta_der * (-1), ha_bilgileri.psi_der, ha_bilgileri.phi_der * (-1));
        transform.rotation = Quaternion.Euler(unity_phi_theta_psi_der);
        transform.position = new Vector3(ha_bilgileri.y_m + ha_bilgileri.CG_Y_m, ha_bilgileri.z_m * (-1) - ha_bilgileri.CG_Z_m, ha_bilgileri.x_m + ha_bilgileri.CG_X_m);
    }
 
}
