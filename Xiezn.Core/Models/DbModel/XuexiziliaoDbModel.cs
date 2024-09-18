using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SqlSugar;
using Newtonsoft.Json;

namespace Xiezn.Core.Models.DbModel
{
    /// <summary>
    ///	Desc: 学习资料
    /// </summary>
    [SugarTable("xuexiziliao")]
	public class XuexiziliaoDbModel
	{           
		/// <summary>
		/// Desc: 主键Id
		/// </summary>
		[SugarColumn(IsPrimaryKey = true, ColumnName = "id")]
		public long Id { get; set; }

		/// <summary>
		/// Desc: 资料名称
		/// </summary>
		[SugarColumn(ColumnName = "ziliaomingcheng")]
		public string Ziliaomingcheng { get; set; }

		/// <summary>
		/// Desc: 资料分类
		/// </summary>
		[SugarColumn(ColumnName = "ziliaofenlei")]
		public string Ziliaofenlei { get; set; }

		/// <summary>
		/// Desc: 图片
		/// </summary>
		[SugarColumn(ColumnName = "tupian")]
		public string Tupian { get; set; }

		/// <summary>
		/// Desc: 资料下载
		/// </summary>
		[SugarColumn(ColumnName = "ziliaoxiazai")]
		public string Ziliaoxiazai { get; set; }

		/// <summary>
		/// Desc: 资料简述
		/// </summary>
		[SugarColumn(ColumnName = "ziliaojianshu")]
		public string Ziliaojianshu { get; set; }

		/// <summary>
		/// Desc: 资料内容
		/// </summary>
		[SugarColumn(ColumnName = "ziliaoneirong")]
		public string Ziliaoneirong { get; set; }

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
