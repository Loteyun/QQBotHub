﻿using Microsoft.AspNetCore.Mvc;
using PluginCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QQBotPlugin.Controllers
{
    /// <summary>
    /// ******  注意: 请将 QQBotPlugin 修改为你的 PluginId ************
    /// 
    /// 其实也可以不写这个, 直接访问 Plugins/QQBotPlugin/index.html
    /// 
    /// 下面的方法, 是去掉 index.html
    /// 
    /// 若 wwwroot 下有其它需要访问的文件, 如何 css, js, 而你又不想每次新增 action 指定返回, 则 Route 必须 Plugins/{PluginId},
    /// 这样访问 Plugins/QQBotPlugin/css/main.css 就会访问到你插件下的 wwwroot/css/main.css
    /// </summary>
    [Route("Plugins/QQBotPlugin")]
    public class HomeController : Controller
    {
        public async Task<ActionResult> Get()
        {
            string indexFilePath = System.IO.Path.Combine(PluginPathProvider.PluginWwwRootDir("QQBotPlugin"), "index.html");

            return PhysicalFile(indexFilePath, "text/html");
        }
    }
}
