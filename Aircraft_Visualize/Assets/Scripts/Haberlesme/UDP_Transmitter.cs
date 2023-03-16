using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

public class UDP_Transmitter : MonoBehaviour
{
    //public string IP = "127.0.0.1";
    //public int TransmitPort;
    //public HA_Bilgileri ha_Bilgileri;
    //private IPEndPoint _RemoteEndPoint;
    //private UdpClient _TransmitClient;
    //private float[] val;

    //private void Start()
    //{
    //    Initialize();
    //}

    //private void FixedUpdate()
    //{
    //    Send();
    //}
    ///// <summary>
    ///// Initialize objects.
    ///// </summary>S
    //private void Initialize()
    //{
    //    _RemoteEndPoint = new IPEndPoint(IPAddress.Parse(IP), TransmitPort);
    //    _TransmitClient = new UdpClient();
    //}

    //public void Send()
    //{
    //    try
    //    {
              
    //        byte[] serverMessageAsByteArray  = BitConverter.GetBytes(giden_veriler.Hedef_X_m);
    //        byte[] serverMessageAsByteArray2 = BitConverter.GetBytes(giden_veriler.Hedef_Y_m);
    //        byte[] serverMessageAsByteArray3 = BitConverter.GetBytes(giden_veriler.Zorla_Saga_Don);

    //        byte[] serverMessageAsByteArray4 = new byte[serverMessageAsByteArray.Length + serverMessageAsByteArray2.Length + serverMessageAsByteArray3.Length];

    //        int idx = 0;
    //        serverMessageAsByteArray.CopyTo(serverMessageAsByteArray4, idx); idx += 4;
    //        serverMessageAsByteArray2.CopyTo(serverMessageAsByteArray4,idx); idx += 4;
    //        serverMessageAsByteArray3.CopyTo(serverMessageAsByteArray4,idx); idx += 4;


    //        _TransmitClient.Send(serverMessageAsByteArray4, serverMessageAsByteArray4.Length, _RemoteEndPoint);
    //    }
    //    catch (Exception err)
    //    {
    //        Debug.Log("<color=red>" + err.Message + "</color>");
    //    }
    //}

    //private void OnApplicationQuit()
    //{
    //    try
    //    {
    //        _TransmitClient.Close();
    //    }
    //    catch (Exception err)
    //    {
    //        Debug.Log("<color=red>" + err.Message + "</color>");
    //    }
    //}

}