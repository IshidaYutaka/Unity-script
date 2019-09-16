//このスクリプトはアイテムを回収してcanvas上にImageを生成します。
//アイテムオブジェクトのSeachAreaにアタッチする

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Get_Item : MonoBehaviour
{

    private bool isNear;
    private GameObject prefab;
    private GameObject image_prefab;

    public Text textA;
    public GameObject canvas;
    public Item item;

    public enum Item
    {
        Key_red,
        Key_blue,
        TimeStopper,
        Alarm,
    }

    private GameObject key() {
        return this.transform.parent.gameObject;
    }

    void Start()
    {
        isNear = false;
    }

    void Update()
    {

        if (isNear)
        {
            textA.text = "Gで拾う";
            if (Input.GetKeyDown("g"))
            {
                textA.text = "";
                SwitchFlags(item);
                Debug.Log("プレハブ生成");
                Destroy(key());
            }
        }
        else
        {
            textA.text = "";
        }

    }

    void SwitchFlags(Item it) {
        switch (it)
        {
            case Item.Key_red:
                image_prefab = Resources.Load<GameObject>("Key_redImage");
                prefab = Instantiate(image_prefab);
                prefab.transform.SetParent(canvas.transform, false);
                FlagManager.Instance.flags[0] = true;
                break;

            case Item.Key_blue:
                image_prefab = Resources.Load<GameObject>("Key_blueImage");
                prefab = Instantiate(image_prefab);
                prefab.transform.SetParent(canvas.transform, false);
                FlagManager.Instance.flags[1] = true;
                break;

            case Item.TimeStopper:
                image_prefab = Resources.Load<GameObject>("TimeStopperImage");
                prefab = Instantiate(image_prefab);
                prefab.transform.SetParent(canvas.transform, false);
                FlagManager.Instance.flags[2] = true;
                break;

            case Item.Alarm:
                image_prefab = Resources.Load<GameObject>("AlarmImage");
                prefab = Instantiate(image_prefab);
                prefab.transform.SetParent(canvas.transform, false);
                FlagManager.Instance.flags[3] = true;
                break;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            isNear = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            isNear = false;
        }
    }

   
}
