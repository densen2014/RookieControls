using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Runtime.InteropServices;
public class NativeMethods
{
	[DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
	private static extern int GetDpiForWindow(IntPtr hWnd);
	public static float GetDisplayScaleFactor(IntPtr windowHandle)
	{
		try
		{
 			return (GetDpiForWindow(windowHandle) / 96f);
		}
		catch (System.Exception ex)
		{
			// Or fallback to GDI solutions above
			return 1;
		}

	}

}
