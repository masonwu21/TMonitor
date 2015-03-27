using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITVM3U8Monitor
{
    class ClassChannelName
    {
        //频道名称	channel_id

//CCTV-1高清	134100
//CCTV-3高清	134110
//CCTV-4中文国际（亚）	101400
//BTV-1高清	134160
//DOX-映画	134340
//DOX-剧场	134310
//DOX-新知	134320
//DOX-新艺	134330
//东方卫视 高清	134230
//江苏卫视 高清	134210
//湖南卫视 高清	134200
//浙江卫视 高清	134220
//CCTV-5 高清	134350
//江西卫视	112230
//CCTV-6 高清	134130
//深圳卫视	112400
//CCTV-新闻	101490
//广东卫视	112270
//贵州卫视	112210
//四川卫视	112320
//劲爆体育	145730
//安徽卫视	112240
//CCTV-NEWS	101520
//金鹰卡通	123320
//CDTV-5	123742
//SCTV-2	123732
//CCTV5+	101710
//国防军事	101620
//SCTV-5	123735
//CDTV-2	123739
        public List<ChannelItem> chitem;
        public ClassChannelName()
        {
            chitem = new List<ChannelItem>();
            chitem.Add(new ChannelItem { id = "1", name = "CCTV-1高清", tvid = "134100" });
            chitem.Add(new ChannelItem { id = "2", name = "CCTV-3高清", tvid = "134110" });
            chitem.Add(new ChannelItem { id = "3", name = "CCTV-4中文国际", tvid = "101400" });
            chitem.Add(new ChannelItem { id = "4", name = "BTV-1高清", tvid = "134160" });
            chitem.Add(new ChannelItem { id = "5", name = "DOX-映画", tvid = "134340" });
            chitem.Add(new ChannelItem { id = "6", name = "DOX-剧场", tvid = "134310" });
            chitem.Add(new ChannelItem { id = "7", name = "DOX-新知", tvid = "134320" });
            chitem.Add(new ChannelItem { id = "8", name = "DOX-韩剧", tvid = "199999" });
            chitem.Add(new ChannelItem { id = "9", name = "东方卫视 高清", tvid = "134230" });
            chitem.Add(new ChannelItem { id = "10", name = "江苏卫视 高清", tvid = "134210" });
            chitem.Add(new ChannelItem { id = "11", name = "湖南卫视 高清", tvid = "134200" });
            chitem.Add(new ChannelItem { id = "12", name = "浙江卫视 高清", tvid = "134220" });
            chitem.Add(new ChannelItem { id = "13", name = "CCTV-5 高清", tvid = "134350" });
            chitem.Add(new ChannelItem { id = "14", name = "新视觉", tvid = "123738" });
            chitem.Add(new ChannelItem { id = "15", name = "CCTV-6 高清", tvid = "134130" });
            chitem.Add(new ChannelItem { id = "16", name = "深圳卫视", tvid = "112400" });
            chitem.Add(new ChannelItem { id = "17", name = "CCTV-新闻", tvid = "101490" });
            chitem.Add(new ChannelItem { id = "18", name = "CHC动作影院", tvid = "145100" });
            chitem.Add(new ChannelItem { id = "19", name = "风云足球", tvid = "101600" });
            chitem.Add(new ChannelItem { id = "20", name = "四川卫视", tvid = "112320" });
            chitem.Add(new ChannelItem { id = "21", name = "游戏风云", tvid = "145420" });
            chitem.Add(new ChannelItem { id = "22", name = "安徽卫视", tvid = "112240" });
            chitem.Add(new ChannelItem { id = "23", name = "CCTV-NEWS", tvid = "101520" });
            chitem.Add(new ChannelItem { id = "24", name = "动漫秀场", tvid = "145430" });
            chitem.Add(new ChannelItem { id = "25", name = "CDTV-5", tvid = "123742" });
            chitem.Add(new ChannelItem { id = "26", name = "SCTV-2", tvid = "123732" });
            chitem.Add(new ChannelItem { id = "27", name = "CCTV5+", tvid = "101710" });
            chitem.Add(new ChannelItem { id = "28", name = "国防军事", tvid = "101620" });
            chitem.Add(new ChannelItem { id = "29", name = "SCTV-5", tvid = "123735" });
            chitem.Add(new ChannelItem { id = "30", name = "CDTV-2", tvid = "123739" });


        }

    }

    class ChannelItem
    {
        public string id { get; set; }
        public string name { get; set; }
        public string tvid { get; set; }

    }


    class ChannelPort
    {
        public List<ChannelPortItem> chitem;
        public ChannelPort()
        {
            chitem = new List<ChannelPortItem>();
        chitem.Add(new ChannelPortItem { ChannelId="209", ServiceId="134100_400k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-209.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="109",ServiceId="134100_1000k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-109.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="210",ServiceId="134110_400k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-210.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="110",ServiceId="134110_1000k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-110.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="211",ServiceId="101400_400k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-211.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="111",ServiceId="101400_1000k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-111.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="205",ServiceId="134160_400k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-205.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="105",ServiceId="134160_1000k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-105.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="202",ServiceId="134230_400k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-202.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="102",ServiceId="134230_1000k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-102.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="201",ServiceId="134210_400k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-201.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="101",ServiceId="134210_1000k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-101.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="204",ServiceId="134200_400k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-204.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="104",ServiceId="134200_1000k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-104.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="203",ServiceId="134220_400k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-203.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="103",ServiceId="134220_1000k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-103.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="212",ServiceId="134350_400k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-212.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="112",ServiceId="134350_1000k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-112.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="213",ServiceId="123738_400k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-213.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="113",ServiceId="123738_1000k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-113.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="214",ServiceId="134130_400k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-214.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="114",ServiceId="134130_1000k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-114.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="215",ServiceId="134340_400k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-215.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="115",ServiceId="134340_1000k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-115.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="216",ServiceId="134310_400k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-216.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="116",ServiceId="134310_1000k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-116.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="217",ServiceId="134320_400k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-217.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="117",ServiceId="134320_1000k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-117.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="218",ServiceId="199999_400k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-218.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="118",ServiceId="199999_1000k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-118.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="414",ServiceId="112400_400k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-414.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="28", ServiceId="112400_1000k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-28.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="413", ServiceId="101490_400k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-413.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="27", ServiceId="101490_1000k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-27.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="443", ServiceId="145100_400k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-443.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="8", ServiceId="145100_1000k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-8.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="478", ServiceId="101600_400k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-478.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="67", ServiceId="101600_1000k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-67.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="475", ServiceId="112320_400k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-475.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="68", ServiceId="112320_1000k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-68.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="476", ServiceId="145420_400k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-476.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="69", ServiceId="145420_1000k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-69.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="474", ServiceId="112240_400k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-474.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="70", ServiceId="112240_1000k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-70.m3u8"});
        //chitem.Add(new ChannelPortItem { ChannelId="479", ServiceId="145270_400k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-479.m3u8"});
        //chitem.Add(new ChannelPortItem { ChannelId="71", ServiceId="145270_1000k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-71.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="472", ServiceId="145430_400k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-472.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="72", ServiceId="145430_1000k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-72.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="417", ServiceId="123742_400k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-417.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="73", ServiceId="123742_1000k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-73.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="416", ServiceId="123732_400k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-416.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="74", ServiceId="123732_1000k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-74.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="418", ServiceId="101710_400k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-418.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="75", ServiceId="101710_1000k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-75.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="419", ServiceId="101620_400k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-419.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="76", ServiceId="101620_1000k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-76.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="480", ServiceId="123735_400k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-480.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="77", ServiceId="123735_1000k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-77.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="402", ServiceId="123739_400k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-402.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="17", ServiceId="123739_1000k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-17.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="481", ServiceId="101520_400k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-481.m3u8"});
        chitem.Add(new ChannelPortItem { ChannelId="482", ServiceId="101520_1000k",URL="http://scgd-m3u8.joyseetv.com:8080/trans_m3u8/DWHLS-482.m3u8"});


        }


    }

    class ChannelPortItem
    {
        public string ChannelId { get; set; }
        public string ServiceId { get; set; }
        public string URL { get; set; }

    }
}
