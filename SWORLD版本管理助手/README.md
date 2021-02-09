# 软件更新方案

## 1、Linux服务器架构设计

### 说明

操作系统：Debian 10

服务软件：nginx

端口号：80

文件服务器root地址：/home/sworld/software/

安装nginx

```shell
sudo apt install nginx
```

配置nginx

nginx配置文件在`/etc/nginx/`路径下，其中`sites-available`为配置文件目录，当需要使配置生效时，建立`sites-enable`目录下软连接，然后使用`sudo service nginx reload`就可以使配置生效，操作nginx还有下述命令：

```shell
sudo /etc/init.d/nginx start|stop|reload|
sudo service nginx start|stop|reload|
```

### 配置

安装nginx后，在`/etc/nginx/sites-available`下新建文件`service-software`：

```shell
sudo nano /etc/nginx/sites-available/service-software
```

添加内容：

```shell
server {
  listen 80; 
  server_name frp.sworld.top; # 自己PC的ip或者服务器的域名 
  charset utf-8; # 避免中文乱码 
  root /home/sworld/software; # 存放文件的目录 
  location / { 
    autoindex on; # 索引 
    autoindex_exact_size on; # 显示文件大小 
    autoindex_localtime on; # 显示文件时间 
  }
}
```

建立软连接：

```shell
sudo ln -s /etc/nginx/sites-available/service-software /etc/nginx/sites-enabled/service-software
```

使配置生效：

```shell
# 需要先删除默认的配置文件软连接
sudo rm /etc/nginx/sites-enabled/default
# 重新加载服务
sudo service nginx reload
```

### 访问加密（可选）

访问加密由两个参数控制：

- `auth_basic`： 定义弹出输入用户名和密码提示信息，如"Access verification";
- `auth_basic_user_file`：代表导入的用户名和密码列表配置文件，这样配置以后所有访问protected目录下文件的请求都需要用户输入用户名和密码才能登陆，如`/etc/nginx/conf.d/htpasswd`;

进入`etc/nginx/conf.d/`目录，生成验证文件：

```shell
cd /etc/nginx/conf.d
printf "sworld:$(openssl passwd -crypt Xp199603290031.)\n" >> htpasswd
```

然后修改`/etc/nginx/sites-available/service-software`文件：

```shell
sudo nano /etc/nginx/sites-available/service-software
```

修改为：

```shell
server {
  listen 80;
  server_name frp.sworld.top; # 自己PC的ip或者服务器的域名
  charset utf-8; # 避免中文乱码
  root /home/sworld/software; # 存放文件的目录
  location / {
    auth_basic   "Access verification";
    auth_basic_user_file  /etc/nginx/conf.d/htpasswd;
    autoindex on; # 索引
    autoindex_exact_size on; # 显示文件大小
    autoindex_localtime on; # 显示文件时间
  }
}
```

使配置生效：

```shell
sudo service nginx reload
```

## 2、目录说明

以项目为单位，一个项目一个文件夹（如`sworld_development_assistant`），项目文件夹中，分为`software、data`等，`software`表示软件源码文件夹，文件夹中以版本区分如`v1.0`，`data`为数据文件，可存放`firmware、config`等,其它文件夹内容根据软件详情具体配置。

```
|/home/sworld/software
|--project 1 (sworld_development_assistant)
|----software
|------v20.01.18
|----data
|------config
|--project 2 (sworld_development_assistant_jlauiot)
|----software
|------v20.01.18
|----data
|------firmware
```

## 3、实体说明

软件实体（Software）

| 字段名   | 说明                     | 数据类型      |
| -------- | ------------------------ | ------------- |
| Code     | 软件编码（存放文件夹名） | string        |
| Name     | 软件名称                 | string        |
| AddDate  | 添加日期                 | datetime      |
| Sync     | 和服务器同步状态         | bool          |
| Versions | 版本信息                 | List<Version> |
| SDatas   |                          |               |

版本实体（Version）

| 字段名        | 说明     | 数据类型 |
| ------------- | -------- | -------- |
| VersionNum    | 版本号   | string   |
| UpdateContent | 更新内容 | string   |
| AddDate       | 添加时间 | datetime |
| Sync          | 同步状态 | bool     |
| MD5           | MD5加密  | string   |

数据实体（SData）

| 字段名 | 说明 | 数据类型 |
| ------ | ---- | -------- |
|        |      |          |
|        |      |          |
|        |      |          |



## 3、更新软件设计

开发语言：C#





参考链接：

[Nginx文件加密](http://vincenthou.github.io/2014/05/21/Nginx%E6%96%87%E4%BB%B6%E5%8A%A0%E5%AF%86/)

[Nginx创建密码验证保护网站目录](https://www.jianshu.com/p/c307aa43f3e6)

[Nginx给指定目录加密，静态文件（设计图）原型部署](https://blog.csdn.net/gu_study/article/details/104791450)

[用nginx一分钟实现文件服务器](https://www.jianshu.com/p/d9f886a9666a)

