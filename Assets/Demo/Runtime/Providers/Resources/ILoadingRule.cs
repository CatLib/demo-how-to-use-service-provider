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

namespace Demo.Resources
{
    /// <summary>
    /// 资源加载规则
    /// </summary>
    internal interface ILoadingRule
    {
        /// <summary>
        /// 是否允许同步加载
        /// </summary>
        bool EnableSyncLoad { get; set; }
    }
}
