using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LapComplete : MonoBehaviour {

    //Objeto del objeto que detecta el final de la carrera 
    public GameObject LapCompleteTrig;
    //Objeto del objeto que detecta el mitad de la carrera 
    public GameObject HalfLapTrig;

    //Creamos los Objetos en donde actualizaremos los min, seg y miliseg
    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;

    public GameObject LapTimeBox;

    void OnTriggerEnter()
    {
        //Vaciamos el tiempo los segundos que tenemos en la clase LapTimeManager en las cajas BEST
        //Si es menor que nueve añadimos un cero a las izquierda 
        if (LapTimeManager.SecondCount <= 9)
        {
            SecondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.SecondCount + ".";
        }
        else
        {
            SecondDisplay.GetComponent<Text>().text = "" + LapTimeManager.SecondCount + ".";
        }

        //Si es menor que nueve añadimos un cero a las izquierda 
        if (LapTimeManager.MinuteCount <= 9)
        {
            MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.MinuteCount + ".";
        }
        else
        {
            MinuteDisplay.GetComponent<Text>().text = "" + LapTimeManager.MinuteCount + ".";
        }

        MilliDisplay.GetComponent<Text>().text = "" + LapTimeManager.MilliCount;

        //Colocamos en cero los elementos de la clase LapTimeMAnager 
        LapTimeManager.MinuteCount = 0;
        LapTimeManager.SecondCount = 0;
        LapTimeManager.MilliCount = 0;

        //Activamos la detección a la mitad de la carrera 
        HalfLapTrig.SetActive(true);
        //Desactivamos al inicio de la carrera
        LapCompleteTrig.SetActive(false);
    }

}
