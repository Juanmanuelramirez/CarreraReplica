using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LapTimeManager : MonoBehaviour {

    //Creamos las variables para actualizar los textos
    public static int MinuteCount;
    public static int SecondCount;
    public static float MilliCount;
    public static string MilliDisplay;

    //Creamos los Objetos en donde actualizaremos los min, seg y miliseg
    public GameObject MinuteBox;
    public GameObject SecondBox;
    public GameObject MilliBox;


    void Update()
    {
        //Esto nos dara los mili segundos los cuales se cuentan por cada duración de los frames
        MilliCount += Time.deltaTime * 10;
        //Casteamos nuestros milisegundos a cadena con cero decimales
        MilliDisplay = MilliCount.ToString("F0");
        //Obtenermos el Objeto Texto Milibox
        MilliBox.GetComponent<Text>().text = "" + MilliDisplay;

        //Si nuestros milisegundos llegan a 10 lo regresamos a cero
        if (MilliCount >= 10)
        {
            MilliCount = 0;
            //Incrementamos segundos
            SecondCount += 1;
        }

        //Si segundos llegamos a 9 aumentamos un cero del lado izquierdo a los segundos 
        if (SecondCount <= 9)
        {
            SecondBox.GetComponent<Text>().text = "0" + SecondCount + ".";
        }
        else
        {
            SecondBox.GetComponent<Text>().text = "" + SecondCount + ".";
        }

        if (SecondCount >= 60)
        {
            //LLevamos a Cero los segundos 
            SecondCount = 0;
            //Aumentamos en uno los minutos 
            MinuteCount += 1;
        }

        //Si es menos a nueve aumentamos añadimos un cero a los munutos del lado izquierdo 
        if (MinuteCount <= 9)
        {
            MinuteBox.GetComponent<Text>().text = "0" + MinuteCount + ":";
        }
        else
        {
            MinuteBox.GetComponent<Text>().text = "" + MinuteCount + ":";
        }

    }
}
