using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arka_Planda_Oynat : MonoBehaviour
{
    void Awake()
    {
        if (Application.isEditor)
            Application.runInBackground = true;
    }
}
