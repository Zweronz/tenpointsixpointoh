using System.Collections.Generic;
using UnityEngine;

public class PhotonStream
{
	private bool write;

	private Queue<object> writeData;

	private object[] readData;

	internal byte currentItem;

	public bool isWriting
	{
		get
		{
			return write;
		}
	}

	public bool isReading
	{
		get
		{
			return !write;
		}
	}

	public int Count
	{
		get
		{
			return (!isWriting) ? readData.Length : writeData.get_Count();
		}
	}

	public PhotonStream(bool write, object[] incomingData)
	{
		this.write = write;
		if (incomingData == null)
		{
			writeData = new Queue<object>(10);
		}
		else
		{
			readData = incomingData;
		}
	}

	internal void ResetWriteStream()
	{
		writeData.Clear();
	}

	public object ReceiveNext()
	{
		if (write)
		{
			Debug.LogError("Error: you cannot read this stream that you are writing!");
			return null;
		}
		object result = readData[currentItem];
		currentItem++;
		return result;
	}

	public object PeekNext()
	{
		if (write)
		{
			Debug.LogError("Error: you cannot read this stream that you are writing!");
			return null;
		}
		return readData[currentItem];
	}

	public void SendNext(object obj)
	{
		if (!write)
		{
			Debug.LogError("Error: you cannot write/send to this stream that you are reading!");
		}
		else
		{
			writeData.Enqueue(obj);
		}
	}

	public object[] ToArray()
	{
		return (!isWriting) ? readData : writeData.ToArray();
	}

	public void Serialize(ref bool myBool)
	{
		if (write)
		{
			writeData.Enqueue((object)myBool);
		}
		else if (readData.Length > currentItem)
		{
			myBool = (bool)readData[currentItem];
			currentItem++;
		}
	}

	public void Serialize(ref int myInt)
	{
		if (write)
		{
			writeData.Enqueue((object)myInt);
		}
		else if (readData.Length > currentItem)
		{
			myInt = (int)readData[currentItem];
			currentItem++;
		}
	}

	public void Serialize(ref string value)
	{
		if (write)
		{
			writeData.Enqueue((object)value);
		}
		else if (readData.Length > currentItem)
		{
			value = (string)readData[currentItem];
			currentItem++;
		}
	}

	public void Serialize(ref char value)
	{
		if (write)
		{
			writeData.Enqueue((object)value);
		}
		else if (readData.Length > currentItem)
		{
			value = (char)readData[currentItem];
			currentItem++;
		}
	}

	public void Serialize(ref short value)
	{
		if (write)
		{
			writeData.Enqueue((object)value);
		}
		else if (readData.Length > currentItem)
		{
			value = (short)readData[currentItem];
			currentItem++;
		}
	}

	public void Serialize(ref float obj)
	{
		if (write)
		{
			writeData.Enqueue((object)obj);
		}
		else if (readData.Length > currentItem)
		{
			obj = (float)readData[currentItem];
			currentItem++;
		}
	}

	public void Serialize(ref PhotonPlayer obj)
	{
		if (write)
		{
			writeData.Enqueue((object)obj);
		}
		else if (readData.Length > currentItem)
		{
			obj = (PhotonPlayer)readData[currentItem];
			currentItem++;
		}
	}

	public void Serialize(ref Vector3 obj)
	{
		if (write)
		{
			writeData.Enqueue((object)obj);
		}
		else if (readData.Length > currentItem)
		{
			obj = (Vector3)readData[currentItem];
			currentItem++;
		}
	}

	public void Serialize(ref Vector2 obj)
	{
		if (write)
		{
			writeData.Enqueue((object)obj);
		}
		else if (readData.Length > currentItem)
		{
			obj = (Vector2)readData[currentItem];
			currentItem++;
		}
	}

	public void Serialize(ref Quaternion obj)
	{
		if (write)
		{
			writeData.Enqueue((object)obj);
		}
		else if (readData.Length > currentItem)
		{
			obj = (Quaternion)readData[currentItem];
			currentItem++;
		}
	}
}
