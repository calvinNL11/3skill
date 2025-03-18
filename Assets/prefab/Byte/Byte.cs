using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Byte : MonoBehaviour
{
    [SerializeField] Bit[] Bits = new Bit[8];
    [SerializeField] private int value = 0;

    void Update()
    {
        BinToDec();
    }

    private void BinToDec()
    {
        value = 0;
        if (Bits[0].state)
        {
            value += 1;
        }

        if (Bits[1].state)
        {
            value += 2;
        }
        if (Bits[7].state)
        {
            value += 4;
        }

        if (Bits[2].state)
        {
            value += 8;
        }
        if (Bits[3].state)
        {
            value += 16;
        }

        if (Bits[4].state)
        {
            value += 32;
        }
        if (Bits[5].state)
        {
            value += 64;
        }

        if (Bits[6].state)
        {
            value += 128;
        }
    }
}