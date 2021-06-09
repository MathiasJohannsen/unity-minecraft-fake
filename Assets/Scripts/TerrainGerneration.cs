using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGerneration : MonoBehaviour
{
    public GameObject cube;
    public int width = 256;
    public int MaxHeight = 64;
    public float NoiseScale = 1f;
    public float rseedX;
    public float rseedY;

    void Start()
    {
        rseedX = Random.Range(0f, 99999f);
        rseedY = Random.Range(0f, 99999f);

        NoiseScale = (float)width / NoiseScale;
        for (float x = 0; x < width/10; x+=0.1f)
        {
            for (float y = 0; y < width/10; y+=0.1f)
            {
                float localHeight = CalcHeight(x, y);
                Instantiate(cube, new Vector3(x, localHeight, y), Quaternion.identity); // Später Funktion
            }
        }
    }

    float CalcHeight(float x, float y)
    {
        float newx = x / width * NoiseScale/10 + rseedX;
        float newy = y / width * NoiseScale/10 + rseedY;
        float sample = Mathf.PerlinNoise(newx, newy);
        return (float)Mathf.RoundToInt(sample * MaxHeight)/10;
    }
}
