using System;
using UnityEngine;

public class ServerTime : MonoBehaviour
{
	public ServerTime()
	{
	}

	private void OnGUI()
	{
		GUILayout.BeginArea(new Rect((float)(Screen.width / 2 - 100), 0f, 200f, 30f));
		GUILayout.Label(string.Format("Time Offset: {0}", PhotonNetwork.ServerTimestamp - Environment.TickCount), new GUILayoutOption[0]);
		if (GUILayout.Button("fetch", new GUILayoutOption[0]))
		{
			PhotonNetwork.FetchServerTimestamp();
		}
		GUILayout.EndArea();
	}
}