﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.﻿

using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace XRTK.Examples.Demos.StandardShader
{
    /// <summary>
    /// Editor to build a matrix of spheres demonstrating a spectrum of material properties.
    /// </summary>
    [CustomEditor(typeof(MaterialMatrix))]
    public class MaterialMatrixInspector : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            if (GUILayout.Button("Build"))
            {
                var materialMatrix = target as MaterialMatrix;
                Debug.Assert(materialMatrix != null);
                materialMatrix.BuildMatrix();

                EditorSceneManager.MarkSceneDirty(SceneManager.GetActiveScene());
            }
        }
    }
}