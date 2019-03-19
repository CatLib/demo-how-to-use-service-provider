/*
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
using UnityEngine;

namespace Demo
{
    /// <summary>
    /// 项目入口
    /// </summary>
    [DisallowMultipleComponent]
    public sealed class Main : Framework
    {
        /// <summary>
        /// 项目入口
        /// </summary>
        protected override void OnStartCompleted()
        {
            var go = App.Make<Component>().gameObject;
            go.AddComponent<TestsGUI>();
        }

        /// <summary>
        /// 获取引导程序
        /// </summary>
        /// <returns>引导脚本</returns>
        protected override IBootstrap[] GetBootstraps()
        {
            return Arr.Merge(base.GetBootstraps(), Bootstraps.GetBoostraps(this));
        }
    }
}
