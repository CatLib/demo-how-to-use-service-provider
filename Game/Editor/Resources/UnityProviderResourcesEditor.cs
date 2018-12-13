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

using Game.Resources;
using UnityEditor;
using UnityEngine;

namespace CatLib.Editor.Resources
{
    /// <summary>
    /// 资源服务可视化图形界面
    /// </summary>
    [CustomEditor(typeof(UnityProviderResources), true)]
    public class UnityProviderResourcesEditor : UnityEditor.Editor
    {
        /// <summary>
        /// 是否允许同步加载
        /// </summary>
        private SerializedProperty enableSyncLoad;

        /// <summary>
        /// 绘图界面时
        /// </summary>
        public override void OnInspectorGUI()
        {
            DrawLogo();

            if (UnityEngine.Application.isPlaying)
            {
                DrawCannotChange();
            }
            else
            {
                serializedObject.Update();
                DrawEnableSyncLoad();
                serializedObject.ApplyModifiedProperties();
            }
        }

        /// <summary>
        /// 显示时
        /// </summary>
        public void OnEnable()
        {
            enableSyncLoad = serializedObject.FindProperty("EnableSyncLoad");
        }

        /// <summary>
        /// 绘制标题
        /// </summary>
        private static void DrawLogo()
        {
            EditorGUILayout.Separator();
            GUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Game Resources Manager", EditorStyles.largeLabel,
                GUILayout.Height(20));
            GUILayout.EndHorizontal();
        }

        /// <summary>
        /// 绘制允许同步
        /// </summary>
        private void DrawEnableSyncLoad()
        {
            enableSyncLoad.boolValue = EditorGUILayout.Toggle("Enable Sync Load", enableSyncLoad.boolValue);
        }

        /// <summary>
        /// 绘制不能修改提示
        /// </summary>
        private void DrawCannotChange()
        {
            EditorGUILayout.HelpBox("Must stop running to modify.", MessageType.Info);
        }
    }
}