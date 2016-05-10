﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace SmartTerminalBase.TerminalUltility
{
    internal class TerminalQueues
    {
        //Queues Listed here
        public static ConcurrentQueue<PlcCommand> plccommandqueue = new ConcurrentQueue<PlcCommand>(); //plc通信队列

        public static ConcurrentQueue<PlcDAQCommunicationObject> plcdataprocessqueue =
            new ConcurrentQueue<PlcDAQCommunicationObject>(); //plc数据处理队列

        public static ConcurrentQueue<PlcDAQCommunicationObject> localdataqueue =
            new ConcurrentQueue<PlcDAQCommunicationObject>(); //本地数据处理队列

        public static ConcurrentQueue<PlcDAQCommunicationObject> datacenterprocessqueue =
            new ConcurrentQueue<PlcDAQCommunicationObject>(); //云数据处理队列

        public static ConcurrentQueue<PLCWarningObject> warninfoqueue = new ConcurrentQueue<PLCWarningObject>();
        public static ConcurrentQueue<PLCWarningObject> warninfoqueue_local = new ConcurrentQueue<PLCWarningObject>();
    }

    public class PLCWarningObject
    {
        public DateTime warn_time;
        public List<string> warndata;
    }

    //==================================================================
    //模块名： PlcDAQCommunicationObject
    //日期：    2015.12.11
    //功能：    建立PLC通信实例，包含一个数据字典和当前时间戳
    //输入参数：
    //返回值：  
    //修改记录：
    //==================================================================
    public class PlcDAQCommunicationObject
    {
        public DateTime daq_time;
        public Dictionary<string, int> plc_data;
        public Dictionary<string, string> plc_time;
        public Dictionary<string, string> temp_value;

        public PlcDAQCommunicationObject()
        {
            plc_data = new Dictionary<string, int>();
            plc_time = new Dictionary<string, string>();
            daq_time = DateTime.Now;
            temp_value = new Dictionary<string, string>();
        }
    }
}