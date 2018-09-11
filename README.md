# Sample client for E4 streaming server

## Introduction

E4 streaming server is a Windows application that can connect to multiple Empatica E4 devices using Bluetooth and stream data to multiple TCP clients.

## Setup

- Clone/download this repository
- Open it and, if needed, check the address and port where your E4 streaming server instance is running.
  You can adjust these constants in "AsynchronousClient.cs" file
  
      private const string ServerAddress = "127.0.0.1";
      private const int ServerPort = 28000;
  
- Run the EmpaticaBLEClient solution

## Start the client

- Check that the E4 streaming server is running
- Press ENTER and you should see a confirmation message
    
        Socket connected to 127.0.0.1:280000

- You can start sending commands

## Connect to a device and receive data

- Check that a device is connected over Bluetooth to the E4 streaming server
- Bind the TCP client to a device and start receiveing data (from a full description of the command please visit our support page: <http://developer.empatica.com/windows-streaming-server-commands.html>

### Protocol example

In these code snippets, the first row is the sent commands, the second one an example of received data

    device_list
    R device_list 2 | 9ff167 Empatica_E4 | 740163 Empatica_E4
    
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

The application can be run on Windows 7, 8 or 10. 

If you need any additional information about the E4 streaming server for Windows, please check the [official documentation][1].

[1]: http://developer.empatica.com/windows-streaming-server.html
