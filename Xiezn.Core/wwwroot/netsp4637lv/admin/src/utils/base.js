const base = {
    get() {
        return {
            url : "http://localhost:8080/netsp4637lv/",
            name: "netsp4637lv",
            // 退出到首页链接
            indexUrl: 'http://localhost:8080/netsp4637lv/front/dist/index.html'
        };
    },
    getProjectName(){
        return {
            projectName: "某高校社交学习平台的设计与实现"
        } 
    }
}
export default base
