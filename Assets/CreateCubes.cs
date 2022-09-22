using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CreateCubes : MonoBehaviour
{
    public TMP_InputField tmpInputField;
    // Start is called before the first frame update
    void Start()
    {
        tmpInputField.onEndEdit.AddListener(Create);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Create(string count)
    {
        for (var i = 0; i < int.Parse(count); i++)
        {
            var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.AddComponent<Rigidbody>();
            cube.GetComponent<Rigidbody>().useGravity = true;
            
            cube.transform.position = Vector3.up * i * 2.5f;
        }
    }
}
