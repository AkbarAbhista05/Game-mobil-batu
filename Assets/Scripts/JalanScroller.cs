
using UnityEngine;

public class JalanScroller : MonoBehaviour
{

    [Range(-10f,30f)]
    public float scrollSpeed = 20f;
    private float offset;
    private Material mat;

    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material;   
    }

    // Update is called once per frame
    void Update()
    {
        offset += (Time.deltaTime * scrollSpeed) / 10f;
        mat.SetTextureOffset("_MainTex", new Vector3(offset,0));
    }
}
