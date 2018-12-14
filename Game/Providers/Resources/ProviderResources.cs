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

using CatLib;
using Game.API.Resources;
using Game.Resources;
using Platform = UnityEngine.Application;

namespace Game.Debugger
{
    /// <summary>
    /// 资源加载服务提供者
    /// </summary>
    public sealed class ProviderResources : ServiceProvider
    {
        /// <summary>
        /// 允许同步加载
        /// </summary>
        public bool EnableSyncLoad { get; set; }

        /// <summary>
        /// 资源加载服务提供者
        /// </summary>
        public ProviderResources()
        {
            EnableSyncLoad = true;
        }

        /// <summary>
        /// 初始化资源服务
        /// </summary>
        public override void Init()
        {
            App.Watch<DebugLevels>(() =>
            {
                throw new LogicException("Resources provider it is not allowed to change the debug level at runtime");
            });
        }

        /// <summary>
        /// 注册资源加载服务
        /// </summary>
        public override void Register()
        {
            RegisterLoader(App.DebugLevel);
        }

        /// <summary>
        /// 注册资源加载器
        /// </summary>
        /// <param name="debugLevel">调试等级</param>
        private void RegisterLoader(DebugLevels debugLevel)
        {
            var binder = SingletonLoaderWithDebugLevel(debugLevel) ?? SingletonLoaderWithPlatform();
            binder.OnResolving<ILoadingRule>(rule =>
            {
                rule.EnableSyncLoad = EnableSyncLoad;
            });
        }

        /// <summary>
        /// 根据调试等级单例化指定的加载器
        /// </summary>
        /// <param name="debugLevel">调试等级</param>
        /// <returns>服务绑定数据</returns>
        private IBindData SingletonLoaderWithDebugLevel(DebugLevels debugLevel)
        {
            switch (debugLevel)
            {
                case DebugLevels.Development:
                    return SingletonLoaderAssetData();
                case DebugLevels.Staging:
                    return SingletonLoaderAssetBundle();
            }

            return null;
        }

        /// <summary>
        /// 根据平台单例化指定的加载器
        /// </summary>
        /// <returns>服务绑定数据</returns>
        private IBindData SingletonLoaderWithPlatform()
        {
            if (Platform.isEditor)
            {
                return SingletonLoaderAssetData();
            }

            return Platform.isMobilePlatform
                ? SingletonLoaderAssetBundle()
                : App.Singleton<IResources, LoaderResourcesFolder>();
        }

        /// <summary>
        /// 单例化AssetData加载器
        /// </summary>
        /// <returns>服务绑定数据</returns>
        private IBindData SingletonLoaderAssetData()
        {
            return App.Singleton<IResources, LoaderAssetData>();
        }

        /// <summary>
        /// 单例化AssetBundle加载器
        /// </summary>
        /// <returns>服务绑定数据</returns>
        private IBindData SingletonLoaderAssetBundle()
        {
            return App.Singleton<IResources, LoaderAssetBundle>();
        }
    }
}
