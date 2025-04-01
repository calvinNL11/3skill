using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Byteset : MonoBehaviour
{

    [SerializeField] int newValue = 0;
    [SerializeField] Byte myByte;

    void Start()
    {
        
    }

   
    void Update()
    {
        myByte.SetByte(newValue);
    }
}
