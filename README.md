# Geeiot AliyunDdns Tools
自动获取本机外网IP，然后将指定域名解析到此IP，类似于花生壳DDNS。支持开机启动。

##### 一、简介

  ![image](https://github.com/geeiot/AliyunDdns/blob/master/Image/001.jpg)

这货长这样，有点丑，但是简单好用。填好域名，点击Start即可开始工作。当扫描到IP变化后会自动将变化后的IP解析到指定域名。这货基于隔壁的AliyunDnsSDK，欢迎Star。

##### 二、如何使用
首先在设置当中填写AccessKeyId和AccessKeySecret，这两个数据需要到阿里云控制台去申请。
然后填写域名，格式为www.geeiot.net，不指定主机记录的话，也需要填写成@.geeiot.net。然后点击Start，即可开始工作。
