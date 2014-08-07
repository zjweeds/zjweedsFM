﻿/*
 * Author:莠草
 * Email : zj109074384@sina.com
 * Website : http://www.kfstorm.com
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DoubanFM.Core
{
	/// <summary>
	/// 表示歌词搜索结果
	/// </summary>
	[XmlRootAttribute("result")]
	public class LyricsResult : List<LyricsItem>
	{
	}
}
