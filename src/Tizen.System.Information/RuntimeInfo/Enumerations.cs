/*
* Copyright (c) 2016 Samsung Electronics Co., Ltd All Rights Reserved
*
* Licensed under the Apache License, Version 2.0 (the License);
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an AS IS BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System;

namespace Tizen.System
{
    /// <summary>
    /// Enumeration for keys for runtime information
    /// </summary>
    public enum RuntimeInformationKey
    {
        /// <summary>
        /// Indicates whether Bluetooth is enabled.
        /// </summary>
        Bluetooth = 2,
        /// <summary>
        /// Indicates whether Wi-Fi hotspot is enabled.
        /// <see cref="WifiStatus"/>
        /// </summary>
        WifiHotspot = 3,
        /// <summary>
        /// Indicates whether Bluetooth tethering is enabled.
        /// </summary>
        BluetoothTethering = 4,
        /// <summary>
        /// Indicates whether USB tethering is enabled.
        /// </summary>
        UsbTethering = 5,
        /// <summary>
        /// Indicates Whether the packet data through 3G network is enabled.
        /// </summary>
        PacketData = 9,
        /// <summary>
        /// Indicates whether data roaming is enabled.
        /// </summary>
        DataRoaming = 10,
        /// <summary>
        /// Indicates whether vibration is enabled.
        /// </summary>
        Vibration = 12,
        /// <summary>
        /// Indicates whether audio jack is connected.
        /// </summary>
        AudioJack = 17,
        /// <summary>
        /// Indicates the current status of GPS.
        /// <see cref="GpsStatus"/>
        /// </summary>
        Gps = 18,
        /// <summary>
        /// Indicates the battery is currently charging.
        /// </summary>
        BatteryIsCharging = 19,
        /// <summary>
        /// Indicates whether TV out is connected.
        /// </summary>
        TvOut = 20,
        /// <summary>
        /// Indicates the change in audio jack connector type.
        /// <see cref="AudioJackConnectionType"/>
        /// </summary>
        AudioJackConnector = 21,
        /// <summary>
        /// Indicates whether charger is connected.
        /// </summary>
        Charger = 24,
        /// <summary>
        /// Indicates whether auto rotation is enabled.
        /// </summary>
        AutoRotation = 26
    }

    /// <summary>
    /// Enumeration for Wi-Fi status
    /// </summary>
    public enum WifiStatus
    {
        /// <summary>
        /// Wi-Fi is disabled.
        /// </summary>
        Disabled,
        /// <summary>
        /// Wi-Fi is enabled and network connection is not established.
        /// </summary>
        Unconnected,
        /// <summary>
        ///  Network connection is established in Wi-Fi network.
        /// </summary>
        Connected
    }

    /// <summary>
    /// Enumeration for GPS status.
    /// </summary>
    public enum GpsStatus
    {
        /// <summary>
        /// GPS is disabled.
        /// </summary>
        Disabled,
        /// <summary>
        /// GPS is searching for satellites.
        /// </summary>
        Searching,
        /// <summary>
        /// GPS connection is established.
        /// </summary>
        Connected
    }

    /// <summary>
    /// Enumeration for type of audio jack connected.
    /// </summary>
    public enum AudioJackConnectionType
    {
        /// <summary>
        /// Audio jack is not connected
        /// </summary>
        Unconnected,
        /// <summary>
        /// 3-conductor wire is connected.
        /// </summary>
        ThreeWireConnected,
        /// <summary>
        /// 4-conductor wire is connected.
        /// </summary>
        FourWireConnected
    }
}
