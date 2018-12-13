/*
 * This file is part of the CatLib package.
 *
 * (c) Yu Bin <support@catlib.io>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Document: http://catlib.io/
 */

using System;
using CatLib;
using Game.Debugger;
using UnityEngine;
using IServiceProvider = CatLib.IServiceProvider;

namespace Game.Resources
{
    /// <summary>
    /// 资源服务服务提供者 - 可视化编辑支持
    /// </summary>
    [AddComponentMenu("Game/Providers/ProviderResources")]
    [DisallowMultipleComponent]
    public sealed class UnityProviderResources : MonoBehaviour, IServiceProvider, IServiceProviderType
    {
        /// <summary>
        /// 是否允许调试
        /// </summary>
        public bool EnableSyncLoad;

        /// <summary>
        /// 基础服务提供者
        /// </summary>
        private ProviderResources baseProvider;

        /// <summary>
        /// 基础服务提供者
        /// </summary>
        private ProviderResources BaseProvider
        {
            get
            {
                return baseProvider ?? (baseProvider = new ProviderResources
                {
                    EnableSyncLoad = EnableSyncLoad
                });
            }
        }

        /// <summary>
        /// 基础类型
        /// </summary>
        public Type BaseType
        {
            get
            {
                return BaseProvider.GetType();
            }
        }

        /// <summary>
        /// 初始化服务提供者
        /// </summary>
        public void Init()
        {
            BaseProvider.Init();
        }

        /// <summary>
        /// 注册服务提供者
        /// </summary>
        public void Register()
        {
            BaseProvider.Register();
        }
    }
}
