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

namespace Game.API.Resources
{
    /// <summary>
    /// 资源服务
    /// </summary>
    public interface IResources
    {
        /// <summary>
        /// 以同步的形式加载指定的资源
        /// </summary>
        /// <param name="path">资源路径</param>
        object LoadSync(string path);
    }
}
