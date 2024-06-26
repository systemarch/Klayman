﻿using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Text;

namespace Klayman.Infrastructure.Windows.WinApi;

[ExcludeFromCodeCoverage]
[SupportedOSPlatform("windows")]
public class WinApiFunctions : IWinApiFunctions
{
    public int GetLastWin32Error()
    {
        return Marshal.GetLastWin32Error();
    }

    public int RegLoadMUIStringW(IntPtr hKey, string pszValue, StringBuilder pszOutBuf, int cbOutBuf, out int pcbData, uint flags,
        string? pszDirectory)
    {
        return WinApiFunctionImports
            .RegLoadMUIStringW(hKey, pszValue, pszOutBuf, cbOutBuf,
                out pcbData, flags, pszDirectory);
    }

    public bool GetKeyboardLayoutNameW(StringBuilder pwszKLID)
    {
        return WinApiFunctionImports
            .GetKeyboardLayoutNameW(pwszKLID);
    }

    public int GetKeyboardLayoutList(int nBuff, IntPtr[]? lpList)
    {
        return WinApiFunctionImports
            .GetKeyboardLayoutList(nBuff, lpList);
    }

    public IntPtr LoadKeyboardLayoutW(string pwszKLID, uint flags)
    {
        return WinApiFunctionImports
            .LoadKeyboardLayoutW(pwszKLID, flags);
    }

    public bool UnloadKeyboardLayout(IntPtr hkl)
    {
        return WinApiFunctionImports
            .UnloadKeyboardLayout(hkl);
    }
}