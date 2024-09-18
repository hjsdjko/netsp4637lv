import VueRouter from 'vue-router'

//引入组件
import Index from '../pages'
import Home from '../pages/home/home'
import Login from '../pages/login/login'
import Register from '../pages/register/register'
import Center from '../pages/center/center'
import Forum from '../pages/forum/list'
import ForumAdd from '../pages/forum/add'
import ForumDetail from '../pages/forum/detail'
import MyForumList from '../pages/forum/myForumList'
import Storeup from '../pages/storeup/list'
import News from '../pages/news/news-list'
import NewsDetail from '../pages/news/news-detail'
import payList from '../pages/pay'

import yonghuList from '../pages/yonghu/list'
import yonghuDetail from '../pages/yonghu/detail'
import yonghuAdd from '../pages/yonghu/add'
import ziliaofenleiList from '../pages/ziliaofenlei/list'
import ziliaofenleiDetail from '../pages/ziliaofenlei/detail'
import ziliaofenleiAdd from '../pages/ziliaofenlei/add'
import xuexiziliaoList from '../pages/xuexiziliao/list'
import xuexiziliaoDetail from '../pages/xuexiziliao/detail'
import xuexiziliaoAdd from '../pages/xuexiziliao/add'
import shipinfenleiList from '../pages/shipinfenlei/list'
import shipinfenleiDetail from '../pages/shipinfenlei/detail'
import shipinfenleiAdd from '../pages/shipinfenlei/add'
import xuexishipinList from '../pages/xuexishipin/list'
import xuexishipinDetail from '../pages/xuexishipin/detail'
import xuexishipinAdd from '../pages/xuexishipin/add'
import newstypeList from '../pages/newstype/list'
import newstypeDetail from '../pages/newstype/detail'
import newstypeAdd from '../pages/newstype/add'
import systemintroList from '../pages/systemintro/list'
import systemintroDetail from '../pages/systemintro/detail'
import systemintroAdd from '../pages/systemintro/add'
import discussxuexiziliaoList from '../pages/discussxuexiziliao/list'
import discussxuexiziliaoDetail from '../pages/discussxuexiziliao/detail'
import discussxuexiziliaoAdd from '../pages/discussxuexiziliao/add'
import discussxuexishipinList from '../pages/discussxuexishipin/list'
import discussxuexishipinDetail from '../pages/discussxuexishipin/detail'
import discussxuexishipinAdd from '../pages/discussxuexishipin/add'

const originalPush = VueRouter.prototype.push
VueRouter.prototype.push = function push(location) {
	return originalPush.call(this, location).catch(err => err)
}

//配置路由
export default new VueRouter({
	routes:[
		{
      path: '/',
      redirect: '/index/home'
    },
		{
			path: '/index',
			component: Index,
			children:[
				{
					path: 'home',
					component: Home
				},
				{
					path: 'center',
					component: Center,
				},
				{
					path: 'pay',
					component: payList,
				},
				{
					path: 'forum',
					component: Forum
				},
				{
					path: 'forumAdd',
					component: ForumAdd
				},
				{
					path: 'forumDetail',
					component: ForumDetail
				},
				{
					path: 'myForumList',
					component: MyForumList
				},
				{
					path: 'storeup',
					component: Storeup
				},
				{
					path: 'news',
					component: News
				},
				{
					path: 'newsDetail',
					component: NewsDetail
				},
				{
					path: 'yonghu',
					component: yonghuList
				},
				{
					path: 'yonghuDetail',
					component: yonghuDetail
				},
				{
					path: 'yonghuAdd',
					component: yonghuAdd
				},
				{
					path: 'ziliaofenlei',
					component: ziliaofenleiList
				},
				{
					path: 'ziliaofenleiDetail',
					component: ziliaofenleiDetail
				},
				{
					path: 'ziliaofenleiAdd',
					component: ziliaofenleiAdd
				},
				{
					path: 'xuexiziliao',
					component: xuexiziliaoList
				},
				{
					path: 'xuexiziliaoDetail',
					component: xuexiziliaoDetail
				},
				{
					path: 'xuexiziliaoAdd',
					component: xuexiziliaoAdd
				},
				{
					path: 'shipinfenlei',
					component: shipinfenleiList
				},
				{
					path: 'shipinfenleiDetail',
					component: shipinfenleiDetail
				},
				{
					path: 'shipinfenleiAdd',
					component: shipinfenleiAdd
				},
				{
					path: 'xuexishipin',
					component: xuexishipinList
				},
				{
					path: 'xuexishipinDetail',
					component: xuexishipinDetail
				},
				{
					path: 'xuexishipinAdd',
					component: xuexishipinAdd
				},
				{
					path: 'newstype',
					component: newstypeList
				},
				{
					path: 'newstypeDetail',
					component: newstypeDetail
				},
				{
					path: 'newstypeAdd',
					component: newstypeAdd
				},
				{
					path: 'systemintro',
					component: systemintroList
				},
				{
					path: 'systemintroDetail',
					component: systemintroDetail
				},
				{
					path: 'systemintroAdd',
					component: systemintroAdd
				},
				{
					path: 'discussxuexiziliao',
					component: discussxuexiziliaoList
				},
				{
					path: 'discussxuexiziliaoDetail',
					component: discussxuexiziliaoDetail
				},
				{
					path: 'discussxuexiziliaoAdd',
					component: discussxuexiziliaoAdd
				},
				{
					path: 'discussxuexishipin',
					component: discussxuexishipinList
				},
				{
					path: 'discussxuexishipinDetail',
					component: discussxuexishipinDetail
				},
				{
					path: 'discussxuexishipinAdd',
					component: discussxuexishipinAdd
				},
			]
		},
		{
			path: '/login',
			component: Login
		},
		{
			path: '/register',
			component: Register
		},
	]
})
