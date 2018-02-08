using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class cuboro : MonoBehaviour
{
    public Canvas create_canvas;
    public cuboro button;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        if (button == null)
        {
            throw new System.Exception("Button instance is null!!");
        }
        // 自身のオブジェクト名を渡す
        button.OnClick(this.gameObject.name);
    }

    protected virtual void OnClick(string objectName)
    {
        // 呼ばれることはない
        Debug.Log("Base Button");
    }

    //オブジェクト作成

}

