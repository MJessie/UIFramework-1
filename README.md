# UIFramework Coming Soon

设计思路
1、数据使用Database
2、通用UI与战斗数据
3、通用大厅UI与战斗UI
4、支持特殊UI，比喻新手引导
5、使用数据与UI绑定方式，数据更新，UI跟着更新
6、支持延迟加载，即一个UI可以分多次加载
7、UI要支持排序，数据内容更新，重新加载等所有功能
8、有一个通用的View，如果有特殊可以继承这个View来做特殊功能
9、一个Model可以绑定多个View，一个View可以来源于多个Model
10、View在显示时，所有数据实时更新
11、View隐藏后，再次显示，会有Refrese重新刷新所有数据。（只刷新用到的，比喻有多个标签数据，只刷新一个标签数据）
12、数据刷新以标签内容为单位
13、有一个ViewList，用来处理列表类的显示数据
14、Model与View的绑定数据结构为树形结构，当View需要Refrash时，会指定树层级结构来刷新