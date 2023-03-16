using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "HA_Bilgileri", fileName = "HA_Bilgileri")]
public class HA_Bilgileri : ScriptableObject // Hava Araci Bilgileri
{
    //public enum Kontrol_Modu
    //{
    //    Klavye_Mouse,
    //    Matlab,
    //}
    //public Kontrol_Modu kontrol_Modu;
    public float x_m;
    public float y_m;
    public float z_m;
    public float phi_der;
    public float theta_der;
    public float psi_der;
    public float CG_X_m;
    public float CG_Y_m;
    public float CG_Z_m;
    public float alpha_der;
    public float beta_der;
    public float gamma_der;
    public float TAS_m_sn;
    public float Mach;
    public float elevator_der;
    public float aileron_der;
    public float rudder_der;
    public float flap_der;
    public float itki_per;
    public float irtifa_m;

}  
