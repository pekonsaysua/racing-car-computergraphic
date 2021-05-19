using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DropdownHandle : MonoBehaviour
{
    public Dropdown x;
    public int a;
    // Start is called before the first frame update
    void Start()
    {
        x.onValueChanged.AddListener(delegate{
            aaa(x);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void aaa(Dropdown sender) 
    {
         a = sender.value;
         a = a + 1;
         PlayerPrefs.SetInt("soVong", a);
         
    }

    // void update(a)
    // {
        
    // }
}
