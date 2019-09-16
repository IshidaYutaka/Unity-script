//カードロックや使われるオブジェクトのSeachPlayerにアタッチする

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseItem : MonoBehaviour
{
    private bool isNear;
    private GameObject prefab;
    private GameObject key;
    private GameObject img;

    public GameObject prefab_parent;
    public Text textA;
    public GameObject canvas;
    public Get_Item.Item item;

    public enum UI {
        Key_redImage,
        Key_blueImage,
        TimeStopperImage,
        AlarmImage,
    }

    public UI ui;


    //Get_Item.Item item;あとでアイテムでスイッチ
    // Start is called before the first frame update
    void Start()
    {
        isNear = false;
        img = Resources.Load<GameObject>("");
    }

    // Update is called once per frame
    void Update()
    {
        if (FlagManager.Instance.flags[0])
        {
            if (isNear)
            {
                textA.text = "Gで使う";
                if (Input.GetKeyDown("g"))
                {
                    SwitchFlags(item);
                    textA.text = "";
                    Debug.Log("プレハブ削除");
                    Debug.Log("FlagManagerのflags[0]は"+ FlagManager.Instance.flags[0]);
                }
            }
            else
            {
                textA.text = "";
            }
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

    void SwitchFlags(Get_Item.Item it)
    {
        switch (it)
        {
            case Get_Item.Item.Key_red:
                key = Resources.Load<GameObject>("Key_red");
                prefab = Instantiate(key);
                prefab.transform.SetParent(prefab_parent.transform, true);
                Destroy(img);
                FlagManager.Instance.flags[0] = false;
                break;

            case Get_Item.Item.Key_blue:
                key = Resources.Load<GameObject>("Key_red");
                prefab = Instantiate(key);
                prefab.transform.SetParent(prefab_parent.transform, true);
                Destroy(img);
                FlagManager.Instance.flags[1] = false;
                break;

            case Get_Item.Item.TimeStopper:
                key = Resources.Load<GameObject>("Key_red");
                prefab = Instantiate(key);
                prefab.transform.SetParent(prefab_parent.transform, true);
                Destroy(img);
                FlagManager.Instance.flags[2] = false;
                break;

            case Get_Item.Item.Alarm:
                key = Resources.Load<GameObject>("Key_red");
                prefab = Instantiate(key);
                prefab.transform.SetParent(prefab_parent.transform, true);
                Destroy(img);
                FlagManager.Instance.flags[3] = false;
                break;
        }
    }

    GameObject SwitchUi(UI useitem) {
        switch (useitem) {
            case UI.Key_redImage:
                img = canvas.transform.Find("Key_redImage").gameObject;
                break;
            case UI.Key_blueImage:
                img = canvas.transform.Find("Key_blueImag").gameObject;
                break;
            case UI.TimeStopperImage:
                img = canvas.transform.Find("TimeStopperImage").gameObject;
                break;
            case UI.AlarmImage:
                img = canvas.transform.Find("AlarmImage").gameObject;
                break;
        }
        return img;
    }
}
