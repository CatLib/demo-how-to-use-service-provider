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
using Demo.API.Resources;

namespace Demo.Resources
{
    /// <summary>
    /// 是否支持资源同步加载
    /// </summary>
    internal abstract class LoaderBase : IResources, ILoadingRule
    {
        /// <summary>
        /// 是否允许同步加载
        /// </summary>
        public bool EnableSyncLoad { get; set; }

        /// <summary>
        /// 以同步的形式加载指定的资源
        /// </summary>
        /// <param name="path">资源路径</param>
        /// <returns>加载的资源</returns>
        public object LoadSync(string path)
        {
            AssertSyncLoad();
            return InternalLoadSync(path);
        }

        /// <summary>
        /// 同步加载
        /// </summary>
        /// <param name="path">资源路径</param>
        /// <returns>加载的资源</returns>
        protected abstract object InternalLoadSync(string path);

        /// <summary>
        /// 断言同步加载
        /// </summary>
        protected virtual void AssertSyncLoad()
        {
            if (!EnableSyncLoad)
            {
                throw new LogicException("Synchronous loading is not allowed");
            }
        }
    }
}
