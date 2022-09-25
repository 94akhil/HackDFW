using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class First_hurdle : MonoBehaviour
{
    public GameObject firstHurdle;

    public void destroyTheHurdle(){
        if (firstHurdle.activeInHierarchy == true){
            firstHurdle.SetActive(false);
        }
        else{
            firstHurdle.SetActive(true);
        }
    }
}
