using UnityEngine;

public class MaterialModifier : MonoBehaviour
{


    private Material mat;

    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void slider0(float newValue)
    {
        mat.SetFloat("_Tiling", newValue);
    }

    public void slider1(float OffsetX)
    {
        mat.SetFloat("_Offset_X", OffsetX);
    }

    public void slider2(float OffsetY)
    {
        mat.SetFloat("_Offset_Y", OffsetY);
    }

}
