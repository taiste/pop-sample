// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Popper
{
	[Register ("OptionsViewController")]
	partial class OptionsViewController
	{
		[Outlet]
		UIKit.UISlider slider1 { get; set; }

		[Outlet]
		UIKit.UISlider slider2 { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (slider1 != null) {
				slider1.Dispose ();
				slider1 = null;
			}

			if (slider2 != null) {
				slider2.Dispose ();
				slider2 = null;
			}
		}
	}
}