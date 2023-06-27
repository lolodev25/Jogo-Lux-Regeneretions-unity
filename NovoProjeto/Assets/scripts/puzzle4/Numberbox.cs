using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Numberbox : MonoBehaviour
{

    public int index = 0;
    int x = 0;
    int y = 0;

   public void Init(int i, int j, int index, Sprite sprite)
    {
        this.index = index;
        this.GetComponent<SpriteRenderer>().sprite = sprite;
        UpadatePos(i, j);

    }

    public void UpadatePos(int i,int j)
    {
        x = i;
        y = j;
        this.gameObject.transform.localPosition = new Vector2(i, j);


    }
}
