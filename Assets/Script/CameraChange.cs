using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour {

    public GameObject[] Camera;
    private int CamLength;

    //Modo de la camara
    private  int CamMode;


    void Start()
    {
        //Inicializamos la longitud de los marcadores e indice 
        CamLength = Camera.Length;
        CamMode = 0;
    }


    void Update()
    {
        if (Input.GetButtonDown("Viewmode"))
        {
            //Entramos con la letra c 
            CamMode = CamMode == (CamLength - 1) ? 0 : CamMode+1;
            StartCoroutine(ModeChange());
        }
    }

    IEnumerator ModeChange()
    {
        yield return new WaitForSeconds(0.01f);


        for (int IndCam = 0; IndCam < CamLength; IndCam++ )
        {
            //Verificamos cual se activa 
            Camera[IndCam].SetActive(true);
            //Desactivamos las camaras que no apliquen
            if (IndCam != CamMode) {
                Camera[IndCam].SetActive(false);
            }
            
        }

    }
}
