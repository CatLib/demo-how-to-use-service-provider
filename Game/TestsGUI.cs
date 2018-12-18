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
using Game.API.Resources;
using UnityEngine;

namespace Game
{
    /// <summary>
    /// 测试用的UI界面
    /// </summary>
    public sealed class TestsGUI : MonoBehaviour
    {
        /// <summary>
        /// GUI绘制
        /// </summary>
        public void OnGUI()
        {
            if (!GUI.Button(new Rect(0, 0, 100, 30), "Load Resource"))
            {
                return;
            }

            Facades.Resources.LoadSync("hello world - Facade");
            Facade<IResources>.Instance.LoadSync("hello world - Facade<>");
            App.Make<IResources>().LoadSync("hello world - App.Make");
        }
    }
}
