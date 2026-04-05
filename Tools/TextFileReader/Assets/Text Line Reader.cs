using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using ColorUtility = UnityEngine.ColorUtility;

namespace nicorueda{
	

	public class TextLineReader : MonoBehaviour
	{
		[Header("Dependencies")]
		[SerializeField]
		//private TextAsset _file;

		//[SerializeField] 
		public Item[] _items;

		/*void OnValidate()
		{
			var lines = _file ? _file.text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries) : null;
			int i = 0;
			foreach (var line in lines)
			{
				_items[i] = ConvertToItem(line);
			}
		}

		Item ConvertToItem(string line)
		{
			var parts = line.Split(',');
			return new Item
			{
				name = parts[0],
				price = int.TryParse(parts[1], out var p) ? p : 0,
				color = ColorUtility.TryParseHtmlString(parts[2], out var c) ? c : Color.white,
			};
		}*/
		
	}

}

