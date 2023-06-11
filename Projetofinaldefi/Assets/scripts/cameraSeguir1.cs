using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraSeguir1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;

    private void FixedUpdate()
    {
        transform.position = Vector2.Lerp(transform.position, player.position, 0.1f);
    }
}
