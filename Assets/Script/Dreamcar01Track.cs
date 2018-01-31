using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dreamcar01Track : MonoBehaviour {

    //Creamos el Marcador 
    public GameObject TheMarker;
    //Cada uno de los marcadores creados 
    
    //Prueba para optimizar el codigo 
    public Transform[] Mark;

    int MaxTracker;
    int indiceMark;

    void Start()
    {
        //Inicializamos la longitud de los marcadores e indice 
        MaxTracker = Mark.Length;
        indiceMark = 0;
    }

    void Update()
    {

        TheMarker.transform.position = Mark[indiceMark].transform.position;

    }

    IEnumerator OnTriggerEnter(Collider collision)
    {
        //Si la coalicion es con el Tag Dreamcar01
        if (collision.gameObject.tag == "Dreamcar01")
        {
            //Deahabilitamos el boxcollaider del objeto en coalición
            this.GetComponent<BoxCollider>().enabled = false;
            //Despues aumentamos el collider 
            indiceMark += 1;
            //Si llegamos al final reseteamos el Collaider
            if (indiceMark == MaxTracker)
            {
                indiceMark = 0;
            }
            //Esperamos por un segundo para que pase el objeto 
            yield return new WaitForSeconds(1);
            //habilitamos el collider
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
