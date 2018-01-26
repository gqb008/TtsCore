﻿using System.ComponentModel;

namespace TTS.Common.Enum
{
    /// <summary>
    /// 服务请求状态枚举
    /// </summary>
    public enum ServiceStateEnum
    {
        /// <summary>
        /// 请求成功
        /// </summary>
        [Description("成功")]
        Success = 0,

        /// <summary>
        /// 请求失败
        /// </summary>
        [Description("失败")]
        Failed = 1
    }
}