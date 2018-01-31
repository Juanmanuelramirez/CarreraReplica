using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {
    //Creamos el objeto texto Countdown
    public GameObject CountDown;
    //Creamos los Audios 
    public AudioSource GetReady;
    public AudioSource GoAudio;
    //Creamos el objeto contador ya que duraran un segundo cada una de las animaciones
    public GameObject LapTimer;
    public GameObject CarControls;


    void Start()
    {
        //Llamamos la rutina 
        StartCoroutine(CountStart());

    }


    IEnumerator CountStart()
    {
        //Esperamos 0.5 segundos 
        yield return new WaitForSeconds(0.5f);
        //Obtenemos el objeto texto Countdown y le asignamos 3

        for (int i = 3; i >= 0; i--)
        {
            CountDown.GetComponent<Text>().text = i.ToString();
            GetReady.Play();
            CountDown.SetActive(true);
            yield return new WaitForSeconds(1);
            CountDown.SetActive(false);
        }

        
        GoAudio.Play();
        
        LapTimer.SetActive(true);
        CarControls.SetActive(true);

    }



}
