using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q2_BTN : MonoBehaviour
{
   int m;
    
   public void OnSecButtonPress(){
      m++;
      Debug.Log("Button clicked " + m + " times.");
   }
}
