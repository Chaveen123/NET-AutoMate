from netmiko import ConnectHandler
import sys
import datetime
import csv
import os
from netaddr import IPAddress

time_now  = datetime.datetime.now().strftime('%Y-%m-%d_%I-%M-%S-%p')

intname = sys.argv[1]
ipaddress = sys.argv[2]
subnetmask = sys.argv[3]
prefixlength = IPAddress(str(subnetmask)).netmask_bits()

def writelog(path,output):
    save = open(path,'w')
    save.write(str(output))
    save.close

try:
	with open('C:\\NETAutoMate\\DeviceAuth.csv','r') as deviceauth:
			csvreader = csv.reader(deviceauth)
			for row in csvreader:
				device_vendor=row[0]
				device_model=row[1]
				device_type=row[2]           
				netmiko=row[3]
				ip=row[4] 
				username=row[5]
				password=row[6]

	net_connect = ConnectHandler(device_type=netmiko,ip=ip,username=username,password=password)
	
	enable = net_connect.enable()

	if(netmiko=="cisco_ios"):
		config_commands = [f'interface {intname}',f'ip address {ipaddress} {subnetmask}','no shutdown']
	
	elif(netmiko=="arista_eos"):
		config_commands = [f'interface {intname}',f'ip address {ipaddress} {subnetmask}','no shutdown']
		
	elif(netmiko=="juniper"):
		intname = 'lo0'
		config_commands = [f'set interfaces {intname} unit 0 family inet address {ipaddress}/{prefixlength}']
   
	net_connect.send_config_set(config_commands)    

	if(netmiko=="juniper"):
		net_connect.commit()
    
	net_connect.disconnect()

	print(f'Loopback Interface {intname} Configured SUCCESSFULLY!\nIP Address: {ipaddress} Subnet Mask: {subnetmask}')

except Exception as e:

	efolder = 'C:\\NETAutoMate\\Device_Logs\\LoopbackInterface_Logs'
	
	efile = f'LoopbackIntConfigERROR_{device_vendor}_{device_type}_{time_now}.log'
	
	if not os.path.isdir(efolder):
		os.makedirs(efolder)
		
	epath = os.path.join(efolder,efile)
	
	writelog(path=epath,output=e)

	print(f'System was UNABLE to Configure Loopback Interface {intname}. Please Retry!\nError: {e}')

