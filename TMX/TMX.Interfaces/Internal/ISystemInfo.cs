﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 9/3/2014
 * Time: 4:48 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace TMX.Interfaces.Internal
{
    using System.Collections.Generic;
    
    /// <summary>
    /// Description of ISystemInfo.
    /// </summary>
    public interface ISystemInfo
    {
		string Hostname { get; set; } // Environment.MachineName
		string Fqdn { get; set; }
		List<string> IpAddresses { get; set; }
		List<string> MacAddresses { get; set; }
		string UserDomainName { get; set; } // Environment.UserDomainName
		string Username { get; set; } // Environment.UserName aka sAMAccountName
		bool IsInteractive { get; set; } // Environment.UserInteractive
		bool IsAdmin { get; set; }
		string OsVersion { get; set; } // Environment.OSVersion like Microsoft Windows NT 6.2.9200.0
		string Language { get; set; }
		string EnvironmentVersion { get; set; } // Environment.Version like 2.0.50727.8000
		int UptimeSeconds { get; set; } // Environment.TickCount / 1000
		string CustomString { get; set; }
    }
}