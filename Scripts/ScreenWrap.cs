using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWrap : MonoBehaviour
{
    private void Start()
    {
        
        
    }
    void Update()
    {
        Vector2 position = transform.position;
        if (position.x > ScreenUtils.ScreenRight)
        {
            position.x = ScreenUtils.ScreenLeft;
        }
        else if(position.x < ScreenUtils.ScreenLeft)
        {
            position.x = ScreenUtils.ScreenRight;
        }
        if (position.y > ScreenUtils.ScreenTop)
        {
            position.y = ScreenUtils.ScreenBottom;
        }
        else if (position.y < ScreenUtils.ScreenBottom)
        {
            position.y = ScreenUtils.ScreenTop;
        }
        transform.position = position;
    }
}
