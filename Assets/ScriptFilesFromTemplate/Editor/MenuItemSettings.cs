using System.IO;
using UnityEditor;
using UnityEngine;

namespace Hamster.Editor
{
    static internal class MenuItemSettings
    {
        // �e���v���[�g�̃t�@�C���p�X
        private const string templateFilePath = "Assets/ScriptFilesFromTemplate";

        // �e���v���[�g���ۑ�����Ă���ꏊ�̃t�@�C���p�X
        private const string templateDirectoryPath = "Templates";

        // �C���^�[�t�F�[�X�̃e���v���[�g�t�@�C����
        private const string interfaceTemplateFileName = "InterfaceTemplate.txt";

        // �쐬����X�N���v�g�̖��O
        private const string interfaceScriptName = "NewInterfaceScript.cs";

        // �G�f�B�^��̕\�������鍀�ڂ̖��O
        private const string menuRoot = "Assets/Create/Add New Script/";

        // �G�f�B�^�ɕ\������鍀�ڂ̏ꏊ�ƕ\������ݒ肷��
        [MenuItem(menuRoot + "Interface")]
        private static void CreateInterfaceScript() => CreateScriptFile(interfaceTemplateFileName, interfaceScriptName);

        /// <summary>
        /// �e���v���[�g�t�@�C�������ɐV�����X�N���v�g���쐬����
        /// </summary>
        /// <param name="templateFileName">���ɂ���t�@�C����</param>
        /// <param name="newScriptName">�쐬����X�N���v�g��</param>
        private static void CreateScriptFile(string templateFileName, string newScriptName)
        {
            // Path.Combine�Ɋւ��āA���������Ƒ��������������ƌ�������� Combine("A","B") => "A/B" �X���b�V���͏����Ă������Ȃ��Ă�����
            // ��O�������������Ɛ�΃p�X�ɂȂ�炵���A���A������������������A��O�������̊m��p�X�����g���Ȃ��Ȃ�
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(Path.Combine(templateFilePath, $"{templateDirectoryPath}/{templateFileName}"), newScriptName);
        }
    }
}