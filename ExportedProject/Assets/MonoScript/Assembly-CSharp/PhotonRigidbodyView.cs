using System;
using UnityEngine;

[AddComponentMenu("Photon Networking/Photon Rigidbody View")]
[RequireComponent(typeof(PhotonView))]
[RequireComponent(typeof(Rigidbody))]
public class PhotonRigidbodyView : MonoBehaviour
{
	[SerializeField]
	private bool m_SynchronizeVelocity = true;

	[SerializeField]
	private bool m_SynchronizeAngularVelocity = true;

	private Rigidbody m_Body;

	public PhotonRigidbodyView()
	{
	}

	private void Awake()
	{
		this.m_Body = base.GetComponent<Rigidbody>();
	}

	private void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
		if (!stream.isWriting)
		{
			if (this.m_SynchronizeVelocity)
			{
				this.m_Body.velocity = (Vector3)stream.ReceiveNext();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.m_Body.angularVelocity = (Vector3)stream.ReceiveNext();
			}
		}
		else
		{
			if (this.m_SynchronizeVelocity)
			{
				stream.SendNext(this.m_Body.velocity);
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				stream.SendNext(this.m_Body.angularVelocity);
			}
		}
	}
}