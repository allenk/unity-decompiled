﻿// Decompiled with JetBrains decompiler
// Type: UnityEditor.LineRendererInspector
// Assembly: UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 01B28312-B6F5-4E06-90F6-BE297B711E41
// Assembly location: C:\Users\Blake\sandbox\unity\test-project\Library\UnityAssemblies\UnityEditor.dll

using UnityEngine;

namespace UnityEditor
{
  [CanEditMultipleObjects]
  [CustomEditor(typeof (LineRenderer))]
  internal class LineRendererInspector : RendererEditorBase
  {
    public override void OnEnable()
    {
      base.OnEnable();
    }

    public override void OnInspectorGUI()
    {
      this.serializedObject.Update();
      Editor.DrawPropertiesExcluding(this.m_SerializedObject);
      this.serializedObject.ApplyModifiedProperties();
    }
  }
}