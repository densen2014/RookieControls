
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

---
#### Blazor 组件

[条码扫描 ZXingBlazor](https://www.nuget.org/packages/ZXingBlazor#readme-body-tab)
[![nuget](https://img.shields.io/nuget/v/ZXingBlazor.svg?style=flat-square)](https://www.nuget.org/packages/ZXingBlazor) 
[![stats](https://img.shields.io/nuget/dt/ZXingBlazor.svg?style=flat-square)](https://www.nuget.org/stats/packages/ZXingBlazor?groupby=Version)

[图片浏览器 Viewer](https://www.nuget.org/packages/BootstrapBlazor.Viewer#readme-body-tab)
  
[条码扫描 BarcodeScanner](Densen.Component.Blazor/BarcodeScanner.md)
   
[手写签名 Handwritten](Densen.Component.Blazor/Handwritten.md)

[手写签名 SignaturePad](https://www.nuget.org/packages/BootstrapBlazor.SignaturePad#readme-body-tab)

[定位/持续定位 Geolocation](https://www.nuget.org/packages/BootstrapBlazor.Geolocation#readme-body-tab)

[屏幕键盘 OnScreenKeyboard](https://www.nuget.org/packages/BootstrapBlazor.OnScreenKeyboard#readme-body-tab)

[百度地图 BaiduMap](https://www.nuget.org/packages/BootstrapBlazor.BaiduMap#readme-body-tab)

[谷歌地图 GoogleMap](https://www.nuget.org/packages/BootstrapBlazor.Maps#readme-body-tab)

[蓝牙和打印 Bluetooth](https://www.nuget.org/packages/BootstrapBlazor.Bluetooth#readme-body-tab)

[PDF阅读器 PdfReader](https://www.nuget.org/packages/BootstrapBlazor.PdfReader#readme-body-tab)

[文件系统访问 FileSystem](https://www.nuget.org/packages/BootstrapBlazor.FileSystem#readme-body-tab)

[光学字符识别 OCR](https://www.nuget.org/packages/BootstrapBlazor.OCR#readme-body-tab)

[电池信息/网络信息 WebAPI](https://www.nuget.org/packages/BootstrapBlazor.WebAPI#readme-body-tab)

#### AlexChow

[今日头条](https://www.toutiao.com/c/user/token/MS4wLjABAAAAGMBzlmgJx0rytwH08AEEY8F0wIVXB2soJXXdUP3ohAE/?) | [博客园](https://www.cnblogs.com/densen2014) | [知乎](https://www.zhihu.com/people/alex-chow-54) | [Gitee](https://gitee.com/densen2014) | [GitHub](https://github.com/densen2014)


![ChuanglinZhou](https://user-images.githubusercontent.com/8428709/205942253-8ff5f9ca-a033-4707-9c36-b8c9950e50d6.png)
