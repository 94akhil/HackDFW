using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Second_hurdle : MonoBehaviour
{
    public GameObject secondHurdle;

    public void destroySecHurdle(){
        if (secondHurdle.activeInHierarchy == true){
            secondHurdle.SetActive(false);
        }
        else{
            secondHurdle.SetActive(true);
        }
    }
}
