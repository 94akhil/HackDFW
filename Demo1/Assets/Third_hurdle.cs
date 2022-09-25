using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Third_hurdle : MonoBehaviour
{
    public GameObject thirdHurdle;

    public void destroyThirHurdle(){
        if (thirdHurdle.activeInHierarchy == true){
            thirdHurdle.SetActive(false);
        }
        else{
            thirdHurdle.SetActive(true);
        }
    }
}
