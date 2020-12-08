﻿using IoTClient.Clients.ModBus;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace IoTClient.Tests.ModBus
{
    public class ModBusTcpClient_tests
    {
        ModBusTcpClient client;
        byte stationNumber = 2;//站号
        public ModBusTcpClient_tests()
        {
            var ip = IPAddress.Parse("ip".GetConfig());
            var port = int.Parse("port".GetConfig());
            client = new ModBusTcpClient(new IPEndPoint(ip, port));
        }

        /// <summary>
        /// ModBus值的写入有一定的延时，500毫秒后检验
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task 短连接自动开关()
        {
            short Number = 33;
            client.Write("4", Number, stationNumber);
            await Task.Delay(500);
            Assert.True(client.ReadInt16("4", stationNumber).Value == Number);

            Number = 34;
            client.Write("4", Number, stationNumber);
            await Task.Delay(500);
            Assert.True(client.ReadInt16("4", stationNumber).Value == Number);

            Number = 1;
            client.Write("12", Number, stationNumber);
            await Task.Delay(500);
            Assert.True(client.ReadInt16("12", stationNumber).Value == 1);

            Number = 0;
            client.Write("12", Number, stationNumber);
            await Task.Delay(500);
            Assert.True(client.ReadInt16("12", stationNumber).Value == 0);

            int numberInt32 = -12;
            client.Write("4", numberInt32, stationNumber);
            await Task.Delay(500);
            Assert.True(client.ReadInt32("4", stationNumber).Value == numberInt32);

            float numberFloat = 112;
            client.Write("4", numberFloat, stationNumber);
            await Task.Delay(500);
            Assert.True(client.ReadFloat("4", stationNumber).Value == numberFloat);

            double numberDouble = 32;
            client.Write("4", numberDouble, stationNumber);
            await Task.Delay(500);
            Assert.True(client.ReadDouble("4", stationNumber).Value == numberDouble);
        }

        [Fact]
        public async Task 长连接主动开关()
        {
            client.Open();

            short Number = 33;
            client.Write("4", Number, stationNumber);
            await Task.Delay(500);
            Assert.True(client.ReadInt16("4", stationNumber).Value == Number);

            Number = 34;
            client.Write("4", Number, stationNumber);
            await Task.Delay(500);
            Assert.True(client.ReadInt16("4", stationNumber).Value == Number);

            Number = 1;
            client.Write("12", Number, stationNumber);
            await Task.Delay(500);
            Assert.True(client.ReadInt16("12", stationNumber).Value == 1);

            Number = 0;
            client.Write("12", Number, stationNumber);
            await Task.Delay(500);
            Assert.True(client.ReadInt16("12", stationNumber).Value == 0);

            int numberInt32 = -12;
            client.Write("4", numberInt32, stationNumber);
            await Task.Delay(500);
            Assert.True(client.ReadInt32("4", stationNumber).Value == numberInt32);

            float numberFloat = 112;
            client.Write("4", numberFloat, stationNumber);
            await Task.Delay(500);
            Assert.True(client.ReadFloat("4", stationNumber).Value == numberFloat);

            double numberDouble = 32;
            client.Write("4", numberDouble, stationNumber);
            await Task.Delay(500);
            Assert.True(client.ReadDouble("4", stationNumber).Value == numberDouble);

            client.Close();
        }
    }
}
