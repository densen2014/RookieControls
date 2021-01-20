
### RookieControls
菜鸟学建自定义控件

### 组件
- TextBoxWithPlaceholder, 有占位文本的文本框
- DataGridViewHiDpi, 支持HiDpi的DataGridView
- Toast, 右下角信息浮动框
- RoundButton, 圆角/方形播放按钮,支持渐变和鼠标焦点
- InputNumber, 数字输入框
- Monitor, 网速监控

### 截图

![densen2014_RookieControls](https://user-images.githubusercontent.com/8428709/105117342-9f74eb00-5acc-11eb-88f1-11b8b2de165e.jpg)

### 0120
- **修改** 例程修整
- **增加** TextBoxWithPlaceholder ,有占位文本的文本框
- **增加** DataGridViewHiDpi, 支持HiDpi的DGV 
- **增加** RoundButton 添加方形属性
- **增加** Toast 添加直接初始化显示的方法,显示后主动返回现在窗体


          Toast 添加直接初始化显示的方法
          new Toast($"切换中文.", AlertType.Warning);

          添加 Toast 显示后主动返回现在窗体demo.
          new Toast($"切换中文.", AlertType.Warning);
          Activate();

### 1001
- **增加** Toast, 图标使用 https://fontawesome.com/icons?d=gallery

### 0930
- **增加** 圆角播放按钮.
- **增加** 数字框.仅允许输入标准的数字值，支持自定义范围及其他高级功能




### 参与贡献

1. Fork 本项目
2. 新建 Feat_xxx 分支
3. 提交代码
4. 新建 Pull Request 
