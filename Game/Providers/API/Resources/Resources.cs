/*
 * Generated from CatLib.Generater
 * Time : 2018-12-13 14:31
 */

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

using CatLib;
using Game.API.Resources;

namespace Game.Facades
{
    /// <summary>
    /// 资源服务
    /// </summary>
    public sealed class Resources : Facade<IResources>
    {
        /// <summary>
        /// 以同步的形式加载指定的资源
        /// </summary>
        /// <param name="path">资源路径</param>
        public static object LoadSync(string path)
        {
            return Instance.LoadSync(path);
        }
    }
}
