using System.Collections.Generic;
using System.Reflection;

namespace Edelweiss.DecalSystem
{
	[DefaultMember("Item")]
	internal class CutEdges
	{
		private SortedDictionary<CutEdge, CutEdge> m_CutEdgeDictionary = new SortedDictionary<CutEdge, CutEdge>();

		public int Count
		{
			get
			{
				return m_CutEdgeDictionary.get_Count();
			}
		}

		public CutEdge this[CutEdge a_CutEdge]
		{
			get
			{
				return m_CutEdgeDictionary.get_Item(a_CutEdge);
			}
			set
			{
				m_CutEdgeDictionary.set_Item(a_CutEdge, value);
			}
		}

		public void Clear()
		{
			m_CutEdgeDictionary.Clear();
		}

		public bool HasCutEdge(CutEdge a_CutEdge)
		{
			return m_CutEdgeDictionary.ContainsKey(a_CutEdge);
		}

		public void AddEdge(CutEdge a_CutEdge)
		{
			m_CutEdgeDictionary.Add(a_CutEdge, a_CutEdge);
		}
	}
}