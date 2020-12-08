﻿using IoTClient.Models;

namespace IoTClient.Clients.ModBus
{
    /// <summary>
    /// 
    /// </summary>
    public interface IModBusClient
    {
        /// <summary>
        /// 关闭连接
        /// </summary>
        /// <returns></returns>
        Result Close();

        /// <summary>
        /// 打开连接
        /// </summary>
        /// <returns></returns>
        Result Open();

        /// <summary>
        /// 发送报文，并获取响应报文
        /// </summary>
        /// <param name="dataPackage"></param>
        /// <returns></returns>
        byte[] SendPackage(byte[] dataPackage);

        #region  Read 读取
        /// <summary>
        /// 读取数据
        /// </summary>
        /// <param name="address">寄存器起始地址</param>
        /// <param name="stationNumber">站号</param>
        /// <param name="functionCode">功能码</param>
        /// <param name="readLength">读取长度</param>
        /// <returns></returns>
        Result<byte[]> Read(string address, byte stationNumber = 1, byte functionCode = 3, ushort readLength = 1);

        /// <summary>
        /// 读取Int16
        /// </summary>
        /// <param name="address">寄存器起始地址</param>
        /// <param name="stationNumber">站号</param>
        /// <param name="functionCode">功能码</param>
        /// <returns></returns>
        Result<short> ReadInt16(string address, byte stationNumber = 1, byte functionCode = 3);

        /// <summary>
        /// 从批量读取的数据字节提取对应的地址数据
        /// </summary>
        /// <param name="beginAddress"></param>
        /// <param name="address"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        Result<short> ReadInt16(string beginAddress, string address, byte[] values);

        /// <summary>
        /// 读取UInt16
        /// </summary>
        /// <param name="address">寄存器起始地址</param>
        /// <param name="stationNumber">站号</param>
        /// <param name="functionCode">功能码</param>
        /// <returns></returns>
        Result<ushort> ReadUInt16(string address, byte stationNumber = 1, byte functionCode = 3);

        /// <summary>
        /// 从批量读取的数据字节提取对应的地址数据
        /// </summary>
        /// <param name="beginAddress"></param>
        /// <param name="address"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        Result<ushort> ReadUInt16(string beginAddress, string address, byte[] values);

        /// <summary>
        /// 读取Int32
        /// </summary>
        /// <param name="address">寄存器起始地址</param>
        /// <param name="stationNumber">站号</param>
        /// <param name="functionCode">功能码</param>
        /// <returns></returns>
        Result<int> ReadInt32(string address, byte stationNumber = 1, byte functionCode = 3);

        /// <summary>
        /// 从批量读取的数据字节提取对应的地址数据
        /// </summary>
        /// <param name="beginAddress"></param>
        /// <param name="address"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        Result<int> ReadInt32(string beginAddress, string address, byte[] values);

        /// <summary>
        /// 读取UInt32
        /// </summary>
        /// <param name="address">寄存器起始地址</param>
        /// <param name="stationNumber">站号</param>
        /// <param name="functionCode">功能码</param>
        /// <returns></returns>
        Result<uint> ReadUInt32(string address, byte stationNumber = 1, byte functionCode = 3);

        /// <summary>
        /// 从批量读取的数据字节提取对应的地址数据
        /// </summary>
        /// <param name="beginAddress"></param>
        /// <param name="address"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        Result<uint> ReadUInt32(string beginAddress, string address, byte[] values);

        /// <summary>
        /// 读取Int64
        /// </summary>
        /// <param name="address">寄存器起始地址</param>
        /// <param name="stationNumber">站号</param>
        /// <param name="functionCode">功能码</param>
        /// <returns></returns>
        Result<long> ReadInt64(string address, byte stationNumber = 1, byte functionCode = 3);

        /// <summary>
        /// 从批量读取的数据字节提取对应的地址数据
        /// </summary>
        /// <param name="beginAddress"></param>
        /// <param name="address"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        Result<long> ReadInt64(string beginAddress, string address, byte[] values);

        /// <summary>
        /// 读取UInt64
        /// </summary>
        /// <param name="address">寄存器起始地址</param>
        /// <param name="stationNumber">站号</param>
        /// <param name="functionCode">功能码</param>
        /// <returns></returns>
        Result<ulong> ReadUInt64(string address, byte stationNumber = 1, byte functionCode = 3);

        /// <summary>
        /// 从批量读取的数据字节提取对应的地址数据
        /// </summary>
        /// <param name="beginAddress"></param>
        /// <param name="address"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        Result<ulong> ReadUInt64(string beginAddress, string address, byte[] values);

        /// <summary>
        /// 读取Float
        /// </summary>
        /// <param name="address">寄存器起始地址</param>
        /// <param name="stationNumber">站号</param>
        /// <param name="functionCode">功能码</param>
        /// <returns></returns>
        Result<float> ReadFloat(string address, byte stationNumber = 1, byte functionCode = 3);

        /// <summary>
        /// 从批量读取的数据字节提取对应的地址数据
        /// </summary>
        /// <param name="beginAddress"></param>
        /// <param name="address"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        Result<float> ReadFloat(string beginAddress, string address, byte[] values);

        /// <summary>
        /// 读取Double
        /// </summary>
        /// <param name="address">寄存器起始地址</param>
        /// <param name="stationNumber">站号</param>
        /// <param name="functionCode">功能码</param>
        /// <returns></returns>
        Result<double> ReadDouble(string address, byte stationNumber = 1, byte functionCode = 3);

        /// <summary>
        /// 从批量读取的数据字节提取对应的地址数据
        /// </summary>
        /// <param name="beginAddress"></param>
        /// <param name="address"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        Result<double> ReadDouble(string beginAddress, string address, byte[] values);

        /// <summary>
        /// 读取线圈
        /// </summary>
        /// <param name="address">寄存器起始地址</param>
        /// <param name="stationNumber">站号</param>
        /// <param name="functionCode">功能码</param>
        /// <returns></returns>
        Result<bool> ReadCoil(string address, byte stationNumber = 1, byte functionCode = 1);

        /// <summary>
        /// 从批量读取的数据字节提取对应的地址数据
        /// </summary>
        /// <param name="beginAddress"></param>
        /// <param name="address"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        Result<bool> ReadCoil(string beginAddress, string address, byte[] values);

        /// <summary>
        /// 读取离散
        /// </summary>
        /// <param name="address"></param>
        /// <param name="stationNumber"></param>
        /// <param name="functionCode"></param>
        /// <returns></returns>
        Result<bool> ReadDiscrete(string address, byte stationNumber = 1, byte functionCode = 2);

        /// <summary>
        /// 从批量读取的数据字节提取对应的地址数据
        /// </summary>
        /// <param name="beginAddress"></param>
        /// <param name="address"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        Result<bool> ReadDiscrete(string beginAddress, string address, byte[] values);
        #endregion

        #region Write 写入
        /// <summary>
        /// 线圈写入
        /// </summary>
        /// <param name="address"></param>
        /// <param name="value"></param>
        /// <param name="stationNumber"></param>
        /// <param name="functionCode"></param>
        Result Write(string address, bool value, byte stationNumber = 1, byte functionCode = 5);

        /// <summary>
        /// 写入
        /// </summary>
        /// <param name="address"></param>
        /// <param name="values"></param>
        /// <param name="stationNumber"></param>
        /// <param name="functionCode"></param>
        /// <returns></returns>
        Result Write(string address, byte[] values, byte stationNumber = 1, byte functionCode = 16);

        /// <summary>
        /// 写入
        /// </summary>
        /// <param name="address">寄存器地址</param>
        /// <param name="value">写入的值</param>
        /// <param name="stationNumber">站号</param>
        /// <param name="functionCode">功能码</param>
        Result Write(string address, short value, byte stationNumber = 1, byte functionCode = 16);

        /// <summary>
        /// 写入
        /// </summary>
        /// <param name="address">寄存器地址</param>
        /// <param name="value">写入的值</param>
        /// <param name="stationNumber">站号</param>
        /// <param name="functionCode">功能码</param>
        Result Write(string address, ushort value, byte stationNumber = 1, byte functionCode = 16);

        /// <summary>
        /// 写入
        /// </summary>
        /// <param name="address">寄存器地址</param>
        /// <param name="value">写入的值</param>
        /// <param name="stationNumber">站号</param>
        /// <param name="functionCode">功能码</param>
        Result Write(string address, int value, byte stationNumber = 1, byte functionCode = 16);

        /// <summary>
        /// 写入
        /// </summary>
        /// <param name="address">寄存器地址</param>
        /// <param name="value">写入的值</param>
        /// <param name="stationNumber">站号</param>
        /// <param name="functionCode">功能码</param>
        Result Write(string address, uint value, byte stationNumber = 1, byte functionCode = 16);

        /// <summary>
        /// 写入
        /// </summary>
        /// <param name="address">寄存器地址</param>
        /// <param name="value">写入的值</param>
        /// <param name="stationNumber">站号</param>
        /// <param name="functionCode">功能码</param>
        Result Write(string address, long value, byte stationNumber = 1, byte functionCode = 16);

        /// <summary>
        /// 写入
        /// </summary>
        /// <param name="address">寄存器地址</param>
        /// <param name="value">写入的值</param>
        /// <param name="stationNumber">站号</param>
        /// <param name="functionCode">功能码</param>
        Result Write(string address, ulong value, byte stationNumber = 1, byte functionCode = 16);

        /// <summary>
        /// 写入
        /// </summary>
        /// <param name="address">寄存器地址</param>
        /// <param name="value">写入的值</param>
        /// <param name="stationNumber">站号</param>
        /// <param name="functionCode">功能码</param>
        Result Write(string address, float value, byte stationNumber = 1, byte functionCode = 16);

        /// <summary>
        /// 写入
        /// </summary>
        /// <param name="address">寄存器地址</param>
        /// <param name="value">写入的值</param>
        /// <param name="stationNumber">站号</param>
        /// <param name="functionCode">功能码</param>
        Result Write(string address, double value, byte stationNumber = 1, byte functionCode = 16);
        #endregion
    }
}
