﻿/*
 * This file is part of the CatLib package.
 *
 * (c) CatLib <support@catlib.io>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Document: http://catlib.io/
 */

using CatLib;
using Demo.Debugger;

namespace Demo
{
    /// <summary>
    /// 项目注册的服务提供者
    /// </summary>
    public static class Providers
    {
        /// <summary>
        /// 项目注册的服务提供者
        /// </summary>
        public static IServiceProvider[] ServiceProviders
        {
            get
            {
                return new IServiceProvider[]
                {
                    new ProviderResources(),
                    new ProviderDebugger()
                };
            }
        }
    }
}