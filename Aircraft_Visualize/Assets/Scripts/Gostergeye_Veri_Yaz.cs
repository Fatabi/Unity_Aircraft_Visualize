using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gostergeye_Veri_Yaz : MonoBehaviour
{
    public HA_Bilgileri ha_Bilgileri;
    public Text[] texts;
    // Update is called once per frame
    void Update()
    {
        int idx = 0;

        texts[idx].text = ha_Bilgileri.phi_der.ToString("n2");
        idx = idx + 1;
        texts[idx].text = ha_Bilgileri.theta_der.ToString("n2");
        idx = idx + 1;
        texts[idx].text = ha_Bilgileri.psi_der.ToString("n2");
        idx = idx + 1;
        idx = idx + 1;
        texts[idx].text = ha_Bilgileri.alpha_der.ToString("n2");
        idx = idx + 1;
        texts[idx].text = ha_Bilgileri.beta_der.ToString("n2");
        idx = idx + 1;
        texts[idx].text = ha_Bilgileri.gamma_der.ToString("n2");
        idx = idx + 1;
        idx = idx + 1;
        texts[idx].text = ha_Bilgileri.TAS_m_sn.ToString("n2");
        idx = idx + 1;
        texts[idx].text = ha_Bilgileri.Mach.ToString("n2");
        idx = idx + 1;
        idx = idx + 1;
        texts[idx].text = ha_Bilgileri.elevator_der.ToString("n2");
        idx = idx + 1;
        texts[idx].text = ha_Bilgileri.aileron_der.ToString("n2");
        idx = idx + 1;
        texts[idx].text = ha_Bilgileri.rudder_der.ToString("n2");
        idx = idx + 1;
        texts[idx].text = ha_Bilgileri.flap_der.ToString("n2");
        idx = idx + 1;
        texts[idx].text = ha_Bilgileri.itki_per.ToString("n2");
        idx = idx + 1;
        idx = idx + 1;
        //texts[idx].text = ha_Bilgileri.irtifa_m.ToString("n2");
    }
}
