using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
/*
//Bluetooth Model
public interface Observer {
    void OnStateChange(string state);
    void OnSendMsg(string msg);
    void OnGetMsg(string msg);
    void OnFoundDevice(string device);
    void OnNotFoundDevice(string noDivice);
    void OnScanFinished(string s);
}

public static class BtObservable : MonoBehaviour
{
    protected List<Observer> observerList;
    public abstract void AddOb(Observer ob);
    public abstract void RemoveOb(observer ob);
}

public class BluetoothModel : BtObservable
{
    private int buffersize = 256;
    private char startCh = '$';
    private char endCh = '#';

    public List<string> macAddr = null;
    private Queue<string> msgQueue = null;
    private StringBuilder rawMsg = null;

    void Awake() 
    {
        this.observerList = new List<Observer>();
        this.macAddr = new List<string>();
        this.msgQueue = new List<string>();
        this.rawMsg = new StringBuilder(this.buffersize);
    }

    public void clearMacAddr()
    {
        macAddr.Clear();
    }

    private void CheckMsgFormat()
    {
        int startPos = -1;
        int endPos = -1;

        for(int i=0; i<rawMsg.Length; i++)
        {
            if( startPos == -1 &&
                rawMsg[i] == this.startCh )
                {   
                    startPos = i;
                }
            else if( endPos == -1 && rawMsg[i]==this.endCh)
            {
                endPos = -i;
            }
        }

        if(startPos != -1 && endPos != -1)
        {
            msgQueue.Enqueue(rawMsg.ToString(startPos, endPos-startPos-1));
            rawMsg.Remove(startPos, endPos);
        }

        string tmpMsg = msgQueue.Dequeue();
        
        for(int i=0; i<this.observerList.Count; i++)
        {
            this.observerList[i].OnGetMsg(tmpMsg);
        }
        
        Debug.Log(rawMsg);
    }

    public abstract void AddOb(Observer ob)
    {
        this.observerList.Add(ob);
    }
    public abstract void RemoveOb(Observer ob)
    {
        if(observerList.Contains(ob))
            this.observerList.Remove(ob);
    }

    void OnStateChange(string state)
    {
        for(int i=0; i<this.observerList.Count; i++)
        {
            this.observerList[i].OnStateChange(state);
        }

        Debug.Log(state);
    }
    void OnSendMsg(string msg)
    {
        for(int i=0; i<this.observerList.Count; i++){
            this.observerList[i].OnSendMsg(msg);
        }

        Debug.Log(msg);
    }
  
    void OnFoundDevice(string device)
    {
        this.macAddr.Add(device);
        for(int i=0; i<this.observerList.Count; i++){
            this.observerList[i].OnFoundDevice();
        }

        Debug.Log(device + "Found It");
    }
    void OnNotFoundDevice(string noDivice)
    {
        for(int i=0; i<this.observerList.Count; i++)
        {
            this.observerList[i].OnNotFoundDevice();
        }

        Debug.Log("Not Found");
    }
    void OnScanFinished(string s)
    {
        for(int i=0; i<this.observerList.Count; i++)
        {
            this.observerList[i].OnScanFinished();
        }
        Debug.Log("On Scan Finish");
    }
}

 */