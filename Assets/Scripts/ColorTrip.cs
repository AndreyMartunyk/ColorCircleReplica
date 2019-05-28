using System.Collections;
using UnityEngine;

public class ColorTrip : MonoBehaviour
{
    public SpriteRenderer sr;
    [Range(0.01f, 1f)]
    public float colorChangeSpeed = 10f;

    ColorManager cm;

    void Start()
    {
        cm = FindObjectOfType<ColorManager>();
        StartCoroutine(ChangeColor());
    }

    IEnumerator ChangeColor()
    {
        while (true)
        {
            foreach (GameColor color in cm.colors)
            {
                sr.color = color.color;
                yield return new WaitForSeconds(Time.deltaTime / colorChangeSpeed);
            }
        }
    }   
}
