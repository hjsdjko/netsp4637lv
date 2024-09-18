using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SqlSugar;
using Newtonsoft.Json;

namespace Xiezn.Core.Models.DbModel
{
    /// <summary>
    ///	Desc: 学习视频
    /// </summary>
    [SugarTable("xuexishipin")]
	public class XuexishipinDbModel
	{           
		/// <summary>
		/// Desc: 主键Id
		/// </summary>
		[SugarColumn(IsPrimaryKey = true, ColumnName = "id")]
		public long Id { get; set; }

		/// <summary>
		/// Desc: 视频名称
		/// </summary>
		[SugarColumn(ColumnName = "shipinmingcheng")]
		public string Shipinmingcheng { get; set; }

		/// <summary>
		/// Desc: 视频分类
		/// </summary>
		[SugarColumn(ColumnName = "shipinfenlei")]
		public string Shipinfenlei { get; set; }

		/// <summary>
		/// Desc: 图片
		/// </summary>
		[SugarColumn(ColumnName = "tupian")]
		public string Tupian { get; set; }

		/// <summary>
		/// Desc: 学习视频
		/// </summary>
		[SugarColumn(ColumnName = "xuexishipin")]
		public string Xuexishipin { get; set; }

		/// <summary>
		/// Desc: 视频简述
		/// </summary>
		[SugarColumn(ColumnName = "shipinjianshu")]
		public string Shipinjianshu { get; set; }

		/// <summary>
		/// Desc: 发布时间
		/// </summary>
        [SugarColumn(ColumnName = "fabushijian")]
		public DateTime? Fabushijian { get; set; }

		/// <summary>
		/// Desc: 用户名
		/// </summary>
		[SugarColumn(ColumnName = "yonghuming")]
		public string Yonghuming { get; set; }

		/// <summary>
		/// Desc: 姓名
		/// </summary>
		[SugarColumn(ColumnName = "xingming")]
		public string Xingming { get; set; }

		/// <summary>
		/// Desc: 最近点击时间
		/// </summary>
        [SugarColumn(ColumnName = "clicktime")]
		public DateTime? Clicktime { get; set; }

		/// <summary>
		/// Desc: 点击次数
		/// </summary>
        [SugarColumn(ColumnName = "clicknum")]
		public int? Clicknum { get; set; } = 0;

		/// <summary>
		/// Desc: 评论数
		/// </summary>
        [SugarColumn(ColumnName = "discussnum")]
		public int? Discussnum { get; set; } = 0;

		/// <summary>
		/// Desc: 收藏数
		/// </summary>
        [SugarColumn(ColumnName = "storeupnum")]
		public int? Storeupnum { get; set; } = 0;

		/// <summary>
		/// Desc: 添加时间
		/// </summary>
		[SugarColumn(ColumnName = "addtime")]
		public DateTime? Addtime { get; set; } = DateTime.Now;

	}
}
