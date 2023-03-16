using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using UnityEngine.Networking;

public class UDP_Receive : MonoBehaviour
{
    public string IP;
    public int Port;
    public HA_Bilgileri ha_Bilgileri;
    private UdpClient _ReceiveClient;
    private Thread _ReceiveThread;
    private IPEndPoint ipEndPoint;
    
    
    private void Start()
    {
        Initialize();
    }

    public void Initialize()
    {
        ipEndPoint = new IPEndPoint(IPAddress.Parse(IP), Port);
        _ReceiveThread = new Thread(
            new ThreadStart(ReceiveData));
        _ReceiveThread.IsBackground = true;
        _ReceiveThread.Start();
        
    }

    private void ReceiveData()
    {
        _ReceiveClient = new UdpClient(Port);
        
        while (true)
        {
            try
            {
                /*PEndPoint anyIP = new IPEndPoint(IPAddress.Any, 0);*/
                byte[] data = _ReceiveClient.Receive(ref ipEndPoint);
                if (data != null)
                {
                    Decode_Data(data);
                }
                
            }
            catch (Exception err)
            {
                Debug.Log("<color=red>" + err.Message + "</color>");
            }
        }
    }
    private void OnApplicationQuit()
    {
        try
        {
            _ReceiveThread.Abort();
            _ReceiveThread = null;
            _ReceiveClient.Close();
        }
        catch (Exception err)
        {
            Debug.Log("<color=red>" + err.Message + "</color>");
        }
    }
    private void Decode_Data(byte[] data)
    {
        //Array.Reverse(data);
    int idx = 0;
    ha_Bilgileri.x_m = BitConverter.ToSingle(data, idx); idx += 4;
    ha_Bilgileri.y_m = BitConverter.ToSingle(data, idx); idx += 4;
    ha_Bilgileri.z_m = BitConverter.ToSingle(data, idx); idx += 4;
    ha_Bilgileri.phi_der = BitConverter.ToSingle(data, idx); idx += 4;
    ha_Bilgileri.theta_der = BitConverter.ToSingle(data, idx); idx += 4;
    ha_Bilgileri.psi_der = BitConverter.ToSingle(data, idx); idx += 4;
    ha_Bilgileri.CG_X_m = BitConverter.ToSingle(data, idx); idx += 4;
    ha_Bilgileri.CG_Y_m = BitConverter.ToSingle(data, idx); idx += 4;
    ha_Bilgileri.CG_Z_m = BitConverter.ToSingle(data, idx); idx += 4;
    ha_Bilgileri.alpha_der = BitConverter.ToSingle(data, idx); idx += 4;
    ha_Bilgileri.beta_der = BitConverter.ToSingle(data, idx); idx += 4;
    ha_Bilgileri.gamma_der = BitConverter.ToSingle(data, idx); idx += 4;
    ha_Bilgileri.TAS_m_sn = BitConverter.ToSingle(data, idx); idx += 4;
    ha_Bilgileri.Mach = BitConverter.ToSingle(data, idx); idx += 4;
    ha_Bilgileri.elevator_der = BitConverter.ToSingle(data, idx); idx += 4;
    ha_Bilgileri.aileron_der = BitConverter.ToSingle(data, idx); idx += 4;
    ha_Bilgileri.rudder_der = BitConverter.ToSingle(data, idx); idx += 4;
    ha_Bilgileri.flap_der = BitConverter.ToSingle(data, idx); idx += 4;
    ha_Bilgileri.itki_per = BitConverter.ToSingle(data, idx); idx += 4;
    ha_Bilgileri.irtifa_m = BitConverter.ToSingle(data, idx); idx += 4;
    }
}