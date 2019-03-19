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

using Demo.API.Debugger;

namespace Demo.Debugger
{
    /// <summary>
    /// Unity日志调试服务
    /// </summary>
    public sealed class UnityDebugger : IDebugger
    {
        /// <summary>
        /// 输出日志
        /// </summary>
        /// <param name="message">日志内容</param>
        public void Log(string message)
        {
            UnityEngine.Debug.Log(message);
        }
    }
}
