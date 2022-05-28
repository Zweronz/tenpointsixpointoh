using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace DevToDev.Core.Utils
{
	[DefaultMember("Item")]
	public abstract class JSONNode
	{
		public virtual JSONNode this[int aIndex]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual JSONNode this[string aKey]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual string Value
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public virtual int Count
		{
			get
			{
				return 0;
			}
		}

		public virtual global::System.Collections.Generic.IEnumerable<JSONNode> Children
		{
			get
			{
				yield break;
			}
		}

		public global::System.Collections.Generic.IEnumerable<JSONNode> DeepChildren
		{
			get
			{
				global::System.Collections.Generic.IEnumerator<JSONNode> enumerator = Children.GetEnumerator();
				try
				{
					while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
					{
						JSONNode C = enumerator.get_Current();
						global::System.Collections.Generic.IEnumerator<JSONNode> enumerator2 = C.DeepChildren.GetEnumerator();
						try
						{
							while (((global::System.Collections.IEnumerator)enumerator2).MoveNext())
							{
								yield return enumerator2.get_Current();
							}
						}
						finally
						{
							if (enumerator2 != null)
							{
								((global::System.IDisposable)enumerator2).Dispose();
							}
						}
					}
				}
				finally
				{
					if (enumerator != null)
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
				}
			}
		}

		public virtual JSONBinaryTag Tag
		{
			[CompilerGenerated]
			get
			{
				return _003CTag_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				_003CTag_003Ek__BackingField = value;
			}
		}

		public virtual int AsInt
		{
			get
			{
				int result = 0;
				if (int.TryParse(Value, ref result))
				{
					return result;
				}
				return 0;
			}
			set
			{
				Value = value.ToString();
				Tag = JSONBinaryTag.IntValue;
			}
		}

		public virtual long AsLong
		{
			get
			{
				long result = 0L;
				if (long.TryParse(Value, ref result))
				{
					return result;
				}
				return 0L;
			}
			set
			{
				Value = value.ToString();
				Tag = JSONBinaryTag.IntValue;
			}
		}

		public virtual float AsFloat
		{
			get
			{
				float result = 0f;
				if (float.TryParse(Value, ref result))
				{
					return result;
				}
				return 0f;
			}
			set
			{
				Value = value.ToString().Replace(",", ".");
				Tag = JSONBinaryTag.FloatValue;
			}
		}

		public virtual double AsDouble
		{
			get
			{
				double result = 0.0;
				if (double.TryParse(Value, ref result))
				{
					return result;
				}
				return 0.0;
			}
			set
			{
				Value = value.ToString().Replace(",", ".");
				Tag = JSONBinaryTag.DoubleValue;
			}
		}

		public virtual bool AsBool
		{
			get
			{
				bool result = false;
				if (bool.TryParse(Value, ref result))
				{
					return result;
				}
				if (Value != null)
				{
					return !Value.Equals(string.Empty);
				}
				return false;
			}
			set
			{
				Value = (value ? "true" : "false");
				Tag = JSONBinaryTag.BoolValue;
			}
		}

		public virtual JSONArray AsArray
		{
			get
			{
				return this as JSONArray;
			}
		}

		public virtual JSONClass AsObject
		{
			get
			{
				return this as JSONClass;
			}
		}

		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		public virtual void Add(JSONNode aItem)
		{
			Add("", aItem);
		}

		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		public virtual JSONNode Remove(JSONNode aNode)
		{
			return aNode;
		}

		public override string ToString()
		{
			return "JSONNode";
		}

		public virtual string ToString(string aPrefix)
		{
			return "JSONNode";
		}

		public abstract string ToJSON(int prefix);

		public static implicit operator JSONNode(string s)
		{
			return new JSONData(s);
		}

		public static implicit operator string(JSONNode d)
		{
			if (!(d == null))
			{
				return d.Value;
			}
			return null;
		}

		public static bool operator ==(JSONNode a, object b)
		{
			if (b == null && a is JSONLazyCreator)
			{
				return true;
			}
			return object.ReferenceEquals((object)a, b);
		}

		public static bool operator !=(JSONNode a, object b)
		{
			return !(a == b);
		}

		public override bool Equals(object obj)
		{
			return object.ReferenceEquals((object)this, obj);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		internal static string Escape(string aText)
		{
			if (aText == null)
			{
				return null;
			}
			string text = "";
			for (int i = 0; i < aText.get_Length(); i++)
			{
				char c = aText.get_Chars(i);
				switch (c)
				{
				case '\\':
					text += "\\\\";
					break;
				case '"':
					text += "\\\"";
					break;
				case '\n':
					text += "\\n";
					break;
				case '\r':
					text += "\\r";
					break;
				case '\t':
					text += "\\t";
					break;
				case '\b':
					text += "\\b";
					break;
				case '\f':
					text += "\\f";
					break;
				default:
					text = string.Concat((object)text, (object)c);
					break;
				}
			}
			return text;
		}

		private static JSONData Numberize(string token)
		{
			bool aData = false;
			int aData2 = 0;
			double aData3 = 0.0;
			token = token.Replace(".", ",");
			if (int.TryParse(token, ref aData2))
			{
				return new JSONData(aData2);
			}
			if (double.TryParse(token, ref aData3))
			{
				return new JSONData(aData3);
			}
			if (bool.TryParse(token, ref aData))
			{
				return new JSONData(aData);
			}
			return new JSONData(null);
		}

		private static void AddElement(JSONNode ctx, string token, string tokenName, bool tokenIsString)
		{
			if (tokenIsString)
			{
				if (ctx is JSONArray)
				{
					ctx.Add(token);
				}
				else
				{
					ctx.Add(tokenName, token);
				}
				return;
			}
			JSONData aItem = Numberize(token);
			if (ctx is JSONArray)
			{
				ctx.Add(aItem);
			}
			else
			{
				ctx.Add(tokenName, aItem);
			}
		}

		public static JSONNode Parse(string aJSON)
		{
			Stack<JSONNode> val = new Stack<JSONNode>();
			JSONNode jSONNode = null;
			int i = 0;
			string text = "";
			string text2 = "";
			bool flag = false;
			bool flag2 = false;
			for (; i < aJSON.get_Length(); i++)
			{
				switch (aJSON.get_Chars(i))
				{
				case '{':
					if (flag)
					{
						text = string.Concat((object)text, (object)aJSON.get_Chars(i));
						break;
					}
					val.Push((JSONNode)new JSONClass());
					if (jSONNode != null)
					{
						text2 = text2.Trim();
						if (jSONNode is JSONArray)
						{
							jSONNode.Add(val.Peek());
						}
						else
						{
							jSONNode.Add(text2, val.Peek());
						}
					}
					text2 = "";
					text = "";
					jSONNode = val.Peek();
					break;
				case '[':
					if (flag)
					{
						text = string.Concat((object)text, (object)aJSON.get_Chars(i));
						break;
					}
					val.Push((JSONNode)new JSONArray());
					if (jSONNode != null)
					{
						text2 = text2.Trim();
						if (jSONNode is JSONArray)
						{
							jSONNode.Add(val.Peek());
						}
						else if (text2 != "")
						{
							jSONNode.Add(text2, val.Peek());
						}
					}
					text2 = "";
					text = "";
					jSONNode = val.Peek();
					break;
				case ']':
				case '}':
					if (flag)
					{
						text = string.Concat((object)text, (object)aJSON.get_Chars(i));
						break;
					}
					if (val.get_Count() == 0)
					{
						throw new global::System.Exception("JSON Parse: Too many closing brackets");
					}
					val.Pop();
					if (text != "")
					{
						text2 = text2.Trim();
						AddElement(jSONNode, text, text2, flag2);
						flag2 = false;
					}
					text2 = "";
					text = "";
					if (val.get_Count() > 0)
					{
						jSONNode = val.Peek();
					}
					break;
				case ':':
					if (flag)
					{
						text = string.Concat((object)text, (object)aJSON.get_Chars(i));
						break;
					}
					text2 = text;
					text = "";
					flag2 = false;
					break;
				case '"':
					flag = !flag;
					flag2 = flag || flag2;
					break;
				case ',':
					if (flag)
					{
						text = string.Concat((object)text, (object)aJSON.get_Chars(i));
						break;
					}
					if (text != "")
					{
						AddElement(jSONNode, text, text2, flag2);
						flag2 = false;
					}
					text2 = "";
					text = "";
					flag2 = false;
					break;
				case '\t':
				case ' ':
					if (flag)
					{
						text = string.Concat((object)text, (object)aJSON.get_Chars(i));
					}
					break;
				case '\\':
					i++;
					if (flag)
					{
						char c = aJSON.get_Chars(i);
						switch (c)
						{
						case 't':
							text = string.Concat((object)text, (object)'\t');
							break;
						case 'r':
							text = string.Concat((object)text, (object)'\r');
							break;
						case 'n':
							text = string.Concat((object)text, (object)'\n');
							break;
						case 'b':
							text = string.Concat((object)text, (object)'\b');
							break;
						case 'f':
							text = string.Concat((object)text, (object)'\f');
							break;
						case 'u':
						{
							string text3 = aJSON.Substring(i + 1, 4);
							text = string.Concat((object)text, (object)(char)int.Parse(text3, (NumberStyles)512));
							i += 4;
							break;
						}
						default:
							text = string.Concat((object)text, (object)c);
							break;
						}
					}
					break;
				default:
					text = string.Concat((object)text, (object)aJSON.get_Chars(i));
					break;
				case '\n':
				case '\r':
					break;
				}
			}
			if (flag)
			{
				throw new global::System.Exception("JSON Parse: Quotation marks seems to be messed up.");
			}
			return jSONNode;
		}

		public virtual void Serialize(BinaryWriter aWriter)
		{
		}

		public static JSONNode Deserialize(BinaryReader aReader)
		{
			JSONBinaryTag jSONBinaryTag = (JSONBinaryTag)aReader.ReadByte();
			switch (jSONBinaryTag)
			{
			case JSONBinaryTag.Array:
			{
				int num2 = aReader.ReadInt32();
				JSONArray jSONArray = new JSONArray();
				for (int j = 0; j < num2; j++)
				{
					jSONArray.Add(Deserialize(aReader));
				}
				return jSONArray;
			}
			case JSONBinaryTag.Class:
			{
				int num = aReader.ReadInt32();
				JSONClass jSONClass = new JSONClass();
				for (int i = 0; i < num; i++)
				{
					string aKey = aReader.ReadString();
					JSONNode aItem = Deserialize(aReader);
					jSONClass.Add(aKey, aItem);
				}
				return jSONClass;
			}
			case JSONBinaryTag.Value:
				return new JSONData(aReader.ReadString());
			case JSONBinaryTag.IntValue:
				return new JSONData(aReader.ReadInt32());
			case JSONBinaryTag.DoubleValue:
				return new JSONData(aReader.ReadDouble());
			case JSONBinaryTag.BoolValue:
				return new JSONData(aReader.ReadBoolean());
			case JSONBinaryTag.FloatValue:
				return new JSONData(aReader.ReadSingle());
			case JSONBinaryTag.Null:
				return new JSONData(null);
			default:
				throw new global::System.Exception(string.Concat((object)"Error deserializing JSON. Unknown tag: ", (object)jSONBinaryTag));
			}
		}
	}
}