# untiy淡出淡入转场效果
unity转场功能，淡出淡入效果，利用画布黑色渐变转场
在unity中创建一个新的Canvas，并且添加Canvas Group组件。
在Canvas中添加image组件，修改Rect Transform左上角的锚点，最右下角按住Alt键选择(stretch,stretch)，更改image颜色为黑色，盖住整个游戏画面。
为Canvas添加脚本
将Canvas赋给脚本
组件界面勾选Fade in 和设置Alpha为1，播放可淡入场景
组件界面取消勾选Fade out 和设置Alpha为o，可淡出场景

matt视频学习所得
