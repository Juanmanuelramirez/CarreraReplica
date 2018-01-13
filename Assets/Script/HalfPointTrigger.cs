using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTrigger : MonoBehaviour
{
    //Primer Trigger 
    public GameObject LapCompleteTrig;
    //Trigger del final de la vuelta
    public GameObject HalfLapTrig;

    //Al momento de coalicionar se activa el metodo OnTriggerEnter
    void OnTriggerEnter()
    {
        //Esta variable será activa el trigger de la meta 
        LapCompleteTrig.SetActive(true);
        //Detecta el momento cuando cruza la mitad de la carrera 
        HalfLapTrig.SetActive(false);
    }
}
