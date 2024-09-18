using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xiezn.Core.Common.Helpers;
using Xiezn.Core.Models;
using Xiezn.Core.Models.DbModel;


namespace Xiezn.Core.Business.Services
{
    public class XuexiziliaoService : BaseService<XuexiziliaoDbModel>
    {
        private readonly long _uid;
        private readonly string _role;
        private readonly string _tablename;

        public XuexiziliaoService()
        {
            try
            {
                if (CacheHelper.TokenModel != null)
                {
                    _uid = CacheHelper.TokenModel.Uid;
                    _role = CacheHelper.TokenModel.Role;
                    _tablename = CacheHelper.TokenModel.Tablename;
                }
            }
            catch
            {
                _uid = 0;
                _role = "游客";
            }
        }



        public int IntelRecom(long id)
        {
            XuexiziliaoDbModel updateObj = new XuexiziliaoDbModel();
            //return Db.Updateable(updateObj).UpdateColumns(it => new { it.Clicktime }).ReSetValue(it => it.Clicktime == (it.Clicktime + 1)).Where(it => it.Id == id).ExecuteCommand();
            return Db.Updateable(updateObj).UpdateColumns(it => new { it.Clicktime }).ReSetValue(it => it.Clicktime == DateTime.Now).Where(it => it.Id == id).ExecuteCommand();
        }

		public int BrowseClick(long id)
        {
            XuexiziliaoDbModel updateObj = new XuexiziliaoDbModel();
            return Db.Updateable(updateObj).UpdateColumns(it => new { it.Clicknum }).ReSetValue(it => it.Clicknum == (it.Clicknum + 1)).Where(it => it.Id == id).ExecuteCommand();
        }


        public PageModel<XuexiziliaoDbModel> GetPageList(int page, int limit, string sort, string order, List<IConditionalModel> conModels)
        {
            PageModel pageModel = new PageModel() { PageIndex = page, PageSize = limit };

            int totalNumber = 0;
            int totalPage = 0;
            string[] sortFields = sort.Split(',');
            string[] orderFields = order.Split(',');
            string mysort = "";
            for (int i = 0; i < sortFields.Length; i++)
            {
                if (i == sortFields.Length - 1)
                {
                    mysort += sortFields[i] + " " + orderFields[i];
                }
                else
                {
                    mysort += sortFields[i] + " " + orderFields[i] + ",";

                }

            }
            List<XuexiziliaoDbModel> ts = Db.Queryable<XuexiziliaoDbModel>().Where(conModels).OrderBy(mysort).ToPageList(page, limit, ref totalNumber, ref totalPage);


            PageModel<XuexiziliaoDbModel> t = new PageModel<XuexiziliaoDbModel>()
            {
                Code = ResponseCodeEnum.Success,
                Data = new Page<XuexiziliaoDbModel>()
                {
                    Total = totalNumber,
                    PageSize = limit,
                    TotalPage = totalPage,
                    CurrPage = page,
                    List = ts
                }
            };

            return t;
        }






        public PageModel<XuexiziliaoDbModel> AutoSort2(int page, int limit, Dictionary<string, string> filterPairs =null)
        {
            List<StoreupDbModel> storeupList = Db.Ado.SqlQuery<StoreupDbModel>(@"select inteltype from storeup where userid = " + _uid + " and tablename = 'xuexiziliao' order by addtime desc").ToList();

            List<string> whereIn = new List<string>();
            foreach (StoreupDbModel storeup in storeupList)
            {
                whereIn.Add(storeup.Inteltype);
            }

            string filtervalues = "";
            foreach (var queryString in filterPairs)
            {
                var key = queryString.Key;
                var values = queryString.Value;

                filtervalues += "AND " + key + "='" + values+"'";
            }

            string sql = @"select * from xuexiziliao where ziliaofenlei in ('{0}') "+ filtervalues + " union all select * from xuexiziliao where ziliaofenlei not in ('{0}') "+ filtervalues;
 
            sql = string.Format(sql, string.Join("','", whereIn.ToArray()));

            List<XuexiziliaoDbModel> ts = Db.Ado.SqlQuery<XuexiziliaoDbModel>(sql).ToList();
            PageModel<XuexiziliaoDbModel> t = new PageModel<XuexiziliaoDbModel>()
            {
                Code = ResponseCodeEnum.Success,
                Data = new Page<XuexiziliaoDbModel>()
                {
                    Total = limit,
                    PageSize = limit,
                    TotalPage = 1,
                    CurrPage = page,
                    List = ts
                }
            };

            return t;
        }


    }
}
