using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum eColor
{
    Pink,
    Magenta,
    Cyan,
    Yellow,
    None
}

public class ColorManager : MonoBehaviour
{
    public GameColor[] colors ;

    public GameColor GetColor(string colorName)
    {
        GameColor res = null;

        foreach (GameColor color in colors)
        {
            if (color.name.ToString() == colorName)
            {
                res = color;
                break;
            }
        }

        return res;

    }

    public GameColor GetColor(int index)
    {
        if (index < 0 || index >= colors.Length)
        {
            Debug.LogWarning("index uot if range!!! (GetColor)");
            return null;
        }

        return colors[index];
    }
}
    
