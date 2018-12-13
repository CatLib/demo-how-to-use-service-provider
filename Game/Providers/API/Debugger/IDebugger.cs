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

namespace Game.API.Debugger
{
    /// <summary>
    /// 日志调试服务
    /// </summary>
    public interface IDebugger
    {
        /// <summary>
        /// 输出日志
        /// </summary>
        /// <param name="message">日志内容</param>
        void Log(string message);
    }
}
