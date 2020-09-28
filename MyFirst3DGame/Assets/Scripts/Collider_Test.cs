using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Collider_Test : MonoBehaviour
{
    public Text T;
    private void OnMouseDown()       //鼠标按下
    {
        Destroy(this.gameObject);
        T.text = this.gameObject.name + "被销毁!";
    }
    private void OnMouseEnter()       //鼠标移入物体
    {
        this.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
    }
    private void OnMouseOver()     //鼠标悬停时每帧调用
    {
        this.transform.Rotate(new Vector3(10, 10, 10) * Time.deltaTime);
        T.text = this.gameObject.name + "在旋转!";
    }
    private void OnMouseExit()         //鼠标移出
    {
        T.text = "离开了" + this.gameObject.name;
        this.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }
}

