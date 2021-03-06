/***************************************************************
* Copyright (C) 2011 Jeremy Reagan, All Rights Reserved.
* I may be reached via email at: jeremy.reagan@live.com
* 
* This program is free software; you can redistribute it and/or
* modify it under the terms of the GNU General Public License
* as published by the Free Software Foundation; under version 2
* of the License.
* 
* This program is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
* GNU General Public License for more details.
****************************************************************/

using NLog;
using System;
using System.IO;
using System.Windows.Forms;

namespace HL7Analyst
{
    /// <summary>
    /// Log Class: Used to log exceptions to disk
    /// </summary>
    class Log
    {
        static ILogger Logger = LogManager.GetCurrentClassLogger();
        /// <summary>
        /// The exception that is being logged
        /// </summary>
        public Exception Error { get; set; }
        /// <summary>
        /// Logs the specified exception to a log file on disk and returns an Error Report Form containing the error message
        /// </summary>
        /// <param name="err">Exception being logged</param>
        /// <returns>Returns an Error Report Form</returns>
        public static frmErrorReport LogException(Exception err)
        {
            frmErrorReport fer = new frmErrorReport(err);
            Logger.Error(err);
            return fer;
        }
    }
}
