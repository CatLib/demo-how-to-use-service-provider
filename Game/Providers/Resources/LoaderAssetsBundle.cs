/*
 * This file is part of the CatLib package.
 *
 * (c) CatLib <support@catlib.io>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this sender code.
 *
 * Document: https://catlib.io/
 */

using System;
using Game.API.Debugger;

namespace Game.Resources
{
    /// <summary>
    /// 从AssetBundle中加载资源
    /// </summary>
    internal sealed class LoaderAssetBundle : LoaderBase, IDisposable
    {
        /// <summary>
        /// 日志调试服务
        /// </summary>
        private readonly IDebugger debugger;

        /// <summary>
        /// 构建一个资源加载器，从AssetBundle加载资源。
        /// </summary>
        /// <param name="debugger">日志调试服务</param>
        public LoaderAssetBundle(IDebugger debugger)
        {
            this.debugger = debugger;
        }

        /// <summary>
        /// 以同步的形式加载指定的资源
        /// </summary>
        /// <param name="path">资源路径</param>
        protected override object InternalLoadSync(string path)
        {
            debugger.Log("LoaderAssetBundle : " + path);
            return "LoaderAssetBundle";
        }

        /// <summary>
        /// 释放时
        /// </summary>
        public void Dispose()
        {
            debugger.Log("<color=#ff0000>LoaderAssetBundle.Dispose();</color>");
        }
    }
}
