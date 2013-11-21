using System;
using System.Drawing;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreBluetooth;
using MonoTouch.CoreLocation;

namespace EstimoteXamarin
{
	
	[Model, BaseType (typeof (NSObject))]
	public partial interface ESTBeaconDelegate {

		[Export ("beaconConnectionDidFail:withError:")]
		void BeaconConnectionDidFail (ESTBeacon beacon, NSError error);

		[Export ("beaconConnectionDidSucceeded:")]
		void BeaconConnectionDidSucceeded(ESTBeacon beacon);

		[Export ("beaconDidDisconnect:withError:")]
		void BeaconDidDisconnect (ESTBeacon beacon, NSError error);
	}

	[BaseType (typeof (NSObject))]
	public partial interface ESTBeacon {

		[Export ("firmwareState")]
		ESTBeaconFirmwareState FirmwareState { get; set; }

		[Export ("delegate")]
		ESTBeaconDelegate Delegate { get; set; }

		[Export ("peripheral", ArgumentSemantic.Retain)]
		CBPeripheral Peripheral { get; set; }

		[Export ("macAddress", ArgumentSemantic.Retain)]
		string MacAddress { get; set; }

		[Export ("measuredPower", ArgumentSemantic.Retain)]
		NSNumber MeasuredPower { get; set; }

		[Export ("major", ArgumentSemantic.Retain)]
		NSNumber Major { get; set; }

		[Export ("minor", ArgumentSemantic.Retain)]
		NSNumber Minor { get; set; }

		[Export ("rssi", ArgumentSemantic.Retain)]
		NSNumber Rssi { get; set; }

		[Export ("power", ArgumentSemantic.Retain)]
		NSNumber Power { get; set; }

		[Export ("frequency", ArgumentSemantic.Retain)]
		NSNumber Frequency { get; set; }

		[Export ("batteryLevel", ArgumentSemantic.Retain)]
		NSNumber BatteryLevel { get; set; }

		[Export ("hardwareVersion", ArgumentSemantic.Retain)]
		string HardwareVersion { get; set; }

		[Export ("firmwareVersion", ArgumentSemantic.Retain)]
		string FirmwareVersion { get; set; }

		[Export ("ibeacon", ArgumentSemantic.Retain)]
		CLBeacon Ibeacon { get; set; }

		[Export ("isConnected")]
		bool IsConnected { get; }

		[Export ("connectToBeacon")]
		void ConnectToBeacon ();

		[Export ("disconnectBeacon")]
		void DisconnectBeacon ();

//		[Export ("readBeaconMajorWithCompletion:")]
//		void ReadBeaconMajorWithCompletion (ESTUnsignedCompletionBlock completion);
//
//		[Export ("readBeaconMinorWithCompletion:")]
//		void ReadBeaconMinorWithCompletion (ESTUnsignedCompletionBlock completion);
//
//		[Export ("readBeaconFrequencyWithCompletion:")]
//		void ReadBeaconFrequencyWithCompletion (ESTUnsignedCompletionBlock completion);
//
//		[Export ("readBeaconPowerWithCompletion:")]
//		void ReadBeaconPowerWithCompletion (ESTUnsignedCompletionBlock completion);
//
//		[Export ("readBeaconBatteryWithCompletion:")]
//		void ReadBeaconBatteryWithCompletion (ESTUnsignedCompletionBlock completion);
//
//		[Export ("readBeaconFirmwareVersionWithCompletion:")]
//		void ReadBeaconFirmwareVersionWithCompletion (ESTStringCompletionBlock completion);
//
//		[Export ("readBeaconHardwareVersionWithCompletion:")]
//		void ReadBeaconHardwareVersionWithCompletion (ESTStringCompletionBlock completion);
//
//		[Export ("writeBeaconMajor:withCompletion:")]
//		void WriteBeaconMajor (short major, ESTUnsignedCompletionBlock completion);
//
//		[Export ("writeBeaconMinor:withCompletion:")]
//		void WriteBeaconMinor (short minor, ESTUnsignedCompletionBlock completion);
//
//		[Export ("writeBeaconFrequency:withCompletion:")]
//		void WriteBeaconFrequency (short frequency, ESTUnsignedCompletionBlock completion);
//
//		[Export ("writeBeaconPower:withCompletion:")]
//		void WriteBeaconPower (ESTBeaconPower power, ESTUnsignedCompletionBlock completion);
//
//		[Export ("updateBeaconFirmwareWithProgress:andCompletion:")]
//		void UpdateBeaconFirmwareWithProgress (ESTStringCompletionBlock progress, ESTCompletionBlock completion);
	}

	//ESTBeaconMajorValue: represents the most significant value in a beacon.
	//ESTBeaconMinorValue: represents the least significant value in a beacon.
	[BaseType (typeof (CLBeaconRegion))]
	public partial interface ESTBeaconRegion {

		[Export ("initRegionWithIdentifier:")]
		IntPtr Constructor (string identifier);

		[Export ("initRegionWithMajor:identifier:")]
		IntPtr Constructor (ushort ESTBeaconMajorValue, string identifier);

		[Export ("initRegionWithMajor:minor:identifier:")]
		IntPtr Constructor (ushort ESTBeaconMajorValue, ushort ESTBeaconMinorValue, string identifier);
	}
	
	[Model, BaseType (typeof (NSObject))]
	public partial interface ESTBeaconManagerDelegate {

		[Export ("beaconManager:didRangeBeacons:inRegion:")]
		void DidRangeBeacons (ESTBeaconManager manager, NSArray [] beacons, ESTBeaconRegion region);

		[Export ("beaconManager:rangingBeaconsDidFailForRegion:withError:")]
		void RangingBeaconsDidFailForRegion (ESTBeaconManager manager, ESTBeaconRegion region, NSError error);

		[Export ("beaconManager:monitoringDidFailForRegion:withError:")]
		void MonitoringDidFailForRegion (ESTBeaconManager manager, ESTBeaconRegion region, NSError error);

		[Export ("beaconManager:didEnterRegion:")]
		void DidEnterRegion (ESTBeaconManager manager, ESTBeaconRegion region);

		[Export ("beaconManager:didExitRegion:")]
		void DidExitRegion (ESTBeaconManager manager, ESTBeaconRegion region);

		[Export ("beaconManager:didDetermineState:forRegion:")]
		void DidDetermineState (ESTBeaconManager manager, CLRegionState state, ESTBeaconRegion region);

		[Export ("beaconManagerDidStartAdvertising:error:")]
		void Error (ESTBeaconManager manager, NSError error);

		[Export ("beaconManager:didDiscoverBeacons:inRegion:")]
		void DidDiscoverBeacons (ESTBeaconManager manager, NSArray [] beacons, ESTBeaconRegion region);

		[Export ("beaconManager:didFailDiscoveryInRegion:")]
		void DidFailDiscoveryInRegion (ESTBeaconManager manager, ESTBeaconRegion region);
	}
	
	[BaseType (typeof (NSObject))]
	//TODO: Make it implement CLLocationManagerDelegate 
	public partial interface ESTBeaconManager //: CLLocationManagerDelegate
	{

		[Export ("delegate", ArgumentSemantic.Assign)]
		ESTBeaconManagerDelegate Delegate { get; set; }

		[Export ("avoidUnknownStateBeacons")]
		bool AvoidUnknownStateBeacons { get; set; }

		[Export ("virtualBeaconRegion", ArgumentSemantic.Retain)]
		ESTBeaconRegion VirtualBeaconRegion { get; set; }

		[Export ("startRangingBeaconsInRegion:")]
		void StartRangingBeaconsInRegion (ESTBeaconRegion region);

		[Export ("startMonitoringForRegion:")]
		void StartMonitoringForRegion (ESTBeaconRegion region);

		[Export ("stopRangingBeaconsInRegion:")]
		void StopRangingBeaconsInRegion (ESTBeaconRegion region);

		[Export ("stopMonitoringForRegion:")]
		void StopMonitoringForRegion (ESTBeaconRegion region);

		[Export ("requestStateForRegion:")]
		void RequestStateForRegion (ESTBeaconRegion region);

		//ESTBeaconMajorValue: represents the most significant value in a beacon.
		//ESTBeaconMinorValue: represents the least significant value in a beacon.
		[Export ("startAdvertisingWithMajor:withMinor:withIdentifier:")]
		void StartAdvertisingWithMajor (ushort ESTBeaconMajorValue, ushort ESTBeaconMinorValue, string identifier);

		[Export ("stopAdvertising")]
		void StopAdvertising ();

		[Export ("startEstimoteBeaconsDiscoveryForRegion:")]
		void StartEstimoteBeaconsDiscoveryForRegion (ESTBeaconRegion region);

		[Export ("stopEstimoteBeaconDiscovery")]
		void StopEstimoteBeaconDiscovery ();
	}
}
