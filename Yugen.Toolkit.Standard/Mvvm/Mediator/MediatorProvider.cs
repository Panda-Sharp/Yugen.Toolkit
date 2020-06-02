﻿using System;
using Yugen.Toolkit.Standard.Helpers;

namespace Yugen.Toolkit.Standard.Mvvm.Mediator
{
    /// <summary>
    /// MediatorProvider.UpdateContent(title, MediatorPropertiesEnum.AppShellTitle.ToString());
    /// </summary>
    public static class MediatorProvider
    {
        public static void UpdateContent<T>(T text, string properties)
        {
            try
            {
                MediatorService.Instance.NotifyColleagues(properties, text);
            }
            catch (Exception exception)
            {
                LoggerHelper.WriteLine(typeof(MediatorProvider), exception);
            }
        }
    }
}