using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piicies : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (!gamecontrol.youwin)
        {
            transform.Rotate(0f, 0f, 90f);
        }
    }
}
