﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.Keyframe
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A8FF7A2C-E4EE-4232-AB17-3FCABEC16496
// Assembly location: C:\Users\Blake\sandbox\unity\test-project\Library\UnityAssemblies\UnityEngine.dll

using UnityEngine.Scripting;

namespace UnityEngine
{
  /// <summary>
  ///   <para>A single keyframe that can be injected into an animation curve.</para>
  /// </summary>
  [RequiredByNativeCode]
  public struct Keyframe
  {
    private float m_Time;
    private float m_Value;
    private float m_InTangent;
    private float m_OutTangent;
    private int m_TangentMode;

    /// <summary>
    ///   <para>The time of the keyframe.</para>
    /// </summary>
    public float time
    {
      get
      {
        return this.m_Time;
      }
      set
      {
        this.m_Time = value;
      }
    }

    /// <summary>
    ///   <para>The value of the curve at keyframe.</para>
    /// </summary>
    public float value
    {
      get
      {
        return this.m_Value;
      }
      set
      {
        this.m_Value = value;
      }
    }

    /// <summary>
    ///   <para>Describes the tangent when approaching this point from the previous point in the curve.</para>
    /// </summary>
    public float inTangent
    {
      get
      {
        return this.m_InTangent;
      }
      set
      {
        this.m_InTangent = value;
      }
    }

    /// <summary>
    ///   <para>Describes the tangent when leaving this point towards the next point in the curve.</para>
    /// </summary>
    public float outTangent
    {
      get
      {
        return this.m_OutTangent;
      }
      set
      {
        this.m_OutTangent = value;
      }
    }

    public int tangentMode
    {
      get
      {
        return this.m_TangentMode;
      }
      set
      {
        this.m_TangentMode = value;
      }
    }

    /// <summary>
    ///   <para>Create a keyframe.</para>
    /// </summary>
    /// <param name="time"></param>
    /// <param name="value"></param>
    public Keyframe(float time, float value)
    {
      this.m_Time = time;
      this.m_Value = value;
      this.m_InTangent = 0.0f;
      this.m_OutTangent = 0.0f;
      this.m_TangentMode = 0;
    }

    /// <summary>
    ///   <para>Create a keyframe.</para>
    /// </summary>
    /// <param name="time"></param>
    /// <param name="value"></param>
    /// <param name="inTangent"></param>
    /// <param name="outTangent"></param>
    public Keyframe(float time, float value, float inTangent, float outTangent)
    {
      this.m_Time = time;
      this.m_Value = value;
      this.m_InTangent = inTangent;
      this.m_OutTangent = outTangent;
      this.m_TangentMode = 0;
    }
  }
}
