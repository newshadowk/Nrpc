﻿using System;
using System.Threading.Tasks;
using DataContract;
using NetRpc.Grpc;

namespace Service
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var o = new GrpcServiceOptions();
            o.AddPort("0.0.0.0", 50001);
            await NetRpcManager.CreateHost(o, null, typeof(Service)).StartAsync();
        }
    }

    internal class Service : IService
    {
        public async Task Call(string s)
        {
            Console.WriteLine($"Receive: {s}");
        }
    }
}