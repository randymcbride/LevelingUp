using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace CSharpTipsAndTraps.Tips
{
	[TestClass]
	public class CallerInformationAttribute
	{
		private static HashSet<string> dirtyProperties = new HashSet<string>();

		[TestMethod]
		public void CaptureCallerInformation()
		{
			//We are going to use this custom logger. Notice we only send a message but it logs a lot more than that
			Logger.Log("Test");
			//Check the debug output
			// You will see something like this: CaptureCallerInformation C:\dev\sandbox\SoftwareDesignPrinciples\CSharpTipsAndTraps\Tips\CallerInformationAttribute.cs 16: Test
		}

		[TestMethod]
		public void AMorePracticalApplication()
		{
			var thing = new ObservableThing();
			thing.PropertyChanged += LogDirtyProperty;
			thing.ObservableProperty = "updated value";
			Assert.IsTrue(dirtyProperties.Count == 1);
			//There is not much to see here in this Unit Test, 
			//but pry open ObservableThing and see the [CallerMemberName] attriubute
			//makes the ObservalbeThing class more maintainable.
		}

		private static void LogDirtyProperty(object sender, PropertyChangedEventArgs e)
		{
			dirtyProperties.Add(e.PropertyName);
		}
	}

	static class Logger
	{
		public static void Log(string message, 
			[CallerMemberName] string callerMember = null, 
			[CallerFilePath] string callerFile = null,
			[CallerLineNumber] int callerLine = 0)
		{
			Debug.WriteLine($"{callerMember} {callerFile} {callerLine}: {message}");
		}
	}

	class ObservableThing : INotifyPropertyChanged
	{
		private string observalbeProperty;

		public string ObservableProperty
		{
			get
			{
				return observalbeProperty;
			}
			set
			{
				observalbeProperty = value;
				//Instead of doing this (which leads to some maintenance overhead if we want to add properties or rename them)
				//PropertyChanged(this, new PropertyChangedEventArgs("ObservableProperty"));

				//We could do somehting like this
				HandlePropertyChange();
			}
		}


		public event PropertyChangedEventHandler PropertyChanged;
		private void HandlePropertyChange([CallerMemberName] string propertyName = null)
		{
			if (propertyName != null)
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
