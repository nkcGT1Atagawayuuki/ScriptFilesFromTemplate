using System.IO;
using UnityEditor;
using UnityEngine;

namespace Hamster.Editor
{
    static internal class MenuItemSettings
    {
        // テンプレートのファイルパス
        private const string templateFilePath = "Assets/ScriptFilesFromTemplate";

        // テンプレートが保存されている場所のファイルパス
        private const string templateDirectoryPath = "Templates";

        // インターフェースのテンプレートファイル名
        private const string interfaceTemplateFileName = "InterfaceTemplate.txt";

        // 作成するスクリプトの名前
        private const string interfaceScriptName = "NewInterfaceScript.cs";

        // エディタ上の表示させる項目の名前
        private const string menuRoot = "Assets/Create/Add New Script/";

        // エディタに表示される項目の場所と表示名を設定する
        [MenuItem(menuRoot + "Interface")]
        private static void CreateInterfaceScript() => CreateScriptFile(interfaceTemplateFileName, interfaceScriptName);

        /// <summary>
        /// テンプレートファイルを元に新しいスクリプトを作成する
        /// </summary>
        /// <param name="templateFileName">元にするファイル名</param>
        /// <param name="newScriptName">作成するスクリプト名</param>
        private static void CreateScriptFile(string templateFileName, string newScriptName)
        {
            // Path.Combineに関して、第一引き数と第二引き数を書くと結合される Combine("A","B") => "A/B" スラッシュは書いても書かなくてもいい
            // 第三引き数を書くと絶対パスになるらしく、第一、第二引き数が無視され、第三引き数の確定パスしか使われなくなる
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(Path.Combine(templateFilePath, $"{templateDirectoryPath}/{templateFileName}"), newScriptName);
        }
    }
}