using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStable : MonoBehaviour {

    //Creamos el objeto Carro 
    public GameObject TheCar;

    private float CarX;
    private float CarY;
    private float CarZ;


    // Update is called once per frame
    void Update () {
        //Obtenemos las posiciones de X, Y y Z para estabilizar la camara 
        CarX = TheCar.transform.eulerAngles.x;
        CarY = TheCar.transform.eulerAngles.y;
        CarZ = TheCar.transform.eulerAngles.z;

        //Estabilizamos la camara solo obteniendo la posición en Y
        transform.eulerAngles = new Vector3(CarX - CarX, CarY, CarZ - CarZ);
    }
}
