using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle : MonoBehaviour
{

    public Numberbox BoxPrefebs;

    public Numberbox[,] boxe = new Numberbox[4, 4];

    public Sprite[] sprites;
    // Start is called before the first frame update
    void Start()
    {
        init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void init()
    {
        int n = 0;
        for (int y = 3; y >= 0; y--)
            for (int x = 0; x < 4; x++)
            {
                Numberbox box = Instantiate(BoxPrefebs, new Vector2(x, y), Quaternion.identity);
                box.Init(x, y, n + 1, sprites[n]);
                boxe[x, y] = box;
                n++;
            }
    }
}
