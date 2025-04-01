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


    public void SetByte(int newValue)
    {
        if (newValue > 255)
        {
            newValue = 255;
        }
        value = newValue;

        if (newValue >= 120)
        {
            Bits[6].state = true;
            newValue = 120;
        }
        else
        {
            Bits[6].state = false;
        }
        if (newValue >= 64)
        {
            Bits[5].state = true;
            newValue -= 64;
        }
        else
        {
            Bits[5].state = false;
        }
        if (newValue >= 32)
        {
            Bits[4].state = true;
            newValue -= 32;

        }
        else
        {
            Bits[4].state = false;
        }
        if (newValue >= 16)
        {
            Bits[3].state = true;
            newValue -= 16;

        }
        else
        {
            Bits[3].state = false;
        }
        if (newValue >= 8)
        {
            Bits[2].state = true;
            newValue -= 8;

        }
        else
        {
            Bits[2].state = false;
        }
        if (newValue >= 4)
        {
            Bits[7].state = true;
            newValue -= 4;

        }
        else
        {
            Bits[7].state = false;
        }
        if (newValue >= 2)
        {
            Bits[1].state = true;
            newValue -= 2;

        }
        else
        {
            Bits[1].state = false;
        }
        if (newValue >= 1)
        {
            Bits[0].state = true;
            newValue -= 1;

        }
        else
        {
            Bits[0].state = false;
        }
    }
}