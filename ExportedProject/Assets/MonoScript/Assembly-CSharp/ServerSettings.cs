using ExitGames.Client.Photon;
using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ServerSettings : ScriptableObject
{
	public ServerSettings.HostingOption HostType;

	public ConnectionProtocol Protocol;

	public string ServerAddress = string.Empty;

	public int ServerPort = 5055;

	public string AppID = string.Empty;

	public CloudRegionCode PreferredRegion;

	public CloudRegionFlag EnabledRegions = CloudRegionFlag.eu | CloudRegionFlag.us | CloudRegionFlag.asia | CloudRegionFlag.jp | CloudRegionFlag.au | CloudRegionFlag.usw | CloudRegionFlag.sa | CloudRegionFlag.cae;

	public bool JoinLobby;

	public bool EnableLobbyStatistics;

	public List<string> RpcList = new List<string>();

	[HideInInspector]
	public bool DisableAutoOpenWizard;

	public ServerSettings()
	{
	}

	public override string ToString()
	{
		return string.Concat(new object[] { "ServerSettings: ", this.HostType, " ", this.ServerAddress });
	}

	public void UseCloud(string cloudAppid)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = cloudAppid;
	}

	public void UseCloud(string cloudAppid, CloudRegionCode code)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = cloudAppid;
		this.PreferredRegion = code;
	}

	public void UseCloudBestRegion(string cloudAppid)
	{
		this.HostType = ServerSettings.HostingOption.BestRegion;
		this.AppID = cloudAppid;
	}

	public void UseMyServer(string serverAddress, int serverPort, string application)
	{
		this.HostType = ServerSettings.HostingOption.SelfHosted;
		this.AppID = (application == null ? "master" : application);
		this.ServerAddress = serverAddress;
		this.ServerPort = serverPort;
	}

	public enum HostingOption
	{
		NotSet,
		PhotonCloud,
		SelfHosted,
		OfflineMode,
		BestRegion
	}
}