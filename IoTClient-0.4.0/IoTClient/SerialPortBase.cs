﻿using IoTClient.Models;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;
using System.Threading;

namespace IoTClient
{
    /// <summary>
    /// SerialPort基类
    /// </summary>
    public abstract class SerialPortBase
    {
        /// <summary>
        /// 串行端口对象
        /// </summary>
        protected SerialPort serialPort;

        /// <summary>
        /// 是否自动打开关闭
        /// </summary>
        protected bool isAutoOpen = true;

        /// <summary>
        /// 获取设备上的COM端口集合
        /// </summary>
        /// <returns></returns>
        public static string[] GetPortNames()
        {
            return SerialPort.GetPortNames();
        }

        /// <summary>
        /// 连接
        /// </summary>
        /// <returns></returns>
        protected Result Connect()
        {
            var result = new Result();
            serialPort?.Close();
            try
            {
                serialPort.Open();
            }
            catch (Exception ex)
            {
                result.IsSucceed = false;
                result.Err = ex.Message;
            }
            return result;
        }

        /// <summary>
        /// 打开连接
        /// </summary>
        /// <returns></returns>
        public Result Open()
        {
            isAutoOpen = false;
            return Connect();
        }

        /// <summary>
        /// 关闭连接
        /// </summary>
        /// <returns></returns>
        protected Result Dispose()
        {
            var result = new Result();
            try
            {
                serialPort.Close();
            }
            catch (Exception ex)
            {
                result.IsSucceed = false;
                result.Err = ex.Message;
            }
            return result;
        }

        /// <summary>
        /// 关闭连接
        /// </summary>
        /// <returns></returns>
        public Result Close()
        {
            isAutoOpen = true;
            return Dispose();
        }

        /// <summary>
        /// 读取
        /// </summary>
        /// <param name="serialPort"></param>
        /// <returns></returns>
        protected byte[] SerialPortRead(SerialPort serialPort)
        {
            //延时处理
            if (serialPort.BytesToRead == 0) Thread.Sleep(20);
            if (serialPort.BytesToRead == 0) Thread.Sleep(40);
            if (serialPort.BytesToRead == 0) Thread.Sleep(80);
            byte[] buffer = new byte[serialPort.BytesToRead];
            var length = serialPort.Read(buffer, 0, buffer.Length);
            return buffer;
        }
    }
}
