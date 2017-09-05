# Sample client for Empatica BLE Server

## Introduction

Empatica BLE Server is a Windows application that can connect to multiple Empatica E4 devices using Bluetooth and stream data to local endpoint using multiple socket connections.

In order to get Empatica BLE Server, please contact us at <mailto:support@empatica.com>

## Setup

- Clone/download this repository
- Open it and, if needed, check the address and port where your istance of EmpaticaBLEServer is running.
  You can change it by editing these constants in "AsynchronousClient.cs" file
  
      private const string ServerAddress = "127.0.0.1";
      private const int ServerPort = 28000;
  
- Run EmpaticaBLEClient

## Start the client

- Check that EmpaticaBLEServer is running (Start button pressed)
- Press ENTER and you should see a confirmation message
    
        Socket connected to 127.0.0.1:280000

- You can start to sending commands

## Connect to a device and receive data

- Check that a device is connected to EmpaticaBLEServer
- Connect to a device and start receiveing data (from a full description of the command please visit our support page: <http://empatica.github.io/windows-ble-server.html>

### Protocol example

In these code snippets, the first row is the sent commands, the second one an example of received data

    device_list
    R device_list 2 | 9ff167 Empatica_E4 available | 740163 Empatica_E4 available
    
    device_connect 9ff167
    R device_connect OK
    
    device_subscribe bvp ON
    R device_subscribe bvp OK
    
    device_subscribe gsr ON
    R device_subscribe gsr OK

After each subscription, you'll start to receive data in real time:

    E4_Bvp 123345627891.123 31.128
    

When you want to stop receiving data, simply disconnect the device or send

    device_disconnect
    device_disconnect OK

### System requirements

The application can be run on Windows 7, 8 or 10 desktop computers. 

If you need any additional information about the Empatica BLE Server for Windows, please check the [official documentation][1].

[1]: http://developer.empatica.com
