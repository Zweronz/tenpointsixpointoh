using System;
using System.Reflection;

namespace FyberPlugin.LitJson
{
	internal struct PropertyMetadata
	{
		public MemberInfo Info;

		public bool IsField;

		public global::System.Type Type;
	}
}