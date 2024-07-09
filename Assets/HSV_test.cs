using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class HSV_test : MonoBehaviour
{
    /*
    // Start is called before the first frame update
    [Range(1,10)]
    public int public_int;
    [Range(0.0f, 1.0f)]
    public float public_float;

    [SerializeField]
    private int private_int;
    [SerializeField]
    protected int protected_int;
    [SerializeField]
    private int m_int;

    [SerializeField]
    private int[] intArray;
    [SerializeField]
    private List<GameObject> GameObjectList;

//    public Slider H, S, V;
*/

    [SerializeField, Range(0.0f, 1.0f)]
    private float H, S, V;
    
    
    void Start()
    {
        //GetComponent<Renderer>().material.color = new Color32(128, 200, 150, 1);
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Renderer>().material.color = UnityEngine.Color.HSVToRGB(H, S, V);
    }
}
