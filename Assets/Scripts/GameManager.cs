using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Options App Variables
    public bool airplaneMode = true;
    public bool sound = true;
    public bool wifi = false;
    public bool bluetooth = false;

    public void SetOptionVariables(int value)
    {
        if(value == 1)
        {
            airplaneMode = !airplaneMode;
            if(airplaneMode == true)
            {
                wifi = false;
                bluetooth = false;
            }
            return;
        }
        else if(value == 2)
        {
            sound = !sound;
            return;
        }
        else if (value == 3)
        {
            wifi = !wifi;
            return;
        }
        else if (value == 4)
        {
            bluetooth = !bluetooth;
            return;
        }
    }
}
