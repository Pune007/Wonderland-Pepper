using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class ArduinoManager : MonoBehaviour
{

    private SerialPort m_SerialPort;
    
    // Start is called before the first frame update
    void Start()
    {
        m_SerialPort = new SerialPort("COM3", 9600); 
        m_SerialPort.Open();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_SerialPort.Write("35");
        }
    }
}
