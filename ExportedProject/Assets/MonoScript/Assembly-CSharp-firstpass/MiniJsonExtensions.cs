using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public static class MiniJsonExtensions
{
	public static ArrayList arrayListFromJson(this string json)
	{
		return MiniJSON.jsonDecode(json) as ArrayList;
	}

	public static Hashtable hashtableFromJson(this string json)
	{
		return MiniJSON.jsonDecode(json) as Hashtable;
	}

	public static string toJson(this Hashtable obj)
	{
		return MiniJSON.jsonEncode(obj);
	}

	public static string toJson(this Dictionary<string, string> obj)
	{
		return MiniJSON.jsonEncode(obj);
	}
}