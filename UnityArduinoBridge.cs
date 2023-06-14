// https://www.youtube.com/watch?v=5ElKFY3N1zs&ab_channel=Comet%27sVR
using UnityEngine;
using System.Collections;

using System.Collections.Generic;
using System.IO.Ports;

public class ArduinoTest : MonoBehaviour
{

    SerialPort data_stream = new SerialPort("/dev/tty.usbmodem112301", 9600);
    public string[] receivedstring;
    public int one;
    public int two;
    public int tre;
    public string answer;

    void Start()
    {
        data_stream.Open();
    }

    void Update()
    {
    // Vector3 movement = new Vector3();

      if (data_stream.IsOpen) {
                  try {
                      receivedstring = data_stream.ReadLine().Split(",");

                      one = int.Parse(receivedstring[0]);
                      transform.Rotate(0, one, 0);

                      // Uncomment to connect second sensor
                      // two = int.Parse(receivedstring[1]);
                      // movement += transform.forward * two;

                      // Example If using first sensor
                      // if(one > 100){
                      //     Debug.Log("Im hit");
                      // }else{
                      //     Debug.Log("Im not hit");
                      // }

                      


                      Debug.Log(one);

                  } catch (System.Exception) {
                  }
              }

    }
}
