//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using MonoTouch;
using MonoTouch.CoreFoundation;
using MonoTouch.CoreMedia;
using MonoTouch.CoreMotion;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreLocation;
using MonoTouch.MapKit;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;
using MonoTouch.NewsstandKit;
using MonoTouch.GLKit;
using MonoTouch.CoreVideo;
using OpenTK;

namespace EstimoteXamarin {
	[Register("ESTBeaconManagerDelegate", true)]
	[Model]
	public unsafe partial class ESTBeaconManagerDelegate : NSObject {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ESTBeaconManagerDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.Init);
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public ESTBeaconManagerDelegate (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public ESTBeaconManagerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public ESTBeaconManagerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("beaconManager:didRangeBeacons:inRegion:")]
		[CompilerGenerated]
		public virtual void DidRangeBeacons (ESTBeaconManager manager, NSArray[] beacons, ESTBeaconRegion region)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("beaconManager:rangingBeaconsDidFailForRegion:withError:")]
		[CompilerGenerated]
		public virtual void RangingBeaconsDidFailForRegion (ESTBeaconManager manager, ESTBeaconRegion region, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("beaconManager:monitoringDidFailForRegion:withError:")]
		[CompilerGenerated]
		public virtual void MonitoringDidFailForRegion (ESTBeaconManager manager, ESTBeaconRegion region, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("beaconManager:didEnterRegion:")]
		[CompilerGenerated]
		public virtual void DidEnterRegion (ESTBeaconManager manager, ESTBeaconRegion region)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("beaconManager:didExitRegion:")]
		[CompilerGenerated]
		public virtual void DidExitRegion (ESTBeaconManager manager, ESTBeaconRegion region)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("beaconManager:didDetermineState:forRegion:")]
		[CompilerGenerated]
		public virtual void DidDetermineState (ESTBeaconManager manager, global::MonoTouch.CoreLocation.CLRegionState state, ESTBeaconRegion region)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("beaconManagerDidStartAdvertising:error:")]
		[CompilerGenerated]
		public virtual void Error (ESTBeaconManager manager, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("beaconManager:didDiscoverBeacons:inRegion:")]
		[CompilerGenerated]
		public virtual void DidDiscoverBeacons (ESTBeaconManager manager, NSArray[] beacons, ESTBeaconRegion region)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("beaconManager:didFailDiscoveryInRegion:")]
		[CompilerGenerated]
		public virtual void DidFailDiscoveryInRegion (ESTBeaconManager manager, ESTBeaconRegion region)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class ESTBeaconManagerDelegate */
}
