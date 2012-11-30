﻿using System;
using LibClassicBot;
namespace LibClassicBot.Plugins
{
	/// <summary>
	/// All custom built plugins must inherit from this class. 
	/// Note that you cannot target a more recent .NET version than the LibClassicSupports. 
	/// By default, LibClassicBot targets .NET Framework 2.0.<br/>
	/// If your plugin targets a later version of the .NET Framework,
	/// you either have to change LibClassicBot to target a later version, 
	/// or change the .NET version your plugin targets.
	/// </summary>
	public abstract class Plugin
	{
		/// <summary>
		/// The name of the plugin, which will be used for registering of 
		/// </summary>
		public abstract string PluginName {get; }
		
		/// <summary>
		/// The command to be executed upon the receiving of the chat line.
		/// </summary>
		public ClassicBot.CommandDelegate Command;
		
		/// <summary>
		/// This method initalizes the command of the plugin.
		/// </summary>
		/// <param name="main">The ClassicBot with which this plugin
		/// is attached to.</param>
		/// <example>This for example, creates a new plugin that sends a message saying test
		/// everytime it is called. <code>Command = delegate(string Line)<br/> 
		/// {<br/>
		/// 	main.SendMessagePacket("Test");<br/>
		/// };</code></example>
		public abstract void Initalize(ClassicBot main);
		
	}
	/*Below is an example of such a plugin.
 	public class TestPlugin : Plugin
	{	
		public override string PluginName { get { return "Test"; } } 

		public override void Initalize(ClassicBot main) 
		{
			Command = delegate(string Line) 
			{
				main.SendMessagePacket("Test");
			};
		}
	}*/
}