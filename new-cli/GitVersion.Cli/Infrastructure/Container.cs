﻿using System;
using GitVersion.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace GitVersion.Cli.Infrastructure
{
    public class Container : IContainer
    {
        private readonly ServiceProvider serviceProvider;

        public Container(ServiceProvider serviceProvider) => this.serviceProvider = serviceProvider;

        public T GetService<T>() => serviceProvider.GetService<T>();

        public object GetService(Type type) => serviceProvider.GetService(type);

        public void Dispose() => serviceProvider.Dispose();
    }
}