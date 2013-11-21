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
	[Register("ESTBeaconManager", true)]
	public unsafe partial class ESTBeaconManager : NSObject {
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selAvoidUnknownStateBeacons = "avoidUnknownStateBeacons";
		static readonly IntPtr selAvoidUnknownStateBeaconsHandle = Selector.GetHandle ("avoidUnknownStateBeacons");
		[CompilerGenerated]
		const string selSetAvoidUnknownStateBeacons_ = "setAvoidUnknownStateBeacons:";
		static readonly IntPtr selSetAvoidUnknownStateBeacons_Handle = Selector.GetHandle ("setAvoidUnknownStateBeacons:");
		[CompilerGenerated]
		const string selVirtualBeaconRegion = "virtualBeaconRegion";
		static readonly IntPtr selVirtualBeaconRegionHandle = Selector.GetHandle ("virtualBeaconRegion");
		[CompilerGenerated]
		const string selSetVirtualBeaconRegion_ = "setVirtualBeaconRegion:";
		static readonly IntPtr selSetVirtualBeaconRegion_Handle = Selector.GetHandle ("setVirtualBeaconRegion:");
		[CompilerGenerated]
		const string selStartRangingBeaconsInRegion_ = "startRangingBeaconsInRegion:";
		static readonly IntPtr selStartRangingBeaconsInRegion_Handle = Selector.GetHandle ("startRangingBeaconsInRegion:");
		[CompilerGenerated]
		const string selStartMonitoringForRegion_ = "startMonitoringForRegion:";
		static readonly IntPtr selStartMonitoringForRegion_Handle = Selector.GetHandle ("startMonitoringForRegion:");
		[CompilerGenerated]
		const string selStopRangingBeaconsInRegion_ = "stopRangingBeaconsInRegion:";
		static readonly IntPtr selStopRangingBeaconsInRegion_Handle = Selector.GetHandle ("stopRangingBeaconsInRegion:");
		[CompilerGenerated]
		const string selStopMonitoringForRegion_ = "stopMonitoringForRegion:";
		static readonly IntPtr selStopMonitoringForRegion_Handle = Selector.GetHandle ("stopMonitoringForRegion:");
		[CompilerGenerated]
		const string selRequestStateForRegion_ = "requestStateForRegion:";
		static readonly IntPtr selRequestStateForRegion_Handle = Selector.GetHandle ("requestStateForRegion:");
		[CompilerGenerated]
		const string selStopAdvertising = "stopAdvertising";
		static readonly IntPtr selStopAdvertisingHandle = Selector.GetHandle ("stopAdvertising");
		[CompilerGenerated]
		const string selStartEstimoteBeaconsDiscoveryForRegion_ = "startEstimoteBeaconsDiscoveryForRegion:";
		static readonly IntPtr selStartEstimoteBeaconsDiscoveryForRegion_Handle = Selector.GetHandle ("startEstimoteBeaconsDiscoveryForRegion:");
		[CompilerGenerated]
		const string selStopEstimoteBeaconDiscovery = "stopEstimoteBeaconDiscovery";
		static readonly IntPtr selStopEstimoteBeaconDiscoveryHandle = Selector.GetHandle ("stopEstimoteBeaconDiscovery");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("ESTBeaconManager");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ESTBeaconManager () : base (NSObjectFlag.Empty)
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
		public ESTBeaconManager (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public ESTBeaconManager (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public ESTBeaconManager (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("startRangingBeaconsInRegion:")]
		[CompilerGenerated]
		public virtual void StartRangingBeaconsInRegion (ESTBeaconRegion region)
		{
			if (region == null)
				throw new ArgumentNullException ("region");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selStartRangingBeaconsInRegion_Handle, region.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selStartRangingBeaconsInRegion_Handle, region.Handle);
			}
		}
		
		[Export ("startMonitoringForRegion:")]
		[CompilerGenerated]
		public virtual void StartMonitoringForRegion (ESTBeaconRegion region)
		{
			if (region == null)
				throw new ArgumentNullException ("region");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selStartMonitoringForRegion_Handle, region.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selStartMonitoringForRegion_Handle, region.Handle);
			}
		}
		
		[Export ("stopRangingBeaconsInRegion:")]
		[CompilerGenerated]
		public virtual void StopRangingBeaconsInRegion (ESTBeaconRegion region)
		{
			if (region == null)
				throw new ArgumentNullException ("region");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selStopRangingBeaconsInRegion_Handle, region.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selStopRangingBeaconsInRegion_Handle, region.Handle);
			}
		}
		
		[Export ("stopMonitoringForRegion:")]
		[CompilerGenerated]
		public virtual void StopMonitoringForRegion (ESTBeaconRegion region)
		{
			if (region == null)
				throw new ArgumentNullException ("region");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selStopMonitoringForRegion_Handle, region.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selStopMonitoringForRegion_Handle, region.Handle);
			}
		}
		
		[Export ("requestStateForRegion:")]
		[CompilerGenerated]
		public virtual void RequestStateForRegion (ESTBeaconRegion region)
		{
			if (region == null)
				throw new ArgumentNullException ("region");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selRequestStateForRegion_Handle, region.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selRequestStateForRegion_Handle, region.Handle);
			}
		}
		
		[Export ("stopAdvertising")]
		[CompilerGenerated]
		public virtual void StopAdvertising ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStopAdvertisingHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selStopAdvertisingHandle);
			}
		}
		
		[Export ("startEstimoteBeaconsDiscoveryForRegion:")]
		[CompilerGenerated]
		public virtual void StartEstimoteBeaconsDiscoveryForRegion (ESTBeaconRegion region)
		{
			if (region == null)
				throw new ArgumentNullException ("region");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selStartEstimoteBeaconsDiscoveryForRegion_Handle, region.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selStartEstimoteBeaconsDiscoveryForRegion_Handle, region.Handle);
			}
		}
		
		[Export ("stopEstimoteBeaconDiscovery")]
		[CompilerGenerated]
		public virtual void StopEstimoteBeaconDiscovery ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStopEstimoteBeaconDiscoveryHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selStopEstimoteBeaconDiscoveryHandle);
			}
		}
		
		[CompilerGenerated]
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual ESTBeaconManagerDelegate Delegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				ESTBeaconManagerDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<ESTBeaconManagerDelegate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegateHandle));
				} else {
					ret =  Runtime.GetNSObject<ESTBeaconManagerDelegate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegateHandle));
				}
				MarkDirty ();
				__mt_Delegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDelegate_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDelegate_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_Delegate_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool AvoidUnknownStateBeacons {
			[Export ("avoidUnknownStateBeacons")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAvoidUnknownStateBeaconsHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selAvoidUnknownStateBeaconsHandle);
				}
			}
			
			[Export ("setAvoidUnknownStateBeacons:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAvoidUnknownStateBeacons_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetAvoidUnknownStateBeacons_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_VirtualBeaconRegion_var;
		[CompilerGenerated]
		public virtual ESTBeaconRegion VirtualBeaconRegion {
			[Export ("virtualBeaconRegion", ArgumentSemantic.Retain)]
			get {
				ESTBeaconRegion ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<ESTBeaconRegion> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selVirtualBeaconRegionHandle));
				} else {
					ret =  Runtime.GetNSObject<ESTBeaconRegion> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selVirtualBeaconRegionHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_VirtualBeaconRegion_var = ret;
				return ret;
			}
			
			[Export ("setVirtualBeaconRegion:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetVirtualBeaconRegion_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetVirtualBeaconRegion_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_VirtualBeaconRegion_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Delegate_var = null;
				__mt_VirtualBeaconRegion_var = null;
			}
		}
	} /* class ESTBeaconManager */
}
