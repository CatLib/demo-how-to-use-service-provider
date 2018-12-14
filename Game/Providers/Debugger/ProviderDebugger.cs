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
using Game.API.Debugger;

namespace Game.Debugger
{
    /// <summary>
    /// 日志调试服务
    /// </summary>
    public sealed class ProviderDebugger : ServiceProvider
    {
        /// <summary>
        /// 注册日志调试服务
        /// </summary>
        public override void Register()
        {
            App.Singleton<IDebugger, UnityDebugger>();
        }
    }
}
