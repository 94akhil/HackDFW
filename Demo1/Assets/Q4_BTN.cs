using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q4_BTN : MonoBehaviour
{
   int m;
    
   public void OnFourthButtonPress(){
      m++;
      Debug.Log("Button clicked " + m + " times.");
   }
}
