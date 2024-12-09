using UnityEditor;
using UnityEngine;

namespace Editor
{
    public static class Menu
    {
        [MenuItem("Custom/Print Assets Path")]
        public static void PrintPath()
        {
            var root = Application.dataPath;
            Debug.Log(root);
        }
    }
}