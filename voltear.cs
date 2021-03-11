using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class voltear : MonoBehaviour
{
    //OBJETO EN EL QUE VAMOS A INTERACTUAR
    public GameObject casa;
    
    //VARIABLES DE CONTROL 
    //VARIABLE PARA SABER SI SE ESTA EJECUTANDO LA ACCION DE VOLTEAR
    private int bloqueo=0;
    //VARIABLE PARA CONTROLAR LOS GRADOS QUE SE HA RECORRIDO EL OBJETO
    private int gradosGirados = 0;
    //VARIABLE PARA SABER QUE TECLA SEPRESIONÓ ANTES DE BLOQUEAR LAS FUNCIONES
    private string flecha = "";


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //SI LA BARIABLE BLOQUEO ESTA EN 0, SIGNIFICA QUE NINGUNA TECLA HA SIDOPRESIONADA Y TAMPOCO LA ROTACIÓN ESTA EN PLENO PROCESO
        if (bloqueo == 0)
        {
            //SI NO ESTA BLOQUEADO Y SE DETECTA QUE SE PRESIONO LA TECLA IZQUIEDO
            if (Input.GetKey("left"))
            {
                //ESTABLECER BLOQUEO
                bloqueo = 1;
                //GUARDAR EL DATO DE QUE TECLA SE PRESIONO ANTES DEL BLOQUEO
                flecha = "L";
            }

            if (Input.GetKey("right"))
            {
                //ESTABLECER BLOQUEO
                bloqueo = 1;
                 //GUARDAR EL DATO DE QUE TECLA SE PRESIONO ANTES DEL BLOQUEO
                flecha = "R";
            }

            if (Input.GetKey("up"))
            {
                //ESTABLECER BLOQUEO
                bloqueo = 1;
                 //GUARDAR EL DATO DE QUE TECLA SE PRESIONO ANTES DEL BLOQUEO
                flecha = "U";
            }

            if (Input.GetKey("down"))
            {
                //ESTABLECER BLOQUEO
                bloqueo = 1;
                 //GUARDAR EL DATO DE QUE TECLA SE PRESIONO ANTES DEL BLOQUEO
                flecha = "D";
            }

        }
        //SI BLOQUEDO SE ACTIVO
        else {
            //Y LOS GRADDOS GIRADOS HASTA EL MOMENTO SON MENORES DE 90
            if (gradosGirados < 90)
            {
                //SUMAR 1 A LOS GRADOS ACTUALES GIRADOS HASTA EL MOMENTO
                gradosGirados = gradosGirados + 1;
                
                //SI EL DATO DE TECLA PRESIONADO FUE IZQUIERDA, GIRAR PBJETO CASA UN GRADO A LA IZQUIERDA SOBRE SI MISMO
                if (flecha.Equals("L"))
                {
                    this.casa.GetComponent<Transform>().transform.Rotate(0, 1, 0, Space.Self);
                }
                //SI EL DATO DE TECLA PRESIONADO FUE DERECHA, GIRAR PBJETO CASA UN GRADO A LA DERECHA SOBRE SI MISMO
                if (flecha.Equals("R"))
                {
                    this.casa.GetComponent<Transform>().transform.Rotate(0, -1, 0, Space.Self);
                }
                //SI EL DATO DE TECLA PRESIONADO FUE ARRIBA, GIRAR PBJETO CASA UN GRADO A ARRIBA SOBRE SI MISMO
                if (flecha.Equals("U"))
                {
                    this.casa.GetComponent<Transform>().transform.Rotate(1, 0, 0, Space.Self);
                }
                //SI EL DATO DE TECLA PRESIONADO FUE ABAJO, GIRAR PBJETO CASA UN GRADO A ABAJO SOBRE SI MISMO
                if (flecha.Equals("D"))
                {
                    this.casa.GetComponent<Transform>().transform.Rotate(-1, 0, 0, Space.Self);
                }

            }
            //CUANDO LA SUMA DE 1 A 1 SUPERA LOS 90 GRADOS
            else
            {
                //SE TERMINA EL BLOQUEO
                bloqueo = 0;
                //GRADOS SE RESETEA A 0
                gradosGirados = 0;
            }

        }


        

    }
}
