using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fourth_hurdle : MonoBehaviour
{
    public GameObject fourthHurdle;

    public void destroyFourthHurdle(){
        if (fourthHurdle.activeInHierarchy == true){
            fourthHurdle.SetActive(false);
        }
        else{
            fourthHurdle.SetActive(true);
        }
    }
}
