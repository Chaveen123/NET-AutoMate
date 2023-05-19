=====================================================================================================================================================	
								NET-AutoMate | README
=====================================================================================================================================================		
	NET-AutoMate is a Configuration Management Tool, that aids Network Engineers in Small Businesses to Manage Network Devices Effectively

#####################################################################################################################################################

					!!!!! KINDLY READ THE FOLLOWING INSTRUCTIONS BEFORE USING THE SOFTWARE !!!!!

#####################################################################################################################################################

								GENERAL REQUIREMENTS
=====================================================================================================================================================			
- Supported Device Vendors: Arista, Cisco, Juniper*

- Supported Device Types: Switches and Routers*

*NOTE 1 - For Native Support, the Device should be NETCONF (Port 830) Compatible and support OpenConfig Model.

*NOTE 2 - 'Legacy Mode' will be Enabled for Unsupported Devices that are only Compatible with SSH (Port 22). Currently Supports only Cisco Devices.
 
(The software will automatically check for the compatibility and will adjust the options acccordingly.)

#####################################################################################################################################################

								SYSTEM REQUIREMENTS
=====================================================================================================================================================
• Operating System - Windows 7 (64-bit) or later versions.
• Memory (RAM) - 2GB minimum.
• Processor Speed (CPU) - 2.0Ghz and above.  
• Storage - 200MB after installation.
• Active Internet Connection for Installation of Additional Libraries. (Only during the Initial Startup of the Software)
• OpenSSH Client Feature Installed*

*NOTE 1 - OpenSSH is not natively supported on Windows 8 and eariler versions. Install the provided 'OpenSSH for Windows' package during the 
 Installation Setup.

*NOTE 2 - For Systems running Windows 10 or Higher, Install the OpenSSH Client using 'Optional Features'.

#####################################################################################################################################################

								DEVICE COMPATIBILITY
=====================================================================================================================================================	
 Native Support (NETCONF OpenConfig Devices)
=====================================================================================================================================================	
- Supported Virtual Devices:
-----------------------------------------------------------------------------------------------------------------------------------------------------
• Arista vEOS L3 Switches
• Cisco CSR 1000v Routers
• Cisco Nexus 9000v Switches
• Juniper vSRX Firewalls (No OpenConfig) - Added Native Support with v1.0.2
• Juniper vMX Routers
• Juniper vQFX Switches
-----------------------------------------------------------------------------------------------------------------------------------------------------		
- Supported Physical Devices:
-----------------------------------------------------------------------------------------------------------------------------------------------------
• Arista 7280R3 Switches
• Arista 7800R3 Switches
• Cisco Switches running IOS-XE 16.3 or newer (Cisco Catalyst 3650 Series, 3850 Series, 9000 Series)
• Cisco Routers running IOS-XE 16.3 or newer (Cisco ISR 1000 Series, 4000 Series)
• Cisco Switches running NX-OS 9.3 (Cisco Nexus 9000 Series)
• Juniper Routers and Switches running Junos OS 18.3 or newer (QFX Series, PTX Series, MX Series)

=====================================================================================================================================================	
 Legacy Support (All SSH Devices) - Compatible with all Cisco SSH Routers and Switches
=====================================================================================================================================================
- Supported Virtual Devices:
-----------------------------------------------------------------------------------------------------------------------------------------------------	
• Cisco NX-OSv Switches
• Cisco IOSvL2 Switches
• Cisco IOSvL3 Switches
• Cisco IOSv Routers
-----------------------------------------------------------------------------------------------------------------------------------------------------		
- Supported Physical Devices:
-----------------------------------------------------------------------------------------------------------------------------------------------------
• Cisco Nexus 7000 Series Switches
• Cisco Catalyst 1000 Series Switches
• Cisco ISR 1941 Switches
• Cisco Catalyst 2960-X Series
• Cisco Legacy IOS Devices

#####################################################################################################################################################
								
								AUTOMATION FEATURES
=====================================================================================================================================================
 Perform Configurations
=====================================================================================================================================================
- Device Provisioning:
In an instance where a business undergoes a device upgrade or replacement, it is required to have an initial connection with the device. The tool 
provides the feature to configure a new device by utilizing the serial connectivity method and push pre-configured templates for quick provisioning.
-----------------------------------------------------------------------------------------------------------------------------------------------------
- VLAN Interface Configurations:
VLANs can be created to segment the ports or a range of ports in a physical LAN by subnets. The user can define the number of VLANs and assign 
interfaces to them.
-----------------------------------------------------------------------------------------------------------------------------------------------------
- Routed Interface Configurations:
IP addresses and subnet masks can be assigned to the interfaces in routers and modified where necessary.
-----------------------------------------------------------------------------------------------------------------------------------------------------
- Loopback Interface Configurations:
Loopback Interface is a virtual interface that can be configured with IP addresses to identify the device in the network. This is to make sure that 
the device is reachable even if all other interfaces are down.
-----------------------------------------------------------------------------------------------------------------------------------------------------
- Backup Device Configurations:
The configuration file of the device can be saved locally by simply performing a backup. This is helpful, if the device requires a configuration 
rollback or to migrate from the current device to a new one.
-----------------------------------------------------------------------------------------------------------------------------------------------------
- Translate VLAN Configurations:
The tool is further introduced with a configuration translation feature. This would greatly benefit a business, if it wants to quickly copy and 
convert specific VLAN Interface configurations of a vendor device to another vendor.
-----------------------------------------------------------------------------------------------------------------------------------------------------
- Commit and Rollback Configurations:
Commit is done to confirm the changes requested by the user. Rollback reverts changes to the original state where changes were made but has not been 
committed.

=====================================================================================================================================================
 Test Network Connectivity
=====================================================================================================================================================
- Ping Devices:
The user can log into the device (switch or router) to ping to any destination device (end-devices, routers, or switches) in the network.
-----------------------------------------------------------------------------------------------------------------------------------------------------
- Port Scanning:
Port scanning helps to identify which ports are open in a network device or any host in the local network. By determining the status of the ports, 
the user can manage them to prevent any unauthorized persons from gaining access to the network.

=====================================================================================================================================================
 Retrieve Information
=====================================================================================================================================================
- Retrieve ARP Table:
The ARP table shows the list of entries of interfaces including, the Interface’s name, IP address and the associated MAC address.
-----------------------------------------------------------------------------------------------------------------------------------------------------
- Retrieve MAC Address Table:
The MAC address table shows the list of entries of MAC addresses including, the Interface’s name and the associated VLAN.
-----------------------------------------------------------------------------------------------------------------------------------------------------
- Retrieve Running and Startup Configurations:
Shows the running and startup configuration of the device. This can be used to differentiate the configuration stored in the memory with the 
candidate configuration.
-----------------------------------------------------------------------------------------------------------------------------------------------------
- Retrieve Device Information:
Shows all information related to the device which includes, the device Vendor, Model, Serial number, OS version, Hostname, Uptime, and the list of 
Interfaces.
-----------------------------------------------------------------------------------------------------------------------------------------------------
- Device Vendor Verification:
In a heterogenous network environment, the user may find difficulties to keep track of the device vendor, the IP Address corresponds to. With the 
help of vendor verification, the user can simply enter the IP Address of the device and verify the device vendor.

#####################################################################################################################################################