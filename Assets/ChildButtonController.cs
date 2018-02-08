using UnityEngine;
using System.Collections;

public class ChildButtonController : cuboro
{
    private GameObject target,Obj = null;
    bool forwardmove;
    bool backmove;
    bool rightmove;
    bool leftmove;

    void Update()
    {
        MoveObj();
    }

    protected override void OnClick(string objectName)
    {
        // 渡されたオブジェクト名で処理を分岐
        //（オブジェクト名はどこかで一括管理した方がいいかも）
        if ("Button1".Equals(objectName))
        {
            // Button1がクリックされたとき
            target = (GameObject) Resources.Load("1");
            this.Button1Click();
        }
        else if ("Button2".Equals(objectName))
        {
            target = (GameObject)Resources.Load("2");
            this.Button2Click();
        }
        else if ("Button3".Equals(objectName))
        {
            target = (GameObject)Resources.Load("3");
            this.Button3Click();
        }
        else if ("Button4".Equals(objectName))
        {
            target = (GameObject)Resources.Load("4");
            this.Button4Click();
        }
        else if ("Button5".Equals(objectName))
        {
            target = (GameObject)Resources.Load("5");
            this.Button5Click();
        }
        else if ("Button6".Equals(objectName))
        {
            target = (GameObject)Resources.Load("6");
            this.Button6Click();
        }
        else if ("Button7".Equals(objectName))
        {
            target = (GameObject)Resources.Load("7");
            this.Button7Click();
        }
        else if ("Button8".Equals(objectName))
        {
            target = (GameObject)Resources.Load("8");
            this.Button8Click();
        }
        else if ("Button9".Equals(objectName))
        {
            target = (GameObject)Resources.Load("9");
            this.Button9Click();
        }
        else if ("Button10".Equals(objectName))
        {
            target = (GameObject)Resources.Load("10");
            this.Button10Click();
        }
        else if ("Button11".Equals(objectName))
        {
            target = (GameObject)Resources.Load("11");
            this.Button11Click();
        }
        else if ("Button12".Equals(objectName))
        {
            target = (GameObject)Resources.Load("12");
            this.Button12Click();
        }
        else if ("LeftButton".Equals(objectName))
        {
            this.LeftButtonDown();
        }
        else if ("RightButton".Equals(objectName))
        {
            this.RightButtonDown();
        }
        else if ("ForwardButton".Equals(objectName))
        {
            this.ForwardButtunDown();
        }
        else if ("BackButton".Equals(objectName))
        {
            this.BackButtonDown();
        }
        else
        {
            throw new System.Exception("Not implemented!!");
        }
    }

    //ボタンごとの処理

    private void Button1Click()
    {
        Debug.Log("Button1 Click");
        CreateObj();
        MoveObj();
    }

    private void Button2Click()
    {
        Debug.Log("Button2 Click");
        CreateObj();
        MoveObj();
    }

    private void Button3Click()
    {
        Debug.Log("Button3 Click");
        CreateObj();
    }

    private void Button4Click()
    {
        Debug.Log("Button4 Click");
        CreateObj();
    }

    private void Button5Click()
    {
        Debug.Log("Button5 Click");
        CreateObj();
    }

    private void Button6Click()
    {
        Debug.Log("Button6 Click");
        CreateObj();
    }

    private void Button7Click()
    {
        Debug.Log("Button7 Click");
        CreateObj();
    }

    private void Button8Click()
    {
        Debug.Log("Button8 Click");
        CreateObj();
    }

    private void Button9Click()
    {
        Debug.Log("Button9 Click");
        CreateObj();
    }

    private void Button10Click()
    {
        Debug.Log("Button10 Click");
        CreateObj();
    }

    private void Button11Click()
    {
        Debug.Log("Button11 Click");
        CreateObj();
    }

    private void Button12Click()
    {
        Debug.Log("Button12 Click");
        CreateObj();
    }

    public void LeftButtonDown()
    {
        Debug.Log("LeftButton Click");
        leftmove = true;
    }

    public void RightButtonDown()
    {
        Debug.Log("RigtButton Click");
        rightmove = true;
    }

    public void ForwardButtunDown()
    {
        Debug.Log("ForwardButton Click");
        forwardmove = true;
    }

    public void BackButtonDown()
    {
        Debug.Log("BackButton Click");
        backmove = true;
    }

    



    //オブジェクト生成
    public void CreateObj()
    {
        Obj = Instantiate(target, new Vector3(0f, 0f, 0f), Quaternion.identity);
        Obj.transform.Translate(1,0,1);
    }

    public void MoveObj()
    {
        if (forwardmove)
        {
            Debug.Log("Move Forward");
            Obj.transform.Translate(0f, 0f, 1f);
            Debug.Log(target.transform.position);
            forwardmove = false;
        }

        if (backmove)
        {
            Obj.transform.Translate(0f, 0f, -1f);
            Debug.Log("Move Back");
            Debug.Log(target.transform.position);
            backmove = false;
        }

        if (rightmove)
        {
            Obj.transform.Translate(1f, 0f, 0f);
            Debug.Log("Move Right");
            Debug.Log(target.transform.position);
            rightmove = false;
        }

        if (leftmove)
        {
            Obj.transform.Translate(-1f, 0f, 0f);
            Debug.Log("Move Left");
            Debug.Log(target.transform.position);
            leftmove = false;
        }
    }

}
