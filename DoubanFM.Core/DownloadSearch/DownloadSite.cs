/*
 * Author:莠草
 * Email : zj109074384@sina.com
 * Website : http://www.kfstorm.com
 * */

using System;

namespace DoubanFM.Core
{
	/// <summary>
	/// 提供音乐下载的网站
	/// </summary>
	[Flags]
	public enum DownloadSite
	{
		/// <summary>
        /// 巨鲸音乐(www.top100.cn)
		/// </summary>
		//Top100 = 0x1,
		/// <summary>
		/// 百度音乐(music.baidu.com)
		/// </summary>
		BaiduMusic = 0x2,
        /// <summary>
        /// QQ音乐(y.qq.com)
        /// </summary>
        QQMusic = 0x4
	}
}
