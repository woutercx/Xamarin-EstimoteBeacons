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
	[Register("ESTBeacon", true)]
	public unsafe partial class ESTBeacon : NSObject {
		[CompilerGenerated]
		const string selFirmwareState = "firmwareState";
		static readonly IntPtr selFirmwareStateHandle = Selector.GetHandle ("firmwareState");
		[CompilerGenerated]
		const string selSetFirmwareState_ = "setFirmwareState:";
		static readonly IntPtr selSetFirmwareState_Handle = Selector.GetHandle ("setFirmwareState:");
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selPeripheral = "peripheral";
		static readonly IntPtr selPeripheralHandle = Selector.GetHandle ("peripheral");
		[CompilerGenerated]
		const string selSetPeripheral_ = "setPeripheral:";
		static readonly IntPtr selSetPeripheral_Handle = Selector.GetHandle ("setPeripheral:");
		[CompilerGenerated]
		const string selMacAddress = "macAddress";
		static readonly IntPtr selMacAddressHandle = Selector.GetHandle ("macAddress");
		[CompilerGenerated]
		const string selSetMacAddress_ = "setMacAddress:";
		static readonly IntPtr selSetMacAddress_Handle = Selector.GetHandle ("setMacAddress:");
		[CompilerGenerated]
		const string selMeasuredPower = "measuredPower";
		static readonly IntPtr selMeasuredPowerHandle = Selector.GetHandle ("measuredPower");
		[CompilerGenerated]
		const string selSetMeasuredPower_ = "setMeasuredPower:";
		static readonly IntPtr selSetMeasuredPower_Handle = Selector.GetHandle ("setMeasuredPower:");
		[CompilerGenerated]
		const string selMajor = "major";
		static readonly IntPtr selMajorHandle = Selector.GetHandle ("major");
		[CompilerGenerated]
		const string selSetMajor_ = "setMajor:";
		static readonly IntPtr selSetMajor_Handle = Selector.GetHandle ("setMajor:");
		[CompilerGenerated]
		const string selMinor = "minor";
		static readonly IntPtr selMinorHandle = Selector.GetHandle ("minor");
		[CompilerGenerated]
		const string selSetMinor_ = "setMinor:";
		static readonly IntPtr selSetMinor_Handle = Selector.GetHandle ("setMinor:");
		[CompilerGenerated]
		const string selRssi = "rssi";
		static readonly IntPtr selRssiHandle = Selector.GetHandle ("rssi");
		[CompilerGenerated]
		const string selSetRssi_ = "setRssi:";
		static readonly IntPtr selSetRssi_Handle = Selector.GetHandle ("setRssi:");
		[CompilerGenerated]
		const string selPower = "power";
		static readonly IntPtr selPowerHandle = Selector.GetHandle ("power");
		[CompilerGenerated]
		const string selSetPower_ = "setPower:";
		static readonly IntPtr selSetPower_Handle = Selector.GetHandle ("setPower:");
		[CompilerGenerated]
		const string selFrequency = "frequency";
		static readonly IntPtr selFrequencyHandle = Selector.GetHandle ("frequency");
		[CompilerGenerated]
		const string selSetFrequency_ = "setFrequency:";
		static readonly IntPtr selSetFrequency_Handle = Selector.GetHandle ("setFrequency:");
		[CompilerGenerated]
		const string selBatteryLevel = "batteryLevel";
		static readonly IntPtr selBatteryLevelHandle = Selector.GetHandle ("batteryLevel");
		[CompilerGenerated]
		const string selSetBatteryLevel_ = "setBatteryLevel:";
		static readonly IntPtr selSetBatteryLevel_Handle = Selector.GetHandle ("setBatteryLevel:");
		[CompilerGenerated]
		const string selHardwareVersion = "hardwareVersion";
		static readonly IntPtr selHardwareVersionHandle = Selector.GetHandle ("hardwareVersion");
		[CompilerGenerated]
		const string selSetHardwareVersion_ = "setHardwareVersion:";
		static readonly IntPtr selSetHardwareVersion_Handle = Selector.GetHandle ("setHardwareVersion:");
		[CompilerGenerated]
		const string selFirmwareVersion = "firmwareVersion";
		static readonly IntPtr selFirmwareVersionHandle = Selector.GetHandle ("firmwareVersion");
		[CompilerGenerated]
		const string selSetFirmwareVersion_ = "setFirmwareVersion:";
		static readonly IntPtr selSetFirmwareVersion_Handle = Selector.GetHandle ("setFirmwareVersion:");
		[CompilerGenerated]
		const string selIbeacon = "ibeacon";
		static readonly IntPtr selIbeaconHandle = Selector.GetHandle ("ibeacon");
		[CompilerGenerated]
		const string selSetIbeacon_ = "setIbeacon:";
		static readonly IntPtr selSetIbeacon_Handle = Selector.GetHandle ("setIbeacon:");
		[CompilerGenerated]
		const string selIsConnected = "isConnected";
		static readonly IntPtr selIsConnectedHandle = Selector.GetHandle ("isConnected");
		[CompilerGenerated]
		const string selConnectToBeacon = "connectToBeacon";
		static readonly IntPtr selConnectToBeaconHandle = Selector.GetHandle ("connectToBeacon");
		[CompilerGenerated]
		const string selDisconnectBeacon = "disconnectBeacon";
		static readonly IntPtr selDisconnectBeaconHandle = Selector.GetHandle ("disconnectBeacon");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("ESTBeacon");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ESTBeacon () : base (NSObjectFlag.Empty)
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
		public ESTBeacon (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public ESTBeacon (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public ESTBeacon (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("connectToBeacon")]
		[CompilerGenerated]
		public virtual void ConnectToBeacon ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selConnectToBeaconHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selConnectToBeaconHandle);
			}
		}
		
		[Export ("disconnectBeacon")]
		[CompilerGenerated]
		public virtual void DisconnectBeacon ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDisconnectBeaconHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selDisconnectBeaconHandle);
			}
		}
		
		[CompilerGenerated]
		public virtual ESTBeaconFirmwareState FirmwareState {
			[Export ("firmwareState")]
			get {
				if (IsDirectBinding) {
					return (ESTBeaconFirmwareState) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selFirmwareStateHandle);
				} else {
					return (ESTBeaconFirmwareState) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selFirmwareStateHandle);
				}
			}
			
			[Export ("setFirmwareState:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetFirmwareState_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetFirmwareState_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual ESTBeaconDelegate Delegate {
			[Export ("delegate")]
			get {
				ESTBeaconDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<ESTBeaconDelegate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegateHandle));
				} else {
					ret =  Runtime.GetNSObject<ESTBeaconDelegate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegateHandle));
				}
				MarkDirty ();
				__mt_Delegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:")]
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
		object __mt_Peripheral_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.CoreBluetooth.CBPeripheral Peripheral {
			[Export ("peripheral", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.CoreBluetooth.CBPeripheral ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.CoreBluetooth.CBPeripheral> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPeripheralHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.CoreBluetooth.CBPeripheral> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPeripheralHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Peripheral_var = ret;
				return ret;
			}
			
			[Export ("setPeripheral:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPeripheral_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPeripheral_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Peripheral_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string MacAddress {
			[Export ("macAddress", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMacAddressHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selMacAddressHandle));
				}
			}
			
			[Export ("setMacAddress:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetMacAddress_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetMacAddress_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_MeasuredPower_var;
		[CompilerGenerated]
		public virtual NSNumber MeasuredPower {
			[Export ("measuredPower", ArgumentSemantic.Retain)]
			get {
				NSNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMeasuredPowerHandle));
				} else {
					ret =  Runtime.GetNSObject<NSNumber> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selMeasuredPowerHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_MeasuredPower_var = ret;
				return ret;
			}
			
			[Export ("setMeasuredPower:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetMeasuredPower_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetMeasuredPower_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_MeasuredPower_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Major_var;
		[CompilerGenerated]
		public virtual NSNumber Major {
			[Export ("major", ArgumentSemantic.Retain)]
			get {
				NSNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMajorHandle));
				} else {
					ret =  Runtime.GetNSObject<NSNumber> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selMajorHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Major_var = ret;
				return ret;
			}
			
			[Export ("setMajor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetMajor_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetMajor_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Major_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Minor_var;
		[CompilerGenerated]
		public virtual NSNumber Minor {
			[Export ("minor", ArgumentSemantic.Retain)]
			get {
				NSNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMinorHandle));
				} else {
					ret =  Runtime.GetNSObject<NSNumber> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selMinorHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Minor_var = ret;
				return ret;
			}
			
			[Export ("setMinor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetMinor_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetMinor_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Minor_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Rssi_var;
		[CompilerGenerated]
		public virtual NSNumber Rssi {
			[Export ("rssi", ArgumentSemantic.Retain)]
			get {
				NSNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRssiHandle));
				} else {
					ret =  Runtime.GetNSObject<NSNumber> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRssiHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Rssi_var = ret;
				return ret;
			}
			
			[Export ("setRssi:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetRssi_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetRssi_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Rssi_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Power_var;
		[CompilerGenerated]
		public virtual NSNumber Power {
			[Export ("power", ArgumentSemantic.Retain)]
			get {
				NSNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPowerHandle));
				} else {
					ret =  Runtime.GetNSObject<NSNumber> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPowerHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Power_var = ret;
				return ret;
			}
			
			[Export ("setPower:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPower_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPower_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Power_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Frequency_var;
		[CompilerGenerated]
		public virtual NSNumber Frequency {
			[Export ("frequency", ArgumentSemantic.Retain)]
			get {
				NSNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFrequencyHandle));
				} else {
					ret =  Runtime.GetNSObject<NSNumber> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selFrequencyHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Frequency_var = ret;
				return ret;
			}
			
			[Export ("setFrequency:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetFrequency_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetFrequency_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Frequency_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_BatteryLevel_var;
		[CompilerGenerated]
		public virtual NSNumber BatteryLevel {
			[Export ("batteryLevel", ArgumentSemantic.Retain)]
			get {
				NSNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBatteryLevelHandle));
				} else {
					ret =  Runtime.GetNSObject<NSNumber> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selBatteryLevelHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_BatteryLevel_var = ret;
				return ret;
			}
			
			[Export ("setBatteryLevel:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBatteryLevel_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetBatteryLevel_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_BatteryLevel_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string HardwareVersion {
			[Export ("hardwareVersion", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selHardwareVersionHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selHardwareVersionHandle));
				}
			}
			
			[Export ("setHardwareVersion:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetHardwareVersion_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetHardwareVersion_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string FirmwareVersion {
			[Export ("firmwareVersion", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFirmwareVersionHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selFirmwareVersionHandle));
				}
			}
			
			[Export ("setFirmwareVersion:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetFirmwareVersion_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetFirmwareVersion_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_Ibeacon_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.CoreLocation.CLBeacon Ibeacon {
			[Export ("ibeacon", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.CoreLocation.CLBeacon ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.CoreLocation.CLBeacon> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selIbeaconHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.CoreLocation.CLBeacon> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selIbeaconHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Ibeacon_var = ret;
				return ret;
			}
			
			[Export ("setIbeacon:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetIbeacon_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetIbeacon_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Ibeacon_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsConnected {
			[Export ("isConnected")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsConnectedHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsConnectedHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Delegate_var = null;
				__mt_Peripheral_var = null;
				__mt_MeasuredPower_var = null;
				__mt_Major_var = null;
				__mt_Minor_var = null;
				__mt_Rssi_var = null;
				__mt_Power_var = null;
				__mt_Frequency_var = null;
				__mt_BatteryLevel_var = null;
				__mt_Ibeacon_var = null;
			}
		}
	} /* class ESTBeacon */
}
