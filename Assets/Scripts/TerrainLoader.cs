using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainLoader : MonoBehaviour
{
    public int RenderDistance = 5;


    const int ChunkWidth = 16;
    const int ChunkHeight = 64;

    // 1 Chunk mit block-ids gespeichert
    int[,,] BlockData = new int[ChunkWidth, ChunkHeight, ChunkWidth];

    void Start()
    {
        // Alle Chunks in Renderdistance laden
    }

    void Update()
    {
        // Checken, ob ein neuer chunk geladen werden soll -> LoadChunk()
    }

    void LoadChunk()
    {
        // Versuche den gegebenen Chunk aus dem Speicher zu laden, in die Variable speichern, DrawFaces()
        // Else GenerateChunk()
    }

    void GenerateChunk()
    {
        // Berechne die Chunk Daten, in die Variable speichern, DrawFaces()
    }

    void DrawFaces()
    {
        //Flächen aus der Variable zeichnen
    }
}
