﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dp2weixin.service
{
    public class BbResult : ApiResult
    {
        public List<BbItem> items { get; set; }

        public string worker { get; set; }

        public string html { get;set;}
    }

    public class BbItem
    {
        public string id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public string contentFormat { get; set; }  // 2016-6-20 text/markdown
        public string contentHtml { get; set; }  // 2016-6-20 html形态
        public string publishTime { get; set; } // 2016-6-20 jane 发布时间，服务器消息的时间

        public string creator { get; set; }  //创建公告的工作人员帐户
    }
}