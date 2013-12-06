Estimote Beacons Xamarin SDK wrapper
=======================

- **UPDATE** 2013-12-05 The most up-to-date version of this wrapper is now: https://github.com/mono/monotouch-bindings/tree/master/Estimote
My code (an improved version of Xamarin-EstimoteBeacons) was merged there.


A wrapper around the Estimote iOS SDK ( https://github.com/Estimote/iOS-SDK ).

Estimote Beacons are small, wireless sensors from http://estimote.com that use a new Bluetooth low energy (BLE) chip and continually transmit radio signals that your phone can pick up.
You can think about the beacon as a small lighthouse tower that's installed in a fixed location and broadcasts its presence to all the ships (smartphones) around.
The nearby smartphones can communicate with them using an API they’ve developed. This makes it easy for developers to add micro-location features to their mobile apps.

For the technical specifications of the Estimote beacons see http://estimote.com/api/index.html


- There is a working Proximity demo that uses the wrapper. This is the translation of the ProximityDemo (Objective C) from Estimote: https://github.com/Estimote/iOS-SDK

- I will appreciate all input, feedback, and especially contributions!

This is my personal project, I'm not affiliated with Estimote in any way.

Credits
=======
Xamarin-EstimoteBeacons is the Xamarin.iOS-capable version of [EstimoteSDK](https://github.com/Estimote/iOS-SDK/tree/master/EstimoteSDK).
Estimote certainly deserves all the credit as all I have done is create the Xamarin.iOS binding for the library.

License
=======

The bindings are licensed under the MIT X11 license:

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.

Authors
=======
* woutercx
