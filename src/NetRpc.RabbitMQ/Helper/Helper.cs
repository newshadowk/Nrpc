﻿using System;
using RabbitMQ.Client;

namespace NetRpc.RabbitMQ
{
    public static class Helper
    {
        public static ConnectionFactory CreateConnectionFactory(this MQOptions options)
        {
            return new()
            {
                UserName = options.User,
                Password = options.Password,
                VirtualHost = options.VirtualHost,
                HostName = options.Host,
                Port = options.Port,
                AutomaticRecoveryEnabled = true,
                NetworkRecoveryInterval = TimeSpan.FromSeconds(5),
                DispatchConsumersAsync = true,
                ConsumerDispatchConcurrency =  options.PrefetchCount
            };
        }
    }
}