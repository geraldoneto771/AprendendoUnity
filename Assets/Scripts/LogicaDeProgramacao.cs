using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaDeProgramacao : MonoBehaviour
{
    //Estado = 1-Coragem
    //Estado = 2-Meio termo
    //Estado = 3-Covardia
    int estados = 4;
    
    void Start()
    {
        /*
        if (estados == 1)
        {
            //a��o
            print("Mate o h�roi!");
        }else if(estados == 2){
            //a��o
            print("Mate se puder o h�roi!");
        } else if (estados == 3)
        {
            //a��o
            print("Fuja do h�roi!");
        } else
        {
            //a��o
            print("Nenhum estado selecionado.");
        }*/

        switch (estados)
        {
            case 1:
                //a��o
                print("Mate o h�roi!");
                break;
            case 2:
                //a��o
                print("Mate se puder o h�roi!");
                break;
            case 3:
                //a��o
                print("Fuja do h�roi!");
                break;
            default:
                //a��o
                print("Nenhum estado selecionado.");
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
