////このスクリプトはcanvas上に生成されたImageからアイテムの有無を取得します。

//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class ItemManager : MonoBehaviour
//{
//    [SerializeField]
//    public bool[] itemFlags = new bool[5];
//    //canvas下にゲームオブジェクトが生成された時に取得
//    private GameObject Image;
//    public GameObject canvas;
//    private bool bl;
//    string a;
//    //int count;

//    public enum Item
//    {
//        Key_redImage,
//        Key_blueImage,
//        TimeStopperImage,
//        AlarmImage,
//    }
//    //"Key_redImage"
//    public Item item;

//    private void Start()
//    {
//        itemFlags[(int)Item.Key_redImage] = true;
//    }

//    private void GettedItem()
//    {
//        //count = System.Enum.GetValues(typeof(ItemManager.Item)).Length;
//        switch (item) {
//            case Item.Key_redImage:
//                Image = canvas.transform.Find(Item.Key_redImage.ToString()).gameObject;
//                try
//                {
//                    if (Image != null)
//                    {
//                        itemFlags[(int)Item.Key_redImage] = true;
//                        Debug.Log("Key_redもってるよ");
//                    }
//                }
//                catch {Debug.Log("Null"); }
              
                
//                break;
//            case Item.Key_blueImage:
//                Image = canvas.transform.Find(Item.Key_blueImage.ToString()).gameObject;
//                try
//                {
//                    if (Image != null)
//                {
//                    itemFlags[(int)Item.Key_blueImage] = true;
//                    }
//                }
//                catch { Debug.Log("Null"); }
                
//                break;
//            case Item.TimeStopperImage:
//                Image = canvas.transform.Find(Item.TimeStopperImage.ToString()).gameObject;
//                try
//                {
//                    if (Image != null)
//                {
//                    itemFlags[(int)Item.TimeStopperImage] = true;
//                }
//                }
//                catch { Debug.Log("Null"); }
               
//                break;
//            case Item.AlarmImage:
//                try
//                {
//                    Image = canvas.transform.Find(Item.AlarmImage.ToString()).gameObject;
//                    if (Image != null)
//                     {
//                       itemFlags[(int)Item.AlarmImage] = true;
//                      }
//                 }
//                catch { Debug.Log("Null"); }
//        break;
//        }
//    }

    
//    //.TOstring();でstringへ

//    //itemFlags[(int)item] = true;

//    public bool GetItemFlag(Item item)
//    {
//        return itemFlags[(int)item];
//    }
//}