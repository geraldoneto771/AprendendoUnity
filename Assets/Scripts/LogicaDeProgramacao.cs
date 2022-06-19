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
            //ação
            print("Mate o héroi!");
        }else if(estados == 2){
            //ação
            print("Mate se puder o héroi!");
        } else if (estados == 3)
        {
            //ação
            print("Fuja do héroi!");
        } else
        {
            //ação
            print("Nenhum estado selecionado.");
        }*/

        switch (estados)
        {
            case 1:
                //ação
                print("Mate o héroi!");
                break;
            case 2:
                //ação
                print("Mate se puder o héroi!");
                break;
            case 3:
                //ação
                print("Fuja do héroi!");
                break;
            default:
                //ação
                print("Nenhum estado selecionado.");
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
