using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int c = 0;
    public int d = 0;
    public int t = 0;
    public Texture c1;
    public Texture c2;
    public Texture c3;
    public Texture c4;
    public Texture d1;
    public Texture d2;
    public Texture d3;
    public Texture t1;
    public Texture t2;
    public Texture t3;
    public Texture t4;
    void Start()
    {
        Button btn1;
        btn1 = GameObject.Find("Canvas/Clock").GetComponent<Button>();
        Button btn2;
        btn2 = GameObject.Find("Canvas/Door").GetComponent<Button>();
        Button btn3;
        btn3 = GameObject.Find("Canvas/Tree").GetComponent<Button>();
        btn1.onClick.AddListener(C);
        btn2.onClick.AddListener(D);
        btn3.onClick.AddListener(T);
    }
    public void C()
    {
        GameObject obj;
        obj = GameObject.Find("Clock");
        switch (c)
        {
            case 0:
                obj.GetComponent<Renderer>().material.mainTexture = c1;
                c++;
                break;
            case 1:
                obj.GetComponent<Renderer>().material.mainTexture = c2;
                c++;
                break;
            case 2:
                obj.GetComponent<Renderer>().material.mainTexture = c3;
                c++;
                break;
            default:
                obj.GetComponent<Renderer>().material.mainTexture = c4;
                c=0;
                break;
        }
        return;
    }
    public void D()
    {
        //就换成不同的配色吧！
        GameObject obj;
        obj = GameObject.Find("Door");
        switch (d)
        {
            case 0:
                obj.GetComponent<Renderer>().materials[0].mainTexture = d1;
                obj.GetComponent<Renderer>().materials[1].mainTexture = d1;
                obj.GetComponent<Renderer>().materials[2].mainTexture = d1;
                d++;
                break;
            case 1:
                obj.GetComponent<Renderer>().materials[1].mainTexture = d2;
                d++;
                break;
            case 2:
                obj.GetComponent<Renderer>().materials[2].mainTexture = d3;
                d++;
                break;
            default:
                obj.GetComponent<Renderer>().materials[0].mainTexture = d3;
                obj.GetComponent<Renderer>().materials[2].mainTexture = d1;
                d=0;
                break;
        }
        return;
    }
    public void T()
    {
        GameObject obj;
        obj = GameObject.Find("Tree");
        switch (t)
        {
            case 0:
                obj.GetComponent<Renderer>().materials[0].mainTexture = t1;
                obj.GetComponent<Renderer>().materials[1].mainTexture = t3;
                t++;
                break;
            default:
                obj.GetComponent<Renderer>().materials[0].mainTexture = t2;
                obj.GetComponent<Renderer>().materials[1].mainTexture = t4;
                t =0;
                break;
        }
        return;
    }
 }
