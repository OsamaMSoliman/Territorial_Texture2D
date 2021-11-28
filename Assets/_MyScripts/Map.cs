using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Map : MonoBehaviour
{
    [SerializeField] private Texture2D tex;
    [SerializeField] private byte QuantizationLevels;
    [SerializeField] private byte strengthFactor = 3;

    private int levelValue;
    private int size = 1024;

    private Vector2Int mousePos;

    private Color32[] pixels;

    private void Awake()
    {
        if (tex == null)
        {
            Debug.LogError("Texture is not provided!");
            return;
        }
        size = tex.width;
        transform.localScale = new Vector3(size, size, 1);
        transform.position += new Vector3(size / 2, size / 2, 0);
        GetComponent<Renderer>().material.mainTexture = tex;
    }

    private void QuantizeTex()
    {
        // done through the import settings in the editor
        //     tex.filterMode = FilterMode.Point;
        //     tex.wrapMode = TextureWrapMode.Clamp;

        levelValue = (byte)(256 / QuantizationLevels);
        pixels = tex.GetPixels32();
        for (int i = 0; i < pixels.Length; i++)
        {
            int value = (pixels[i].r + pixels[i].g + pixels[i].b) * strengthFactor / 3;
            byte valueB = ((byte)((byte)(1 + value * QuantizationLevels / 255) * levelValue));
            pixels[i] = new Color32(valueB, valueB, valueB, valueB);
        }
        tex.SetPixels32(pixels);
        tex.Apply(false);
    }

    // bool flag = true;
    void OnClick()
    {
        // if (0 <= mousePos.x && mousePos.x < size && 0 <= mousePos.y && mousePos.y < size)
        // {
        //     Color c = flag ? Color.black : Color.white;
        //     flag = !flag;
        //     StartCoroutine(flood(c));
        // }
    }

    // tex 
    // mousePos
    // Color.black
    private IEnumerator flood(Color32 color)
    {

        int count = size;
        var delay = new WaitForSeconds(1f);
        var pixels = tex.GetPixelData<Color32>(0);
        Queue<Vector2Int> neighbor = new Queue<Vector2Int>();
        // neighbor.Enqueue(mousePos);
        while (neighbor.Count > 0)
        {
            Vector2Int cell = neighbor.Dequeue();

            // if (SameColor(pixels[cell.x + cell.y * size], color)) continue;
            if (SameColor(pixels[cell.x + cell.y * size], Color.black)) continue;
            if (SameColor(pixels[cell.x + cell.y * size], Color.white)) continue;

            pixels[cell.x + cell.y * size] = color;

            if (cell.x + 1 < size) neighbor.Enqueue(new Vector2Int { x = cell.x + 1, y = cell.y });
            if (cell.x - 1 >= 0) neighbor.Enqueue(new Vector2Int { x = cell.x - 1, y = cell.y });
            if (cell.y + 1 < size) neighbor.Enqueue(new Vector2Int { x = cell.x, y = cell.y + 1 });
            if (cell.y - 1 >= 0) neighbor.Enqueue(new Vector2Int { x = cell.x, y = cell.y - 1 });

            if (count-- == 0)
            {
                tex.Apply(false);
                yield return delay;
                count = size;
            }
        }
        tex.Apply(false);
    }

    private bool SameColor(Color32 c1, Color32 c2) => c1.r == c2.r && c1.g == c2.g && c1.b == c2.b;

}
