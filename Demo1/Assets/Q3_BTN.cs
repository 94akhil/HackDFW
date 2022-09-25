using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q3_BTN : MonoBehaviour
{
   int m;
    
   public void OnThirdButtonPress(){
      m++;
      Debug.Log("Button clicked " + m + " times.");
   }
}
