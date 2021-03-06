﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrainMVC.Utility.Extensions
{
    public static class ExtensionOfDictionary
    {
        /// <summary>
        /// 若找不到資料回傳預設(大部分是null)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="S"></typeparam>
        /// <param name="dic"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static T GetValue<T, S>(this Dictionary<S, T> dic, S key, T DefaultValue = default(T))
        {
            if (dic != null && key != null && dic.ContainsKey(key) && dic[key] != null)
            {
                return dic[key];
            }
            return DefaultValue;
        }
    }
}