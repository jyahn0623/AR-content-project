using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic; 

public class Bluetooth
{
    private AndroidJavaClass plugin;
    private AndroidJavaObject activityObj;
    private static Bluetooth instance;

    private Bluetooth() {}
    public static Bluetooth getInstance()
    {
        if(instance==null)
        {
            instance = new Bluetooth();
            instance.PluginStart();
        }
        return instance;
    }
    // 플러그인 시작 요청
    private void PluginStart()
    {
        plugin = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        activityObj = plugin.GetStatic<AndroidJavaObject>("currentActivity");

        Debug.Log(activityObj);
        activityObj.Call("StartPlugin");
    }

    //블루투스 장비에게 메세지 전달 요청
    public string Send(string msg)
    {
        return activityObj.Call<string>("sendMessage", msg);
    }

    //주위 있는 장비 검색 요청
    public string SearchDevice()
    {
        return activityObj.Call<string>("ScanDevice");
    }

    //해당 주소의 장비 연결 요청
    public void Connect(string addr)
    {
        activityObj.Call("Connect", addr);
    }
}

