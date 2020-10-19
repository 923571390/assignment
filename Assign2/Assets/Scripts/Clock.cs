using System;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    public GameObject hourHand;
    public GameObject minuteHand;
    //小时、分钟
    public int h;
    public int m;
    public int s;
    void Start()
    {
        print("这是平凡枯燥的一天啊");
        //读取本地时间
        GetNowTime();
        draw();
        InvokeRepeating("VitualTime", 1, 1);
        Dis();
    }
    void Update()
    {
        Text text;
        text = GameObject.Find("Canvas/Text").GetComponent<Text>();
        Text text1;
        text1 = GameObject.Find("Canvas/Text1").GetComponent<Text>();
        if (h == 7 && m == 0) s = 1;
        if (h == 7 && m == 15) s = 2;
        else if (h == 8 && m == 0) s = 3;
        else if (h == 8 && m == 15) s = 4;
        else if (h == 11 && m == 45) s = 0;
        switch (s)
        {
            case 0:
                Dis();
                text.text =  "该睡觉了！";
                text1.text = "又定了个7点的闹铃……";
                break;
            case 1:
                text.text = "闹铃响了！";
                text1.text = "我们去吃饭~";
                break;
            case 2:
                text.text = "吃完了！";
                text1.text = "我们去上课~";
                break;
            case 3:
                text.text = "总算下课了！";
                text1.text = "又能吃饭了~";
                break;
            case 4:
                text.text = "吃完了！";
                text1.text = "接下来做什么呢~";
                choose();
                break;
            case 5:
                text.text = "虽然逃了课！";
                text1.text = "但打游戏太快乐了~";
                break;
            case 6:
                text.text = "虽然没有耽误上课~";
                text1.text = "但我还是想打游戏……";
                break;
            default:
                break;
        }

    }
    private void draw()
    {
        hourHand.transform.rotation = Quaternion.AngleAxis((30 * h + 0.5f * m + (30.0f / 3600.0f) * s), Vector3.back);
        minuteHand.transform.rotation = Quaternion.AngleAxis((6 * m + 0.1f * s), Vector3.back);
    } 
    private void GetNowTime()
    {
        h = 6;
        m = 15;
        s = 0;
    }
    private void VitualTime()
    {
        m = m + 15;
        if (m == 60)
        {
            m = 0;
            h = h + 1;
            if (h == 12) h = 0;
        }
        draw();
    }
    private void choose()
    {
        Button btn1;
        btn1 = GameObject.Find("Canvas/early").GetComponent<Button>();
        btn1.transform.localScale = Vector3.one;
        Button btn2;
        btn2 = GameObject.Find("Canvas/late").GetComponent<Button>();
        btn2.transform.localScale = Vector3.one;
        btn1.onClick.AddListener(F);
        btn2.onClick.AddListener(M);
        return;

    }
    public void M()
    {
        Dis();
        s = 6;
        return;
    }
     public void F()
    {
        Dis();
        s = 5;
        return;
    }
    private void Dis()
    {
        Button btn1;
        btn1 = GameObject.Find("Canvas/early").GetComponent<Button>();
        btn1.transform.localScale = Vector3.zero;
        Button btn2;
        btn2 = GameObject.Find("Canvas/late").GetComponent<Button>();
        btn2.transform.localScale = Vector3.zero;
    }

}