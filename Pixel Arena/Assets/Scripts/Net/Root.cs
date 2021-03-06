﻿using UnityEngine;

public class Root : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Application.runInBackground = true;//后台运行
        PanelMgr.instance.OpenPanel<ConnectPanel>("");
    }
	
	// Update is called once per frame
	void Update () {
        NetMgr.Update();
    }

	private void OnDestroy()
	{
		Debug.Log("destroy");
		if(NetMgr.srvConn.MyUdpClientInstance!=null)
		NetMgr.srvConn.MyClose();
		if (NetMgr.srvConn.socket != null)
			NetMgr.srvConn.Close();
		
		NetMgr.srvConn.udpcontinue = false;
	}
}
