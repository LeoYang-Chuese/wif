﻿/**************************************************************************
*      File Name：ScreenExtensions.cs
*    Description：ScreenExtensions.cs class description...
*      Copyright：Copyright © 2020 LeoYang-Chuese. All rights reserved.
*        Creator：Leo Yang
*    Create Time：2020/12/15
*Project Address：https://github.com/LeoYang-Chuese/wif
**************************************************************************/


using System.Linq;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Interop;

namespace Frontier.Wif.Utilities.Extensions
{
    /// <summary>
    /// Defines the <see cref="ScreenExtensions" />
    /// </summary>
    public static class ScreenExtensions
    {
        #region Methods

        /// <summary>
        /// 获取窗口所属屏幕。
        /// </summary>
        /// <param name="window">指定的窗口</param>
        /// <returns></returns>
        public static Screen GetWindowOfScreen(this Window window)
        {
            var handle = new WindowInteropHelper(window).Handle;
            var currentScreen = Screen.FromHandle(handle);
            return currentScreen;
        }

        /// <summary>
        /// 获取窗口所属屏幕的索引。
        /// </summary>
        /// <param name="window">指定的窗口</param>
        /// <returns></returns>
        public static int GetWindowOfScreenIndex(this Window window)
        {
            var handle = new WindowInteropHelper(window).Handle;
            var currentScreen = Screen.FromHandle(handle);
            var currentIndex = Screen.AllScreens.ToList().FindIndex(x => x.DeviceName == currentScreen.DeviceName);
            return currentIndex;
        }

        #endregion
    }
}