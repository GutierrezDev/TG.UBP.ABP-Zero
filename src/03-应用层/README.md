展现层
	展现层使用ASP.NET MVC和Web API来实现。可分别用于多页面应用程序(MPA)和单页面应用程序(SPA)。
	目前使用基于EasyUI的MPA。

具体规则：
1、将Controller和View分离，其中Controller放在TG.UBP.Web.Controllers项目（分离的目的是当业务采用不同实现方式时，Controller可以重用）；
2、一些页面需要使用Model暂时放在TG.UBP.Web.Controllers项目，视情况是否需要独立出来；
3、按模块建立Area子目录，例如：BaseManage（基础管理）；
